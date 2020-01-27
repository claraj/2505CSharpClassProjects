namespace AppointmentCreator
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
            this.dteAppointmentDay = new System.Windows.Forms.DateTimePicker();
            this.btnAddSpecialRequests = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCorner = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSpecialRequests = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dteAppointmentDay
            // 
            this.dteAppointmentDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteAppointmentDay.Location = new System.Drawing.Point(185, 99);
            this.dteAppointmentDay.Name = "dteAppointmentDay";
            this.dteAppointmentDay.Size = new System.Drawing.Size(236, 22);
            this.dteAppointmentDay.TabIndex = 2;
            // 
            // btnAddSpecialRequests
            // 
            this.btnAddSpecialRequests.Location = new System.Drawing.Point(220, 283);
            this.btnAddSpecialRequests.Name = "btnAddSpecialRequests";
            this.btnAddSpecialRequests.Size = new System.Drawing.Size(201, 23);
            this.btnAddSpecialRequests.TabIndex = 4;
            this.btnAddSpecialRequests.Text = "Add Special Requests";
            this.btnAddSpecialRequests.UseVisualStyleBackColor = true;
            this.btnAddSpecialRequests.Click += new System.EventHandler(this.btnAddSpecialRequests_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCorner);
            this.groupBox1.Controls.Add(this.rdoSingle);
            this.groupBox1.Location = new System.Drawing.Point(36, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of sidewalk";
            // 
            // rdoCorner
            // 
            this.rdoCorner.AutoSize = true;
            this.rdoCorner.Location = new System.Drawing.Point(21, 61);
            this.rdoCorner.Name = "rdoCorner";
            this.rdoCorner.Size = new System.Drawing.Size(72, 21);
            this.rdoCorner.TabIndex = 1;
            this.rdoCorner.Tag = "Corner";
            this.rdoCorner.Text = "Corner";
            this.rdoCorner.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(21, 34);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(68, 21);
            this.rdoSingle.TabIndex = 0;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Tag = "Single";
            this.rdoSingle.Text = "Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 24);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 22);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Requested";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 62);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(293, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(36, 340);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(121, 23);
            this.btnEstimate.TabIndex = 5;
            this.btnEstimate.Text = "Get Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnGetEstimate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(321, 341);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Estimated Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSpecialRequests);
            this.groupBox2.Location = new System.Drawing.Point(221, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Special Requests";
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.AutoEllipsis = true;
            this.txtSpecialRequests.Location = new System.Drawing.Point(6, 18);
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.Size = new System.Drawing.Size(188, 89);
            this.txtSpecialRequests.TabIndex = 0;
            this.txtSpecialRequests.Text = "No special requests";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddSpecialRequests);
            this.Controls.Add(this.dteAppointmentDay);
            this.Name = "Form1";
            this.Text = "Snow Shovel Estimate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteAppointmentDay;
        private System.Windows.Forms.Button btnAddSpecialRequests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCorner;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtSpecialRequests;
    }
}

