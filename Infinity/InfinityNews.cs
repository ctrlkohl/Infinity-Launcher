using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;

namespace Infinity
{
    public partial class InfinityNews : UserControl
    {
        private const string url = "http://infinityapi.nekuzi.cf:43614/launcher/v1/news"; // Api Endpoint to call
        public InfinityNews()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        private async void LoadData()
        {
            //string url = "http://example.com/data.json";
            //string json;
            //WebClient wc = new WebClient();
            //HttpClient client = new HttpClient();
        }

        private class Item
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
        }

        private async void InfinityNews_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);
                        foreach (var item in data)
                        {
                        // Create box
                        Panel box = new Panel();
                            box.Size = new System.Drawing.Size(550, 245);
                            box.Margin = new Padding(10);
                            box.BackColor = ColorTranslator.FromHtml("#202020"); // Set background color of the box
                            flowLayoutPanel1.Controls.Add(box);

                            // Create title
                            Label title = new Label();
                            title.Text = item.title;
                            title.TextAlign = ContentAlignment.MiddleCenter;
                            title.Dock = DockStyle.Top;
                            title.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
                            title.ForeColor = Color.White;
                            box.Controls.Add(title);

                            // Create image
                            PictureBox image = new PictureBox();
                            image.ImageLocation = item.image;
                            image.SizeMode = PictureBoxSizeMode.Zoom;
                            image.Dock = DockStyle.Fill;
                            box.Controls.Add(image);

                            // Create description
                            Label description = new Label();
                            description.Text = item.description;
                            description.Dock = DockStyle.Bottom;
                            description.AutoSize = false;
                            description.Font = new System.Drawing.Font("Segoe UI", 10);
                            description.Height = 70;
                            description.ForeColor = Color.White;
                            description.TextAlign = ContentAlignment.MiddleCenter;
                            box.Controls.Add(description);
                        }
                    }
                }
        }
    }
}
