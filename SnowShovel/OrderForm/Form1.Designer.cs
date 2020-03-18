namespace OrderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddSpecialRequests = new System.Windows.Forms.Button();
            this.btnGetEstimate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dteAppointmentDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoCorner = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Requested";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estimated Price";
            // 
            // btnAddSpecialRequests
            // 
            this.btnAddSpecialRequests.Location = new System.Drawing.Point(444, 397);
            this.btnAddSpecialRequests.Name = "btnAddSpecialRequests";
            this.btnAddSpecialRequests.Size = new System.Drawing.Size(231, 41);
            this.btnAddSpecialRequests.TabIndex = 4;
            this.btnAddSpecialRequests.Text = "Add Special Requests";
            this.btnAddSpecialRequests.UseVisualStyleBackColor = true;
            this.btnAddSpecialRequests.Click += new System.EventHandler(this.btnAddSpecialRequests_Click);
            // 
            // btnGetEstimate
            // 
            this.btnGetEstimate.Location = new System.Drawing.Point(40, 476);
            this.btnGetEstimate.Name = "btnGetEstimate";
            this.btnGetEstimate.Size = new System.Drawing.Size(198, 38);
            this.btnGetEstimate.TabIndex = 5;
            this.btnGetEstimate.Text = "Get Estimate";
            this.btnGetEstimate.UseVisualStyleBackColor = true;
            this.btnGetEstimate.Click += new System.EventHandler(this.btnGetEstimate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(226, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(449, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(449, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(475, 485);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 26);
            this.txtPrice.TabIndex = 6;
            // 
            // dteAppointmentDay
            // 
            this.dteAppointmentDay.Location = new System.Drawing.Point(226, 119);
            this.dteAppointmentDay.Name = "dteAppointmentDay";
            this.dteAppointmentDay.Size = new System.Drawing.Size(449, 26);
            this.dteAppointmentDay.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSpecialRequests);
            this.groupBox1.Location = new System.Drawing.Point(373, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 166);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Requests";
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.AutoEllipsis = true;
            this.lblSpecialRequests.Location = new System.Drawing.Point(18, 45);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(253, 101);
            this.lblSpecialRequests.TabIndex = 2;
            this.lblSpecialRequests.Text = "No special requests entered";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoCorner);
            this.groupBox2.Controls.Add(this.rdoSingle);
            this.groupBox2.Location = new System.Drawing.Point(28, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 166);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Sidewalk";
            // 
            // rdoCorner
            // 
            this.rdoCorner.AutoSize = true;
            this.rdoCorner.Location = new System.Drawing.Point(27, 99);
            this.rdoCorner.Name = "rdoCorner";
            this.rdoCorner.Size = new System.Drawing.Size(82, 24);
            this.rdoCorner.TabIndex = 1;
            this.rdoCorner.Text = "Corner";
            this.rdoCorner.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(27, 45);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(78, 24);
            this.rdoSingle.TabIndex = 0;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dteAppointmentDay);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnGetEstimate);
            this.Controls.Add(this.btnAddSpecialRequests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Snow Shovel Estimate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddSpecialRequests;
        private System.Windows.Forms.Button btnGetEstimate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dteAppointmentDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoCorner;
        private System.Windows.Forms.RadioButton rdoSingle;
    }
}

