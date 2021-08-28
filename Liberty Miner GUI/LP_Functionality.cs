using System;
using System.IO;
using System.Linq;
using LibertyMinerGUI.Data;
using System.Diagnostics;
using LibertyMinerGUI.Properties;
using System.Net.NetworkInformation;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Management;
using System.Reflection;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using Microsoft.Win32;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace LibertyMinerGUI
{
    public class LP_Functionality
    {
        #region Variables
        // Default settings:
        public const string LP_VERSION = "1.2";
        //
        public static string xmrigDownloadURL = "https://raw.githubusercontent.com/Liberty-Pool/Liberty-Miner-GUI/master/xmrig-download";
        public static string LP_DownloadURL = "https://raw.githubusercontent.com/Liberty-Pool/Liberty-Miner-GUI/master/lp-dwnld-link";
        public static string LP_VersionURL = "https://raw.githubusercontent.com/Liberty-Pool/Liberty-Miner-GUI/master/lp-version-link";
        // APIs &
        public static LP_Functionality LP = new LP_Functionality();
        public static string PoolApiURL = "https://liberty-pool.com/api/pool/stats";
        public static string PoolApiPaymentsURL = "https://liberty-pool.com/api/pool/payments?page=";
        public static string AnnouncementsApiURL = "https://raw.githubusercontent.com/Liberty-Pool/etc/master/Liberty%20Miner%20GUI/ancn.txt";
        public static string XMRpriceApiURL = "https://min-api.cryptocompare.com/data/price?fsym=XMR&tsyms=BTC,USD,EUR";
        public static string XMRhashrateApiURL = "https://localmonero.co/blocks/api/get_stats";
        public static string xmrigPath = Path.Combine(Application.StartupPath, "xmrig.exe");
        public static string configPath = Path.Combine(Application.StartupPath, "config.json");
        public static List<String> cpuPorts = new List<String>()
        {"mine.liberty-pool.com:3333",
         "mine.liberty-pool.com:5555",
         "mine.liberty-pool.com:7777",
         "mine.liberty-pool.com:9000"
        };
        public static List<String> coins = new List<String>()
        {String.Empty,
         String.Empty,
         "~rx/arq",
         "~cn/gpu",
         "~astrobwt",
         "~ethash",
         "~cn/rwz",
         "~cn-pico/trtl",
         "~cn/r",
         "~cn/half",
         "~kawpow",
         "~cn/gpu",
         "~cn/r",
         "~argon2/chukwav2",
         "~c29b",
         "~rx/wow",
         "~cn/gpu",
         "~cn-heavy/xhv",
         "~panthera",
         "~rx/0",
         "~c29v",
         "~c29s",
        };
        public static WalletData walletData;
        // LP's Singleton
        public Stopwatch xmrigWatch = new Stopwatch();
        public bool running = false;
        public Process xmrig;
        public frmWallet frmwallet;
        public Form1 form1;
        public string xmrigOutput = "XMRIG is not running...";
        #endregion
        #region Get Data
        #region Get Memory Data
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);
        static public float GetMinerMemoryUsageMB()
        {
            Process[] localByName = Process.GetProcessesByName("xmrig");
            long x = 0;
            float y = 0;
            foreach (Process p in localByName)
            {
                long memoryUse = (p.PagedMemorySize64);
                x = memoryUse;
                y = x / 100000;
                y = y / 10;
            }
            return y;
        }
        static public float GetLPGUIMemoryUsage()
        {
            long t = Process.GetCurrentProcess().PrivateMemorySize64;
            return (float)t / 1024;
        }
        static public float GetPCMemory()
        {
            long memKb;
            GetPhysicallyInstalledSystemMemory(out memKb);
            Console.WriteLine((memKb / 1024) + " MB of RAM installed.");
            return (float)memKb;
        }
        static public string TotalMemoryUsagePercentage()
        {
            float usage = GetLPGUIMemoryUsage() + GetMinerMemoryUsageMB();
            float y = (usage * 100) / GetPCMemory();
            return Math.Round(y, 2) + " %";
        }
        #endregion
        #region PC-Level & Low-Level
        static public async Task<bool> InternetConnectionAvailableAsync()
        {
            Ping myPing = new Ping();
            try
            {
                var pingReply = await myPing.SendPingAsync("google.com", 3000, new byte[32], new PingOptions(64, true));
                if (pingReply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        static public string GetCPUtemp()
        {
            Double temperature = 0;
            String instanceName = "";
            // Query the MSAcpi_ThermalZoneTemperature API
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");

            foreach (ManagementObject obj in searcher.Get())
            {
                temperature = Convert.ToDouble(obj["CurrentTemperature"].ToString());
                // Convert the value to celsius degrees
                temperature = (temperature - 2732) / 10.0;
                instanceName = obj["InstanceName"].ToString();
            }
            Console.WriteLine(temperature);
            return temperature.ToString() + " º";
        }
        public static bool isProcess(string name)
        {
            Process[] pname = Process.GetProcessesByName(name);
            if (pname.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool IsRunning(Process process)
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
        static public string GetResolution()
        {
            string ExecPath = Path.Combine(Application.StartupPath, "GetScreenResolution.exe");
            Process compiler = new Process();
            compiler.StartInfo.FileName = ExecPath;
            compiler.StartInfo.CreateNoWindow = true;
            compiler.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            compiler.StartInfo.UseShellExecute = false;
            compiler.StartInfo.RedirectStandardOutput = true;
            compiler.Start();
            return compiler.StandardOutput.ReadToEnd();
        }
        public static DateTime TimeStampToDateTime(string TimeStamp)
        {
            long l1 = (long)Convert.ToDouble(TimeStamp);
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(l1).ToUniversalTime();
        }
        public static DateTime JavaTimeStampToDateTime(string TimeStamp)
        {
            long l1 = (long)Convert.ToDouble(TimeStamp);
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(l1).ToUniversalTime();
        }
        static public bool IsResolutionRightForHighDPH()
        {
            if (int.Parse(GetResolution().Split('x')[0]) <= 1920 && int.Parse(GetResolution().Split('x')[0]) >= 1280)
            {
                if (int.Parse(GetResolution().Split('x')[0]) == 1920)
                {
                    if (int.Parse(GetResolution().Split('x')[1]) <= 1080)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (int.Parse(GetResolution().Split('x')[0]) == 1280)
                {
                    if (int.Parse(GetResolution().Split('x')[1]) >= 720)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        static public bool MinerExists()
        {
            string miner = LP_Functionality.xmrigPath;
            string winsys = Path.Combine(Application.StartupPath, "WinRing0x64.sys");
            if (File.Exists(miner) && File.Exists(winsys))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool isMinerOpen()
        {
            if (LP.running)
            {
                if (LP.xmrig != null)
                {
                    if (!LP.xmrig.HasExited)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else if (isProcess("xmrig"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public string WalletPaymentsAPI()
        {
            return "https://liberty-pool.com/api/miner/" + Settings.Default.Wallet + "/payments";
        }
        static public bool IsWalletValid(string address)
        {
            if (address.Length == 95)
            {
                if (address[0] == '4' || address[0] == '8'
                || Enumerable.Range(0, 9).Contains(address[1])
                || address[1] == 'A' || address[1] == 'B'
                )
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        #region API Data Fetch Requests
        public static List<WalletPayment> GetWalletPayments()
        {
            string apiresult = DownloadString(WalletPaymentsAPI());
            // If there's no payments:
            if(apiresult == "[]" || apiresult.Contains("amount")) 
            {
            List<WalletPayment> payments = new List<WalletPayment>();
                payments.Add(new WalletPayment());
                payments[0].Amount = "Nein";
                return payments;
            }
            //Adapting API to LP GUI
            StringBuilder stringBuilder = new StringBuilder(apiresult);
            stringBuilder.Replace("ts", "Time");
            stringBuilder.Replace("amount", "Amount");
            string json = stringBuilder.ToString();
            // Deserializing json data to WalletPayment
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<WalletPayment> paymentObjects = js.Deserialize<List<WalletPayment>>(json);
            //preparing the output...
            List<WalletPayment> result = new List<WalletPayment>();
            foreach (WalletPayment w in paymentObjects)
            {
                w.Time = TimeStampToDateTime(w.Time).ToString();
                w.Amount = (float.Parse(w.Amount) / Math.Pow(10, 12)).ToString() + " XMR";
                result.Add(w);
            }
            return result;
        }
        public static string GetNextPaymentDate()
        {
            string apiresult = DownloadString(PoolApiPaymentsURL);
            //Adapting API to LP GUI
            StringBuilder stringBuilder = new StringBuilder(apiresult);
            stringBuilder.Replace("ts", "Time");
            stringBuilder.Replace("amount", "Amount");
            string json = stringBuilder.ToString();
            // Deserializing json data to WalletPayment
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<WalletPayment> paymentObjects = js.Deserialize<List<WalletPayment>>(json);
            //preparing the output...
            string result = JavaTimeStampToDateTime(paymentObjects[0].Time).AddHours(24).ToString();
            return result;
        }
        public static void print(string message) 
        {
            MessageBox.Show(message);
        }
        public static string WalletStatsApiUrl()
        {
            return "https://liberty-pool.com/api/miner/" + Settings.Default.Wallet + "/stats";
        }
        public static string DownloadString(string address)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            Uri uri = new Uri(address);
            string reply = client.DownloadString(uri);
            return reply;
        }
        static async public void FetchWalletData(string walletAdress)
        {
            WalletData result = new WalletData();
            string apiresult;
            using (var client = new WebClient())
            {
                apiresult = await client.DownloadStringTaskAsync(WalletStatsApiUrl());
            }
            dynamic wallet = JObject.Parse(apiresult);
            dynamic w = wallet;
            string wallethash = w.hash;
            result.Hashes = ConvertRawHashToCorrespondentHash(wallethash);
            result.Paid = w.amtPaid / Math.Pow(10, 12);
            result.Pending = w.amtDue / Math.Pow(10, 12);
            walletData = result;
        }
        static public async Task<PoolData> FetchPoolDataAsync()
        {
            PoolData result = new PoolData();
            //
            string poolresult;
            using (var client = new WebClient())
            {
                poolresult = await client.DownloadStringTaskAsync(PoolApiURL);
            }
            dynamic pool = JObject.Parse(poolresult);
            //
            string xmrresult;
            using (var client = new WebClient())
            {
                xmrresult = await client.DownloadStringTaskAsync(XMRpriceApiURL);
            }
            dynamic xmr = JObject.Parse(xmrresult);
            //
            string WorldXMRresult;
            using (var client = new WebClient())
            {
                WorldXMRresult = await client.DownloadStringTaskAsync(XMRhashrateApiURL);
            }
            dynamic WorldXMRHash = JObject.Parse(WorldXMRresult);
            dynamic p = pool.pool_statistics;
            //
            result.xmrPrice = xmr.EUR + "€  " + xmr.USD + "$ ";
            result.TotalPayments = p.totalPayments;
            result.BlocksFound = p.totalAltBlocksFound + p.totalBlocksFound;
            result.TotalMinersPaid = p.totalMinersPaid;
            //
            string worldHash = WorldXMRHash.hashrate;
            result.WorldXMRHashrate = ConvertRawHashToCorrespondentHash(worldHash);
            string totalHashes = p.totalHashes;
            result.TotalPoolHashrate = ConvertRawGigaHashes(totalHashes);
            string poolHashes = p.hashRate;
            result.PoolHashrate = ConvertRawHashToCorrespondentHash(poolHashes);
            //
            return result;
        }
        static public ConfigData FetchConfigData()
        {
            Settings s = Settings.Default;
            ConfigData result = new ConfigData
                (s.Wallet,
                s.Worker,
                s.Cpu,
                s.Coin,
                s.RunOnStartup,
                s.PauseOnBattery
                );
            return result;
        }
        #endregion
        #region Maths
        static public string ConvertRawGigaHashes(string Hashes)
        {
            Hashes = Hashes.Split('.')[0];
            if (Hashes == null)
                return "No hashes yet...";
            double hash = Math.Round(float.Parse(Hashes), 1);
            double numlength = Math.Floor(Math.Log10(hash) + 1);
            hash = hash / 1000000000;
            string MinerHashrate = "Hashes: " + Math.Round(hash, 1) + " GHs";
            return MinerHashrate;
        }
        static public string ConvertRawHashToCorrespondentHash(string Hashes)
        {
            Hashes = Hashes.Split('.')[0];
            if (Hashes == null)
                return "No hashrates yet...";
            double hash = Math.Round(float.Parse(Hashes), 1);
            double numlength = Math.Floor(Math.Log10(hash) + 1);
            string MinerHashrate = "";
            if (numlength >= 10)
            {
                hash = hash / 1000000000;

                MinerHashrate = "Hashrate: " + Math.Round(hash, 1) + " GHS";
            }
            else if (numlength >= 7)
            {
                hash = hash / 1000000;

                MinerHashrate = "Hashrate: " + Math.Round(hash, 1) + " MHS";
            }
            else if (numlength == 6)
            {
                hash = hash / 1000;
                MinerHashrate = "Hashrate: " + Math.Round(hash, 1) + " KHS";
            }
            else if (numlength == 5)
            {
                hash = hash / 1000;
                MinerHashrate = "Hashrate: " + Math.Round(hash, 1) + " KHS";
            }
            else if (numlength == 4)
            {
                hash = hash / 1000;
                MinerHashrate = "Hashrate: " + Math.Round(hash, 1) + " KHS";
            }
            else if (numlength < 3)
            {
                MinerHashrate = "Hashrate: " + Math.Round(hash, 1) + " HS";
            }
            else
            {
                MinerHashrate = "No hashrates yet...";
            }
            return MinerHashrate;
        }
        #endregion
        #endregion
        #region PC Functionality
        public static void Print(RichTextBox box, string message)
        {
            if (box.Text == "")
            {
                box.Text += message;
            }
            else
            {
                box.Text += Environment.NewLine + message;
            }
        }
        public static void RunMiner()
        {
            // Check if miner/config exists
            ApplyConfig();
            if (!MinerExists())
            {
                Form1 form1 = new Form1();
                form1.Show();
                LP.form1.Invoke(LP.form1._Close);
            }
            // Start the child process.
            Process process = new Process();
            LP_Functionality.LP.xmrig = process;
            // set up output redirection
            process.StartInfo.FileName = LP_Functionality.xmrigPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(XMRigOutput_Event);
            process.Start();
            // Configures the LP Singleton
            LP.xmrigWatch.Start();
            LP.running = true;
            // Output
            process.BeginOutputReadLine();
        }
        public static void CloseProcess(string processn)
        {
            Process[] processes = Process.GetProcessesByName(processn);
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit();
                process.Dispose();
            }
        }
        static public void KillMiner()
        {
            if (LP.running)
            {
                if (LP.xmrig != null)
                {
                    if (!LP.xmrig.HasExited)
                    {
                        LP.xmrig.CancelOutputRead();
                        LP.xmrig.Kill();
                    }
                }
            }
            else if (isProcess("xmrig"))
            {
                CloseProcess("xmrig");
            }
            // Configures the LP Singleton
            LP.xmrigWatch.Reset();
            LP.running = false;
            LP.xmrigOutput = "XMRIG has exited...";
        }
        private static int lineCount = 0;
        private static StringBuilder output = new StringBuilder();
        private static void XMRigOutput_Event(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                lineCount++;
                output.Append("\n[" + lineCount + "]: " + e.Data);
            }
            LP.xmrigOutput = output.ToString();
            Console.WriteLine(output.ToString());
        }
        #region Config Settings
        static public void ApplyConfig()
        {
            Settings s = Settings.Default;
            if (File.Exists(configPath))
            {
                string config = File.ReadAllText(configPath);
                dynamic Result = JsonConvert.DeserializeObject(config);
                ChangeConfig("pools", "pass", s.Worker + coins[s.Coin], config);
                ChangeConfig("pools", "url", cpuPorts[s.Cpu], config);
                ChangeConfig("pools", "user", s.Wallet, config);
                //
                if (s.Coin == 3)
                {
                    ChangeConfig("pools", "tls", "true", config);
                }
                else
                {
                    ChangeConfig("pools", "tls", "false", config);
                }
            }
            else
            {
                //
                string config = Resources.config1;
                StringBuilder stringBuilder = new StringBuilder(config);
                stringBuilder.Replace("poolminingport", cpuPorts[s.Cpu]);
                stringBuilder.Replace("YOUR_WALLET_ADDRESS", s.Wallet);
                stringBuilder.Replace("WORKER_NAME_HERE", s.Worker + coins[s.Coin]);
                if (s.Coin == 3)
                {
                    stringBuilder.Replace("tlsconfiguration", "true");
                }
                else
                {
                    stringBuilder.Replace("tlsconfiguration", "false");
                }
                File.WriteAllText(configPath, stringBuilder.ToString());
            }
            if (s.RunOnStartup == true)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("LP Miner GUI", Application.ExecutablePath);
            }
            else
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("LP Miner GUI", false);
            }
        }
        static void ChangeConfig(string header, string subheader, string value, string config)
        {
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(config);
            jsonObj[header][0][subheader] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(configPath, output);
        }
        static public void SaveConfigData(ConfigData config)
        {
            Settings s = Settings.Default;
            s.Wallet = config.Wallet;
            s.Worker = config.Worker;
            s.Cpu = config.Cpu;
            s.Coin = config.Coin;
            s.PauseOnBattery = config.PauseOnBattery;
            s.RunOnStartup = config.RunOnStartUp;
            s.Save();
            //
            ApplyConfig();
        }
        #endregion
        #endregion
    }

}
