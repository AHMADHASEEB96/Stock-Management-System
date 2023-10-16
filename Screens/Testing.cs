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

namespace Stock_Management.Screens
{
    public partial class Testing : Form
    {
        Model4 DB = new Model4();   
        public Testing()
        {
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_ManagementDataSet4.Product' table. You can move, or remove it, as needed.
            // this.productTableAdapter.Fill(this.stock_ManagementDataSet4.Product);
            // TODO: This line of code loads data into the 'stock_ManagementDataSet3.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.stock_ManagementDataSet3.Product);

            var WH = DB.Warehouses.Include(w => w.Products).Where(w => w.ID == 3).FirstOrDefault();
            var WHProduct = WH.Products.Where(p => p == p).Select( p => p == p).Count();
            // foreach (var product in WHProduct) { MessageBox.Show(product.Name); }
            MessageBox.Show($"{WHProduct}");

          
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the date as a string 
            var ProductionDateText = dateTimePicker1.Text;
            var ExpiryDateText = dateTimePicker2.Text;
            // convert the string to a datetime type
            DateTime ProductionDate = DateTime.Parse(ProductionDateText);
            DateTime ExpiryDate = DateTime.Parse(ExpiryDateText);
            // Get the deifference in days and time between two dates as a time span
            TimeSpan timeto = ExpiryDate - ProductionDate;
            // get the days only, ignore the time 
            var dayes = timeto.Days;
            // textBox1.Text = timeto.ToString();
            // textBox1.Text = $"{dayes} dayes";
             textBox1.Text = $"{dayes} dayes";

            // get the validation period as an interger 
            var validationPText = int.Parse(validationPeriod.Text);
            
            // add the validation period to the production date to get the expiry date
            DateTime expdate = ProductionDate.AddDays(validationPText);
            TimeSpan periodToExpire = (expdate - ProductionDate);
            var daysToExpire = periodToExpire.Days;

            MessageBox.Show($" this product expires at {expdate} after {daysToExpire} days");


        }
    }
}
