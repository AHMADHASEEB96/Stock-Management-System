namespace Stock_Management.Screens
{
    partial class ReportsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.expiredProductsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countText = new System.Windows.Forms.Label();
            this.validProductsBtn = new System.Windows.Forms.Button();
            this.periodTB = new System.Windows.Forms.MaskedTextBox();
            this.periodTypeCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Expiration = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.processDescription = new System.Windows.Forms.Label();
            this.filterByWHCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.totalPriceValueText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warehousrToCB = new System.Windows.Forms.ComboBox();
            this.warehousrFromCB = new System.Windows.Forms.ComboBox();
            this.transactionsBtn = new System.Windows.Forms.Button();
            this.fromTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.toTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.allProductsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1531, 294);
            this.dataGridView1.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Products those exprire before";
            // 
            // expiredProductsBtn
            // 
            this.expiredProductsBtn.Location = new System.Drawing.Point(205, 85);
            this.expiredProductsBtn.Name = "expiredProductsBtn";
            this.expiredProductsBtn.Size = new System.Drawing.Size(142, 23);
            this.expiredProductsBtn.TabIndex = 44;
            this.expiredProductsBtn.Text = "Expired Products";
            this.expiredProductsBtn.UseVisualStyleBackColor = true;
            this.expiredProductsBtn.Click += new System.EventHandler(this.expiredProductsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Count";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalPriceValueText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.processDescription);
            this.groupBox1.Controls.Add(this.countText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(205, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 145);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // countText
            // 
            this.countText.AutoSize = true;
            this.countText.Location = new System.Drawing.Point(50, 34);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(35, 13);
            this.countText.TabIndex = 46;
            this.countText.Text = "Count";
            // 
            // validProductsBtn
            // 
            this.validProductsBtn.Location = new System.Drawing.Point(205, 114);
            this.validProductsBtn.Name = "validProductsBtn";
            this.validProductsBtn.Size = new System.Drawing.Size(142, 23);
            this.validProductsBtn.TabIndex = 47;
            this.validProductsBtn.Text = "Valid Products";
            this.validProductsBtn.UseVisualStyleBackColor = true;
            this.validProductsBtn.Click += new System.EventHandler(this.validProductsBtn_Click);
            // 
            // periodTB
            // 
            this.periodTB.Location = new System.Drawing.Point(6, 38);
            this.periodTB.Name = "periodTB";
            this.periodTB.Size = new System.Drawing.Size(82, 20);
            this.periodTB.TabIndex = 87;
            this.periodTB.TextChanged += new System.EventHandler(this.periodTB_TextChanged);
            // 
            // periodTypeCB
            // 
            this.periodTypeCB.FormattingEnabled = true;
            this.periodTypeCB.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.periodTypeCB.Location = new System.Drawing.Point(6, 75);
            this.periodTypeCB.Name = "periodTypeCB";
            this.periodTypeCB.Size = new System.Drawing.Size(82, 21);
            this.periodTypeCB.TabIndex = 86;
            this.periodTypeCB.SelectedIndexChanged += new System.EventHandler(this.periodTypeCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Period Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Period";
            // 
            // Expiration
            // 
            this.Expiration.Location = new System.Drawing.Point(205, 12);
            this.Expiration.Name = "Expiration";
            this.Expiration.Size = new System.Drawing.Size(200, 162);
            this.Expiration.TabIndex = 88;
            this.Expiration.TabStop = false;
            this.Expiration.Text = "Expiration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.periodTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.periodTypeCB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(469, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 162);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stored For more than";
            // 
            // processDescription
            // 
            this.processDescription.AutoSize = true;
            this.processDescription.Location = new System.Drawing.Point(88, 34);
            this.processDescription.Name = "processDescription";
            this.processDescription.Size = new System.Drawing.Size(10, 13);
            this.processDescription.TabIndex = 47;
            this.processDescription.Text = " ";
            // 
            // filterByWHCB
            // 
            this.filterByWHCB.FormattingEnabled = true;
            this.filterByWHCB.Location = new System.Drawing.Point(1385, 334);
            this.filterByWHCB.Name = "filterByWHCB";
            this.filterByWHCB.Size = new System.Drawing.Size(121, 21);
            this.filterByWHCB.TabIndex = 91;
            this.filterByWHCB.SelectedIndexChanged += new System.EventHandler(this.filterByWHCB_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1382, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "Filter By warhouse";
            // 
            // totalPriceValueText
            // 
            this.totalPriceValueText.AutoSize = true;
            this.totalPriceValueText.Location = new System.Drawing.Point(88, 72);
            this.totalPriceValueText.Name = "totalPriceValueText";
            this.totalPriceValueText.Size = new System.Drawing.Size(13, 13);
            this.totalPriceValueText.TabIndex = 50;
            this.totalPriceValueText.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = " ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Total Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.toTimeDTP);
            this.groupBox3.Controls.Add(this.fromTimeDTP);
            this.groupBox3.Controls.Add(this.transactionsBtn);
            this.groupBox3.Controls.Add(this.warehousrFromCB);
            this.groupBox3.Controls.Add(this.warehousrToCB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(753, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 162);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warhouses Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "From Warehouse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "To Warehouse";
            // 
            // warehousrToCB
            // 
            this.warehousrToCB.FormattingEnabled = true;
            this.warehousrToCB.Location = new System.Drawing.Point(6, 75);
            this.warehousrToCB.Name = "warehousrToCB";
            this.warehousrToCB.Size = new System.Drawing.Size(88, 21);
            this.warehousrToCB.TabIndex = 92;
            // 
            // warehousrFromCB
            // 
            this.warehousrFromCB.FormattingEnabled = true;
            this.warehousrFromCB.Location = new System.Drawing.Point(6, 36);
            this.warehousrFromCB.Name = "warehousrFromCB";
            this.warehousrFromCB.Size = new System.Drawing.Size(88, 21);
            this.warehousrFromCB.TabIndex = 93;
            this.warehousrFromCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // transactionsBtn
            // 
            this.transactionsBtn.Location = new System.Drawing.Point(6, 112);
            this.transactionsBtn.Name = "transactionsBtn";
            this.transactionsBtn.Size = new System.Drawing.Size(88, 23);
            this.transactionsBtn.TabIndex = 92;
            this.transactionsBtn.Text = "Analayse";
            this.transactionsBtn.UseVisualStyleBackColor = true;
            this.transactionsBtn.Click += new System.EventHandler(this.transactionsBtn_Click);
            // 
            // fromTimeDTP
            // 
            this.fromTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromTimeDTP.Location = new System.Drawing.Point(117, 36);
            this.fromTimeDTP.Name = "fromTimeDTP";
            this.fromTimeDTP.Size = new System.Drawing.Size(100, 20);
            this.fromTimeDTP.TabIndex = 94;
            // 
            // toTimeDTP
            // 
            this.toTimeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toTimeDTP.Location = new System.Drawing.Point(117, 73);
            this.toTimeDTP.Name = "toTimeDTP";
            this.toTimeDTP.Size = new System.Drawing.Size(100, 20);
            this.toTimeDTP.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "To Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "From Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 98;
            this.button1.Text = "Exluding period";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allProductsBtn
            // 
            this.allProductsBtn.Location = new System.Drawing.Point(1385, 271);
            this.allProductsBtn.Name = "allProductsBtn";
            this.allProductsBtn.Size = new System.Drawing.Size(75, 23);
            this.allProductsBtn.TabIndex = 92;
            this.allProductsBtn.Text = "All Products";
            this.allProductsBtn.UseVisualStyleBackColor = true;
            this.allProductsBtn.Click += new System.EventHandler(this.allProductsBtn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 677);
            this.Controls.Add(this.allProductsBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.filterByWHCB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.validProductsBtn);
            this.Controls.Add(this.expiredProductsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Expiration);
            this.Name = "ReportsForm";
            this.Text = "Reports ";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button expiredProductsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label countText;
        private System.Windows.Forms.Button validProductsBtn;
        private System.Windows.Forms.MaskedTextBox periodTB;
        private System.Windows.Forms.ComboBox periodTypeCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Expiration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label processDescription;
        private System.Windows.Forms.ComboBox filterByWHCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label totalPriceValueText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox warehousrFromCB;
        private System.Windows.Forms.ComboBox warehousrToCB;
        private System.Windows.Forms.Button transactionsBtn;
        private System.Windows.Forms.DateTimePicker fromTimeDTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker toTimeDTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button allProductsBtn;
    }
}