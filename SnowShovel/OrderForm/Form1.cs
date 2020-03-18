using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configur earliest and latest dates possible in DateTimePicker
            // Earliest is today, latest in 7 days time
            dteAppointmentDay.MinDate = DateTime.Today;
            dteAppointmentDay.MaxDate = DateTime.Today.AddDays(7);
        }

        private void btnAddSpecialRequests_Click(object sender, EventArgs e)
        {
            // Create new FormSpecialRequests form
            FormSpecialRequests frmSpecialRequests = new FormSpecialRequests();
            // Set the Tag to the current text in lblSpecialRequests
            frmSpecialRequests.Tag = lblSpecialRequests.Text;
            // Show the FormSpecialRequests form as a dialog
            DialogResult specialRequestsResults = frmSpecialRequests.ShowDialog();
       
            // This method won't continue until the user closes the special requests form
            if (specialRequestsResults == DialogResult.OK)
            {
                if (frmSpecialRequests.Tag is string specialRequests)
                {
                    lblSpecialRequests.Text = specialRequests;
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
