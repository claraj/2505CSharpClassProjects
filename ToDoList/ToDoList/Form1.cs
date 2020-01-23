using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAddTodoItem_Click(object sender, EventArgs e)
        {

            // Remove any spaces start and end of sstring
            string newItem = txtNewToDo.Text.Trim();

            if (!String.IsNullOrWhiteSpace(newItem))
            {
                // Use Add to add new item to end of Items collection
                clsToDo.Items.Add(newItem);
                txtNewToDo.Text = "";
            }
            // No else, just ignore empty input.
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            // Make new list
            List<string> doneItems = new List<string>();

            // Copy all checked items to new List 
            foreach (string item in clsToDo.CheckedItems)
            {
                doneItems.Add(item);
            }

            // For each string in doneItems list, remove from clsToDo.Items
            // Add to lstDone.Items
            foreach (string item in doneItems)
            {
                clsToDo.Items.Remove(item);  // Remove by value
                lstDone.Items.Add(item);     
            }
        }
    }
}
