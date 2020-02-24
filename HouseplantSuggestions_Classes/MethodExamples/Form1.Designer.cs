namespace MethodExamples
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
            this.chkSouthFacing = new System.Windows.Forms.CheckBox();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lnkHousePlantInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthFacing
            // 
            this.chkSouthFacing.AutoSize = true;
            this.chkSouthFacing.Location = new System.Drawing.Point(28, 25);
            this.chkSouthFacing.Name = "chkSouthFacing";
            this.chkSouthFacing.Size = new System.Drawing.Size(261, 21);
            this.chkSouthFacing.TabIndex = 0;
            this.chkSouthFacing.Text = "Do you have a south-facing window?";
            this.chkSouthFacing.UseVisualStyleBackColor = true;
            this.chkSouthFacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(23, 101);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(327, 56);
            this.trkTemp.TabIndex = 2;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.trkTemp_Scroll);
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(25, 169);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(146, 17);
            this.lblSuggestion.TabIndex = 3;
            this.lblSuggestion.Text = "Plant suggestion here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "How warm is your home?";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(356, 101);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(42, 17);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Text = "50 °F";
            // 
            // lnkHousePlantInfo
            // 
            this.lnkHousePlantInfo.AutoSize = true;
            this.lnkHousePlantInfo.Location = new System.Drawing.Point(281, 200);
            this.lnkHousePlantInfo.Name = "lnkHousePlantInfo";
            this.lnkHousePlantInfo.Size = new System.Drawing.Size(132, 17);
            this.lnkHousePlantInfo.TabIndex = 6;
            this.lnkHousePlantInfo.TabStop = true;
            this.lnkHousePlantInfo.Text = "houseplant411.com";
            this.lnkHousePlantInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHousePlantInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(425, 226);
            this.Controls.Add(this.lnkHousePlantInfo);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.chkSouthFacing);
            this.Name = "Form1";
            this.Text = "Houseplant Suggestions";
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthFacing;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.LinkLabel lnkHousePlantInfo;
    }
}

