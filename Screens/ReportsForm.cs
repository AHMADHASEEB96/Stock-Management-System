using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management.Screens
{
    public partial class ReportsForm : Form
    {
        Model4 DB = new Model4();
        public ReportsForm()
        {
            InitializeComponent();
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FORM ON LOAD
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            foreach (var wareH in DB.Warehouses) {  warehousrToCB.Items.Add(wareH.ID); warehousrFromCB.Items.Add(wareH.ID); }
            FillWarehouseCB();

        }


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// DATE TIME PICKER VALUE CHANGED

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = (DateTime)dateTimePicker1.Value;
            var productsExpireBefore = DB.Products.Where(p => p.ExpiryDate <= chosenDate).Select(p => new
            {
                p.ID,
                p.Name,
                p.Code,
                p.Quantity,
                p.MeasuringUnit,
                p.Price,
                p.TotalItemPrice,
                p.Currency,
                p.ProdDate,
                p.ValidationPeriod,
                p.ValidationPeriodType,
                p.ExpiryDate,
                p.SupplierId,
                p.WarehouseID,
                p.SupplyOrderId,
                p.AddedAt,
                p.Notes
            }).ToList();
            dataGridView1.DataSource = productsExpireBefore;
            var totalPrice = DB.Products.Where(p => p.ExpiryDate <= chosenDate).Sum(product => product.TotalItemPrice);
            totalPriceValueText.Text = totalPrice.ToString();
            DGVRowsCount();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// EXPIRED BUTTON

        private void expiredProductsBtn_Click(object sender, EventArgs e)
        {
            var expiredProducts = DB.Products.Where(p => p.ExpiryDate <= DateTime.Now).Select(p => new
            {
                p.ID,
                p.Name,
                p.Code,
                p.Quantity,
                p.MeasuringUnit,
                p.Price,
                p.TotalItemPrice,
                p.Currency,
                p.ProdDate,
                p.ValidationPeriod,
                p.ValidationPeriodType,
                p.ExpiryDate,
                p.SupplierId,
                p.WarehouseID,
                p.SupplyOrderId,
                p.AddedAt,
                p.Notes

            }).ToList();
            dataGridView1.DataSource = expiredProducts;
            var totalPrice = DB.Products.Where(p => p.ExpiryDate <= DateTime.Now).Sum(product => product.TotalItemPrice);
            totalPriceValueText.Text = totalPrice.ToString();

            DGVRowsCount();
            processDescription.Text = $"Expired Item/s";
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// DATA FRID VIEW ROW CHANGED

        private void dataGridView1_RowCountChanged(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("Changed");
            // Update the number of rows label.
            DGVRowsCount();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// DATA GRID VIEW ROW COUNT

        void DGVRowsCount()
        {

            countText.Text = dataGridView1.RowCount.ToString();



        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// VALID PRODUCTS BUTTON CLICK

        private void validProductsBtn_Click(object sender, EventArgs e)
        {
            var expiredProducts = DB.Products.Where(p => p.ExpiryDate >= DateTime.Now).Select(p => new
            {
                p.ID,
                p.Name,
                p.Code,
                p.Quantity,
                p.MeasuringUnit,
                p.Price,
                p.TotalItemPrice,
                p.Currency,
                p.ProdDate,
                p.ValidationPeriod,
                p.ValidationPeriodType,
                p.ExpiryDate,
                p.SupplierId,
                p.WarehouseID,
                p.SupplyOrderId,
                p.AddedAt,
                p.Notes

            }).ToList();
            dataGridView1.DataSource = expiredProducts;
            var totalPrice = DB.Products.Where(p => p.ExpiryDate >= DateTime.Now).Sum(product => product.TotalItemPrice);
            totalPriceValueText.Text = totalPrice.ToString();
            DGVRowsCount();
            processDescription.Text = $"Valid Item/s";
            var lastColumn = dataGridView1.Columns[dataGridView1.Columns.Count - 1];

            dataGridView1.Columns.Remove(lastColumn);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PERIOD TYPE TEXT CHANGED

        private void periodTB_TextChanged(object sender, EventArgs e)
        {
            var period = 1;
            if (periodTB.Text != "")
            {


                period = int.Parse(periodTB.Text.Trim());

            }

            ViewItemsAccordingToDate();
        }

        private void periodTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// VIEW ITEMS ACCORDING TO DATE

        void ViewItemsAccordingToDate()
        {
            var finalPeriodInDays = 0;

            if (periodTypeCB.Text != "")
            {

                int period;
                IntitializePeriod(out period);



                var expiryDate = DateTime.Now;
                switch (periodTypeCB.Text)
                {
                    case "Day":
                        finalPeriodInDays = period;
                        break;
                    case "Month":
                        try { finalPeriodInDays = period * 30; } catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Very Big value"); }
                        break;
                    case "Year":
                        try { finalPeriodInDays = period * 365; } catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Very Big value"); }


                        break;

                }

                // Get the items those are stored since a certian time

                // go back in time a number of days like the number the chosen;
                DateTime date = DateTime.Now.AddDays(-finalPeriodInDays);

                // Now get the prodcuts that thier "AddedAt" date value is before that thime, that means they are stored more than thie time the user chooses.
                // if the use chooses 1 year, that menas get the prodects those AddedDate is before than 1 year from now.
                var productsAddedFor = DB.Products.Where(p => p.AddedAt < date).ToList();
                dataGridView1.DataSource = productsAddedFor;
                DGVRowsCount();
                processDescription.Text = $"Items have been stored for more than {period} {periodTypeCB.Text}";

                var totalPrice = DB.Products.Where(p => p.AddedAt < date).Sum(product => product.TotalItemPrice);
                totalPriceValueText.Text = totalPrice.ToString();


            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PERIOD TYPE SELECT INDEX CHANGED

        private void periodTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewItemsAccordingToDate();

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// INITIALIZER PERIOD METHOD

        void IntitializePeriod(out int period)
        {



            if (periodTB.Text != "")
            {


                period = int.Parse(periodTB.Text.Trim());

            }
            else { period = 0; }

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FILTER BY WAREHOUSE

        private void filterByWHCB_SelectedIndexChanged(object sender, EventArgs e)
        {


            object selectedValue = filterByWHCB.SelectedValue; // Get the selected value object
            if (selectedValue is int) // Parse its interger ( wh id)
            {
                int whID = (int)selectedValue;


                var warehouse = DB.Warehouses.Where(w => w.ID == whID).FirstOrDefault();

                var allProductsFromThisWH = DB.Products.Where(p => p.WarehouseID == whID).ToList();
                dataGridView1.DataSource = allProductsFromThisWH;
                DGVRowsCount();
                processDescription.Text = $"Product/s Found in warhouse \"{warehouse.Name}\"";
                var totalPrice = DB.Products.Where(product => product.WarehouseID == whID).Sum(product => product.TotalItemPrice);
                totalPriceValueText.Text = totalPrice.ToString();

            }

          


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TRANSACTIONS BETWEEN WAREHOUSES

        private void transactionsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int wh1 = int.Parse(warehousrFromCB.Text);
                Warehouse warehouse1 = DB.Warehouses.Where(wh => wh.ID == wh1).FirstOrDefault();
                var startTime = fromTimeDTP.Value;

                int wh2 = int.Parse(warehousrToCB.Text);
                Warehouse warehouse2 = DB.Warehouses.Where(wh => wh.ID == wh2).FirstOrDefault();
                var endTime = toTimeDTP.Value;

                var transferred = DB.TransferredItems.Where(t => t.FromWh == wh1 && t.ToWh == wh2 && t.TransferTime > startTime && t.TransferTime < endTime).ToList();
                dataGridView1.DataSource = transferred;
                DGVRowsCount();
                processDescription.Text = $"Product/s Transferred from Warhouse \"{warehouse1.Name}\" To Warehouse \"{warehouse2.Name}\" in the specified period ";
                totalPriceValueText.Text = string.Empty;




            }



            catch
            {
                MessageBox.Show(" Can't search by empty or invalid value");
            }
        }

        void UpdateGridView()
        {




            var neededProds = DB.Products.Where(p => p == p).Select(p => new
            {
                p.ID,
                p.Name,
                p.Code,
                p.Quantity,
                p.MeasuringUnit,
                p.Price,
                p.TotalItemPrice,
                p.Currency,
                p.ProdDate,
                p.ValidationPeriod,
                p.ValidationPeriodType,
                p.ExpiryDate,
                p.SupplierId,
                p.WarehouseID,
                p.SupplyOrderId,
                p.AddedAt,
                p.Notes


            }).ToList();
            dataGridView1.DataSource = neededProds; 
            DGVRowsCount();
            var lastColumn = dataGridView1.Columns[dataGridView1.Columns.Count - 1];

            dataGridView1.Columns.Remove(lastColumn);
            var totalPrice = DB.Products.Where(p => p == p).Sum(p => p.TotalItemPrice);
            totalPriceValueText.Text = totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int wh1 = int.Parse(warehousrFromCB.Text);
                Warehouse warehouse1 = DB.Warehouses.Where(wh => wh.ID == wh1).FirstOrDefault();
               var startTime = fromTimeDTP.Value;

                int wh2 = int.Parse(warehousrToCB.Text);
                Warehouse warehouse2 = DB.Warehouses.Where(wh => wh.ID == wh2).FirstOrDefault();

                var transferred = DB.TransferredItems.Where(t => t.FromWh == wh1 && t.ToWh == wh2).ToList();
                dataGridView1.DataSource = transferred;
                DGVRowsCount();
                processDescription.Text = $"Product/s Transferred from Warhouse \"{warehouse1.Name}\" To Warehouse \"{warehouse2.Name}\" ";
                totalPriceValueText.Text = string.Empty;




            }



            catch
            {
                MessageBox.Show(" Can't search by empty or invalid value");
            }

        }

        private void FillWarehouseCB()
        {

            filterByWHCB.DataSource = DB.Warehouses.ToList();
            filterByWHCB.ValueMember = "ID";
            filterByWHCB.DisplayMember = "Name";
        }

        private void allProductsBtn_Click(object sender, EventArgs e)
        {
            var allProductInAllWarehouses = DB.Products.Where(p => p == p).ToList();    
            dataGridView1.DataSource = allProductInAllWarehouses;

        }




























        /*   private object GirdColumns( Product p) {

               return new
               {
                   p.ID,
                   p.Name,
                   p.Code,
                   p.Quantity,
                   p.MeasuringUnit,
                   p.Price,
                   p.Currency,
                   p.ProdDate,
                   p.ValidationPeriod,
                   p.ValidationPeriodType,
                   p.ExpiryDate,
                   p.SupplierId,
                   p.WarehouseID,
                   p.SupplyOrderId,
                   p.AddedAt,
                   p.Notes

               };
           }*/

        /*private void periodTB_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }*/
    }

}






