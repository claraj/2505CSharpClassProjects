namespace ToDoList
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
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.clsToDo = new System.Windows.Forms.CheckedListBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(482, 29);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDo.TabIndex = 2;
            this.btnAddToDo.Text = "Add";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddTodoItem_Click);
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(15, 30);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(370, 22);
            this.txtNewToDo.TabIndex = 3;
            // 
            // clsToDo
            // 
            this.clsToDo.FormattingEnabled = true;
            this.clsToDo.Location = new System.Drawing.Point(15, 89);
            this.clsToDo.Name = "clsToDo";
            this.clsToDo.Size = new System.Drawing.Size(542, 140);
            this.clsToDo.TabIndex = 4;
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 16;
            this.lstDone.Location = new System.Drawing.Point(12, 324);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(545, 84);
            this.lstDone.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(243, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove checked items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "What do you need to do?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Things to do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Deleted items";
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(391, 30);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(81, 21);
            this.chkUrgent.TabIndex = 10;
            this.chkUrgent.Text = "Urgent?";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 420);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.clsToDo);
            this.Controls.Add(this.txtNewToDo);
            this.Controls.Add(this.btnAddToDo);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.CheckedListBox clsToDo;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUrgent;
    }
}

