﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace APOD
{
    public partial class AstronomyPictureForm : Form
    {
        public AstronomyPictureForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtePictureDate.Value = DateTime.Today;
            // Set the range of valid dates 
            dtePictureDate.MinDate = new DateTime(1995, 6, 16);
            dtePictureDate.MaxDate = DateTime.Today;
            GetAPOD(DateTime.Today);
        }

        private void btnGetToday_Click(object sender, EventArgs e)
        {
            // Create a DateTime that represents today
            DateTime today = DateTime.Today;
            // Start a request for today's APOD picture
            GetAPOD(DateTime.Today);
        }

        private void btnGetForDate_Click(object sender, EventArgs e)
        {
            DateTime date = dtePictureDate.Value;
            // fetch Astronomy picture for this date 
            GetAPOD(date);
        }

        private void GetAPOD(DateTime date)
        {
            // Clear current image and text, and disable form 
            ClearForm();
            EnableForm(false);

            // If there is not a request in progress, start fetching photo for date 
            // Long-running tasks should be delegated to background workers, otherwise user interface
            // will freeze or be unresponsive while request is in progress
            if (apodBackgroundWorker.IsBusy == false)
            {
                apodBackgroundWorker.RunWorkerAsync(date);
            }
            else   // A request is already in progress, ask user to wait.
            {
                MessageBox.Show("Please wait for previous request to complete.");
            }
        }


        private void ClearForm()
        {
            // Clear all info about a previous picture. 
            lblDate.Text = "";
            lblDescription.Text = "";
            lblTitle.Text = "";
            lblCredits.Text = "";

            picAstronomyPicture.Image?.Dispose();    // Release the image file resource, if there is one
            picAstronomyPicture.Image = null;    // Clear current image
        }

        private void HandleResponse(APODResponse apodResponse, string error)
        {
            // Check if there was an error, show user error message if so
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }

            // Does the response represent an image? Some "photos" are videos, 
            // which we can't display in this app. 
            if (apodResponse.MediaType.Equals("image"))
            {
                // If the response is an image, call method to display
                // the data in the form controls 
                LoadImageResponseIntoForm(apodResponse);
            }
            else
            {
                MessageBox.Show($"The response for this date is not an image", "Sorry!");
            }
        }

        private void LoadImageResponseIntoForm(APODResponse apodResponse)
        {
            // Show title 
            lblTitle.Text = apodResponse.Title;

            // Format and show image credits
            lblCredits.Text = $"Image credit: {apodResponse.Copyright}";

            // Convert date string from response, which is in the form yyyy-mm-dd, 
            // into a DateTime, so it can be formatted and displayed 
            DateTime date = DateTime.Parse(apodResponse.Date);
            string formattedDate = $"{date:D}";  // Example format "Saturday January 19, 2020"
            lblDate.Text = formattedDate;

            // Show explanation text
            lblDescription.Text = apodResponse.Explanation;
       
            // Try to load image. Catch and handle any image file errors
            try
            {
                picAstronomyPicture.Image = Image.FromFile(apodResponse.FileSavePath);
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error loading image saved for {apodResponse}\n{e.Message}");
            }
        }

        private void EnableForm(Boolean enable)
        {
            // If the enable parameter is true, the Enabled property of Buttons and TextBox will be true
            // The progress bar visibility will be false. 
            // The user will be able to interact with the Button and TextBox controls, the progress bar will be hidden.

            // If the enable parameter is false, the Enabled property of Buttons and TextBox will be false
            // The progress bar visibility will be true. 
            // The user will not be able to interact with the Button and TextBox controls, the progress bar will be visible.

            btnGetForDate.Enabled = enable;
            btnGetToday.Enabled = enable;
            dtePictureDate.Enabled = enable;

            progressBar.Visible = !enable;   // The opposite of whether the buttons are enabled
        }
      

        private void apodBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // If the argument is a DateTime, convert it to a DateTime and store in variable named dt
            if (e.Argument is DateTime dt)  
            {
                APODResponse apodResponse = APOD.FetchAPOD(out string error, dt);  // Make the request!
                e.Result = (reponse: apodResponse, error);   // A tuple https://docs.microsoft.com/en-us/dotnet/csharp/tuples
                Debug.WriteLine(e.Result);
            }
            else
            {
                Debug.WriteLine("Background worker error - argument not a datetime" + e.Argument);
                throw new Exception("Incorrect Argument type, must be a DateTime");
            }
        }

        private void apodBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // If the background worker throws an error, e.Error will have a value
                MessageBox.Show($"Unexpected Error fetching data", "Error");
                Debug.WriteLine($"Background Worker error {e.Error}");
            }
            else
            {
                try
                {
                    // Read the result from the background worker 
                    var (response, error) = ((APODResponse, string)) e.Result;
                    // Update the user interface with the data returned. 
                    // This method also shows the user an error, if there is one
                    // These errors are generally things the user can fix, for example, no internet connection
                    HandleResponse(response, error);
                }
                catch (Exception err)
                {
                    // These are probably issues with the program that a user can't reasonable fix.
                    Debug.WriteLine($"Unexpected response from APOD request worker: {e.Result} causing error {err}");
                    MessageBox.Show($"Unexpected data returned from APOD request", "Error");
                }
            }

            EnableForm(true);   // In any case, enable the user interface 
        }
    }
}