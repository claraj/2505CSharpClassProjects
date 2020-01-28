using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentCreator
{
    public partial class frmSpecialRequests : Form
    {
        private bool saved = false;   // Has the user saved their changes?

        public frmSpecialRequests()
        {
            InitializeComponent();
        }

        private void frmSpecialRequests_Load(object sender, EventArgs e)
        {
            if (Tag is string specialRequests)
            {
                txtRequests.Text = specialRequests;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Store the user's special requests in this form's Tag property
            // The form that created this form will be able to access the data
            Tag = txtRequests.Text;
            saved = true;
            DialogResult = DialogResult.OK;  
            Close();        // Initiate Form close process, to return control to form that opened this one
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();  // Initiate form close process
        }

        private void frmSpecialRequests_Close(object sender, FormClosingEventArgs e)
        {
            // Intercepts form close events. If changes are not saved,
            // ask use if they are sure - that they want to discard their changes
            // if the user cancels closing the form, then prevent the form closing.

            bool userMadeChanges = Tag.ToString() != txtRequests.Text;

            // If not saved, and user has made changes, confirm they do
            // want to close this window and lose their changes
            if (!saved && userMadeChanges)
            {
                DialogResult closeResult = MessageBox.Show("Your changes are not saved, close anyway?", 
                    "Unsaved Changes", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);
                
                if (closeResult == DialogResult.No)
                {
                    e.Cancel = true;  // Prevent form closing
                }
            }

            // If changes are saved, or user has not made changes, 
            // let close event proceed to close the form
        }
    }
}
