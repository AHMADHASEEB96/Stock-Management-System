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
    public partial class TransferProductsForm : Form
    {

        Model4 DB = new Model4();

        public TransferProductsForm()
        {
            InitializeComponent();
        }

        private void TransferProductsForm_Load(object sender, EventArgs e)
        {
            // Fill the products DGV
            FillWithAllProducts();
            // Fill the Warhouses Combo Boxes
            var allWarehouses = DB.Warehouses.Where(w => w == w).ToList();

            foreach (var item in allWarehouses) { transferFromCB.Items.Add(item.ID); }
            foreach (var item in allWarehouses) { transferToCB.Items.Add(item.ID); }


            filterByWHCB.DataSource = DB.Warehouses.ToList();
            filterByWHCB.ValueMember = "ID";
            filterByWHCB.DisplayMember = "Name";
         
        }

        private void tansferProductsDGV_SelectionChanged(object sender, EventArgs e)
        {
            var thisProductID = int.Parse(tansferProductsDGV.CurrentRow.Cells[0].Value.ToString()); // object > string > int 
            var thisProduct = DB.Products.Where(p => p.ID == thisProductID).FirstOrDefault(); // Without firstordefault it would return a sequence that we must iterate over.
            try
            {
                productQuantityTB.Text = thisProduct.Quantity.ToString();
                transferFromCB.Text = thisProduct.WarehouseID.ToString();
                productCodeTB.Text = thisProduct.Code.ToString();
            }
            catch { }

        }

        private void filterByWHCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter by warhouse 
            try
            {
                object selectedValue = filterByWHCB.SelectedValue; // Get the selected value object
                if (selectedValue is int) // Parse its interger ( wh id)
                {
                    int whID = (int)selectedValue;
                    var allProductsFromThisWH = DB.Products.Where(p => p.WarehouseID == whID).ToList();
                    tansferProductsDGV.DataSource = allProductsFromThisWH;

                }



             
                
            }



            catch
            {
                MessageBox.Show(" Can't search by empty or invalid value");
            }




        }

        private void refreshGVBtn_Click(object sender, EventArgs e)
        {
            FillWithAllProducts();
            FillOutFilterationFields();
        }

        private void FillWithAllProducts()
        {

            var allProducts = DB.Products.Where(p => p == p).Select( p=> new {


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
            tansferProductsDGV.DataSource = allProducts;
        }

        private void productIDGridBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var thiProductId = int.Parse(productIDGridTB.Text);

                var thisProduct = DB.Products.Where(p => p.ID == thiProductId).ToList();
                tansferProductsDGV.DataSource = thisProduct;
            }



            catch
            {
                MessageBox.Show(" Can't search by empty or invalid value");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Search By code
            try
            {
                var thisProductCode = long.Parse(productCodeTB.Text);
                var thisProduct = DB.Products.Where(p => p.Code == thisProductCode).ToList();
                tansferProductsDGV.DataSource = thisProduct;
            }



            catch
            {
                MessageBox.Show(" Can't search by empty or invalid value");
            }

        }

        private void FillOutFilterationFields()
        {
            productCodeTB.Text = productIDGridTB.Text = filterByWHCB.Text = "";
            ;

        }



        // Transfer procuts between warehoues
        private void transferPartialBTN_Click(object sender, EventArgs e) // Use Try catch
        {

            // For the selected product ( From the Data grid view) get the coming info
            // ID
            var thisProductID = int.Parse(tansferProductsDGV.CurrentRow.Cells[0].Value.ToString());
            // Get the wharehous's Id that you are trying to transferre from
            var whTransferreFrom = int.Parse(transferFromCB.Text);
            
            // Make sure the product already found in there
            var isProdInThisWH = DB.Products.Where(p => p.ID == thisProductID && p.WarehouseID == whTransferreFrom).FirstOrDefault();
            if (isProdInThisWH != null)
            {

                // Itself
                var thisProduct = DB.Products.Where(p => p.ID == thisProductID).FirstOrDefault();
                // It's current warhoues id 
                int? oldWH = thisProduct.WarehouseID;
                // It's Quantity
                var currentQty = thisProduct.Quantity;
                // The quantity to transfer to another warhouse
                decimal qtuToTransfer;
                decimal.TryParse(productQuantityToTransferTB.Text, out qtuToTransfer);


                // It's Code
                var thisProductCode = DB.Products.Where(p => p.ID == thisProductID).Select(p => p.Code).FirstOrDefault();
                //The warehouse Id that you want to transfer to
                int newWHid;
                int.TryParse(transferToCB.Text, out newWHid);


                // Make sure this product ( same code ) doesn't exist in the new warehouse
                // Get the product with the same warehoue id you want to transfer to and with the same code 
                var sameProductInwarehouse = DB.Products.Where(p => p.Code == thisProductCode && p.WarehouseID == newWHid).FirstOrDefault();
                // First check that the user is not tryin to transfer to the same warhouse

                if (transferFromCB.Text != transferToCB.Text)
                {
                    if (currentQty == 0 || qtuToTransfer == 0)
                    {
                        MessageBox.Show(" quantities can't be empty ");
                        return;
                    }

                    ////////// Transfer the current quantity
                    // var sameProduct = DB.Products.Where( p.code)
                    ///// If the product already found in the warehoue to transfer to, just increase the quantity and don't add it as a new product 

                    if (sameProductInwarehouse != null)
                    {
                        // Reduce the transfer quantity from the current one 
                        thisProduct.Quantity = currentQty - qtuToTransfer;
                        // then add it to the new one 
                        sameProductInwarehouse.Quantity += qtuToTransfer;
                        PushTransferredItems(thisProductID, thisProductCode, qtuToTransfer, thisProduct.SupplierId, DateTime.Now, newWHid, oldWH);
                        // PushTransferredItems( int ProdIdn, decimal qty, int supplierId, DateTime transferTime, int distWhId, int srcWhId )
                    }
                    else
                    {
                        // If there is no product with the same code there, add a new product to this warehoue ( this new product takes new Id but the same code)
                        
                        thisProduct.Quantity = currentQty - qtuToTransfer;
                        // After reducing the quantity create another product with another id and the new quantity but with the same code;

                        Product Prod = new Product();
                        Prod.Code = thisProduct.Code;
                        Prod.Quantity = qtuToTransfer;
                        Prod.Currency = thisProduct.Currency;
                        Prod.Name = thisProduct.Name;
                        Prod.Price = thisProduct.Price;
                        // Prod.Supplier = thisProduct.Supplier;
                        Prod.SupplierId = thisProduct.SupplierId;
                        Prod.Name = thisProduct.Name;
                        Prod.ProdDate = thisProduct.ProdDate;
                        Prod.ValidationPeriod = thisProduct.ValidationPeriod;
                        Prod.ValidationPeriodType = thisProduct.ValidationPeriodType;
                        Prod.WarehouseID = newWHid;
                        // Then add this new Product to the Products table ( but with a different warhouse id )
                        DB.Products.Add(Prod);
                        PushTransferredItems(thisProductID, thisProductCode, qtuToTransfer, thisProduct.SupplierId, DateTime.Now, newWHid, oldWH);

                        DB.SaveChanges();

                    }
                    // If you are trying to transfer the whole quantity to a new warhouse then this product will be removed from the current warhoues
                    if (currentQty == qtuToTransfer)
                    {
                        if (currentQty == 0 || qtuToTransfer == 0)
                        {
                            MessageBox.Show(" quantities can't be empty ");
                        }
                        else
                        {
                            //Remove the product with the old warehouse 
                            var oldProduct = DB.Products.Where(p => p.Code == thisProduct.Code && p.WarehouseID == oldWH).FirstOrDefault();
                            PushTransferredItems(thisProductID, thisProductCode, qtuToTransfer, thisProduct.SupplierId, DateTime.Now, newWHid, oldWH);

                            DB.Products.Remove(oldProduct);
                            DB.SaveChanges();

                            MessageBox.Show($"Item with the code: {thisProductCode} was removed and The whole quantity was transfered to warehouse: {newWHid}");

                        }

                    }


                    DB.SaveChanges();

                    // refresh the Data Grid View
                    FillWithAllProducts();
                }
                else
                {
                    MessageBox.Show(" can't transfer to the same warhouse");
                }

            }
            else { MessageBox.Show(" This Item is not found in the warehouse " + whTransferreFrom); }

           

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        }


        // Remove the whole quantity to another warehouse without having to insert the same quantity to remove
        private void TransferWhole_Click(object sender, EventArgs e)
        {

            var thisProductID = int.Parse(tansferProductsDGV.CurrentRow.Cells[0].Value.ToString());
            var whTransferreFrom = int.Parse(transferFromCB.Text);
            var isProdInThisWH = DB.Products.Where(p => p.ID == thisProductID && p.WarehouseID == whTransferreFrom).FirstOrDefault();
            if (isProdInThisWH != null)
            {



                var thisProduct = DB.Products.Where(p => p.ID == thisProductID).FirstOrDefault();
                var newWHid = int.Parse(transferToCB.Text);
                var thisProductCode = DB.Products.Where(p => p.ID == thisProductID).Select(p => p.Code).FirstOrDefault();

                var sameProductInwarehouse = DB.Products.Where(p => p.Code == thisProductCode && p.WarehouseID == newWHid).FirstOrDefault();
                var currentQty = thisProduct.Quantity;

                int? oldWH = thisProduct.WarehouseID;
                decimal qtuToTransfer;
                decimal.TryParse(productQuantityToTransferTB.Text, out qtuToTransfer);


                if (transferFromCB.Text != transferToCB.Text)
                {

                    if (sameProductInwarehouse != null)
                    {
                        // if the product already found there increase its quantity by the quanitiy in this warehouse, to avoid having two products with same code and warehouse id 
                        sameProductInwarehouse.Quantity += currentQty;
                        PushTransferredItems(thisProductID, thisProductCode, qtuToTransfer, thisProduct.SupplierId, DateTime.Now, newWHid, oldWH);


                    }
                    else
                    {
                        // if not found in another warehouse just change the warehoues id
                        thisProduct.WarehouseID = newWHid;

                    }
                    // any way the product needs to be removed from the current warehouse after all.
                    DB.Products.Remove(thisProduct);

                    DB.SaveChanges();
                    FillWithAllProducts();

                }
                else
                {
                    MessageBox.Show(" can't transfer to the same warhouse");
                }




            }
            else { MessageBox.Show(" This Item is not found in the warehouse " + whTransferreFrom); }





        }

        private void PushTransferredItems( int ProdId, long? prodCode, decimal qty, int? supplierId, DateTime transferTime, int distWhId, int ? srcWhId ) { 
        TransferredItem NewTransferredItem = new TransferredItem();
            NewTransferredItem.ProductId = ProdId;
            NewTransferredItem.ProductsCode = prodCode; 
            NewTransferredItem.Quantity = qty;
            NewTransferredItem.SupplierId = supplierId;
            NewTransferredItem.TransferTime = transferTime;
            NewTransferredItem.FromWh = srcWhId;
            NewTransferredItem.ToWh = distWhId;

            DB.TransferredItems.Add(NewTransferredItem);
            DB.SaveChanges() ;  



            
        }

        private void productIDGridTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

