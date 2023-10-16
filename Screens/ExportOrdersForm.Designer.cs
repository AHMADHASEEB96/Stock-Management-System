namespace Stock_Management.Screens
{
    partial class ExportOrdersForm
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
            this.CustomersCB = new System.Windows.Forms.ComboBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.productFindBtn = new System.Windows.Forms.Button();
            this.productsCB = new System.Windows.Forms.ComboBox();
            this.ExportOrderDGV = new System.Windows.Forms.DataGridView();
            this.productQuantityTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExportingOrderNoetsTB = new System.Windows.Forms.Label();
            this.updateExportingOrder = new System.Windows.Forms.Button();
            this.ExportingOrderIdTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentExpOrderText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exportiOrderItemRemoveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExportOrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersCB
            // 
            this.CustomersCB.FormattingEnabled = true;
            this.CustomersCB.Location = new System.Drawing.Point(667, 113);
            this.CustomersCB.Name = "CustomersCB";
            this.CustomersCB.Size = new System.Drawing.Size(121, 21);
            this.CustomersCB.TabIndex = 0;
            this.CustomersCB.SelectedIndexChanged += new System.EventHandler(this.CustomersCB_SelectedIndexChanged);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(713, 140);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProductBtn.TabIndex = 1;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // productFindBtn
            // 
            this.productFindBtn.Location = new System.Drawing.Point(713, 63);
            this.productFindBtn.Name = "productFindBtn";
            this.productFindBtn.Size = new System.Drawing.Size(75, 23);
            this.productFindBtn.TabIndex = 83;
            this.productFindBtn.Text = "Find Product";
            this.productFindBtn.UseVisualStyleBackColor = true;
            // 
            // productsCB
            // 
            this.productsCB.FormattingEnabled = true;
            this.productsCB.Location = new System.Drawing.Point(121, 21);
            this.productsCB.Name = "productsCB";
            this.productsCB.Size = new System.Drawing.Size(667, 21);
            this.productsCB.TabIndex = 82;
            this.productsCB.SelectedIndexChanged += new System.EventHandler(this.productsCB_SelectedIndexChanged);
            // 
            // ExportOrderDGV
            // 
            this.ExportOrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExportOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExportOrderDGV.Location = new System.Drawing.Point(115, 280);
            this.ExportOrderDGV.Name = "ExportOrderDGV";
            this.ExportOrderDGV.Size = new System.Drawing.Size(682, 297);
            this.ExportOrderDGV.TabIndex = 84;
            this.ExportOrderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExportOrderDGV_CellContentClick);
            this.ExportOrderDGV.SelectionChanged += new System.EventHandler(this.ExportOrderDGV_SelectionChanged);
            // 
            // productQuantityTB
            // 
            this.productQuantityTB.Location = new System.Drawing.Point(512, 114);
            this.productQuantityTB.Name = "productQuantityTB";
            this.productQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTB.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Customer";
            // 
            // productIdTB
            // 
            this.productIdTB.Location = new System.Drawing.Point(375, 113);
            this.productIdTB.Name = "productIdTB";
            this.productIdTB.ReadOnly = true;
            this.productIdTB.Size = new System.Drawing.Size(100, 20);
            this.productIdTB.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Product ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 75);
            this.textBox1.TabIndex = 92;
            // 
            // ExportingOrderNoetsTB
            // 
            this.ExportingOrderNoetsTB.AutoSize = true;
            this.ExportingOrderNoetsTB.Location = new System.Drawing.Point(143, 155);
            this.ExportingOrderNoetsTB.Name = "ExportingOrderNoetsTB";
            this.ExportingOrderNoetsTB.Size = new System.Drawing.Size(35, 13);
            this.ExportingOrderNoetsTB.TabIndex = 91;
            this.ExportingOrderNoetsTB.Text = "Notes";
            // 
            // updateExportingOrder
            // 
            this.updateExportingOrder.Location = new System.Drawing.Point(713, 171);
            this.updateExportingOrder.Name = "updateExportingOrder";
            this.updateExportingOrder.Size = new System.Drawing.Size(75, 23);
            this.updateExportingOrder.TabIndex = 93;
            this.updateExportingOrder.Text = "Update Product";
            this.updateExportingOrder.UseVisualStyleBackColor = true;
            this.updateExportingOrder.Click += new System.EventHandler(this.updateExportingOrder_Click);
            // 
            // ExportingOrderIdTB
            // 
            this.ExportingOrderIdTB.Location = new System.Drawing.Point(146, 113);
            this.ExportingOrderIdTB.Name = "ExportingOrderIdTB";
            this.ExportingOrderIdTB.Size = new System.Drawing.Size(100, 20);
            this.ExportingOrderIdTB.TabIndex = 95;
            this.ExportingOrderIdTB.TextChanged += new System.EventHandler(this.ExportingOrderIdTB_TextChanged);
            this.ExportingOrderIdTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExportingOrderIdTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Export order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Current Export order Number must be ";
            // 
            // CurrentExpOrderText
            // 
            this.CurrentExpOrderText.AutoSize = true;
            this.CurrentExpOrderText.Location = new System.Drawing.Point(346, 73);
            this.CurrentExpOrderText.Name = "CurrentExpOrderText";
            this.CurrentExpOrderText.Size = new System.Drawing.Size(64, 13);
            this.CurrentExpOrderText.TabIndex = 97;
            this.CurrentExpOrderText.Text = "Export order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Find Product First";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.Location = new System.Drawing.Point(269, 113);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.ReadOnly = true;
            this.ProductNameTB.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTB.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Product Name";
            // 
            // exportiOrderItemRemoveBtn
            // 
            this.exportiOrderItemRemoveBtn.Location = new System.Drawing.Point(607, 240);
            this.exportiOrderItemRemoveBtn.Name = "exportiOrderItemRemoveBtn";
            this.exportiOrderItemRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.exportiOrderItemRemoveBtn.TabIndex = 101;
            this.exportiOrderItemRemoveBtn.Text = "Remove ";
            this.exportiOrderItemRemoveBtn.UseVisualStyleBackColor = true;
            this.exportiOrderItemRemoveBtn.Click += new System.EventHandler(this.exportiOrderItemRemoveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Choose item to remove";
            // 
            // ExportOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 599);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportiOrderItemRemoveBtn);
            this.Controls.Add(this.ProductNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentExpOrderText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExportingOrderIdTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateExportingOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExportingOrderNoetsTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productIdTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productQuantityTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExportOrderDGV);
            this.Controls.Add(this.productFindBtn);
            this.Controls.Add(this.productsCB);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.CustomersCB);
            this.Name = "ExportOrdersForm";
            this.Text = "Export Orders";
            this.Load += new System.EventHandler(this.ExportOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExportOrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomersCB;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button productFindBtn;
        private System.Windows.Forms.ComboBox productsCB;
        private System.Windows.Forms.DataGridView ExportOrderDGV;
        private System.Windows.Forms.TextBox productQuantityTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productIdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ExportingOrderNoetsTB;
        private System.Windows.Forms.Button updateExportingOrder;
        private System.Windows.Forms.TextBox ExportingOrderIdTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentExpOrderText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exportiOrderItemRemoveBtn;
        private System.Windows.Forms.Label label8;
    }
}