namespace Stock_Management.Screens
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productIDTB = new System.Windows.Forms.TextBox();
            this.productsCB = new System.Windows.Forms.ComboBox();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productQuantityTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductMUCB = new System.Windows.Forms.ComboBox();
            this.producPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCurrencyTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductProdDateTable = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProducValidationPeriodTypeCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productNotesTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductFormwarehouseCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.productCodeTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.productFindBtn = new System.Windows.Forms.Button();
            this.productIDGridBtn = new System.Windows.Forms.Button();
            this.productIDGridTB = new System.Windows.Forms.TextBox();
            this.refreshGVBtn = new System.Windows.Forms.Button();
            this.filterByWHCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.refreshPageBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.SOSuppliersCB = new System.Windows.Forms.ComboBox();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.supplyOrdersCB = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.productExpireDateTB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.producValidationPeriodTB = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(302, 155);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addProductBtn.TabIndex = 0;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // productIDTB
            // 
            this.productIDTB.Enabled = false;
            this.productIDTB.Location = new System.Drawing.Point(34, 69);
            this.productIDTB.Name = "productIDTB";
            this.productIDTB.Size = new System.Drawing.Size(100, 20);
            this.productIDTB.TabIndex = 2;
            // 
            // productsCB
            // 
            this.productsCB.Enabled = false;
            this.productsCB.FormattingEnabled = true;
            this.productsCB.Location = new System.Drawing.Point(34, 12);
            this.productsCB.Name = "productsCB";
            this.productsCB.Size = new System.Drawing.Size(754, 21);
            this.productsCB.TabIndex = 3;
            this.productsCB.SelectedIndexChanged += new System.EventHandler(this.productsCB_SelectedIndexChanged);
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(163, 68);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(100, 20);
            this.productNameTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // productQuantityTB
            // 
            this.productQuantityTB.Location = new System.Drawing.Point(302, 69);
            this.productQuantityTB.Name = "productQuantityTB";
            this.productQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity Unit";
            // 
            // ProductMUCB
            // 
            this.ProductMUCB.FormattingEnabled = true;
            this.ProductMUCB.Items.AddRange(new object[] {
            "Piece",
            "Kg",
            "Gram",
            "Case",
            "Each",
            "Pallete"});
            this.ProductMUCB.Location = new System.Drawing.Point(421, 68);
            this.ProductMUCB.Name = "ProductMUCB";
            this.ProductMUCB.Size = new System.Drawing.Size(121, 21);
            this.ProductMUCB.TabIndex = 10;
            // 
            // producPriceTB
            // 
            this.producPriceTB.Location = new System.Drawing.Point(569, 69);
            this.producPriceTB.Name = "producPriceTB";
            this.producPriceTB.Size = new System.Drawing.Size(100, 20);
            this.producPriceTB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // ProductCurrencyTB
            // 
            this.ProductCurrencyTB.Location = new System.Drawing.Point(695, 69);
            this.ProductCurrencyTB.Name = "ProductCurrencyTB";
            this.ProductCurrencyTB.Size = new System.Drawing.Size(100, 20);
            this.ProductCurrencyTB.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Currency";
            // 
            // ProductProdDateTable
            // 
            this.ProductProdDateTable.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ProductProdDateTable.Location = new System.Drawing.Point(810, 69);
            this.ProductProdDateTable.Name = "ProductProdDateTable";
            this.ProductProdDateTable.Size = new System.Drawing.Size(206, 20);
            this.ProductProdDateTable.TabIndex = 15;
            this.ProductProdDateTable.ValueChanged += new System.EventHandler(this.ProductProdDateTable_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Production date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1031, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Validatino period";
            // 
            // ProducValidationPeriodTypeCB
            // 
            this.ProducValidationPeriodTypeCB.FormattingEnabled = true;
            this.ProducValidationPeriodTypeCB.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.ProducValidationPeriodTypeCB.Location = new System.Drawing.Point(1159, 68);
            this.ProducValidationPeriodTypeCB.Name = "ProducValidationPeriodTypeCB";
            this.ProducValidationPeriodTypeCB.Size = new System.Drawing.Size(121, 21);
            this.ProducValidationPeriodTypeCB.TabIndex = 20;
            this.ProducValidationPeriodTypeCB.SelectedIndexChanged += new System.EventHandler(this.ProducValidationPeriodTypeCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1156, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Validation period type";
            // 
            // productNotesTB
            // 
            this.productNotesTB.Location = new System.Drawing.Point(34, 113);
            this.productNotesTB.Multiline = true;
            this.productNotesTB.Name = "productNotesTB";
            this.productNotesTB.Size = new System.Drawing.Size(229, 104);
            this.productNotesTB.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Notes";
            // 
            // ProductFormwarehouseCB
            // 
            this.ProductFormwarehouseCB.FormattingEnabled = true;
            this.ProductFormwarehouseCB.Location = new System.Drawing.Point(1307, 68);
            this.ProductFormwarehouseCB.Name = "ProductFormwarehouseCB";
            this.ProductFormwarehouseCB.Size = new System.Drawing.Size(121, 21);
            this.ProductFormwarehouseCB.TabIndex = 24;
            this.ProductFormwarehouseCB.SelectedIndexChanged += new System.EventHandler(this.ProductFormwarehouseCB_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1304, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Warehouse";
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(398, 155);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(75, 23);
            this.updateProductBtn.TabIndex = 25;
            this.updateProductBtn.Text = "Update  Product";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // productCodeTB
            // 
            this.productCodeTB.Location = new System.Drawing.Point(302, 113);
            this.productCodeTB.Name = "productCodeTB";
            this.productCodeTB.Size = new System.Drawing.Size(240, 20);
            this.productCodeTB.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(201, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "*";
            // 
            // productFindBtn
            // 
            this.productFindBtn.Location = new System.Drawing.Point(810, 12);
            this.productFindBtn.Name = "productFindBtn";
            this.productFindBtn.Size = new System.Drawing.Size(75, 23);
            this.productFindBtn.TabIndex = 29;
            this.productFindBtn.Text = "Find Product";
            this.productFindBtn.UseVisualStyleBackColor = true;
            this.productFindBtn.Click += new System.EventHandler(this.productFindBtn_Click);
            // 
            // productIDGridBtn
            // 
            this.productIDGridBtn.Location = new System.Drawing.Point(1205, 262);
            this.productIDGridBtn.Name = "productIDGridBtn";
            this.productIDGridBtn.Size = new System.Drawing.Size(75, 23);
            this.productIDGridBtn.TabIndex = 31;
            this.productIDGridBtn.Text = "Find Product";
            this.productIDGridBtn.UseVisualStyleBackColor = true;
            this.productIDGridBtn.Click += new System.EventHandler(this.productIDGridBtn_Click);
            // 
            // productIDGridTB
            // 
            this.productIDGridTB.Location = new System.Drawing.Point(1085, 262);
            this.productIDGridTB.Multiline = true;
            this.productIDGridTB.Name = "productIDGridTB";
            this.productIDGridTB.Size = new System.Drawing.Size(100, 23);
            this.productIDGridTB.TabIndex = 32;
            // 
            // refreshGVBtn
            // 
            this.refreshGVBtn.Location = new System.Drawing.Point(1307, 262);
            this.refreshGVBtn.Name = "refreshGVBtn";
            this.refreshGVBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshGVBtn.TabIndex = 33;
            this.refreshGVBtn.Text = "Refresh";
            this.refreshGVBtn.UseVisualStyleBackColor = true;
            this.refreshGVBtn.Click += new System.EventHandler(this.refreshGVBtn_Click);
            // 
            // filterByWHCB
            // 
            this.filterByWHCB.FormattingEnabled = true;
            this.filterByWHCB.Location = new System.Drawing.Point(926, 264);
            this.filterByWHCB.Name = "filterByWHCB";
            this.filterByWHCB.Size = new System.Drawing.Size(121, 21);
            this.filterByWHCB.TabIndex = 35;
            this.filterByWHCB.SelectedIndexChanged += new System.EventHandler(this.filterByWHCB_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(923, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Filter By warhouse";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1082, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Product Id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "You can select a product to update or remove.";
            // 
            // refreshPageBtn
            // 
            this.refreshPageBtn.Location = new System.Drawing.Point(1383, 12);
            this.refreshPageBtn.Name = "refreshPageBtn";
            this.refreshPageBtn.Size = new System.Drawing.Size(121, 23);
            this.refreshPageBtn.TabIndex = 38;
            this.refreshPageBtn.Text = "Refresh fields";
            this.refreshPageBtn.UseVisualStyleBackColor = true;
            this.refreshPageBtn.Click += new System.EventHandler(this.refreshPageBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1569, 294);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // productsDGV
            // 
            this.productsDGV.AutoGenerateColumns = false;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.DataSource = this.productBindingSource;
            this.productsDGV.Location = new System.Drawing.Point(1494, 12);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.Size = new System.Drawing.Size(10, 10);
            this.productsDGV.TabIndex = 30;
            this.productsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellContentClick);
            this.productsDGV.SelectionChanged += new System.EventHandler(this.productsDGV_SelectionChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1434, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Suppliers";
            // 
            // SOSuppliersCB
            // 
            this.SOSuppliersCB.FormattingEnabled = true;
            this.SOSuppliersCB.Location = new System.Drawing.Point(1437, 68);
            this.SOSuppliersCB.Name = "SOSuppliersCB";
            this.SOSuppliersCB.Size = new System.Drawing.Size(67, 21);
            this.SOSuppliersCB.TabIndex = 41;
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.Location = new System.Drawing.Point(1428, 262);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(75, 23);
            this.removeProductBtn.TabIndex = 43;
            this.removeProductBtn.Text = "Remove";
            this.removeProductBtn.UseVisualStyleBackColor = true;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // supplyOrdersCB
            // 
            this.supplyOrdersCB.FormattingEnabled = true;
            this.supplyOrdersCB.Location = new System.Drawing.Point(1307, 124);
            this.supplyOrdersCB.Name = "supplyOrdersCB";
            this.supplyOrdersCB.Size = new System.Drawing.Size(121, 21);
            this.supplyOrdersCB.TabIndex = 80;
            this.supplyOrdersCB.SelectedIndexChanged += new System.EventHandler(this.supplyOrdersCB_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1304, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 79;
            this.label18.Text = "Supply order Id";
            // 
            // productExpireDateTB
            // 
            this.productExpireDateTB.Location = new System.Drawing.Point(810, 113);
            this.productExpireDateTB.Name = "productExpireDateTB";
            this.productExpireDateTB.ReadOnly = true;
            this.productExpireDateTB.Size = new System.Drawing.Size(206, 20);
            this.productExpireDateTB.TabIndex = 81;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(807, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 82;
            this.label19.Text = "Expiry Date";
            // 
            // producValidationPeriodTB
            // 
            this.producValidationPeriodTB.Location = new System.Drawing.Point(1034, 68);
            this.producValidationPeriodTB.Name = "producValidationPeriodTB";
            this.producValidationPeriodTB.Size = new System.Drawing.Size(100, 20);
            this.producValidationPeriodTB.TabIndex = 83;
            this.producValidationPeriodTB.TextChanged += new System.EventHandler(this.producValidationPeriodTB_TextChanged_1);
            this.producValidationPeriodTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.producValidationPeriodTB_KeyPress);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 654);
            this.Controls.Add(this.producValidationPeriodTB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.productExpireDateTB);
            this.Controls.Add(this.supplyOrdersCB);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.removeProductBtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SOSuppliersCB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refreshPageBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.filterByWHCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.refreshGVBtn);
            this.Controls.Add(this.productIDGridTB);
            this.Controls.Add(this.productIDGridBtn);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.productFindBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.productCodeTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.ProductFormwarehouseCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.productNotesTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProducValidationPeriodTypeCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductProdDateTable);
            this.Controls.Add(this.ProductCurrencyTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.producPriceTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductMUCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productQuantityTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsCB);
            this.Controls.Add(this.productIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProductBtn);
            this.Name = "ProductsForm";
            this.Text = "Products Form ";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productIDTB;
        private System.Windows.Forms.ComboBox productsCB;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productQuantityTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductMUCB;
        private System.Windows.Forms.TextBox producPriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductCurrencyTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ProductProdDateTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ProducValidationPeriodTypeCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox productNotesTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ProductFormwarehouseCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.TextBox productCodeTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button productFindBtn;
        private System.Windows.Forms.Button productIDGridBtn;
        private System.Windows.Forms.TextBox productIDGridTB;
        private System.Windows.Forms.Button refreshGVBtn;
        private System.Windows.Forms.ComboBox filterByWHCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
       // private Stock_Management.Stock_ManagementDataSet stock_ManagementDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        //private Stock_Management.Stock_ManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measuringUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validationPeriodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refreshPageBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox SOSuppliersCB;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.ComboBox supplyOrdersCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox productExpireDateTB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox producValidationPeriodTB;
    }
}