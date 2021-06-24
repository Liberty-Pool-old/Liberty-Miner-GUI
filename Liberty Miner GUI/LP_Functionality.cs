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

namespace LibertyMinerGUI
{
    public class LP_Functionality
    {
        #region Variables
        public static LP_Functionality LP = new LP_Functionality();
        public static string ContactApiURL = "https://e.widgetbot.io/channels/758798463428329532/785524459779915777/?preset=crate&amp;api=f2b47969-cca9-4fa9-af9c-1b46b929c144";
        public static string PoolApiURL = "https://liberty-pool.com/api/pool/stats";
        public static string XMRpriceApiURL = "https://min-api.cryptocompare.com/data/price?fsym=XMR&tsyms=BTC,USD,EUR";
        public static string XMRhashrateApiURL = "https://localmonero.co/blocks/api/get_stats";
        public static string WalletStatsApiUrl = "https://liberty-pool.com/api/miner/" + Settings.Default.Wallet + "/stats";
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
        //
        public bool running = false;
        public Process xmrig;
        public frmWallet frmwallet;
        public string xmrigOutput = "XMRIG is not running...";
        #endregion
        #region Get Data
        static public bool IsConnectedToInternet()
        {
            string host = "http://google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
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
        #region Data Requests
        public static string DownloadString(string address)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            Uri uri = new Uri(address);
            string reply = client.DownloadString(uri);
            return reply;
        }
        static public WalletData FetchWalletData(string walletAdress)
        {
            WalletData result = new WalletData();
            dynamic wallet = JObject.Parse(DownloadString(WalletStatsApiUrl));
            dynamic w = wallet;
            string wallethash = w.hash;
            result.Hashes = ConvertRawHashToCorrespondentHash(wallethash);
            result.Paid = w.amtPaid / Math.Pow(10, 12);
            result.Pending = w.amtDue / Math.Pow(10, 12);
            return result;
        }
        static public PoolData FetchPoolData()
        {
            PoolData result = new PoolData();
            dynamic pool = JObject.Parse(DownloadString(PoolApiURL));
            dynamic xmr = JObject.Parse(DownloadString(XMRpriceApiURL));
            dynamic WorldXMRHash = JObject.Parse(DownloadString(XMRhashrateApiURL));
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
        static public string ConvertRawGigaHashes(string Hashes)
        {
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
            // Console.WriteLine(Hashes);
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

        public static void RunMiner()
        {
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
            process.BeginOutputReadLine();
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
        static public void MakeConfig()
        {
            string config = Resources.config1;
            StringBuilder stringBuilder = new StringBuilder(config);
            Settings s = Settings.Default;
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
            MakeConfig();
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
        static public string RAM_Usage()
        {
            string currentProcessUsage = GetMemoryUsage(Path.GetFileNameWithoutExtension(Application.ExecutablePath));
            int i;
            if (int.TryParse(currentProcessUsage, out int n))
            {
                i = int.Parse(currentProcessUsage);
            }
            else
            {
                i = 0;
            }
            if (LP.running)
            {
                string xmrigProcessUsage = GetMemoryUsage("xmrig");
                if (int.TryParse(xmrigProcessUsage, out int d))
                {
                    i += int.Parse(currentProcessUsage);
                }
                else
                {
                    i += 0;
                }
            }
            string result = i + "%";
            return result;
        }
        static public string GetMemoryUsage(string procname) // KLUDGE but works
        {
            try
            {
                string fname = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location);
                ProcessStartInfo ps = new ProcessStartInfo("tasklist");
                ps.Arguments = "/fi \"IMAGENAME eq " + procname + ".*\" /FO CSV /NH";
                ps.RedirectStandardOutput = true;
                ps.CreateNoWindow = true;
                ps.UseShellExecute = false;
                var p = Process.Start(ps);
                if (p.WaitForExit(1000))
                {
                    var s = p.StandardOutput.ReadToEnd().Split('\"');
                    string t = s[9].Replace("\"", "").Replace("K", "");
                    string v = t.Split(',')[0];
                    Console.WriteLine(v);
                    return v;
                }
            }
            catch { }
            Console.WriteLine("Unable to get memory usage");
            return "Unable to get memory usage";
        }
    }

}
