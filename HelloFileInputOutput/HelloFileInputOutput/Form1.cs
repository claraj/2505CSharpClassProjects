using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloFileInputOutput
{
    public partial class Form1 : Form
    {

        private const string ToDoFileName = @"todo_items.txt";
        private const string SelectedIndexFileName = @"last_selected.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadToDoItems();
            LoadLastSelectedItem();
        }
  
        private void LoadToDoItems()
        {
            try
            {
                string[] lines = File.ReadAllLines(ToDoFileName);
                lstToDo.Items.Clear();
                lstToDo.Items.AddRange(lines);
            } 
           catch (Exception e)
            {
                // errors reading from file - developer should think about how to handle these
                // In this app, assume user has not created any todo items yet so there is no file.
                Debug.WriteLine("Error reading todo item file, " + e, "Error");
            }
        }

        private void LoadLastSelectedItem()
        {
            try
            {
                // expect this to be a single line with a number, representing the 
                // index of the item selected in the ListBox
                
                string text = File.ReadAllText(SelectedIndexFileName);
                text = text.Trim();  // remove any whitespace
                int selectedIndex = Int32.Parse(text);

                lstToDo.SelectedIndex = selectedIndex;

            }
            catch (Exception e) 
            {
                /* ignore - the user probably hasn't created any todo items yet
                 or the data in the file is not a number 
                 or the number is not a valid index for the ListBox.
                 
                In other apps, you may need to catch and handle these execptions, 
                and possibly take different actions depending on the exception.
                 */ 
                Debug.WriteLine("Error reading last selected item because:" + e);
            }   
        }

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            string text = txtNewToDo.Text;
            if (!String.IsNullOrEmpty(text))
            {
                lstToDo.Items.Add(text);
                SaveToDoItems();
                SaveCurrentSelection();
                txtNewToDo.Text = "";
            }
        }

        private void SaveToDoItems()
        {
            List<string> todoItems = new List<string>();

            foreach (string item in lstToDo.Items)
            {
                todoItems.Add(item);
            }

            string todoItemsText = String.Join(Environment.NewLine, todoItems);

            try
            {
                // Note this method overwrites any information in the file if it already exists
                // Look up the AppendAllText method if you want to add text to an existing file
                File.WriteAllText(ToDoFileName, todoItemsText);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving to do items", "Error");
                Debug.WriteLine("Error saving to do items because " + e);
            }
        }

        private void SaveCurrentSelection()
        {
            int currentSelection = lstToDo.SelectedIndex;
            try
            {
                File.WriteAllText(SelectedIndexFileName, currentSelection.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving selected item", "Error");
                Debug.WriteLine("Error saving selected item index because " + e);
            }
        }

        private void lstToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentSelection();
        }

        private void lstToDo_DeleteKeyPressed(object sender, KeyEventArgs e)
        {
            // If the user presses Delete or Backspace, delete the selected item
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                int selectedIndex = lstToDo.SelectedIndex;
                if (selectedIndex != -1)
                {
                    lstToDo.Items.RemoveAt(selectedIndex);
                    SaveCurrentSelection();
                    SaveToDoItems();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
