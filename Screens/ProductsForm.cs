using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Product's Id is unuque over all the warhouses, code is unique over each warehouse
namespace Stock_Management.Screens
{
    public partial class ProductsForm : Form
    {

        Model4 DB = new Model4();
        public ProductsForm()
        {
            InitializeComponent();
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
        }

       

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            ProductCurrencyTB.Text = "LE";
            var pros = DB.Products.Where(p => p == p);
            foreach (var p in pros) { 
                p.TotalItemPrice = p.Quantity * p.Price;


            }
            DB.SaveChanges();
            producValidationPeriodTB.Text = "1";

         
            foreach (var wareH in DB.Warehouses){ProductFormwarehouseCB.Items.Add(wareH.ID); filterByWHCB.Items.Add(wareH.ID); }
            foreach (var supplier in DB.Suppliers) { SOSuppliersCB.Items.Add(supplier.ID); }
            var supplyOrders = DB.SupplyOrders.Where(s => s == s);
            foreach (var order in supplyOrders) { supplyOrdersCB.Items.Add(order.Id); }


            foreach (var product in DB.Products) { productsCB.Items.Add(product.ID); }

            UpdateGridView();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

            if (productNameTB.Text != "")
            {
                


                Product Prod = new Product();
                Prod.Name = productNameTB.Text;
                Prod.Quantity = decimal.Parse(productQuantityTB.Text);
                Prod.MeasuringUnit = ProductMUCB.Text;
                long code; // it is long because int supports 10 digits only while barcodes are 12 digits long
                decimal price;
                int wh;
                long.TryParse(productCodeTB.Text, out code);
                decimal.TryParse(producPriceTB.Text, out price);
                int.TryParse(ProductFormwarehouseCB.Text, out wh);
                Prod.Code = code;
                Prod.Price = price;
                Prod.TotalItemPrice = Prod.Quantity * Prod.Price;
               
                Prod.Currency = ProductCurrencyTB.Text;
                Prod.ProdDate = ProductProdDateTable.Value;
                Prod.ValidationPeriod = decimal.Parse(producValidationPeriodTB.Text); 
                                                                                    
                Prod.SupplierId = int.Parse(SOSuppliersCB.Text);
                Prod.Notes = productNotesTB.Text;
                Prod.ValidationPeriodType = ProducValidationPeriodTypeCB.Text;
                Prod.SupplyOrderId = int.Parse(supplyOrdersCB.Text);
                ChangeExpiryDate();

                Prod.ExpiryDate = DateTime.Parse(productExpireDateTB.Text);
                Prod.AddedAt = DateTime.Now;
                var sameProduct = DB.Products.Where(p => p.Code == code  && p.WarehouseID == wh).FirstOrDefault();
                if (sameProduct == null) { DB.Products.Add(Prod); DB.SaveChanges(); UpdateGridView(); } else { MessageBox.Show($"product with code { code} was found in this warehouse {wh}"); }
               
               
            }
            else
            {
                MessageBox.Show("Name can't be void");
            }


            ProductCurrencyTB.Text = "LE";




        }



        //////////////
        #region update
        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            

