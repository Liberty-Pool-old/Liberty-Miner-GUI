using System;
using System.IO;
using System.Linq;
using LP.Data;
using System.Diagnostics;
using LibertyMinerGUI.Properties;
using System.Net.NetworkInformation;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;

namespace LP
{
    public class LP_Functionality
    {
        #region Variables
        public static string PoolApiURL = "https://liberty-pool.com/api/pool/stats";
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
        #endregion
        static public Process RunMiner()
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = xmrigPath;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            //string output = p.StandardOutput.ReadToEnd();
            return p;
        }
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
            Console.WriteLine(w.amtPaid);
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
            dynamic p = pool.pool_statistics;
            Console.WriteLine(result.PoolHashrate);
            //
            dynamic xmrEur = JObject.Parse(DownloadString(PoolApiURL));
            dynamic p = pool.pool_statistics;
            //
            result.xmrPrice = p.miners;
            result.TotalPayments = p.totalPayments;
            result.BlocksFound = p.totalAltBlocksFound + p.totalBlocksFound;
            result.TotalMinersPaid = p.totalMinersPaid;
            string poolHashes = p.hashRate;
            result.PoolHashrate = ConvertRawHashToCorrespondentHash(poolHashes);
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
        static public string ConvertRawHashToCorrespondentHash(string Hashes)
        {
           // Console.WriteLine(Hashes);
            if (Hashes == null)
                return "No hashrates yet...";
            double hash = Math.Round(float.Parse(Hashes), 1);
            Console.WriteLine(hash);
            double numlength = Math.Floor(Math.Log10(hash) + 1);
            Console.WriteLine(numlength);
            string MinerHashrate = "";
            if (numlength >= 7)
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
        #endregion
    }
}
