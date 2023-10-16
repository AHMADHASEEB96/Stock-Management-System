using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
//using System.Runtime.Remoting.Contexts;

namespace Stock_Management.Screens
{
    public partial class SupplyOrderForm : Form
    {
        //Stock_Management DB = new Stock_Management();
        Model4 DB  = new Model4();
        

        public SupplyOrderForm()
        {
            InitializeComponent();
        }

        private void SuppliersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void SupplyOrderForm_Load(object sender, EventArgs e)
        {
            foreach (var wareH in DB.Warehouses){ProductFormwarehouseCB.Items.Add(wareH.ID);}

        

            foreach (var supplier in DB.Suppliers) { SOSuppliersCB.Items.Add(supplier.ID); }
          
            // Add products to grid View

            supplyOrderNumberTB.Text = DB.SupplyOrders.Max(s => s.Id).ToString();
            var soid = int.Parse(supplyOrderNumberTB.Text);
            var currentProducts = DB.Products.Where(p => p.SupplyOrderId == soid).ToList();
            supplyOrderProductsDGV.DataSource = currentProducts;

        

            // Fill the supply orders combo box
            var supplyOrders = DB.SupplyOrders.Where(s => s == s);
            foreach ( var order in supplyOrders) { supplyOrdersCB.Items.Add(order.Id); }
        }
        private void addProductBtn_Click(object sender, EventArgs e)
        {

           
          


            if ( productNameTB.Text != "" && ProductFormwarehouseCB.Text != "" && SOSuppliersCB.Text != "" && SOSuppliersCB.Text != "")
            {
                // If the parse method takes empty string or non numaric value it will throw exception, thats why we use tryParse instead.


                long code; // it is long because int supports 10 digits only while barcodes are 12 digits long
                decimal qyt;
                long.TryParse(productCodeTB.Text, out code);
                decimal.TryParse(productQuantityTB.Text, out qyt);

                //Ceck if there is a product found with the same code 
                var GetprodWithCode = DB.Products.Where(p => p.Code == code).FirstOrDefault();
                if (GetprodWithCode != null)
                {
                    // If so dont add a new product, just increase the quantity of the found one
                    GetprodWithCode.Quantity += qyt;
                    DB.SaveChanges();
                    MessageBox.Show($"The Product with code {GetprodWithCode.Code} found and updated to {GetprodWithCode.Quantity}");
                    // Then display all the products with the current ( in text box) SupploOrderId to the grid view
                    supplyOrderNumberTB.Text = DB.SupplyOrders.Max(s => s.Id).ToString();
                    var soid = int.Parse(supplyOrderNumberTB.Text);
                    var currentProducts = DB.Products.Where(p => p.SupplyOrderId == soid).ToList();
                    supplyOrderProductsDGV.DataSource = currentProducts;
                }
                else {
                    // if no product with same code found
                    // create a new instance of the product class and 
                    Product Prod = new Product();
                    // Then start to assign the properties the nwe vlaues needed to be inserted to hte table 
                    Prod.Name = productNameTB.Text;
                    Prod.MeasuringUnit = ProductMUCB.Text;
                    decimal price;
                    int WhId;

                    decimal.TryParse(producPriceTB.Text, out price);
                    int.TryParse(ProductFormwarehouseCB.Text, out WhId);
                    Prod.Quantity = qyt;
                    ;
                    Prod.Code = code;
                    Prod.Price = price;
                    Prod.WarehouseID = WhId;
                    /* Try to parse the code, if the string inserted was in incorrect format
                     initialize the declared variable ( with what ever the value inserted) and assign its value to the property */
                    Prod.Currency = ProductCurrencyTB.Text;
                    Prod.ProdDate = ProductProdDateTable.Value;
                    Prod.SupplyOrderId = int.Parse(supplyOrderNumberTB.Text);
                    Prod.SupplierId = int.Parse(SOSuppliersCB.Text);
                    if (producValidationPeriodTB.Text != "")
                    {
                        Prod.ValidationPeriod = decimal.Parse(producValidationPeriodTB.Text);
                    }
                    else { Prod.ValidationPeriod = null; }
                    Prod.Notes = productNotesTB.Text;
                    // add the new instance to hte context 
                    DB.Products.Add(Prod);
                    // save the changes
                    DB.SaveChanges();
                    supplyOrderNumberTB.Text = DB.SupplyOrders.Max(s => s.Id).ToString();
                    var soid = int.Parse(supplyOrderNumberTB.Text);
                    var currentProducts = DB.Products.Where(p => p.SupplyOrderId == soid).ToList();
                    supplyOrderProductsDGV.DataSource = currentProducts;

                    MessageBox.Show("Added");

                }




            }
            else
            {
                MessageBox.Show("Name, Supplier and Warehouse boxes can't be void");
            }
        }

