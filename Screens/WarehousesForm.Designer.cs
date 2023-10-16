namespace Stock_Management.Screens
{
    partial class WarehousesForm
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
            this.WarehousesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouseIDTB = new System.Windows.Forms.TextBox();
            this.warehouseNameTB = new System.Windows.Forms.TextBox();
            this.warehouseAdressTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddWarehouse = new System.Windows.Forms.Button();
            this.updateWarhouse = new System.Windows.Forms.Button();
            this.warehouseFindBtn = new System.Windows.Forms.Button();
            this.AddNewWHBTN = new System.Windows.Forms.Button();
            this.warehouseAdminTB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WarehousesCB
            // 
            this.WarehousesCB.FormattingEnabled = true;
            this.WarehousesCB.Location = new System.Drawing.Point(79, 42);
            this.WarehousesCB.Name = "WarehousesCB";
            this.WarehousesCB.Size = new System.Drawing.Size(576, 21);
            this.WarehousesCB.TabIndex = 0;
            this.WarehousesCB.SelectedIndexChanged += new System.EventHandler(this.WarehousesCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouses";
            // 
            // warehouseIDTB
            // 
            this.warehouseIDTB.Location = new System.Drawing.Point(79, 98);
            this.warehouseIDTB.Name = "warehouseIDTB";
            this.warehouseIDTB.Size = new System.Drawing.Size(117, 20);
            this.warehouseIDTB.TabIndex = 2;
            // 
            // warehouseNameTB
            // 
            this.warehouseNameTB.Location = new System.Drawing.Point(225, 98);
            this.warehouseNameTB.Name = "warehouseNameTB";
            this.warehouseNameTB.Size = new System.Drawing.Size(117, 20);
            this.warehouseNameTB.TabIndex = 3;
            // 
            // warehouseAdressTB
            // 
            this.warehouseAdressTB.Location = new System.Drawing.Point(79, 141);
            this.warehouseAdressTB.Name = "warehouseAdressTB";
            this.warehouseAdressTB.Size = new System.Drawing.Size(403, 20);
            this.warehouseAdressTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adress";
            // 
            // AddWarehouse
            // 
            this.AddWarehouse.Location = new System.Drawing.Point(525, 98);
            this.AddWarehouse.Name = "AddWarehouse";
            this.AddWarehouse.Size = new System.Drawing.Size(75, 23);
            this.AddWarehouse.TabIndex = 10;
            this.AddWarehouse.Text = "Add";
            this.AddWarehouse.UseVisualStyleBackColor = true;
            this.AddWarehouse.Click += new System.EventHandler(this.AddWarehouse_Click);
            // 
            // updateWarhouse
            // 
            this.updateWarhouse.Location = new System.Drawing.Point(525, 138);
            this.updateWarhouse.Name = "updateWarhouse";
            this.updateWarhouse.Size = new System.Drawing.Size(75, 23);
            this.updateWarhouse.TabIndex = 11;
            this.updateWarhouse.Text = "Update";
            this.updateWarhouse.UseVisualStyleBackColor = true;
            this.updateWarhouse.Click += new System.EventHandler(this.updateWarhouse_Click);
            // 
            // warehouseFindBtn
            // 
            this.warehouseFindBtn.Location = new System.Drawing.Point(661, 42);
            this.warehouseFindBtn.Name = "warehouseFindBtn";
            this.warehouseFindBtn.Size = new System.Drawing.Size(75, 23);
            this.warehouseFindBtn.TabIndex = 12;
            this.warehouseFindBtn.Text = "Find by ID";
            this.warehouseFindBtn.UseVisualStyleBackColor = true;
            this.warehouseFindBtn.Click += new System.EventHandler(this.warehouseFindBtn_Click);
            // 
            // AddNewWHBTN
            // 
            this.AddNewWHBTN.Location = new System.Drawing.Point(639, 96);
            this.AddNewWHBTN.Name = "AddNewWHBTN";
            this.AddNewWHBTN.Size = new System.Drawing.Size(75, 23);
            this.AddNewWHBTN.TabIndex = 13;
            this.AddNewWHBTN.Text = "Add New";
            this.AddNewWHBTN.UseVisualStyleBackColor = true;
            this.AddNewWHBTN.Click += new System.EventHandler(this.AddNewWHBTN_Click);
            // 
            // warehouseAdminTB
            // 
            this.warehouseAdminTB.FormattingEnabled = true;
            this.warehouseAdminTB.Location = new System.Drawing.Point(365, 98);
            this.warehouseAdminTB.Name = "warehouseAdminTB";
            this.warehouseAdminTB.Size = new System.Drawing.Size(121, 21);
            this.warehouseAdminTB.TabIndex = 14;
            this.warehouseAdminTB.SelectedIndexChanged += new System.EventHandler(this.warehouseAdminTB_SelectedIndexChanged);
            // 
            // WarehousesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warehouseAdminTB);
            this.Controls.Add(this.AddNewWHBTN);
            this.Controls.Add(this.warehouseFindBtn);
            this.Controls.Add(this.updateWarhouse);
            this.Controls.Add(this.AddWarehouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warehouseAdressTB);
            this.Controls.Add(this.warehouseNameTB);
            this.Controls.Add(this.warehouseIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehousesCB);
            this.Name = "WarehousesForm";
            this.Text = "WarehousesForm";
            this.Load += new System.EventHandler(this.WarehousesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WarehousesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox warehouseIDTB;
        private System.Windows.Forms.TextBox warehouseNameTB;
        private System.Windows.Forms.TextBox warehouseAdressTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddWarehouse;
        private System.Windows.Forms.Button updateWarhouse;
        private System.Windows.Forms.Button warehouseFindBtn;
        private System.Windows.Forms.Button AddNewWHBTN;
        private System.Windows.Forms.ComboBox warehouseAdminTB;
    }
}