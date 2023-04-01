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
using static Infinity.Settings;

namespace Infinity
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public class Config
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string FNPath { get; set; }
        }

        private void FindFolderBtn_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the initial directory to the user's My Documents folder
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;

                // Show the folder browser dialog and capture the result
                DialogResult result = folderBrowserDialog.ShowDialog();

                // If the user clicked OK, display the selected folder in a message box
                if (result == DialogResult.OK)
                {
                    Infinity.Logic.Global.FNPath = folderBrowserDialog.SelectedPath;
                    FolderPathText.Text = Infinity.Logic.Global.FNPath;

                    // Get the directory where the executable is located
                    string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    // Construct the path of the JSON file
                    string jsonPath = Path.Combine(exeDirectory, "config.json");

                    // Create an anonymous object to store the email and password
                    var credentials = new { FNPath = folderBrowserDialog.SelectedPath };

                    // Check if the config file already exists
                    if (File.Exists(jsonPath))
                    {
                        // Read the existing JSON data from the file
                        string existingJson = File.ReadAllText(jsonPath);
                        // Deserialize the JSON into an anonymous object
                        Config config;
                        config = JsonConvert.DeserializeObject<Config>(existingJson);

                        // Update the FNPath property of the existing credentials
                        config.FNPath = folderBrowserDialog.SelectedPath;

                        // Serialize the updated object to JSON
                        string updatedJson = JsonConvert.SerializeObject(config);
                        // Write the JSON to the file
                        File.WriteAllText(jsonPath, updatedJson);
                    }
                    else
                    {
                        // Serialize the object to JSON
                        string json = JsonConvert.SerializeObject(credentials);
                        // Write the JSON to the file
                        File.WriteAllText(jsonPath, json);
                    }

                    MessageBox.Show("successfully saved!");
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Infinity.Logic.Global.FNPath != "")
            {
                FolderPathText.Text = Infinity.Logic.Global.FNPath;
            }

            UserNameText.Text = Infinity.Logic.Global.DisplayName;
            UserId.Text = Infinity.Logic.Global.userId;
            VersionCode.Text = Infinity.Logic.Global.versionId;

            if (Infinity.Logic.Global.bUseLauncherConsole == true)
            {
                UseLauncherConsoleCheck.Checked = true;
            }
        }

        private void FNConsoleStateChangeHook(object sender, EventArgs e)
        {
            if (UseLauncherConsoleCheck.Checked == true)
            {
                Infinity.Logic.Global.bUseLauncherConsole = true;
                //MessageBox.Show("Launcher Console Enabled", "DEBUG");
            }
            else
            {
                Infinity.Logic.Global.bUseLauncherConsole = false;
                //MessageBox.Show("Launcher Console Disabled", "DEBUG");
            }
        }
    }
}
