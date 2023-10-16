namespace Stock_Management
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.warehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehousesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehousesFormBTN = new System.Windows.Forms.Button();
            this.reportsFormBtn = new System.Windows.Forms.Button();
            this.warehousesTransferreFormBTN = new System.Windows.Forms.Button();
            this.productsFormBtn = new System.Windows.Forms.Button();
            this.customersFormBtn = new System.Windows.Forms.Button();
            this.supplyOrdersFormBtn = new System.Windows.Forms.Button();
            this.exportingOrdersFormBtn = new System.Windows.Forms.Button();
            this.suppliersFormBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehousesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.suppliresToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.testingFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // warehousesToolStripMenuItem
            // 
            this.warehousesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.warehousesToolStripMenuItem1});
            this.warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            this.warehousesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.warehousesToolStripMenuItem.Text = "Warehouses";
            this.warehousesToolStripMenuItem.Click += new System.EventHandler(this.warehousesToolStripMenuItem_Click);
            this.warehousesToolStripMenuItem.DoubleClick += new System.EventHandler(this.warehousesToolStripMenuItem_DoubleClick);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // warehousesToolStripMenuItem1
            // 
            this.warehousesToolStripMenuItem1.Name = "warehousesToolStripMenuItem1";
            this.warehousesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.warehousesToolStripMenuItem1.Text = "Warehouses";
            this.warehousesToolStripMenuItem1.Click += new System.EventHandler(this.warehousesToolStripMenuItem1_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // suppliresToolStripMenuItem
            // 
            this.suppliresToolStripMenuItem.Name = "suppliresToolStripMenuItem";
            this.suppliresToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliresToolStripMenuItem.Text = "Supplires";
            this.suppliresToolStripMenuItem.Click += new System.EventHandler(this.suppliresToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyOrderToolStripMenuItem,
            this.exportOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // supplyOrderToolStripMenuItem
            // 
            this.supplyOrderToolStripMenuItem.Name = "supplyOrderToolStripMenuItem";
            this.supplyOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplyOrderToolStripMenuItem.Text = "Supply order";
            this.supplyOrderToolStripMenuItem.Click += new System.EventHandler(this.supplyOrderToolStripMenuItem_Click);
            // 
            // testingFormToolStripMenuItem
            // 
            this.testingFormToolStripMenuItem.Name = "testingFormToolStripMenuItem";
            this.testingFormToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.testingFormToolStripMenuItem.Text = "Testing Form";
            this.testingFormToolStripMenuItem.Click += new System.EventHandler(this.testingFormToolStripMenuItem_Click);
            // 
            // exportOrderToolStripMenuItem
            // 
            this.exportOrderToolStripMenuItem.Name = "exportOrderToolStripMenuItem";
            this.exportOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportOrderToolStripMenuItem.Text = "Export order";
            this.exportOrderToolStripMenuItem.Click += new System.EventHandler(this.exportOrderToolStripMenuItem_Click);
            // 
            // WarehousesFormBTN
            // 
            this.WarehousesFormBTN.Location = new System.Drawing.Point(80, 67);
            this.WarehousesFormBTN.Name = "WarehousesFormBTN";
            this.WarehousesFormBTN.Size = new System.Drawing.Size(133, 125);
            this.WarehousesFormBTN.TabIndex = 1;
            this.WarehousesFormBTN.Text = "Warehouses";
            this.WarehousesFormBTN.UseVisualStyleBackColor = true;
            this.WarehousesFormBTN.Click += new System.EventHandler(this.WarehousesFormBTN_Click);
            // 
            // reportsFormBtn
            // 
            this.reportsFormBtn.Location = new System.Drawing.Point(80, 232);
            this.reportsFormBtn.Name = "reportsFormBtn";
            this.reportsFormBtn.Size = new System.Drawing.Size(133, 125);
            this.reportsFormBtn.TabIndex = 2;
            this.reportsFormBtn.Text = "Reports";
            this.reportsFormBtn.UseVisualStyleBackColor = true;
            this.reportsFormBtn.Click += new System.EventHandler(this.reportsFormBtn_Click);
            // 
            // warehousesTransferreFormBTN
            // 
            this.warehousesTransferreFormBTN.Location = new System.Drawing.Point(254, 67);
            this.warehousesTransferreFormBTN.Name = "warehousesTransferreFormBTN";
            this.warehousesTransferreFormBTN.Size = new System.Drawing.Size(133, 125);
            this.warehousesTransferreFormBTN.TabIndex = 3;
            this.warehousesTransferreFormBTN.Text = "Transferres";
            this.warehousesTransferreFormBTN.UseVisualStyleBackColor = true;
            this.warehousesTransferreFormBTN.Click += new System.EventHandler(this.warehousesTransferreFormBTN_Click);
            // 
            // productsFormBtn
            // 
            this.productsFormBtn.Location = new System.Drawing.Point(430, 67);
            this.productsFormBtn.Name = "productsFormBtn";
            this.productsFormBtn.Size = new System.Drawing.Size(133, 125);
            this.productsFormBtn.TabIndex = 4;
            this.productsFormBtn.Text = "Products";
            this.productsFormBtn.UseVisualStyleBackColor = true;
            this.productsFormBtn.Click += new System.EventHandler(this.productsFormBtn_Click);
            // 
            // customersFormBtn
            // 
            this.customersFormBtn.Location = new System.Drawing.Point(603, 67);
            this.customersFormBtn.Name = "customersFormBtn";
            this.customersFormBtn.Size = new System.Drawing.Size(133, 125);
            this.customersFormBtn.TabIndex = 5;
            this.customersFormBtn.Text = "Customers";
            this.customersFormBtn.UseVisualStyleBackColor = true;
            this.customersFormBtn.Click += new System.EventHandler(this.customersFormBtn_Click);
            // 
            // supplyOrdersFormBtn
            // 
            this.supplyOrdersFormBtn.Location = new System.Drawing.Point(254, 232);
            this.supplyOrdersFormBtn.Name = "supplyOrdersFormBtn";
            this.supplyOrdersFormBtn.Size = new System.Drawing.Size(133, 125);
            this.supplyOrdersFormBtn.TabIndex = 6;
            this.supplyOrdersFormBtn.Text = "Supply orders";
            this.supplyOrdersFormBtn.UseVisualStyleBackColor = true;
            this.supplyOrdersFormBtn.Click += new System.EventHandler(this.supplyOrdersFormBtn_Click);
            // 
            // exportingOrdersFormBtn
            // 
            this.exportingOrdersFormBtn.Location = new System.Drawing.Point(430, 232);
            this.exportingOrdersFormBtn.Name = "exportingOrdersFormBtn";
            this.exportingOrdersFormBtn.Size = new System.Drawing.Size(133, 125);
            this.exportingOrdersFormBtn.TabIndex = 7;
            this.exportingOrdersFormBtn.Text = "Exporting Orders";
            this.exportingOrdersFormBtn.UseVisualStyleBackColor = true;
            this.exportingOrdersFormBtn.Click += new System.EventHandler(this.exportingOrdersFormBtn_Click);
            // 
            // suppliersFormBtn
            // 
            this.suppliersFormBtn.Location = new System.Drawing.Point(603, 232);
            this.suppliersFormBtn.Name = "suppliersFormBtn";
            this.suppliersFormBtn.Size = new System.Drawing.Size(133, 125);
            this.suppliersFormBtn.TabIndex = 8;
            this.suppliersFormBtn.Text = "Suppliers";
            this.suppliersFormBtn.UseVisualStyleBackColor = true;
            this.suppliersFormBtn.Click += new System.EventHandler(this.suppliersFormBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suppliersFormBtn);
            this.Controls.Add(this.exportingOrdersFormBtn);
            this.Controls.Add(this.supplyOrdersFormBtn);
            this.Controls.Add(this.customersFormBtn);
            this.Controls.Add(this.productsFormBtn);
            this.Controls.Add(this.warehousesTransferreFormBTN);
            this.Controls.Add(this.reportsFormBtn);
            this.Controls.Add(this.WarehousesFormBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main Window - - Stock Management ITI ENG. Ouf\'s Project  - Ahmad Haseeb";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem warehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehousesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportOrderToolStripMenuItem;
        private System.Windows.Forms.Button WarehousesFormBTN;
        private System.Windows.Forms.Button reportsFormBtn;
        private System.Windows.Forms.Button warehousesTransferreFormBTN;
        private System.Windows.Forms.Button productsFormBtn;
        private System.Windows.Forms.Button customersFormBtn;
        private System.Windows.Forms.Button supplyOrdersFormBtn;
        private System.Windows.Forms.Button exportingOrdersFormBtn;
        private System.Windows.Forms.Button suppliersFormBtn;
    }
}

