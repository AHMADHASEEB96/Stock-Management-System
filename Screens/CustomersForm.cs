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
    public partial class CustomersForm : Form
    {
       
        Model4 DB = new Model4();

        public CustomersForm()
        {
            InitializeComponent();
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
          
            FillCustomerCB();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {

     


            Customer customer = new Customer();
            customer.Name = CustomerNameTB.Text;
            customer.Phone = CustomerPhoneTB.Text;

            customer.LandLineNumber = CustomerLandLineNumberTB.Text;

            customer.Fax = CustomerFaxTB.Text;

            customer.Mail = CustomerEmailTB.Text;
            customer.Website = CustomerWebsiteTB.Text;




            DB.Customers.Add(customer);
            DB.SaveChanges();
            FillCustomerCB();
            MessageBox.Show($"Customer Added");

           


        }

        private void CustomersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CustId = int.Parse(CustomersCB.Text);
            var customer = DB.Customers.Where(c => c.ID == CustId).FirstOrDefault(); // Error when FirstOrDefault was absent;
            CustomerIDTB.Text = customer.ID.ToString();
            CustomerNameTB.Text = customer.Name;
            CustomerPhoneTB.Text = customer.Phone;

            CustomerLandLineNumberTB.Text = customer.LandLineNumber;

            CustomerFaxTB.Text = customer.Fax;

            CustomerEmailTB.Text = customer.Mail;
            CustomerWebsiteTB.Text = customer.Website;
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {


            object selectedValue = CustomersCB.SelectedValue;
            if (selectedValue is int)
            {
                int custID = (int)selectedValue;
                var customer = DB.Customers.Where(c => c.ID == custID).FirstOrDefault(); // Error when FirstOrDefault was absent;
                if (customer != null)
                {
                    customer.Name = CustomerNameTB.Text;
                    customer.Phone = CustomerPhoneTB.Text;

                    customer.LandLineNumber = CustomerLandLineNumberTB.Text;

                    customer.Fax = CustomerFaxTB.Text;

                    customer.Mail = CustomerEmailTB.Text;
                    customer.Website = CustomerWebsiteTB.Text;
                    DB.SaveChanges();
                    MessageBox.Show($" Customer {custID} info updated");
                    FillOut();
                }
            }



        }
        void FillOut()
        {

            CustomerIDTB.Text = CustomerNameTB.Text = CustomerPhoneTB.Text = CustomerLandLineNumberTB.Text = CustomerFaxTB.Text = CustomerEmailTB.Text = CustomerWebsiteTB.Text = "";
            CustomersCB.Text = "";
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            FillOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object selectedValue = CustomersCB.SelectedValue;
            if (selectedValue is int)
            {
                int custID = (int)selectedValue;
                var customer = DB.Customers.Where(c => c.ID == custID).FirstOrDefault();
                DialogResult result = MessageBox.Show($"Are you sure you want to remove Customer {customer.Name}?", "Remove Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user's response is Yes, remove the item.
                if (result == DialogResult.Yes)
                {
                    DB.Customers.Remove(customer);
                    DB.SaveChanges();
                    FillCustomerCB();

                }

            }
        }

        void FillCustomerCB() {

            CustomersCB.DataSource = DB.Customers.ToList();
            CustomersCB.ValueMember = "ID";
            CustomersCB.DisplayMember = "Name";


        }
    }
}