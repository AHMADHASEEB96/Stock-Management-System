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
    public partial class SuppliersForm : Form
    {
        Model4 DB = new Model4();

        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void SuppliersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var supId = int.Parse(SuppliersCB.Text);
            var Supplier = DB.Suppliers.Where(s => s.ID == supId).FirstOrDefault(); // Error when FirstOrDefault was absent;
            SuppliersIDTB.Text = Supplier.ID.ToString();
            SuppliersNameTB.Text = Supplier.Name;
            SuppliersPhoneTB.Text = Supplier.Phone;

            SuppliersLandLineNumberTB.Text = Supplier.LandLineNumber;

            SuppliersFaxTB.Text = Supplier.Fax;

            SuppliersEmailTB.Text = Supplier.Mail;
            SuppliersWebsiteTB.Text = Supplier.Website;
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            
            FillSupplierCB();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {



            Supplier Supplier = new Supplier();
            Supplier.Name = SuppliersNameTB.Text;
            Supplier.Phone = SuppliersPhoneTB.Text;

            Supplier.LandLineNumber = SuppliersLandLineNumberTB.Text;

            Supplier.Fax = SuppliersFaxTB.Text;

            Supplier.Mail = SuppliersEmailTB.Text;
            Supplier.Website = SuppliersWebsiteTB.Text;




            DB.Suppliers.Add(Supplier);
            DB.SaveChanges();
            MessageBox.Show($"Supplier Added");
            SuppliersCB.DataSource = DB.Suppliers.ToList();
          
            FillOut();
            FillSupplierCB();

        }
        void FillOut()
        {

            SuppliersIDTB.Text = "";
            SuppliersNameTB.Text = "";
            SuppliersPhoneTB.Text = "";

            SuppliersLandLineNumberTB.Text = "";

            SuppliersFaxTB.Text = "";

            SuppliersEmailTB.Text = "";
            SuppliersWebsiteTB.Text = "";
        }

        private void updateSuppliers_Click(object sender, EventArgs e)
        {

            object selectedValue = SuppliersCB.SelectedValue;
            if (selectedValue is int)
            {
                int suppID = (int)selectedValue;
                var Suppliers = DB.Suppliers.Where(c => c.ID == suppID).FirstOrDefault();

                 if (Suppliers != null)
            {
                Suppliers.Name = SuppliersNameTB.Text;
                Suppliers.Phone = SuppliersPhoneTB.Text;

                Suppliers.LandLineNumber = SuppliersLandLineNumberTB.Text;

                Suppliers.Fax = SuppliersFaxTB.Text;

                Suppliers.Mail = SuppliersEmailTB.Text;
                Suppliers.Website = SuppliersWebsiteTB.Text;
                DB.SaveChanges();
                MessageBox.Show($" Supplier {Suppliers.Name} info updated");
                    FillSupplierCB();
                    FillOut();
            }
            }
               
         
           

            void FillOut()
            {

                SuppliersIDTB.Text = "";
                SuppliersNameTB.Text = "";
                SuppliersPhoneTB.Text = "";

                SuppliersLandLineNumberTB.Text = "";

                SuppliersFaxTB.Text = "";

                SuppliersEmailTB.Text = "";
                SuppliersWebsiteTB.Text = "";
                SuppliersCB.Text = "";
               
            }
        }

        private void supplierAddNewBtn_Click(object sender, EventArgs e)
        {
            FillOut();
        }

        void FillSupplierCB()
        {

            SuppliersCB.DataSource = DB.Suppliers.ToList();
            SuppliersCB.ValueMember = "ID";
            SuppliersCB.DisplayMember = "Name";


        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            object selectedValue = SuppliersCB.SelectedValue;
            if (selectedValue is int)
            {
                int suppID = (int)selectedValue;
                var Suppliers = DB.Suppliers.Where(c => c.ID == suppID).FirstOrDefault();

                DialogResult result = MessageBox.Show($"Are you sure you want to remove The Supplier {Suppliers.Name}?", "Remove Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user's response is Yes, remove the item.
                if (result == DialogResult.Yes)
                {
                    DB.Suppliers.Remove(Suppliers);
                    DB.SaveChanges();
                    FillSupplierCB();

                }

            }
        }
    }
}