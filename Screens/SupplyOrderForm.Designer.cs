namespace Stock_Management.Screens
{
    partial class SupplyOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SOSuppliersCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SupplyOrderDate = new System.Windows.Forms.DateTimePicker();
            this.supplyOrderNumber = new System.Windows.Forms.Label();
            this.supplyOrderNumberTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductsGB = new System.Windows.Forms.GroupBox();
            this.productCodeTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.productNotesTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.productIDTB = new System.Windows.Forms.TextBox();
            this.productQuantityTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductMUCB = new System.Windows.Forms.ComboBox();
            this.producValidationPeriodTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.producPriceTB = new System.Windows.Forms.TextBox();
            this.ProductCurrencyTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductProdDateTable = new System.Windows.Forms.DateTimePicker();
            this.supplyOrderAddBtn = new System.Windows.Forms.Button();
            this.supplyOrderProductsDGV = new System.Windows.Forms.DataGridView();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.productIDGridTB = new System.Windows.Forms.TextBox();
            this.supplyOrderCreateOrderBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ProductFormwarehouseCB = new System.Windows.Forms.ComboBox();
            this.supplyOrdersCB = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.ProductsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyOrderProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Suppliers";
            // 
            // SOSuppliersCB
            // 
            this.SOSuppliersCB.FormattingEnabled = true;
            this.SOSuppliersCB.Location = new System.Drawing.Point(588, 19);
            this.SOSuppliersCB.Name = "SOSuppliersCB";
            this.SOSuppliersCB.Size = new System.Drawing.Size(67, 21);
            this.SOSuppliersCB.TabIndex = 32;
            this.SOSuppliersCB.SelectedIndexChanged += new System.EventHandler(this.SuppliersCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "if the product exist increase its quantity other wize add it as a new product";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "if a new supplier go add it from suppliers form then it will be added here to the" +
    " combobox ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SupplyOrderDate);
            this.groupBox1.Controls.Add(this.supplyOrderNumber);
            this.groupBox1.Controls.Add(this.supplyOrderNumberTB);
            this.groupBox1.Controls.Add(this.ProductFormwarehouseCB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(33, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 128);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supply order";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SupplyOrderDate
            // 
            this.SupplyOrderDate.Location = new System.Drawing.Point(20, 89);
            this.SupplyOrderDate.Name = "SupplyOrderDate";
            this.SupplyOrderDate.Size = new System.Drawing.Size(200, 20);
            this.SupplyOrderDate.TabIndex = 39;
            this.SupplyOrderDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // supplyOrderNumber
            // 
            this.supplyOrderNumber.AutoSize = true;
            this.supplyOrderNumber.Location = new System.Drawing.Point(17, 27);
            this.supplyOrderNumber.Name = "supplyOrderNumber";
            this.supplyOrderNumber.Size = new System.Drawing.Size(44, 13);
            this.supplyOrderNumber.TabIndex = 38;
            this.supplyOrderNumber.Text = "Number";
            // 
            // supplyOrderNumberTB
            // 
            this.supplyOrderNumberTB.Location = new System.Drawing.Point(20, 43);
            this.supplyOrderNumberTB.Name = "supplyOrderNumberTB";
            this.supplyOrderNumberTB.ReadOnly = true;
            this.supplyOrderNumberTB.Size = new System.Drawing.Size(100, 20);
            this.supplyOrderNumberTB.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Warehouse";
            // 
            // ProductsGB
            // 
            this.ProductsGB.Controls.Add(this.label1);
            this.ProductsGB.Controls.Add(this.SOSuppliersCB);
            this.ProductsGB.Controls.Add(this.productCodeTB);
            this.ProductsGB.Controls.Add(this.label10);
            this.ProductsGB.Controls.Add(this.productNotesTB);
            this.ProductsGB.Controls.Add(this.label12);
            this.ProductsGB.Controls.Add(this.label13);
            this.ProductsGB.Controls.Add(this.productIDTB);
            this.ProductsGB.Controls.Add(this.productQuantityTB);
            this.ProductsGB.Controls.Add(this.label17);
            this.ProductsGB.Controls.Add(this.productNameTB);
            this.ProductsGB.Controls.Add(this.label16);
            this.ProductsGB.Controls.Add(this.comboBox3);
            this.ProductsGB.Controls.Add(this.label4);
            this.ProductsGB.Controls.Add(this.label9);
            this.ProductsGB.Controls.Add(this.ProductMUCB);
            this.ProductsGB.Controls.Add(this.producValidationPeriodTB);
            this.ProductsGB.Controls.Add(this.label5);
            this.ProductsGB.Controls.Add(this.label8);
            this.ProductsGB.Controls.Add(this.producPriceTB);
            this.ProductsGB.Controls.Add(this.ProductCurrencyTB);
            this.ProductsGB.Controls.Add(this.label7);
            this.ProductsGB.Controls.Add(this.label6);
            this.ProductsGB.Controls.Add(this.ProductProdDateTable);
            this.ProductsGB.Location = new System.Drawing.Point(372, 48);
            this.ProductsGB.Name = "ProductsGB";
            this.ProductsGB.Size = new System.Drawing.Size(975, 128);
            this.ProductsGB.TabIndex = 37;
            this.ProductsGB.TabStop = false;
            this.ProductsGB.Text = "Products";
            this.ProductsGB.Enter += new System.EventHandler(this.ProductsGB_Enter);
            // 
            // productCodeTB
            // 
            this.productCodeTB.Location = new System.Drawing.Point(366, 75);
            this.productCodeTB.Name = "productCodeTB";
            this.productCodeTB.Size = new System.Drawing.Size(165, 20);
            this.productCodeTB.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Notes";
            // 
            // productNotesTB
            // 
            this.productNotesTB.Location = new System.Drawing.Point(548, 68);
            this.productNotesTB.Multiline = true;
            this.productNotesTB.Name = "productNotesTB";
            this.productNotesTB.Size = new System.Drawing.Size(229, 41);
            this.productNotesTB.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(499, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(101, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "*";
            // 
            // productIDTB
            // 
            this.productIDTB.Enabled = false;
            this.productIDTB.Location = new System.Drawing.Point(6, 27);
            this.productIDTB.Name = "productIDTB";
            this.productIDTB.Size = new System.Drawing.Size(34, 20);
            this.productIDTB.TabIndex = 42;
            // 
            // productQuantityTB
            // 
            this.productQuantityTB.Location = new System.Drawing.Point(202, 27);
            this.productQuantityTB.Name = "productQuantityTB";
            this.productQuantityTB.Size = new System.Drawing.Size(43, 20);
            this.productQuantityTB.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(60, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Name";
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(63, 27);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(100, 20);
            this.productNameTB.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Quantity";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.comboBox3.Location = new System.Drawing.Point(310, 74);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(35, 21);
            this.comboBox3.TabIndex = 58;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Validation period type";
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
            this.ProductMUCB.Location = new System.Drawing.Point(266, 24);
            this.ProductMUCB.Name = "ProductMUCB";
            this.ProductMUCB.Size = new System.Drawing.Size(34, 21);
            this.ProductMUCB.TabIndex = 48;
            // 
            // producValidationPeriodTB
            // 
            this.producValidationPeriodTB.Location = new System.Drawing.Point(252, 75);
            this.producValidationPeriodTB.Name = "producValidationPeriodTB";
            this.producValidationPeriodTB.Size = new System.Drawing.Size(37, 20);
            this.producValidationPeriodTB.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Validatino period";
            // 
            // producPriceTB
            // 
            this.producPriceTB.Location = new System.Drawing.Point(317, 24);
            this.producPriceTB.Name = "producPriceTB";
            this.producPriceTB.Size = new System.Drawing.Size(28, 20);
            this.producPriceTB.TabIndex = 50;
            // 
            // ProductCurrencyTB
            // 
            this.ProductCurrencyTB.Location = new System.Drawing.Point(366, 27);
            this.ProductCurrencyTB.Name = "ProductCurrencyTB";
            this.ProductCurrencyTB.Size = new System.Drawing.Size(46, 20);
            this.ProductCurrencyTB.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Production date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Currency";
            // 
            // ProductProdDateTable
            // 
            this.ProductProdDateTable.Location = new System.Drawing.Point(6, 71);
            this.ProductProdDateTable.Name = "ProductProdDateTable";
            this.ProductProdDateTable.Size = new System.Drawing.Size(200, 20);
            this.ProductProdDateTable.TabIndex = 53;
            // 
            // supplyOrderAddBtn
            // 
            this.supplyOrderAddBtn.Location = new System.Drawing.Point(215, 270);
            this.supplyOrderAddBtn.Name = "supplyOrderAddBtn";
            this.supplyOrderAddBtn.Size = new System.Drawing.Size(75, 23);
            this.supplyOrderAddBtn.TabIndex = 38;
            this.supplyOrderAddBtn.Text = "Add";
            this.supplyOrderAddBtn.UseVisualStyleBackColor = true;
            this.supplyOrderAddBtn.Click += new System.EventHandler(this.supplyOrderAddBtn_Click);
            // 
            // supplyOrderProductsDGV
            // 
            this.supplyOrderProductsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplyOrderProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyOrderProductsDGV.Location = new System.Drawing.Point(12, 332);
            this.supplyOrderProductsDGV.Name = "supplyOrderProductsDGV";
            this.supplyOrderProductsDGV.Size = new System.Drawing.Size(1473, 297);
            this.supplyOrderProductsDGV.TabIndex = 39;
            this.supplyOrderProductsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplyOrderProductsDGV_CellContentClick);
            this.supplyOrderProductsDGV.SelectionChanged += new System.EventHandler(this.supplyOrderProductsDGV_SelectionChanged);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(1230, 294);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(75, 23);
            this.updateProductBtn.TabIndex = 63;
            this.updateProductBtn.Text = "Update  Product";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-13, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "ID";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(1258, 182);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addProductBtn.TabIndex = 40;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(79, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Product Id";
            // 
            // productIDGridTB
            // 
            this.productIDGridTB.Location = new System.Drawing.Point(82, 270);
            this.productIDGridTB.Multiline = true;
            this.productIDGridTB.Name = "productIDGridTB";
            this.productIDGridTB.Size = new System.Drawing.Size(100, 23);
            this.productIDGridTB.TabIndex = 69;
            // 
            // supplyOrderCreateOrderBtn
            // 
            this.supplyOrderCreateOrderBtn.Location = new System.Drawing.Point(53, 182);
            this.supplyOrderCreateOrderBtn.Name = "supplyOrderCreateOrderBtn";
            this.supplyOrderCreateOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.supplyOrderCreateOrderBtn.TabIndex = 73;
            this.supplyOrderCreateOrderBtn.Text = "Create Order";
            this.supplyOrderCreateOrderBtn.UseVisualStyleBackColor = true;
            this.supplyOrderCreateOrderBtn.Click += new System.EventHandler(this.supplyOrderCreateOrderBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Create an order first then start to add products";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1055, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 77;
            this.label15.Text = "Supply order Id";
            // 
            // ProductFormwarehouseCB
            // 
            this.ProductFormwarehouseCB.FormattingEnabled = true;
            this.ProductFormwarehouseCB.Location = new System.Drawing.Point(151, 42);
            this.ProductFormwarehouseCB.Name = "ProductFormwarehouseCB";
            this.ProductFormwarehouseCB.Size = new System.Drawing.Size(121, 21);
            this.ProductFormwarehouseCB.TabIndex = 62;
            // 
            // supplyOrdersCB
            // 
            this.supplyOrdersCB.FormattingEnabled = true;
            this.supplyOrdersCB.Location = new System.Drawing.Point(1058, 295);
            this.supplyOrdersCB.Name = "supplyOrdersCB";
            this.supplyOrdersCB.Size = new System.Drawing.Size(121, 21);
            this.supplyOrdersCB.TabIndex = 78;
            this.supplyOrdersCB.SelectedIndexChanged += new System.EventHandler(this.supplyOrderCB_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(306, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(601, 13);
            this.label20.TabIndex = 79;
            this.label20.Text = "To update products in a certain supply order choose the supply order id below on " +
    "the right Side then choose from the grid view";
            // 
            // SupplyOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 638);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.supplyOrdersCB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.supplyOrderCreateOrderBtn);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.productIDGridTB);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.supplyOrderProductsDGV);
            this.Controls.Add(this.supplyOrderAddBtn);
            this.Controls.Add(this.ProductsGB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplyOrderForm";
            this.Text = "Supply order";
            this.Load += new System.EventHandler(this.SupplyOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ProductsGB.ResumeLayout(false);
            this.ProductsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyOrderProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SOSuppliersCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker SupplyOrderDate;
        private System.Windows.Forms.Label supplyOrderNumber;
        private System.Windows.Forms.TextBox supplyOrderNumberTB;
        private System.Windows.Forms.GroupBox ProductsGB;
        private System.Windows.Forms.Button supplyOrderAddBtn;
        private System.Windows.Forms.DataGridView supplyOrderProductsDGV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox productIDTB;
        private System.Windows.Forms.TextBox productQuantityTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductMUCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox producPriceTB;
        private System.Windows.Forms.TextBox productCodeTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox productNotesTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox producValidationPeriodTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ProductProdDateTable;
        private System.Windows.Forms.TextBox ProductCurrencyTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox productIDGridTB;
        private System.Windows.Forms.Button supplyOrderCreateOrderBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ProductFormwarehouseCB;
        private System.Windows.Forms.ComboBox supplyOrdersCB;
        private System.Windows.Forms.Label label20;
    }
}