using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Infinity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // make a variable for the email and password
            var email = EmailBox.Text;
            var password = PasswordBox.Text;

            var client = new HttpClient();
            var url = "http://infinityapi.nekuzi.cf:43614/infinity/launcher/api/login/" + email + "/" + password;

            var response = await client.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (responseContent == "Err:404")
            {
                MessageBox.Show("This account does not exist", "Infinity");
                return;
            }
            else if (responseContent == "Err:401")
            {
                MessageBox.Show("Email or Password is incorrect", "Infinity");
            }
            else
            {
                // Deserialize the response content into a JSON object
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jsonObject = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(responseContent, options);

                var displayName = jsonObject.GetProperty("displayName").GetString();
                var id = jsonObject.GetProperty("id").GetString();
                Infinity.Logic.Global.userId = id;
                //MessageBox.Show("Welcome, " + displayName);

                // Access the items property of the character object
                var AthenaCharacter = jsonObject.GetProperty("profile")
                                     .GetProperty("character")
                                     .GetProperty("items").GetString();

                var Vbucks = jsonObject.GetProperty("profile")
                                     .GetProperty("vbucks").GetInt32();

                string VbucksString = string.Format("{0:N0}", Vbucks);

                var parts = AthenaCharacter.Split(':');

                Infinity.Logic.Global.DisplayName = displayName;
                Infinity.Logic.Global.Password = password;
                if (parts.Length > 1)
                {
                    Infinity.Logic.Global.Character = parts[1];
                }
                else
                {
                    Infinity.Logic.Global.Character = "CID_001_Athena_Commando_F_Default";
                }

                Infinity.Logic.Global.Email = email;
                Infinity.Logic.Global.vbucks = VbucksString;

                var newCID = "";

                // get skin icon
                if (parts.Length > 1)
                {
                    newCID = parts[1];
                }
                else
                {
                    newCID = "CID_001_Athena_Commando_F_Default";
                }


                var client2 = new HttpClient();
                var url2 = "https://fortnite-api.com/v2/cosmetics/br/" + newCID;

                var response2 = await client2.GetAsync(url2);
                var responseContent2 = await response2.Content.ReadAsStringAsync();


                // Deserialize the response content into a JSON object
                var options2 = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jsonObject2 = System.Text.Json.JsonSerializer.Deserialize<JsonElement>(responseContent2, options2);

                var Icon = jsonObject2.GetProperty("data")
                                         .GetProperty("images")
                                         .GetProperty("smallIcon").GetString();

                Infinity.Logic.Global.CharacterIcon = Icon;


                if (RememberMe.Checked == true)
                {
                    // Get the directory where the executable is located
                    string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    // Construct the path of the JSON file
                    string jsonPath = Path.Combine(exeDirectory, "config.json");
                    // Create an anonymous object to store the email and password
                    var credentials = new { Email = Infinity.Logic.Global.Email, Password = Infinity.Logic.Global.Password, FNPath = "" };
                    // Serialize the object to JSON
                    string json = JsonConvert.SerializeObject(credentials);
                    // Write the JSON to the file
                    File.WriteAllText(jsonPath, json);
                    //MessageBox.Show("Configuration saved successfully.");
                }

                Infinity.Logic.DiscordRPC.Init();
                //Home home = new Home();
                AprilFoolMan home = new AprilFoolMan();
                home.Show();
                this.Hide();
            }
            // DEBUG:
            //Home home = new Home();
            //home.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the directory where the executable is located
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construct the path of the JSON file
            string jsonPath = Path.Combine(exeDirectory, "config.json");

            // Check if the JSON file exists
            if (!File.Exists(jsonPath))
            {
                return;
            }

            // Read the JSON from the file
            string json = File.ReadAllText(jsonPath);

            // Deserialize the JSON to an object
            var credentials = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);

            // Set the email and password inputs
            EmailBox.Text = credentials.Email;
            PasswordBox.Text = credentials.Password;
            Infinity.Logic.Global.FNPath = credentials.FNPath;

            if (EmailBox.Text != "")
            {
                Infinity.Logic.Global.IsPrevSaved = true;
            }
        }

        private void DiscordBtn_Click(object sender, EventArgs e)
        {
            // Set the URL you want to open in the browser
            string url = "https://discord.gg/infinitymp";
            // Create a ProcessStartInfo object with the URL as the argument
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            // Open the URL in the default browser
            Process.Start(psi);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Set the URL you want to open in the browser
            string url = "http://infinityapi.nekuzi.cf:43614/forgotpassword";
            // Create a ProcessStartInfo object with the URL as the argument
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            // Open the URL in the default browser
            Process.Start(psi);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Set the URL you want to open in the browser
            string url = "http://infinityapi.nekuzi.cf:43614/register";
            // Create a ProcessStartInfo object with the URL as the argument
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            // Open the URL in the default browser
            Process.Start(psi);
        }
    }
}