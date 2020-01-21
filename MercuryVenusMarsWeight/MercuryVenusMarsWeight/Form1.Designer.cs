namespace MercuryVenusMarsWeight
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
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.txtVenusWeight = new System.Windows.Forms.TextBox();
            this.txtMercuryWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(98, 45);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(100, 22);
            this.txtEarthWeight.TabIndex = 0;
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.Location = new System.Drawing.Point(347, 133);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.ReadOnly = true;
            this.txtMarsWeight.Size = new System.Drawing.Size(100, 22);
            this.txtMarsWeight.TabIndex = 1;
            // 
            // txtVenusWeight
            // 
            this.txtVenusWeight.Location = new System.Drawing.Point(347, 89);
            this.txtVenusWeight.Name = "txtVenusWeight";
            this.txtVenusWeight.ReadOnly = true;
            this.txtVenusWeight.Size = new System.Drawing.Size(100, 22);
            this.txtVenusWeight.TabIndex = 2;
            // 
            // txtMercuryWeight
            // 
            this.txtMercuryWeight.Location = new System.Drawing.Point(347, 42);
            this.txtMercuryWeight.Name = "txtMercuryWeight";
            this.txtMercuryWeight.ReadOnly = true;
            this.txtMercuryWeight.Size = new System.Drawing.Size(100, 22);
            this.txtMercuryWeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Earth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mercury";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Venus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mars";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(68, 133);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 212);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMercuryWeight);
            this.Controls.Add(this.txtVenusWeight);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.txtEarthWeight);
            this.Name = "Form1";
            this.Text = "Weight on Other Planets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.TextBox txtMarsWeight;
        private System.Windows.Forms.TextBox txtVenusWeight;
        private System.Windows.Forms.TextBox txtMercuryWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
    }
}

