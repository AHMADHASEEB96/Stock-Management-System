using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management.Screens
{
    public partial class ExportOrdersForm : Form
    {
        Model4 DB = new Model4();
        string CurrentExpOrderId = "";

        public ExportOrdersForm()
        {
            InitializeComponent();
        }

        private void ExportOrdersForm_Load(object sender, EventArgs e)
        {
            //CustomersCB.SelectedIndex = -1;
            var Customer = DB.Customers.Where(c => c == c).ToList();
            CustomersCB.DataSource = Customer;
            CustomersCB.DisplayMember = "Name";
            CustomersCB.ValueMember = "ID";

            /*
                        productsCB.DataSource = DB.Products.ToList();
                        productsCB.ValueMember = "ID";
                        productsCB.DisplayMember = "Name";
            */
            foreach (var product in DB.Products) { productsCB.Items.Add(product.ID); }

            //  foreach (var wareH in DB.Warehouses) { ProductFormwarehouseCB.Items.Add(wareH.ID); }
            CurrentExpOrderId = (DB.ExportedItems.Max(s => s.ExprtedOrderId) + 1).ToString();

            CurrentExpOrderText.Text = CurrentExpOrderId;   // label 
            ExportingOrderIdTB.Text = CurrentExpOrderId; // text box
                                                         //
            UpdateDGV();


        }

        private void CustomersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustomerID = int.Parse(CustomersCB.Text);
            var ThisCusotmer = DB.Customers.Where(c => c.ID == CustomerID).FirstOrDefault();
            //    MessageBox.Show(ThisCusotmer.Name);

        }

        private void productsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(productsCB.Text, out int productID))

                FillData(productID);
        }



        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            ExportedItem newExpOrder = new ExportedItem();

            if (int.TryParse(productIdTB.Text, out int pi)) { newExpOrder.ProductId = pi; }
            newExpOrder.CustomerId = int.Parse(CustomersCB.Text);
            if (int.TryParse(productQuantityTB.Text, out int eq)) { newExpOrder.ExportedQuantity = eq; }
            newExpOrder.Notes = ExportingOrderNoetsTB.Text;

            newExpOrder.ExportingDate = DateTime.Now;

            newExpOrder.ExprtedOrderId = int.Parse(CurrentExpOrderId);
            // Reduce the exported quantity from the product quantity

            var prodId = 1;
            try { prodId = int.Parse(productIdTB.Text); } catch { MessageBox.Show(" Empty Fields found"); return; } // dont process any further untill fields are filled with values;
            var thisProd = DB.Products.Where(p => p.ID == prodId).FirstOrDefault();

            try
            {
                thisProd.Quantity -= decimal.Parse(productQuantityTB.Text);

            }
            catch { MessageBox.Show("Empty Fields"); }

            DB.ExportedItems.Add(newExpOrder);
            // check if a Exorting order
            var custId = int.Parse(CustomersCB.Text);
            var Expqty = decimal.Parse(productQuantityTB.Text);
            // Get the current Exporting order ID ( it is identity ).
            // var currentEOID = DB.ExportingOrders.Max( eo => eo.ExportOrderID);

            var SameOrderDetails = DB.ExportedItems.Where(eo => eo.CustomerId == custId && eo.ProductId == prodId && eo.ExportedQuantity == Expqty).FirstOrDefault();
            if (RequiredFieldsFilled())
            {

                if (SameOrderDetails == null)
                {
                    DB.SaveChanges(); UpdateDGV(); MessageBox.Show("Added");
                }
                else
                { MessageBox.Show(" You cant send same procust to the customer twice in the same order"); }
            }
            else { MessageBox.Show("There are empty Required Fields"); }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.SaveChanges();
        }

        void UpdateDGV()
        {
            var currentOrderId = int.Parse(ExportingOrderIdTB.Text);
            ExportOrderDGV.DataSource = DB.ExportedItems.Where(eo => eo.ExprtedOrderId == currentOrderId).Select(eo => new { eo.ProductId, eo.CustomerId, eo.ExportedQuantity, eo.ExportingDate, eo.Notes }).ToList();
        }

        private void ExportingOrderIdTB_TextChanged(object sender, EventArgs e)
        {
            /* if (ExportingOrderIdTB.Text != "") { 
             UpdateDGV();

             }*/

            try { UpdateDGV(); } catch { }

        }

        private bool RequiredFieldsFilled()
        {
            if (
           productQuantityTB.Text != "" && decimal.Parse(productQuantityTB.Text) != 0 && CustomersCB.Text != "" && int.Parse(CustomersCB.Text) != 0
           && productIdTB.Text != "" && int.Parse(productIdTB.Text) != 0 && ExportingOrderIdTB.Text != "" && int.Parse(ExportingOrderIdTB.Text) != 0


                ) { return true; }
            else { return false; }

        }

        private void ExportOrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportOrderDGV_SelectionChanged(object sender, EventArgs e)
        {
            var thisProductID = int.Parse(ExportOrderDGV.CurrentRow.Cells[0].Value.ToString());
            var thisProduct = DB.Products.Where(p => p.ID == thisProductID).FirstOrDefault();
            if (thisProduct != null)
            {
                // Any way it cant be null because the any product must have an ID as it is the PK and Identity so it is inserted automatically which leaves no chance for not inserting it
                productIdTB.Text = thisProductID.ToString();
                FillData(thisProductID);


            }


        }

        void FillData(int prodId)
        {
            var thisProd = DB.Products.Where(p => p.ID == prodId).FirstOrDefault();
            productQuantityTB.Text = thisProd.Quantity.ToString();
            productIdTB.Text = thisProd.ID.ToString();
            ProductNameTB.Text = thisProd.Name;



        }

        private void ExportingOrderIdTB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void updateExportingOrder_Click(object sender, EventArgs e)
        {

        }

        private void exportiOrderItemRemoveBtn_Click(object sender, EventArgs e)
        {
            var thisProductID = int.Parse(ExportOrderDGV.CurrentRow.Cells[0].Value.ToString());
            var thisExpItem = DB.ExportedItems.Where(eo => eo.ProductId == thisProductID).FirstOrDefault();
            if (thisExpItem != null)
            {
                // Any way it cant be null because the any product must have an ID as it is the PK and Identity so it is inserted automatically which leaves no chance for not inserting it

                // Create a message box to ask the user if they are sure they want to remove an item.
                DialogResult result = MessageBox.Show($"Are you sure you want to remove item {thisProductID} from this order ?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user's response is Yes, remove the item.
                if (result == DialogResult.Yes)
                {

                    DB.ExportedItems.Remove(thisExpItem);

                    DB.SaveChanges();
                    UpdateDGV();

                }

            }


        }
    }
}
