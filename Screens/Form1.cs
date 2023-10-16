using Stock_Management.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        void OpenWarhousesForm() { 
        Run(new WarehousesForm());
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Thread Th = new Thread(OpenCustomersForm);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();
        }
        void OpenCustomersForm()
        {
            Run(new CustomersForm());
        }

        private void suppliresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(OpenSuppliersForm);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();
        }
        void OpenSuppliersForm()
        {
            Run(new SuppliersForm());
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Run(new ProductsForm());
        }
        void Run(Form form)
        {

            form.ShowDialog();
        }


     

        private void supplyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread Th = new Thread(OpenSupplyOrderFormForm);
            Th.SetApartmentState(ApartmentState.STA);
            Th.Start();
        }

        void OpenSupplyOrderFormForm()
        {
            Run(new SupplyOrderForm());
        }

        void OpenTestingForm()
        {
            Run(new Testing());
        }

        private void testingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Run(new Testing());
        }

        private void warehousesToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
           
        }

         
        private void warehousesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Open Warhouses form
            Run(new WarehousesForm());
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Transfer products between Warhouses form
           
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Run( new ReportsForm());
        }

        private void exportOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Run( new ExportOrdersForm());
        }

        private void WarehousesFormBTN_Click(object sender, EventArgs e)
        {
            Run(new WarehousesForm());
        }

        private void exportingOrdersFormBtn_Click(object sender, EventArgs e)
        {
            Run(new ExportOrdersForm());
        }

        private void warehousesTransferreFormBTN_Click(object sender, EventArgs e)
        {
            Run(new TransferProductsForm());
        }

        private void customersFormBtn_Click(object sender, EventArgs e)
        {
            Run(new CustomersForm());
        }

        private void productsFormBtn_Click(object sender, EventArgs e)
        {
            Run(new ProductsForm());
        }

        private void supplyOrdersFormBtn_Click(object sender, EventArgs e)
        {
            Run(new SupplyOrderForm());
        }

        private void reportsFormBtn_Click(object sender, EventArgs e)
        {
            Run(new ReportsForm());
        }

        private void suppliersFormBtn_Click(object sender, EventArgs e)
        {
            Run( new SuppliersForm());
        }
    }
}
