using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace APOD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void enableForm(Boolean enable)
        {
            btnGetForDate.Enabled = enable;
            btnGetToday.Enabled = enable;
            txtDate.Enabled = enable;
        }
    
        private void btnGetForDate_Click(object sender, EventArgs e)
        {
            clearForm();
            enableForm(false);

            try
            {
                DateTime date = DateTime.Parse(txtDate.Text);
                if (date > DateTime.Today)
                {
                    throw new FormatException("Date can't be in the future");
                }
                if (date < new DateTime(1995, 06, 16))
                {
                    throw new FormatException("Date can't be before June 16, 1995");
                }
                // service started Jun 16, 1995
                APODResponse apodResponse = APOD.fetchAPOD(out string error, date);
                loadResponseIntoForm(apodResponse, error);
                
                
            }
            catch (FormatException err)
            {

                MessageBox.Show(err.Message, "Invalid date");

            }

            enableForm(true);
        }


        private void clearForm()
        {
            
            // todo threading issue, not clearing correctly
            lblDate.Text = "";
            lblDescription.Text = "";
            lblTitle.Text = "";
            lblCredits.Text = "";  

            // image does not go away either 
            pictureBox1?.Image?.Dispose();


        }
        private void loadResponseIntoForm(APODResponse apodResponse, string error)
        {
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }

            if (apodResponse.media_type.Equals("image"))
            {
                lblCredits.Text = $"Credit: {apodResponse.copyright}";

                // Cpnvert date string into DateTime so it can be formatted 
                DateTime date = DateTime.Parse(apodResponse.date);

                lblDate.Text = $"{date:D}";  // Example formate "Saturday January 19,  2020"
                lblDescription.Text = apodResponse.explanation;
                pictureBox1.Image = Image.FromFile(apodResponse.fileSavePath);
                lblTitle.Text = apodResponse.title;
            }
            else
            {
                MessageBox.Show("Not an image, sorry.");
            }
        }

        private void btnGetToday_Click(object sender, EventArgs e)
        {
            clearForm();
            enableForm(false);
            APODResponse apodResponse = APOD.fetchAPOD(out string error);
            loadResponseIntoForm(apodResponse, error);
            enableForm(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            txtDate.Text = $"{today:d}";
        }

      
    }
}
