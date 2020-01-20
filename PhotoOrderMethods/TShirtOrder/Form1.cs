using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShirtOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
            cbxSize.Items.Add("Extra Large");

            cbxSize.SelectedIndex = 0;   // Select the first size
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtQuantity.Text, out int quantity) == false)
            {
                MessageBox.Show("Quantity must be a number", "Error");
                return;   
            }
            if (quantity < 1)   // Make sure it's positive too 
            {
                MessageBox.Show("Quantity must be positive", "Error");
                return;
            }

            string size = cbxSize.SelectedItem.ToString();
            double price;

            switch (size)
            {
                case "Small":
                    price = 0.20;
                    break;
                case "Medium":
                    price = 0.30;
                    break;
                case "Large":
                    price = 0.40;
                    break;
                default:
                    MessageBox.Show("Unknown size");
                    return;     //Stop processing this event            
            }

            double total = price * quantity;
            txtPrice.Text = total.ToString("c");  // Format as currency
         }
    }
}
