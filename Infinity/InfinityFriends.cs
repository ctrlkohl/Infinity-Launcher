using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinity
{
    public partial class InfinityFriends : UserControl
    {
        [DllImport("user32.dll")]
        private static extern bool GetScrollInfo(IntPtr hWnd, int n, ref SCROLLINFO lpScrollInfo);

        [DllImport("user32.dll")]
        private static extern int SetScrollInfo(IntPtr hWnd, int n, [In] ref SCROLLINFO lpScrollInfo, bool bRedraw);

        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;
        private const int SIF_ALL = 0x17;
        private const int SIF_DISABLENOSCROLL = 0x8;

        private struct SCROLLINFO
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }

        private readonly string apiUrl = "http://infinityapi.nekuzi.cf:43614/infinity/launcher/api/get/friends/" + Infinity.Logic.Global.DisplayName; // Replace with your API endpoint URL
        private readonly HttpClient httpClient = new HttpClient();

        public InfinityFriends()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            // Create a custom vertical scrollbar control
            //VScrollBar customScrollBar = new VScrollBar();
            //customScrollBar.BackColor = Color.FromArgb(50, 50, 50); // set the background color
            //customScrollBar.ForeColor = Color.LightGray; // set the foreground color
            //customScrollBar.Width = 15; // set the width

            // Assign the custom scrollbar to the VerticalScroll property of the FlowLayoutPanel
            //flowLayoutPanel1.VerticalScroll = customScrollBar;

            // Subscribe to the Scroll event of the custom scrollbar to update the position of the FlowLayoutPanel
            //customScrollBar.Scroll += (sender, e) => {
            // flowLayoutPanel1.VerticalScroll.Value = customScrollBar.Value;
            //};

            // Attach the Scroll event handler
            //flowLayoutPanel1.VerticalScroll = vScrollBar1;
            flowLayoutPanel1.Scroll += FlowLayoutPanel1_Scroll;
        }

        private void FlowLayoutPanel1_Scroll(object? sender, ScrollEventArgs e)
        {

            //throw new NotImplementedException();
        }

        private async Task<List<string>> FetchNamesAsync()
        {
            List<string> names = new List<string>();

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // Throws exception if HTTP response is unsuccessful

                string responseContent = await response.Content.ReadAsStringAsync();
                names = JsonSerializer.Deserialize<List<string>>(responseContent);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error retrieving names from API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error parsing JSON response: {ex.Message}", "JSON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return names;
        }

        private async void InfinityFriends_Load(object sender, EventArgs e)
        {
            List<string> names = await FetchNamesAsync();

            foreach (string name in names)
            {
                Panel panel = new Panel();
                panel.BackColor = ColorTranslator.FromHtml("#202020");
                panel.Size = new Size(270, 50);
                panel.Margin = new Padding(0, 0, 0, 10); // Add bottom margin to separate boxes

                Label nameLabel = new Label();
                nameLabel.Text = name;
                nameLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                nameLabel.ForeColor = Color.White;
                nameLabel.AutoSize = true;
                nameLabel.Location = new Point(10, 10);

                panel.Controls.Add(nameLabel);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
