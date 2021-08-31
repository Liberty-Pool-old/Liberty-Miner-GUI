using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyMinerGUI
{
    public partial class Updater : Form
    {
        #region Variables
        Properties.Settings settings = new Properties.Settings();
        string xmrigZIPpath = Path.Combine(Application.StartupPath, "xmrig.zip");
        string updateZIPpath = Path.Combine(Application.StartupPath, "update.zip");
        string resolutionExecpath = Path.Combine(Application.StartupPath, "GetScreenResolution.exe");
        #endregion
        public Updater()
        {
            InitializeComponent();
        }
        #region Checking Bools
        // Update bools:
        // This is here to check whether the updates have finished or not:
        bool DownloadFinished()
        {
            return provisionalTargetPath == "";
        }
        int Decision = 0; // 0 is no, 1 is yes, 2 means nothing (retry)
        bool InterrogationFinished()
        {
            return !YesBtn.Visible;
        }
        #endregion
        #region Check 
        // Here we check whether if we should update any component:
        private void Updater_Load(object sender, EventArgs e)
        {
            Check();
        }
        CheckResult LP_CheckResult()
        {
            CheckResult result = new CheckResult();
            if (settings.LP_Version != LP_Functionality.DownloadString(LP_Functionality.LP_VersionURL))
            {
                result.ShouldUpdate = true;
                result.Message = "LP GUI v" + LP_Functionality.DownloadString(LP_Functionality.LP_VersionURL)
                        + " is available. Do you want to update this app?";
            }
            else
            {
                result.ShouldUpdate = false;
                result.Message = "Loading...";
            }
            return result;
        }
        CheckResult Xmrig_CheckResult()
        {
            CheckResult result = new CheckResult();
            if (!LP_Functionality.MinerExists())
            {
                result.ShouldUpdate = true;
                result.Message = "The XMRIG miner is missing and it's required to mine, do you want to download the latest version?";
            }
            else if (settings.XMRIG_Download_Link
                != LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL))
            {
                result.ShouldUpdate = true;
                result.Message = "There is a new version of the XMRIG miner, do you want to download it?";
            }
            else
            {
                result.ShouldUpdate = false;
                result.Message = "Loading...";
            }
            return result;
        }
        async void Check()
        {
            if (await LP_Functionality.InternetConnectionAvailableAsync())
            {
                CheckResult checkxmrig = Xmrig_CheckResult();
                CheckResult checkLP = LP_CheckResult();
                // Checks for the xmrig and if the version is older, or it's not present, it downloads it
                if (checkxmrig.ShouldUpdate)
                {
                    StatusTxt.Text = checkxmrig.Message;
                    ShowYesNoButtons();
                    await TaskEx.WaitUntil(InterrogationFinished);
                    if (Decision != 0)
                    {
                        DownloadXmrig();
                        await TaskEx.WaitUntil(DownloadFinished);
                    }
                }
                //Offline - Extracts the getscreenresolution
                if (!File.Exists(resolutionExecpath))
                {
                    ExtractResolutionExec();
                }
                //Online - LP GUI
                if (checkLP.ShouldUpdate)
                {
                    ShowYesNoButtons();
                    StatusTxt.Text = checkLP.Message;
                    await TaskEx.WaitUntil(InterrogationFinished);
                    if (Decision == 1)
                    {
                        DownloadLP();
                        await TaskEx.WaitUntil(DownloadFinished);
                    }
                }
                // Spooky UI stuff
                StatusTxt.Text = "Good, everything works...";
                progressBar1.Value = 100;
                await Task.Delay(500);
                //
                Close();
            }
            else
            {
                StatusTxt.Text = "No internet connection, do you want to proceed?";
                ShowAllButtons();
                await TaskEx.WaitUntil(InterrogationFinished);
                if (Decision == 0)
                {
                    Application.Exit();
                }
                else if (Decision == 1)
                {
                    Close();
                }
                else if (Decision == 2)
                {
                    StatusTxt.Text = "Retrying...";
                    Check();
                }
            }
        }
        void ExtractResolutionExec()
        {
            StatusTxt.Text = "Extracting resolution library...";
            File.WriteAllBytes(resolutionExecpath, Properties.Resources.GetScreenResolution);
        }
        #endregion
        #region Downloads
        private async void DownloadLP()
        {
            StatusTxt.Text = "Updating LP GUI...";
            // Downloading LP GUI
            Download(LP_Functionality.DownloadString(LP_Functionality.LP_DownloadURL), updateZIPpath);
            await TaskEx.WaitUntil(DownloadFinished);
            // Save Update Settings
            settings.LP_Version = LP_Functionality.DownloadString(LP_Functionality.LP_VersionURL);
            settings.Save();
            // Execute LP GUI
            try
            {
                Process.Start(Path.Combine(Application.StartupPath, "update.exe"));
                Application.Exit();
            }
            catch (Exception ex)
            {
                StatusTxt.Text = "Couldn't update the app...";
            }
        }
        private async void DownloadXmrig()
        {
            // UI
            StatusTxt.Text = "Installing spooky things in your system...";
            // Download func:
            Download(LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL), xmrigZIPpath);
            await TaskEx.WaitUntil(LP_Functionality.MinerExists);
            // Save Update Settings
            settings.XMRIG_Download_Link = LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL);
            settings.Save();
        }
        #endregion
        #region Buttons
        void HideAllButtons()
        {
            NoBtn.Visible = false;
            RetryBtn.Visible = false;
            YesBtn.Visible = false;
        }
        void ShowAllButtons()
        {
            NoBtn.Show();
            RetryBtn.Show();
            YesBtn.Show();
        }
        void ShowYesNoButtons()
        {
            NoBtn.Show();
            RetryBtn.Hide();
            YesBtn.Show();
        }
        private async void YesBtn_Click(object sender, EventArgs e)
        {
            // Waits to display the beautiful MaterialDesign animation
            await Task.Delay(450);
            //Decision making
            Decision = 1;
            HideAllButtons();
        }
        private async void RetryBtn_Click(object sender, EventArgs e)
        {
            // Waits to display the beautiful MaterialDesign animation
            await Task.Delay(450);
            //Decision making
            Decision = 2;
            HideAllButtons();
        }
        private async void NoBtn_Click(object sender, EventArgs e)
        {
            // Waits to display the beautiful MaterialDesign animation
            await Task.Delay(450);
            //Decision making
            Decision = 0;
            HideAllButtons();
        }
        #endregion
        #region UI
        private void StatusTxt_Enter(object sender, EventArgs e)
        {
            ActiveControl = progressBar1;
        }
        #endregion
        #region Download Functionality
        private void Download(string url, string targetPath)
        {
            //Setting the path for the unzip to extract
            provisionalTargetPath = targetPath;
            //Setting up the client to download said file
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(url), targetPath);
            });
            //Starting the client
            thread.Start();
        }
        string provisionalTargetPath;
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                StatusTxt.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //UI:
            this.BeginInvoke((MethodInvoker)delegate
            {
                StatusTxt.Text = "Completed";
            });
            //Extraction:
            using (ZipArchive archive = ZipFile.OpenRead(provisionalTargetPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName != "config.json")
                    {
                        string path = Path.Combine(Application.StartupPath, entry.FullName);
                        if (File.Exists(path)) File.Delete(path);
                        entry.ExtractToFile(Path.Combine(Application.StartupPath, entry.FullName));
                    }
                }
            }
            // Deletes the zip file to save memory on the client's computer
            File.Delete(provisionalTargetPath);
            // Sets it to empty so that it can be used as a bool to know whether the download has been finished
            provisionalTargetPath = "";
        }
        #endregion     
    }
    class CheckResult
    {
        public bool ShouldUpdate;
        public string Message;
    }
}
