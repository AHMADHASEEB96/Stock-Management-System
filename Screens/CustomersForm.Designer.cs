namespace Stock_Management.Screens
{
    partial class CustomersForm
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
            this.updateCustomer = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.CustmerWebisteTB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerPhoneTB = new System.Windows.Forms.TextBox();
            this.CustomerWebsiteTB = new System.Windows.Forms.TextBox();
            this.CustomerNameTB = new System.Windows.Forms.TextBox();
            this.CustomerIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersCB = new System.Windows.Forms.ComboBox();
            this.CustomerEmailLabel = new System.Windows.Forms.Label();
            this.CustomerFaxLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerEmailTB = new System.Windows.Forms.TextBox();
            this.CustomerFaxTB = new System.Windows.Forms.TextBox();
            this.CustomerLandLineNumberTB = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateCustomer
            // 
            this.updateCustomer.Location = new System.Drawing.Point(570, 120);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(75, 23);
            this.updateCustomer.TabIndex = 23;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(570, 86);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(75, 23);
            this.AddCustomer.TabIndex = 22;
            this.AddCustomer.Text = "Add";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // CustmerWebisteTB
            // 
            this.CustmerWebisteTB.AutoSize = true;
            this.CustmerWebisteTB.Location = new System.Drawing.Point(111, 167);
            this.CustmerWebisteTB.Name = "CustmerWebisteTB";
            this.CustmerWebisteTB.Size = new System.Drawing.Size(46, 13);
            this.CustmerWebisteTB.TabIndex = 21;
            this.CustmerWebisteTB.Text = "Webiste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // CustomerPhoneTB
            // 
            this.CustomerPhoneTB.Location = new System.Drawing.Point(400, 86);
            this.CustomerPhoneTB.Name = "CustomerPhoneTB";
            this.CustomerPhoneTB.Size = new System.Drawing.Size(117, 20);
            this.CustomerPhoneTB.TabIndex = 17;
            // 
            // CustomerWebsiteTB
            // 
            this.CustomerWebsiteTB.Location = new System.Drawing.Point(114, 183);
            this.CustomerWebsiteTB.Name = "CustomerWebsiteTB";
            this.CustomerWebsiteTB.Size = new System.Drawing.Size(403, 20);
            this.CustomerWebsiteTB.TabIndex = 16;
            // 
            // CustomerNameTB
            // 
            this.CustomerNameTB.Location = new System.Drawing.Point(260, 86);
            this.CustomerNameTB.Name = "CustomerNameTB";
            this.CustomerNameTB.Size = new System.Drawing.Size(117, 20);
            this.CustomerNameTB.TabIndex = 15;
            // 
            // CustomerIDTB
            // 
            this.CustomerIDTB.Location = new System.Drawing.Point(114, 86);
            this.CustomerIDTB.Name = "CustomerIDTB";
            this.CustomerIDTB.ReadOnly = true;
            this.CustomerIDTB.Size = new System.Drawing.Size(117, 20);
            this.CustomerIDTB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customers";
            // 
            // CustomersCB
            // 
            this.CustomersCB.FormattingEnabled = true;
            this.CustomersCB.Location = new System.Drawing.Point(114, 46);
            this.CustomersCB.Name = "CustomersCB";
            this.CustomersCB.Size = new System.Drawing.Size(576, 21);
            this.CustomersCB.TabIndex = 12;
            this.CustomersCB.SelectedIndexChanged += new System.EventHandler(this.CustomersCB_SelectedIndexChanged);
            // 
            // CustomerEmailLabel
            // 
            this.CustomerEmailLabel.AutoSize = true;
            this.CustomerEmailLabel.Location = new System.Drawing.Point(397, 120);
            this.CustomerEmailLabel.Name = "CustomerEmailLabel";
            this.CustomerEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.CustomerEmailLabel.TabIndex = 29;
            this.CustomerEmailLabel.Text = "Email";
            // 
            // CustomerFaxLabel
            // 
            this.CustomerFaxLabel.AutoSize = true;
            this.CustomerFaxLabel.Location = new System.Drawing.Point(257, 120);
            this.CustomerFaxLabel.Name = "CustomerFaxLabel";
            this.CustomerFaxLabel.Size = new System.Drawing.Size(24, 13);
            this.CustomerFaxLabel.TabIndex = 28;
            this.CustomerFaxLabel.Text = "Fax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Land Line number";
            // 
            // CustomerEmailTB
            // 
            this.CustomerEmailTB.Location = new System.Drawing.Point(400, 136);
            this.CustomerEmailTB.Name = "CustomerEmailTB";
            this.CustomerEmailTB.Size = new System.Drawing.Size(117, 20);
            this.CustomerEmailTB.TabIndex = 26;
            // 
            // CustomerFaxTB
            // 
            this.CustomerFaxTB.Location = new System.Drawing.Point(260, 136);
            this.CustomerFaxTB.Name = "CustomerFaxTB";
            this.CustomerFaxTB.Size = new System.Drawing.Size(117, 20);
            this.CustomerFaxTB.TabIndex = 25;
            // 
            // CustomerLandLineNumberTB
            // 
            this.CustomerLandLineNumberTB.Location = new System.Drawing.Point(114, 136);
            this.CustomerLandLineNumberTB.Name = "CustomerLandLineNumberTB";
            this.CustomerLandLineNumberTB.Size = new System.Drawing.Size(117, 20);
            this.CustomerLandLineNumberTB.TabIndex = 24;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(615, 17);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 30;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.CustomerEmailLabel);
            this.Controls.Add(this.CustomerFaxLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerEmailTB);
            this.Controls.Add(this.CustomerFaxTB);
            this.Controls.Add(this.CustomerLandLineNumberTB);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.CustmerWebisteTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerPhoneTB);
            this.Controls.Add(this.CustomerWebsiteTB);
            this.Controls.Add(this.CustomerNameTB);
            this.Controls.Add(this.CustomerIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomersCB);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label CustmerWebisteTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerPhoneTB;
        private System.Windows.Forms.TextBox CustomerWebsiteTB;
        private System.Windows.Forms.TextBox CustomerNameTB;
        private System.Windows.Forms.TextBox CustomerIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomersCB;
        private System.Windows.Forms.Label CustomerEmailLabel;
        private System.Windows.Forms.Label CustomerFaxLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerEmailTB;
        private System.Windows.Forms.TextBox CustomerFaxTB;
        private System.Windows.Forms.TextBox CustomerLandLineNumberTB;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button button1;
    }
}