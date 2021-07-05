using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
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
        #region Bools
        // Update bools:
        // This is here to check whether the updates have finished or not:
        bool xmrig_Updated = false;
        bool xmrigUpdated()
        {
            return xmrig_Updated;
        }
        bool LP_Updated = false;
        bool LPUpdated()
        {
            return LP_Updated;
        }
        #endregion
        #region Check
        // Here we check whether we should update any component:
        private void Updater_Load(object sender, EventArgs e)
        {
            Check();
        }
        async void Check()
        {
            if (await LP_Functionality.InternetConnectionAvailableAsync())
            {
                if (!LP_Functionality.MinerExists() || settings.XMRIG_Download_Link != LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL))
                {
                    StatusTxt.Text = "Installing spooky things in your system...";
                    DownloadXmrig();
                    await TaskEx.WaitUntil(xmrigUpdated);
                }
                if (!File.Exists(resolutionExecpath))
                {
                    ExtractResolutionExec();
                }
                if (settings.LP_Version != LP_Functionality.DownloadString(LP_Functionality.LP_VersionURL))
                {
                    DownloadLP();
                    await TaskEx.WaitUntil(LPUpdated);
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
                YesBtn.Show();
                NoBtn.Show();
                RetryBtn.Show();
            }
        }
        void ExtractResolutionExec()
        {
            StatusTxt.Text = "Extracting resolution library...";
            File.WriteAllBytes(resolutionExecpath, Properties.Resources.GetScreenResolution);
        }
        #endregion
        #region LP Download
        private void DownloadLP()
        {
            StatusTxt.Text = "Updating LP GUI...";
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(LP_client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(LP_client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL)), updateZIPpath);
            });
            thread.Start();
        }
        void LP_client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
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
        void LP_client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                StatusTxt.Text = "Completed";
            });
            using (ZipArchive archive = ZipFile.OpenRead(updateZIPpath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    string path = Path.Combine(Application.StartupPath, entry.FullName);
                    if (File.Exists(path)) File.Delete(path);
                    entry.ExtractToFile(Path.Combine(Application.StartupPath, entry.FullName));
                }
            }
            // Save Update Settings
            settings.LP_Version = LP_Functionality.DownloadString(LP_Functionality.LP_VersionURL);
            settings.Save();
            LP_Updated = true;
            // Execute LP GUI
            try
            {
                Process.Start(Path.Combine(Application.StartupPath, "update.exe"));
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion
        #region XMRIG Download
        private void DownloadXmrig()
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(XMRIG_client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(XMRIG_client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL)), xmrigZIPpath);
            });
            thread.Start();
        }
        void XMRIG_client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
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
        void XMRIG_client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                StatusTxt.Text = "Completed";
            });
            using (ZipArchive archive = ZipFile.OpenRead(xmrigZIPpath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    string path = Path.Combine(Application.StartupPath, entry.FullName);
                    if (File.Exists(path)) File.Delete(path);
                    if (!entry.Name.Contains("config")) entry.ExtractToFile(Path.Combine(Application.StartupPath, entry.FullName));
                }
            }
            File.Delete(xmrigZIPpath);
            // Save Update Settings
            settings.XMRIG_Download_Link = LP_Functionality.DownloadString(LP_Functionality.xmrigDownloadURL);
            settings.Save();
            xmrig_Updated = true;
            // Extract

        }
        #endregion
        #region Buttons
        private async void YesBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(450);
            HideAllButtons();
            Close();
        }
        void HideAllButtons()
        {
            NoBtn.Hide();
            RetryBtn.Hide();
            YesBtn.Hide();
        }
        private async void RetryBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(450);
            HideAllButtons();
            StatusTxt.Text = "Retrying...";
            Check();
        }
        private async void NoBtn_Click(object sender, EventArgs e)
        {
            await Task.Delay(450);
            HideAllButtons();
            Application.Exit();
        }
        #endregion
        #region UI
        private void StatusTxt_Enter(object sender, EventArgs e)
        {
            ActiveControl = progressBar1;
        }
        #endregion
    }
}
