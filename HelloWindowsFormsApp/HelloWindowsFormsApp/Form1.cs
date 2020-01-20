using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<String> sts = new List<string>();
            

            listBox1.Items.Add("SFDSDF");
            listBox1.Items.Add("DSFSDFSFSFSF");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Color c = cd.Color;

            Form1.ActiveForm.BackColor = c;


            int GPA = 4;
            Boolean studentHasMaxGPA;

            if (GPA == 4)
            {
                // Wow! What a great student
                studentHasMaxGPA = true;
            } else
            {
                studentHasMaxGPA = false;
            }


            if (studentHasMaxGPA)
            {

            }

        }
    }
}
