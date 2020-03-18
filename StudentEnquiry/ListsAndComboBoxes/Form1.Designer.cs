namespace ListsAndComboBoxes
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
            this.lstDegrees = new System.Windows.Forms.ListBox();
            this.cbxHowDidYouHear = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.lblDegreeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDegrees
            // 
            this.lstDegrees.FormattingEnabled = true;
            this.lstDegrees.ItemHeight = 20;
            this.lstDegrees.Location = new System.Drawing.Point(47, 170);
            this.lstDegrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstDegrees.Name = "lstDegrees";
            this.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDegrees.Size = new System.Drawing.Size(412, 124);
            this.lstDegrees.Sorted = true;
            this.lstDegrees.TabIndex = 1;
            this.lstDegrees.SelectedIndexChanged += new System.EventHandler(this.lstDegrees_SelectedIndexChanged);
            // 
            // cbxHowDidYouHear
            // 
            this.cbxHowDidYouHear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxHowDidYouHear.FormattingEnabled = true;
            this.cbxHowDidYouHear.Location = new System.Drawing.Point(47, 372);
            this.cbxHowDidYouHear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxHowDidYouHear.Name = "cbxHowDidYouHear";
            this.cbxHowDidYouHear.Size = new System.Drawing.Size(412, 28);
            this.cbxHowDidYouHear.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(199, 451);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 29);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "How did you hear about us?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "What degree programs are you interested in?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Which department are you interested in?";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(47, 55);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(412, 28);
            this.cbxDepartment.TabIndex = 0;
            this.cbxDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxDepartment_SelectedIndexChanged);
            // 
            // lblDegreeCount
            // 
            this.lblDegreeCount.AutoSize = true;
            this.lblDegreeCount.Location = new System.Drawing.Point(378, 299);
            this.lblDegreeCount.Name = "lblDegreeCount";
            this.lblDegreeCount.Size = new System.Drawing.Size(82, 20);
            this.lblDegreeCount.TabIndex = 3;
            this.lblDegreeCount.Text = "0 selected";
            this.lblDegreeCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 539);
            this.Controls.Add(this.lblDegreeCount);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxHowDidYouHear);
            this.Controls.Add(this.lstDegrees);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Student Enquiry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDegrees;
        private System.Windows.Forms.ComboBox cbxHowDidYouHear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Label lblDegreeCount;
    }
}

