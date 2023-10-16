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
    public partial class WarehousesForm : Form
    {
        Model4 DB = new Model4();

        public WarehousesForm()
        {
            InitializeComponent();
        }

       
        private void WarehousesForm_Load(object sender, EventArgs e)
        {

            // Fill Admin CB with admins
            warehouseAdminTB.DataSource = DB.Admins.Where( a => a ==a ).ToList();
            warehouseAdminTB.ValueMember = "SSN";
            warehouseAdminTB.DisplayMember = "Name";

           // foreach (var admin in DB.Admins) { warehouseAdminTB.Items.Add(admin.SSN); }


         
            FillCB();

            FillOut(); // Start with the Fiels Empty
        }

        private void WarehousesCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            object selectedValue = WarehousesCB.SelectedValue; // Get the selected value object
            if (selectedValue is int) // Parse its interger ( wh id)
            {
                int whID = (int)selectedValue;


                var warehouse = DB.Warehouses.Where(w => w.ID == whID).FirstOrDefault(); // get the selected warehouse; and then its admin
                var whAdminSSN = DB.Warehouses.Where(w => w.ID == whID).Select(w => w.AdminSSN).FirstOrDefault();
                // get the admin name 
                if (whAdminSSN.HasValue)
                { // from the wareouse get the admin ssn and then go to the admins table and get the name with the same ssn;
                    int adminSSN = whAdminSSN.Value;
                    var whAdmin = DB.Admins.Where(a => a.SSN == adminSSN).FirstOrDefault();
                    warehouseAdminTB.Text = whAdmin.Name;

                }

                if (warehouse != null)
                {

                    warehouseIDTB.Text = warehouse.ID.ToString();
                    warehouseNameTB.Text = warehouse.Name;
                    warehouseAdressTB.Text = warehouse.Adress.ToString();



                }
            }
            else
            {
                // Do something else if the selected value is not an integer.
            }

        

           
        }


        // Add new Warehouse 🛑🛑🛑🛑🛑🛑🔴🔴🔴❌❌❌❌❌❌
        private void AddWarehouse_Click(object sender, EventArgs e)
        {
            var whID = int.Parse(warehouseIDTB.Text);
            // Make sure there is no warehouse with the same id or name;
            // Get all the warehouses with the same ID.
            var warehouses = DB.Warehouses.Where(w => w.ID == whID).FirstOrDefault();
            // Get all the warehouses with the same Nmae.
            var warehouseName = DB.Warehouses.Where(w => w.Name == warehouseNameTB.Text);

            // if there is no one with the same id 
            if (warehouses == null)
            {
                // chech if the user is inserting the same name of an existing warhouse;
                // if ther is 
                if (warehouseName.Count() != 0)
                {
                    // ask the user if the same name to be used again to create anothe warehoues.
                    DialogResult dr = MessageBox.Show($"There are {warehouseName.Count()} Warehouses withs the same name", "are you sure you want to use this name?", MessageBoxButtons.YesNo);
                    // if he is ok with that
                    if (dr == DialogResult.Yes)
                    {
                        // then add the 
                        Warehouse warehouse = new Warehouse();
                        warehouse.ID = whID;
                        warehouse.Name = warehouseNameTB.Text;
                        warehouse.AdminSSN = int.Parse(warehouseAdminTB.Text);
                        warehouse.Adress = warehouseAdressTB.Text;


                        DB.Warehouses.Add(warehouse);
                        DB.SaveChanges();
                        FillCB();

                        MessageBox.Show($"Added");


                    }
                    else { MessageBox.Show(" Add Cancelled"); }
                }
                else
                {
                    // then add the 
                    Warehouse warehouse = new Warehouse();
                    warehouse.ID = whID;
                    warehouse.Name = warehouseNameTB.Text;


                    object selectedValue = warehouseAdminTB.SelectedValue;
                    if (selectedValue is int)
                    {
                        warehouse.AdminSSN = (int)selectedValue;
                    };


                    warehouse.Adress = warehouseAdressTB.Text;

                    DB.Warehouses.Add(warehouse);
                    DB.SaveChanges();
                    FillCB();

                    MessageBox.Show($"Added");
                    FillOut();

                }




            }
            else { MessageBox.Show($"A warehouse with the ID {whID} already Found, Use another one"); }



        }

        // Update warehouse
        private void updateWarhouse_Click(object sender, EventArgs e)
        {
            var whID = int.Parse(warehouseIDTB.Text);
            var warehouse = DB.Warehouses.Where(w => w.ID == whID).FirstOrDefault();
            // If there a warehouse with the same name ask the user if he is sure;
            var warehouseName = DB.Warehouses.Where(w => w.Name == warehouseNameTB.Text);
            if (warehouse != null)
            {
                if (warehouseName.Count() != 0)
                {

                    DialogResult dr = MessageBox.Show($"There are {warehouseName.Count()} Warehouses withs the same name", "are you sure you want to use this name?", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {

                        warehouse.ID = int.Parse(warehouseIDTB.Text);
                        warehouse.Name = warehouseNameTB.Text;
                        warehouse.AdminSSN = int.Parse(warehouseAdminTB.Text);
                        warehouse.Adress = warehouseAdressTB.Text;
                        DB.SaveChanges();
                        FillCB();

                        MessageBox.Show("Updated");

                        FillOut();

                    }
                    else { MessageBox.Show(" Update Cancelled"); }
                }
                else if (warehouseAdminTB.Text != "")
                {


                    warehouse.ID = int.Parse(warehouseIDTB.Text);
                    warehouse.Name = warehouseNameTB.Text;
                    warehouse.AdminSSN = int.Parse(warehouseAdminTB.Text);
                    warehouse.Adress = warehouseAdressTB.Text;
                    DB.SaveChanges();
                    FillCB();

                    MessageBox.Show("Updated");
                    FillOut();
                }
                else

                    MessageBox.Show(" Empty Fields Found");
                {
                }



            }
            else { MessageBox.Show(" Warehouse not found"); }
        }
        void FillOut()
        {

            warehouseIDTB.Text = warehouseNameTB.Text = warehouseAdminTB.Text = warehouseAdressTB.Text = WarehousesCB.Text =  "";


        }

        private void warehouseFindBtn_Click(object sender, EventArgs e)
        {
            int whID;
            int.TryParse(WarehousesCB.Text, out whID);
            // var whID = int.Parse(WarehousesCB.Text);
            var warehouse = DB.Warehouses.Where(w => w.ID == whID).FirstOrDefault();
            // Get the admin

            var whAdminId = DB.Warehouses.Where(w => w.ID == whID).Select(w => w.AdminSSN).FirstOrDefault();
            var whAdmin = DB.Admins.Where(a => a.SSN == whAdminId).FirstOrDefault();

            if (warehouse != null)
            {

                warehouseIDTB.Text = warehouse.ID.ToString();
                warehouseNameTB.Text = warehouse.Name;
                warehouseAdminTB.Text = whAdmin.Name;

                warehouseAdressTB.Text = warehouse.Adress.ToString();

            }

        }
        private void FillCB()
        {

            WarehousesCB.DataSource = DB.Warehouses.ToList();
            WarehousesCB.ValueMember = "ID";
            WarehousesCB.DisplayMember = "Name";
        }

        private void AddNewWHBTN_Click(object sender, EventArgs e)
        {
            FillOut();
        }

        private void warehouseAdminTB_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}


// Try to Create an automatic filling to the combo box, but you may need to find solutions for the errors