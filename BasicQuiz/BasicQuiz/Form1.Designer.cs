namespace BasicQuiz
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
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(71, 105);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(140, 23);
            this.btnCheckAnswer.TabIndex = 0;
            this.btnCheckAnswer.Text = "Check answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(12, 12);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(255, 22);
            this.txtQuestion.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoFalse);
            this.panel1.Controls.Add(this.rdoTrue);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 59);
            this.panel1.TabIndex = 2;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(14, 30);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(63, 21);
            this.rdoFalse.TabIndex = 1;
            this.rdoFalse.Text = "False";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(14, 3);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(59, 21);
            this.rdoTrue.TabIndex = 0;
            this.rdoTrue.Text = "True";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(107, 160);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 17);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 207);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Name = "Form1";
            this.Text = "Tech Quiz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.Label lblScore;
    }
}

