using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullTimePartTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void trkCredits_Scroll(object sender, EventArgs e)
        {
            int credits = trkCredits.Value;

            // Show TrackBar value in lblCredits for user feedback
            lblCredits.Text = trkCredits.Value.ToString();

            // Calculate status and display in lnlStatus
            if (credits >= 12)
            {
                lblStatus.Text = "Full time";
            }
            else if (credits >= 6)
            {
                lblStatus.Text = "Half time";
            }
            else if (credits >= 0)
            {
                lblStatus.Text = "Less than half time";
            }
        }
    }
}
