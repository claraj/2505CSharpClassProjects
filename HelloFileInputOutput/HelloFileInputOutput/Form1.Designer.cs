namespace HelloFileInputOutput
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
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(182, 34);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(354, 26);
            this.txtNewToDo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter To do Item";
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Location = new System.Drawing.Point(461, 77);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(75, 36);
            this.btnAddTodo.TabIndex = 4;
            this.btnAddTodo.Text = "Add";
            this.btnAddTodo.UseVisualStyleBackColor = true;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // lstToDo
            // 
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.ItemHeight = 20;
            this.lstToDo.Location = new System.Drawing.Point(52, 135);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(484, 264);
            this.lstToDo.TabIndex = 5;
            this.lstToDo.SelectedIndexChanged += new System.EventHandler(this.lstToDo_SelectedIndexChanged);
            this.lstToDo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstToDo_DeleteKeyPressed);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select an item and press Delete to remove";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddTodo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstToDo);
            this.Controls.Add(this.btnAddTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewToDo);
            this.Name = "Form1";
            this.Text = "File Input and Output";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.ListBox lstToDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

