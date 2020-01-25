using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsAndComboBoxes
{
    public partial class Form1 : Form
    {

        string[] itPrograms = { "Programming", "Security", "Networking"};
        string[] engineeringPrograms = { "Electrical", "Mechanical"};

        SortedList<string, string[]> programs;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            programs = new SortedList<string, string[]>
            {
                { "Information Technology", itPrograms },
                { "Engineering", engineeringPrograms },
            };

            // This combobox has DropDownStyle = DropDownList, user can only pick one of the available choices
            cbxDepartment.Items.AddRange(programs.Keys.ToArray());

            cbxDepartment.SelectedIndex = 0;   // Select the first choice

            // This combobox has DropDownStyle = DropDown, so user can enter their own text
            cbxHowDidYouHear.Items.Add("Another student");
            cbxHowDidYouHear.Items.Add("Another School");
            cbxHowDidYouHear.Items.Add("Internet Search");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Has user selected at least one degree? 

            List<string> errors = new List<string>();

            if (cbxDepartment.SelectedIndex == -1)
            {
                errors.Add("Select a semester");
            }

            if (lstDegrees.SelectedIndex == -1)
            {
                errors.Add("Select at least one degree");
            }
         
            // because user can type. whatever they type is considered to be index -1
            if (String.IsNullOrEmpty(cbxHowDidYouHear.Text))
            {
                errors.Add("Type or select how you heard about us");
            }

            if (errors.Count > 0)
            {
                MessageBox.Show(String.Join("\n", errors), "Error");
            }

            else
            {
                StringBuilder summaryBuilder = new StringBuilder();

                summaryBuilder.Append("Summary\n\n");
                summaryBuilder.Append("Department: ");
                summaryBuilder.Append(cbxDepartment.Text);
                summaryBuilder.Append("\n\n");

                summaryBuilder.Append("Programs: ");
                summaryBuilder.Append(lblDegreeCount.Text);
                summaryBuilder.Append("\n");


                foreach (object degree in lstDegrees.SelectedItems)
                {
                    summaryBuilder.Append(degree);
                    summaryBuilder.Append("\n");
                }

                summaryBuilder.Append("\n");

                string heard = cbxHowDidYouHear.Text;
                summaryBuilder.Append("You heard about us from: ");
                summaryBuilder.Append(heard);
                summaryBuilder.Append("\n");

                string summary = summaryBuilder.ToString();

                MessageBox.Show(summary, "Thank you!");

                this.Close();
            }
        }

        private void cbxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load semester choices for the selection
            lstDegrees.ClearSelected();  // fires the selection changed event
            // question: watch the number of degrees selection label without this line

            lstDegrees.Items.Clear();
            
            string semester = cbxDepartment.Text;

            if (semester != null)
            {
                string[] degrees = programs[semester];
                lstDegrees.Items.AddRange(degrees);
            }
        }

        private void lstDegrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDegreeCount.Text = $"{lstDegrees.SelectedItems.Count} selected" ;
        }
    }
}
