﻿namespace APOD
{
    partial class AstronomyPictureForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnGetToday = new System.Windows.Forms.Button();
            this.btnGetForDate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(12, 619);
            this.lblDescription.MaximumSize = new System.Drawing.Size(776, 400);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(776, 179);
            this.lblDescription.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(494, 15);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 2;
            // 
            // btnGetToday
            // 
            this.btnGetToday.Location = new System.Drawing.Point(15, 11);
            this.btnGetToday.Name = "btnGetToday";
            this.btnGetToday.Size = new System.Drawing.Size(193, 30);
            this.btnGetToday.TabIndex = 3;
            this.btnGetToday.Text = "Get Today\'s Picture";
            this.btnGetToday.UseVisualStyleBackColor = true;
            this.btnGetToday.Click += new System.EventHandler(this.btnGetToday_Click);
            // 
            // btnGetForDate
            // 
            this.btnGetForDate.Location = new System.Drawing.Point(616, 11);
            this.btnGetForDate.Name = "btnGetForDate";
            this.btnGetForDate.Size = new System.Drawing.Size(172, 30);
            this.btnGetForDate.TabIndex = 4;
            this.btnGetForDate.Text = "Get Picture for Date";
            this.btnGetForDate.UseVisualStyleBackColor = true;
            this.btnGetForDate.Click += new System.EventHandler(this.btnGetForDate_Click);
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(12, 554);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(196, 52);
            this.lblDate.TabIndex = 5;
            // 
            // lblCredits
            // 
            this.lblCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCredits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCredits.Location = new System.Drawing.Point(559, 554);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(229, 52);
            this.lblCredits.TabIndex = 6;
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 40);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(450, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(232, 264);
            this.progressBar.MarqueeAnimationSpeed = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(315, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // AstronomyPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(806, 807);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnGetForDate);
            this.Controls.Add(this.btnGetToday);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AstronomyPictureForm";
            this.Text = "Astronomy Picture of the Day";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnGetToday;
        private System.Windows.Forms.Button btnGetForDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

