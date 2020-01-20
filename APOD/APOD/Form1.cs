using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace APOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            using(client)
            {
                var responseString = client.DownloadString("https://api.nasa.gov/planetary/apod?api_key=6RVB2VqVPHzfyI9TQ0d4XeQEiAopapJf3RmvapIk");
                label1.Text = responseString;
                APODResponse resp = JsonSerializer.Deserialize<APODResponse>(responseString);
                label1.Text = resp.explanation + " DATE " + resp.date; 
                var fileP = Path.Combine(Path.GetTempPath(), "apod.jpg");
                client.DownloadFile(resp.url, fileP);
                pictureBox1.Image = Image.FromFile(fileP);
                

            }


        }
    }
}
