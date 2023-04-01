using Newtonsoft.Json.Linq;
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

namespace Infinity
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            LaunchBtn.ImageLocation = "https://cdn.discordapp.com/attachments/1087556246493732894/1091502182513254441/InfinityLaunchingB.png";
            await Task.Run(() => Infinity.Logic.Action.LaunchFortnite());
            LaunchBtn.ImageLocation = "https://cdn.discordapp.com/attachments/1087556246493732894/1091503628935778314/Screenshot_2023-03-26_212709.png";
            //await Infinity.Logic.Action.LaunchFortnite();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormClosed += Home_FormClosing;
            ProfileBtn.Text = Infinity.Logic.Global.DisplayName;
            string url = "http://infinityapi.nekuzi.cf:43614/infinity/launcher/api/get/friends/" + Infinity.Logic.Global.DisplayName;
            int count = 0;

            try
            {
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    JArray array = JArray.Parse(json);

                    count = array.Count;
                }

                //MessageBox.Show($"Number of friends: {count}", "Count Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Count Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FriendCount.Text = count.ToString();
        }

        private void Home_FormClosing(object? sender, FormClosedEventArgs e)
        {
            Application.Exit(); // patch
            //throw new NotImplementedException();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
