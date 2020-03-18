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
    public partial class FormSpecialRequests : Form
    {

        private bool Saved = false;   // Has the user saved their changes?

        public FormSpecialRequests()
        {
            InitializeComponent();
        }

        private void FormSpecialRequests_Load(object sender, EventArgs e)
        {
            txtRequests.Text = Tag.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Store the user's special requests in this form's Tag property
            // The form that created this form, will be able to read the Tag property to access the data
            Tag = txtRequests.Text;
            // Set the Saved boolean, when the form is closed, we'll know the data is saved
            Saved = true;
            // Indicate the user successfully interacted with this form
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
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
            if (!Saved && userMadeChanges)
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
