namespace Stock_Management.Screens
{
    partial class TransferProductsForm
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
            this.tansferProductsDGV = new System.Windows.Forms.DataGridView();
            this.transferFromCB = new System.Windows.Forms.ComboBox();
            this.TransferfromLaber = new System.Windows.Forms.Label();
            this.TransferfromLabel = new System.Windows.Forms.Label();
            this.transferToCB = new System.Windows.Forms.ComboBox();
            this.productQuantityTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.filterByWHCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.refreshGVBtn = new System.Windows.Forms.Button();
            this.productIDGridTB = new System.Windows.Forms.TextBox();
            this.productIDGridBtn = new System.Windows.Forms.Button();
            this.productCodeTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.transferPartialBTN = new System.Windows.Forms.Button();
            this.TransferWhole = new System.Windows.Forms.Button();
            this.productQuantityToTransferTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tansferProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tansferProductsDGV
            // 
            this.tansferProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tansferProductsDGV.Location = new System.Drawing.Point(12, 237);
            this.tansferProductsDGV.Name = "tansferProductsDGV";
            this.tansferProductsDGV.Size = new System.Drawing.Size(1336, 370);
            this.tansferProductsDGV.TabIndex = 0;
            this.tansferProductsDGV.SelectionChanged += new System.EventHandler(this.tansferProductsDGV_SelectionChanged);
            // 
            // transferFromCB
            // 
            this.transferFromCB.FormattingEnabled = true;
            this.transferFromCB.Location = new System.Drawing.Point(219, 75);
            this.transferFromCB.Name = "transferFromCB";
            this.transferFromCB.Size = new System.Drawing.Size(121, 21);
            this.transferFromCB.TabIndex = 1;
            // 
            // TransferfromLaber
            // 
            this.TransferfromLaber.AutoSize = true;
            this.TransferfromLaber.Location = new System.Drawing.Point(219, 56);
            this.TransferfromLaber.Name = "TransferfromLaber";
            this.TransferfromLaber.Size = new System.Drawing.Size(69, 13);
            this.TransferfromLaber.TabIndex = 2;
            this.TransferfromLaber.Text = "Transfer from";
            // 
            // TransferfromLabel
            // 
            this.TransferfromLabel.AutoSize = true;
            this.TransferfromLabel.Location = new System.Drawing.Point(372, 56);
            this.TransferfromLabel.Name = "TransferfromLabel";
            this.TransferfromLabel.Size = new System.Drawing.Size(58, 13);
            this.TransferfromLabel.TabIndex = 4;
            this.TransferfromLabel.Text = "Transfer to";
            // 
            // transferToCB
            // 
            this.transferToCB.FormattingEnabled = true;
            this.transferToCB.Location = new System.Drawing.Point(372, 75);
            this.transferToCB.Name = "transferToCB";
            this.transferToCB.Size = new System.Drawing.Size(121, 21);
            this.transferToCB.TabIndex = 3;
            // 
            // productQuantityTB
            // 
            this.productQuantityTB.Location = new System.Drawing.Point(219, 33);
            this.productQuantityTB.Name = "productQuantityTB";
            this.productQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Quantity";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1044, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Product Id";
            // 
            // filterByWHCB
            // 
            this.filterByWHCB.FormattingEnabled = true;
            this.filterByWHCB.Location = new System.Drawing.Point(888, 198);
            this.filterByWHCB.Name = "filterByWHCB";
            this.filterByWHCB.Size = new System.Drawing.Size(121, 21);
            this.filterByWHCB.TabIndex = 41;
            this.filterByWHCB.SelectedIndexChanged += new System.EventHandler(this.filterByWHCB_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(885, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Filter By warhouse";
            // 
            // refreshGVBtn
            // 
            this.refreshGVBtn.Location = new System.Drawing.Point(1269, 198);
            this.refreshGVBtn.Name = "refreshGVBtn";
            this.refreshGVBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshGVBtn.TabIndex = 39;
            this.refreshGVBtn.Text = "Refresh";
            this.refreshGVBtn.UseVisualStyleBackColor = true;
            this.refreshGVBtn.Click += new System.EventHandler(this.refreshGVBtn_Click);
            // 
            // productIDGridTB
            // 
            this.productIDGridTB.Location = new System.Drawing.Point(1047, 198);
            this.productIDGridTB.Multiline = true;
            this.productIDGridTB.Name = "productIDGridTB";
            this.productIDGridTB.Size = new System.Drawing.Size(100, 23);
            this.productIDGridTB.TabIndex = 38;
            this.productIDGridTB.TextChanged += new System.EventHandler(this.productIDGridTB_TextChanged);
            // 
            // productIDGridBtn
            // 
            this.productIDGridBtn.Location = new System.Drawing.Point(1167, 198);
            this.productIDGridBtn.Name = "productIDGridBtn";
            this.productIDGridBtn.Size = new System.Drawing.Size(75, 23);
            this.productIDGridBtn.TabIndex = 37;
            this.productIDGridBtn.Text = "Find Product";
            this.productIDGridBtn.UseVisualStyleBackColor = true;
            this.productIDGridBtn.Click += new System.EventHandler(this.productIDGridBtn_Click);
            // 
            // productCodeTB
            // 
            this.productCodeTB.Location = new System.Drawing.Point(888, 137);
            this.productCodeTB.Name = "productCodeTB";
            this.productCodeTB.Size = new System.Drawing.Size(316, 20);
            this.productCodeTB.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(885, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1222, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Find Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transferPartialBTN
            // 
            this.transferPartialBTN.Location = new System.Drawing.Point(644, 72);
            this.transferPartialBTN.Name = "transferPartialBTN";
            this.transferPartialBTN.Size = new System.Drawing.Size(75, 23);
            this.transferPartialBTN.TabIndex = 46;
            this.transferPartialBTN.Text = "Transfer";
            this.transferPartialBTN.UseVisualStyleBackColor = true;
            this.transferPartialBTN.Click += new System.EventHandler(this.transferPartialBTN_Click);
            // 
            // TransferWhole
            // 
            this.TransferWhole.Location = new System.Drawing.Point(219, 116);
            this.TransferWhole.Name = "TransferWhole";
            this.TransferWhole.Size = new System.Drawing.Size(190, 23);
            this.TransferWhole.TabIndex = 47;
            this.TransferWhole.Text = "Transfer the whole quantity";
            this.TransferWhole.UseVisualStyleBackColor = true;
            this.TransferWhole.Click += new System.EventHandler(this.TransferWhole_Click);
            // 
            // productQuantityToTransferTB
            // 
            this.productQuantityToTransferTB.Location = new System.Drawing.Point(519, 76);
            this.productQuantityToTransferTB.Name = "productQuantityToTransferTB";
            this.productQuantityToTransferTB.Size = new System.Drawing.Size(100, 20);
            this.productQuantityToTransferTB.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Quantity to transfer";
            // 
            // TransferProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 619);
            this.Controls.Add(this.productQuantityToTransferTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransferWhole);
            this.Controls.Add(this.transferPartialBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productCodeTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.filterByWHCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.refreshGVBtn);
            this.Controls.Add(this.productIDGridTB);
            this.Controls.Add(this.productIDGridBtn);
            this.Controls.Add(this.productQuantityTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransferfromLabel);
            this.Controls.Add(this.transferToCB);
            this.Controls.Add(this.TransferfromLaber);
            this.Controls.Add(this.transferFromCB);
            this.Controls.Add(this.tansferProductsDGV);
            this.Name = "TransferProductsForm";
            this.Text = "TransferProductsForm";
            this.Load += new System.EventHandler(this.TransferProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tansferProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tansferProductsDGV;
        private System.Windows.Forms.ComboBox transferFromCB;
        private System.Windows.Forms.Label TransferfromLaber;
        private System.Windows.Forms.Label TransferfromLabel;
        private System.Windows.Forms.ComboBox transferToCB;
        private System.Windows.Forms.TextBox productQuantityTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox filterByWHCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button refreshGVBtn;
        private System.Windows.Forms.TextBox productIDGridTB;
        private System.Windows.Forms.Button productIDGridBtn;
        private System.Windows.Forms.TextBox productCodeTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button transferPartialBTN;
        private System.Windows.Forms.Button TransferWhole;
        private System.Windows.Forms.TextBox productQuantityToTransferTB;
        private System.Windows.Forms.Label label1;
    }
}