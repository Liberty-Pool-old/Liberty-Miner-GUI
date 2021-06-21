using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LibertyMinerGUI.Properties;
using System.ComponentModel;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Runtime.InteropServices;

namespace LibertyPool
{

    public class LibertyPoolLibrary
    {
        /*#region Variable
        Settings settings = Settings.Default;
        //Files
        public string MiningConfig = Application.StartupPath + @"\config.json";
        public string MinerPath = Application.StartupPath + @"\xmrig.exe";
        public string WinRing0x64Path = Application.StartupPath + @"\WinRing0x64.sys";
        //Download sites
        public string DownloadMinerLink = "http://download.liberty-pool.com/LP-xmrig.exe";
        public string DownloadWinSysLink = "http://download.liberty-pool.com/WinRing0x64.sys";
        public string MinerVersionLink = "http://download.liberty-pool.com/xmrig-version.html";
        //
        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        //
        string STATS_MINER;
        string STATS_POOL;
        string API_POOL = "https://liberty-pool.com/api/pool/stats";
        //
        Process terminal = new Process();
        bool TERMINAL_SHOWN;
        bool TerminalStartedOnce = false;
        bool WalletAlreadyIn = false;
        //Initialization
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_RESTORE = 0;
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion
        public static string SendRequestToTerminal(string request)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(request);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            return cmd.StandardOutput.ReadToEnd();
        }
        #region Main Functionalities
        void DownloadMiner()
        {
            WebClient client = new WebClient();
            client.DownloadFile(DownloadMinerLink, MinerPath);
            client.DownloadFile(DownloadWinSysLink, WinRing0x64Path);
        }
        string GetWalletApi()
        {
            //https://liberty-pool.com:443/api/miner/address/stats/
            return "https://liberty-pool.com:443/api/miner/" + settings.Wallet + "/stats/";
        }
        public string GetDataFromWeb(string link)
        {

            WebClient webclient = new WebClient();
            return webclient.DownloadString(link);
        }
        string GetValueFromJson(string jsonData, string header, string subheader)
        {
            var details = JObject.Parse(jsonData);
            return details[header][subheader].ToString();
        }
        string GetValueFromJson(string jsonData, string header, string subheader, bool inTheMiddle)
        {
            var details = JObject.Parse(jsonData);
            return details[header][0][subheader].ToString();
        }
        string GetValueFromJson(string jsonData, string header)
        {
            var details = JObject.Parse(jsonData);
            try
            {
                return details[header].ToString();
            }
            catch (Exception ex)
            {
                return "No wallet found";
            }
        }
        public static bool IsRunning(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");
            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        void ChangeConfig(string header, string subheader, string value)
        {
            string json = File.ReadAllText(MiningConfig);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[header][0][subheader] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(MiningConfig, output);
        }
        void ChangeConfig(string header, string subheader, bool value)
        {
            string json = File.ReadAllText(MiningConfig);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[header][subheader] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(MiningConfig, output);
        }
        void ChangeConfig(string header, bool value)
        {
            string json = File.ReadAllText(MiningConfig);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[header] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(MiningConfig, output);
        }
        public void CloseProcess(string c)
        {
            Process[] myProcList = Process.GetProcessesByName(c);
            foreach (Process Target in myProcList)
            {
                try
                {
                    Target.Kill();
                }
                catch
                {
                    return;
                }
            }
        }
        void CloseProccesByCMD(string p)
        {
            //TASKKILL /F /IM telegram.exe
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C TASKKILL /F /IM " + p + ".exe";
            process.StartInfo = startInfo;
            process.Start();
        }
        void ExtractConfig()
        {
            File.WriteAllText(MiningConfig, Resources.config);
        }
        void StartMining()
        {
            CloseProccesByCMD("xmrig");
            System.Threading.Thread.Sleep(1000);
            //
            if (!File.Exists(MinerPath))
            {
                DownloadMiner();
            }
            //
            ProcessStartInfo startInfo = new ProcessStartInfo();
            TERMINAL_SHOWN = true;
            startInfo.FileName = MinerPath;
            terminal.StartInfo = startInfo;
            terminal.Start();
            //
            button2.Text = "Hide Miner";
            InitTimerMiner();
            TerminalStartedOnce = true;
            CloseMinerButton.Visible = true;
        }
        #endregion
    */
    }
}
