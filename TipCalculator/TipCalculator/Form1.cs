using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidatePositiveDouble(textBox5, out double n, out string er);
            ///  ValidatePositiveDouble(textBox2, out double n2, out string er2);
            // ValidatePositiveDouble(textBox3, out double n3, out string er3);
            // ValidatePositiveDouble(textBox4, out double n4, out string er4);
            MessageBox.Show("sdsdf" + Math.Ceiling(10.4));

        }

        private bool ValidatePositiveDouble(TextBox textBox, out double number, out string errorMessage)
        {
            number = 0;
            errorMessage = null;

            try
            {
                number = Double.Parse(textBox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("SDFSDFSDF");
                textBox.Focus();
                return false;
            }
        }
    }
}
