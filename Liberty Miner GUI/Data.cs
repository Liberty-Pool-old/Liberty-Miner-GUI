using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Data
{

    public class WalletData
    {
        public string Hashes;
        public string Pending;
        public string Paid;
    }
    public class WalletPaymentsData 
    {

    }
    public class PoolData
    {
        public string PoolHashrate;
        //public string WorldXMRHashrate;
        public string xmrPrice;
        public int TotalPayments;
        public int BlocksFound;
        public string TotalMinersPaid;
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
