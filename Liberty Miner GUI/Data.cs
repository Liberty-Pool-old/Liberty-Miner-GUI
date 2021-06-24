using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace LibertyMinerGUI.Data
{

    public class Graph 
    {
        List<string> Timestamps;
        List<string> Hashes;
    }
    public class WalletData
    {
        public string Hashes;
        public string Pending;
        public string Paid;
    }
    public class WalletPaymentsData 
    {
        public List<String> Times;
        public List<String> XMRamount;
    }
    public class PoolData
    {
        public string PoolHashrate;
        public string WorldXMRHashrate;
        public string xmrPrice;
        public int TotalPayments;
        public int BlocksFound;
        public string TotalMinersPaid;
        public string TotalPoolHashrate;
    }
    public class ConfigData
    {
        public ConfigData(string wallet, string worker, int cpu, int coin, bool startup, bool battery)
        {
            Wallet = wallet;
            Worker = worker;
            Cpu = cpu;
            Coin = coin;
            RunOnStartUp = startup;
            PauseOnBattery = battery;
        }
        public string Wallet;
        public string Worker;
        public int Cpu;
        public int Coin;
        public bool RunOnStartUp;
        public bool PauseOnBattery;
    }
}
