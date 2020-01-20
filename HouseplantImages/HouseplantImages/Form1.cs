using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseplantImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://picsum.photos/id/152/600/500.jpg";
           
            using (WebClient client = new WebClient())
            {
                string filename = Path.GetTempPath().ToString() + "background.jpg";
                client.DownloadFile(new Uri(url), filename);
                this.BackgroundImage = Image.FromFile(filename);
            }
        }
    }
}


