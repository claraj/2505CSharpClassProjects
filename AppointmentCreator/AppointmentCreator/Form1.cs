using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentCreator
{
    public partial class Form1 : Form
    {

        /*
         Pricing structure:
         
            A single lot costs $20
            A corner lot costs $30

            Same-day service, add $5
             
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configure earliest and latest dates possible in Date
            // Earliest is today, latest in seven days time
            dteAppointmentDay.MinDate = DateTime.Today;
            dteAppointmentDay.MaxDate = DateTime.Today.AddDays(7);
        }


        private void btnAddSpecialRequests_Click(object sender, EventArgs e)
        {
            frmSpecialRequests frmSpecialRequests = new frmSpecialRequests();
            frmSpecialRequests.Tag = txtSpecialRequests.Text;
            DialogResult res = frmSpecialRequests.ShowDialog();

            if (res == DialogResult.OK)
            {
                if (frmSpecialRequests.Tag is string specialReq)
                {
                    txtSpecialRequests.Text = specialReq;
                }
            }
        }

        private void btnGetEstimate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            DateTime date = dteAppointmentDay.Value;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(address) || date == null)
            {
                MessageBox.Show("Fill in all fields", "Error");
                return;
            }

            double price = 0;

            // Which radio button was selected?
            if (rdoSingle.Checked)
            {
                price = 20;
            }
            else
            {
                price = 30;
            }

            // If the Date property of the DateTime is Today, add $5
            if (date.Date == DateTime.Today)
            {
                price += 5;
            }

            txtPrice.Text = $"{price:c}";
            
        }

    }
}
