using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodExamples
{
    public partial class Form1 : Form
    {
        readonly int MinTemp = 50;    // Global variables, available to all methods
        readonly int MaxTemp = 90;    // Convention is to use UppercaseCamelCase names

        bool ShownMinWarning = false;
        bool ShownMaxWarning = false;

        HousePlantInfo plantInfo = new HousePlantInfo();

        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);

            this.trkTemp.Minimum = MinTemp;
            this.trkTemp.Maximum = MaxTemp; 
        }

        private void HouseConditionsChanged(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southFacingWindowAvailable = chkSouthFacing.Checked;

            if (homeTemp == MinTemp && ShownMinWarning == false)
            {
                ShownMinWarning = true;
                MessageBox.Show(text: "Your home may be too cold for most houseplants", caption: "Information");
            }

            if (homeTemp == MaxTemp && ShownMaxWarning == false)
            {
                ShownMaxWarning = true;
                MessageBox.Show(text: "Your home may be too warm for most houseplants", caption: "Information");
            }

            // Call our method, use return value
            string suggestedPlant = plantInfo.GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestedPlant;
        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            // Use format string, the # symbol is replace by the number in tryTemp.Value
            // Pressing Alt + 0176 on your number pad types a ° symbol
            lblTemp.Text = trkTemp.Value.ToString("# °F");
        }

        private void lnkHousePlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                plantInfo.ShowWebPage();   // plantName is optional
            }
            else
            {
                plantInfo.ShowWebPage(lblSuggestion.Text);
            }
        }
    }
}