            int productID = int.Parse(productIDTB.Text);
            var ThisProduct = DB.Products.Where(p => p.ID == productID).FirstOrDefault();
            if (ThisProduct != null)
            {
                if (RequiredFieldsFiiled())
                {

                    ThisProduct.Name = productNameTB.Text;
                  
                    ThisProduct.MeasuringUnit = ProductMUCB.Text;
                    ThisProduct.Quantity = decimal.Parse(productQuantityTB.Text);

                    long code;
                    decimal price;
                    long.TryParse(productCodeTB.Text, out code);
                    decimal.TryParse(producPriceTB.Text, out price);
                    ThisProduct.Code = code;
                    ThisProduct.Price = price;
                    ThisProduct.TotalItemPrice = ThisProduct.Quantity * ThisProduct.Price;
                    ThisProduct.Currency = ProductCurrencyTB.Text; 
                                                                   
                    ThisProduct.ValidationPeriod = decimal.Parse(producValidationPeriodTB.Text);
                    ThisProduct.ValidationPeriodType = ProducValidationPeriodTypeCB.Text;
                    var wh = int.Parse(ProductFormwarehouseCB.Text);
                    ThisProduct.WarehouseID = wh;
                    ThisProduct.Notes = productNotesTB.Text;
                    ThisProduct.ProdDate = ProductProdDateTable.Value;
                    ThisProduct.SupplierId = int.Parse(SOSuppliersCB.Text);
                    ThisProduct.SupplyOrderId = int.Parse(supplyOrdersCB.Text);
                    ChangeExpiryDate();
                    ThisProduct.ExpiryDate = DateTime.Parse(productExpireDateTB.Text);


                    if (int.TryParse(SOSuppliersCB.Text, out int supID)) { ThisProduct.SupplierId = supID; } else { MessageBox.Show(" Supplier Id not Updated duo to invalid input"); }
                    // 
                    var sameProduct = DB.Products.Where(p => p.Code == code && p.WarehouseID == wh).FirstOrDefault();

                    DB.SaveChanges();
                    int focusedRowIndex = dataGridView1.CurrentCell.RowIndex;
                    int focusedColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
                    UpdateGridView();
                    var focusCellIndex = dataGridView1.Rows[focusedRowIndex].Cells[focusedColumnIndex];
                    dataGridView1.CurrentCell = focusCellIndex;
                   


                    //  MessageBox.Show("Updated"); 
                }
                else { MessageBox.Show(" Required Feilds Not Filled"); }

            ProductCurrencyTB.Text = "LE";


            }
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            var thisProductID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var thisProduct = DB.Products.Where(p => p.ID == thisProductID).FirstOrDefault();
            if (thisProduct != null)
            {
                // Create a message box to ask the user if they are sure they want to remove an item.
                DialogResult result = MessageBox.Show($"Are you sure you want to remove item {thisProductID}?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user's response is Yes, remove the item.
                if (result == DialogResult.Yes)
                {

                    DB.Products.Remove(thisProduct);
                    DB.SaveChanges();
                    UpdateGridView();
                }



            }
        }
        #endregion
        //////////////////
        #region Fill Data by Choosing a product ID from the Combobox
        private void productsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(productsCB.Text, out int productID))
                FillData(productID);


        }

        // Fill Data by inserting  a Product ID and  pressing the Find btn
        private void productFindBtn_Click(object sender, EventArgs e)
        {
            int productID;
            int.TryParse(productsCB.Text, out productID);
            FillData(productID);
        }
        #endregion
        

       

        private void productIDGridBtn_Click(object sender, EventArgs e)
        {
            if (productIDGridTB.Text != "") {


                int productID = int.Parse(productIDGridTB.Text);

                var ThisProduct = DB.Products.Where(p => p.ID == productID).ToList();
                if (ThisProduct.Count != 0)
                {
                    dataGridView1.DataSource = ThisProduct;

                }
                else {
                    MessageBox.Show($" No product with Id: {productID} was found");
                }
            }

           

        }
       

        private void refreshGVBtn_Click(object sender, EventArgs e)
        {
            UpdateGridView();
            filterByWHCB.Text = "";

        }


      
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Prevent the default error dialog from being displayed.
            e.Cancel = true;

            // Display your own custom error message.
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      
        // fill text boxes by id selection form the gridView
        private void productsDGV_SelectionChanged(object sender, EventArgs e)
        {
            var productID = int.Parse(productsDGV.CurrentRow.Cells[0].Value.ToString()); // object > string > int 
                                                                                       
            productsCB.Text = productID.ToString(); 
            FillData(productID);    

        }

       

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshPageBtn_Click(object sender, EventArgs e)
        {
            FillOut();
        }

        void FillOut()
        {

            productNameTB.Text = ProductMUCB.Text = producPriceTB.Text = ProductCurrencyTB.Text = ProductFormwarehouseCB.Text = productNotesTB.Text = producValidationPeriodTB.Text = productCodeTB.Text = ProductProdDateTable.Text = productQuantityTB.Text = "";

        }

       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var thisProductID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var thisProduct = DB.Products.Where(p => p.ID == thisProductID).FirstOrDefault();
            if (thisProduct != null) {
                // Any way it cant be null because the any product must have an ID as it is the PK and Identity so it is inserted automatically which leaves no chance for not inserting it
                productIDTB.Text = thisProductID.ToString();
                FillData(thisProductID);


            }
        }

        private void filterByWHCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter by warhouse 
            try
            {
                int thisWarehouseId = int.Parse(filterByWHCB.Text);
                var allProductsFromThisWH = DB.Products.Where(p => p.WarehouseID == thisWarehouseId).ToList();
                dataGridView1.DataSource = allProductsFromThisWH;
            }



            catch
            {
                MessageBox.Show(" Can't search by empty or invalid value");
            }

        }

        private bool RequiredFieldsFiiled() {
            if (
            productNameTB.Text != "" && ProductMUCB.Text != "" && producPriceTB.Text != "" && ProductCurrencyTB.Text != "" && ProductFormwarehouseCB.Text != "" && producValidationPeriodTB.Text != "" && productCodeTB.Text != "" && ProductProdDateTable.Text != "" && productQuantityTB.Text != ""
                
                
                ) { return true; } else { return false; }
        
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
            dataGridView1.DataSource = neededProds;  // or can be added by wizzrd } catch { }



        }

        void FillData(int id)
        {

            var ThisProduct = DB.Products.Where(p => p.ID == id).FirstOrDefault();
            if (ThisProduct != null)
            {
                productIDTB.Text = ThisProduct.ID.ToString();
                productNameTB.Text = ThisProduct.Name;
                productQuantityTB.Text = ThisProduct.Quantity.ToString();
                ProductMUCB.Text = ThisProduct.MeasuringUnit;
                producPriceTB.Text = ThisProduct.Price.ToString();
                ProductCurrencyTB.Text = ThisProduct.Currency;
                ProductProdDateTable.Text = ThisProduct.ProdDate.ToString();
                producValidationPeriodTB.Text = ThisProduct.ValidationPeriod.ToString();
                try { ProducValidationPeriodTypeCB.Text = ThisProduct.ValidationPeriodType.ToString(); } catch { }
                ProductFormwarehouseCB.Text = ThisProduct.WarehouseID.ToString(); // error
                productNotesTB.Text = ThisProduct.Notes;
                productCodeTB.Text = ThisProduct.Code.ToString();
                SOSuppliersCB.Text = ThisProduct.SupplierId.ToString();
                supplyOrdersCB.Text = ThisProduct.SupplyOrderId.ToString();
                ChangeExpiryDate();

            }

             

            

        }
        private void producValidationPeriodTB_KeyPress(object sender, KeyPressEventArgs e)
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

        void ChangeExpiryDate()
        {
            var ProductionDate = DateTime.Parse(ProductProdDateTable.Text);
            var validationPeriod = 1;
            if (producValidationPeriodTB.Text != "" && int.Parse(producValidationPeriodTB.Text) != 0)
            {
                validationPeriod = int.Parse(producValidationPeriodTB.Text);
                var expiryDate = DateTime.Now; // as default
                switch (ProducValidationPeriodTypeCB.Text)
                {
                    case "Day":
                        expiryDate = ProductionDate.AddDays(validationPeriod);
                        break;
                    case "Month":
                        try { expiryDate = ProductionDate.AddDays(validationPeriod * 30); } catch ( System.ArgumentOutOfRangeException) { MessageBox.Show("Very Big value"); } 
                        break;
                    case "Year":
                        try { expiryDate = ProductionDate.AddDays(validationPeriod * 365); } catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Very Big value"); }

                       
                        break;

                }
                //  expiryDate = ProductionDate.AddDays(validationPeriod);
                productExpireDateTB.Text = expiryDate.ToString();

            }
           

        }






        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////













        private void ProductFormwarehouseCB_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplyOrdersCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProducValidationPeriodTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeExpiryDate();

        }

        private void ProductProdDateTable_ValueChanged(object sender, EventArgs e)
        {
          ChangeExpiryDate();

        }

        private void producValidationPeriodTB_TextChanged(object sender, EventArgs e)
        {
            ChangeExpiryDate();

        }

        private void producValidationPeriodTB_TextChanged_1(object sender, EventArgs e)
        {
            ChangeExpiryDate();
        }
    }



}