        private void supplyOrderCreateOrderBtn_Click(object sender, EventArgs e)
        {
            if (ProductFormwarehouseCB.Text == "") {
                MessageBox.Show( "You need to choose a warehosue");
            } else
            {

                var supplyOrder = new SupplyOrder();
                int WhId;
                int.TryParse(ProductFormwarehouseCB.Text, out WhId);
                supplyOrder.Date = SupplyOrderDate.MinDate;
                supplyOrder.WarehouseID = WhId;
                DB.SupplyOrders.Add(supplyOrder);
                DB.SaveChanges();
                var LastSupplyOrder = DB.SupplyOrders.Max(s => s.Id);
                supplyOrderNumberTB.Text = LastSupplyOrder.ToString();

                MessageBox.Show("Now add the Products");

            }

        }

     
        private void updateProductBtn_Click(object sender, EventArgs e)
        {
           

            var productID = int.Parse(supplyOrderProductsDGV.CurrentRow.Cells[0].Value.ToString());
            var ThisProduct = DB.Products.Where(p => p.ID == productID).FirstOrDefault();
            if (ThisProduct != null)
            {


                ThisProduct.Name = productNameTB.Text;
                ThisProduct.Quantity = decimal.Parse(productQuantityTB.Text);
                ThisProduct.MeasuringUnit = ProductMUCB.Text;
                long code;
                decimal price;
                decimal validationPeriod;
                long.TryParse(productCodeTB.Text, out code);
                decimal.TryParse(producPriceTB.Text, out price);
                decimal.TryParse(producValidationPeriodTB.Text, out validationPeriod);
                ThisProduct.Code = code;
                ThisProduct.Price = price;
                ThisProduct.Currency = ProductCurrencyTB.Text; // in db type decimal > nvarchar() but still this change not read here
                //ThisProduct.ProdDate = ProductProdDateTable.Date;
                ThisProduct.ValidationPeriod = validationPeriod;
                ThisProduct.WarehouseID = int.Parse(ProductFormwarehouseCB.Text);
                ThisProduct.Notes = productNotesTB.Text;
                ThisProduct.SupplierId = int.Parse(SOSuppliersCB.Text);
                DB.SaveChanges();

                try { 
                int sod =  Convert.ToInt32(supplyOrdersCB.Text);
                    var currentSOProducts = DB.Products.Where(p => p.SupplyOrderId == sod).ToList();
                    supplyOrderProductsDGV.DataSource = currentSOProducts;
                }
                catch
                {
                    
                } 
              
              
                MessageBox.Show("Updated");

            }
        }

        private void supplyOrderAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void supplyOrderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sod =int.Parse(supplyOrdersCB.Text); 
            var currentSOProducts = DB.Products.Where(p => p.SupplyOrderId == sod).ToList();
            supplyOrderProductsDGV.DataSource = currentSOProducts; 
        }

        private void supplyOrderProductsDGV_SelectionChanged(object sender, EventArgs e)
        {
            var productID = int.Parse(supplyOrderProductsDGV.CurrentRow.Cells[0].Value.ToString());
            FillData(productID);
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
                 producValidationPeriodTB.Text = ThisProduct.ValidationPeriod.ToString() ;
                 ProductFormwarehouseCB.Text = ThisProduct.WarehouseID.ToString(); // error
                productNotesTB.Text = ThisProduct.Notes;
                productCodeTB.Text = ThisProduct.Code.ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void supplyOrderProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsGB_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
 