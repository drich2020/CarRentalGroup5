namespace CarRentalGroup5
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
            this.label1 = new System.Windows.Forms.Label();
            this.textowner = new System.Windows.Forms.TextBox();
            this.CB_carlist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_rentdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_returndate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 137);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textowner
            // 
            this.textowner.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textowner.Location = new System.Drawing.Point(113, 258);
            this.textowner.Name = "textowner";
            this.textowner.Size = new System.Drawing.Size(300, 40);
            this.textowner.TabIndex = 1;
            // 
            // CB_carlist
            // 
            this.CB_carlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_carlist.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_carlist.FormattingEnabled = true;
            this.CB_carlist.Items.AddRange(new object[] {
            "Honda Stream",
            "Toyota Wish",
            "Mazda Demio",
            "Toyota Crown",
            "Honda Accord",
            "Nissan Sylphy"});
            this.CB_carlist.Location = new System.Drawing.Point(677, 267);
            this.CB_carlist.Name = "CB_carlist";
            this.CB_carlist.Size = new System.Drawing.Size(240, 41);
            this.CB_carlist.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Name";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(677, 528);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(297, 40);
            this.textID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rent Date";
            // 
            // dt_rentdate
            // 
            this.dt_rentdate.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_rentdate.Location = new System.Drawing.Point(113, 528);
            this.dt_rentdate.Name = "dt_rentdate";
            this.dt_rentdate.Size = new System.Drawing.Size(506, 40);
            this.dt_rentdate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 639);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Return Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dt_returndate
            // 
            this.dt_returndate.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_returndate.Location = new System.Drawing.Point(113, 688);
            this.dt_returndate.Name = "dt_returndate";
            this.dt_returndate.Size = new System.Drawing.Size(506, 40);
            this.dt_returndate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cost";
            // 
            // textCost
            // 
            this.textCost.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCost.Location = new System.Drawing.Point(674, 386);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(300, 40);
            this.textCost.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri Light", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 767);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 107);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Calibri Light", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(113, 389);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(300, 40);
            this.txtCustomerName.TabIndex = 15;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 1003);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_returndate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_rentdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_carlist);
            this.Controls.Add(this.textowner);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textowner;
        private System.Windows.Forms.ComboBox CB_carlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_rentdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_returndate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustomerName;
    }
}

