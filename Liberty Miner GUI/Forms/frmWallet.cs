using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibertyMinerGUI;
using LibertyMinerGUI.Data;

namespace LibertyMinerGUI
{
    public partial class frmWallet : Form
    {
        string WalletAddress = Properties.Settings.Default.Wallet;
        public frmWallet()
        {
            InitializeComponent();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            OpenPanel(Stats_Panel);
            LP_Functionality.LP.frmwallet = this;
            LoadData();
            InitTimer();
        }
        #region Data Loading
        void LoadData()
        {
            CopyWalletButton.Text = "Copy:" + WalletAddress;
            if (Stats_Panel.Visible) LoadStats();
            if (ConsolePanel.Visible) LoadConsole();
            //
            if (LP_Functionality.LP.running) RunCloseButton.Image = Properties.Resources.stop;

        }
        public void LoadConsole()
        {
            XmrigOutput.Text = LP_Functionality.LP.xmrigOutput;
            XmrigOutput.SelectionStart = XmrigOutput.Text.Length + 1;
            XmrigOutput.ScrollToCaret();
        }
        void LoadStats()
        {
            WalletData walletData = LP_Functionality.FetchWalletData(WalletAddress);
            HashLbl.Text = walletData.Hashes;
            PaidLbl.Text = walletData.Paid;
            PendingLbl.Text = walletData.Pending;
            RAMlbl.Text = LP_Functionality.RAM_Usage();
        }
        #endregion
        void OpenPanel(Panel panel)
        {
            List<Panel> panels = new List<Panel>() { ConsolePanel, Stats_Panel, PaymentsPanel, GraphPanel };
            foreach (Panel p in panels)
            {
                if (p.Equals(panel))
                {
                    p.Visible = true;
                }
                else
                {
                    p.Visible = false;
                }
            }
        }
        async void RunCloseMiner()
        {
            if (LP_Functionality.LP.running)
            {
                if (LP_Functionality.LP.xmrig != null)
                {
                    if (!LP_Functionality.LP.xmrig.HasExited)
                    {
                        LP_Functionality.LP.xmrig.Kill();
                    }
                }
                LP_Functionality.LP.running = false;
            }
            else
            {
                await Task.Run(() => LP_Functionality.RunMiner());
                //
                ConsolePanel.Visible = true;
                Stats_Panel.Visible = false;
                LP_Functionality.LP.running = true;
            }
        }

        #region BACKGROUND WORKER
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Buttons
        private void CopyWalletButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Settings.Default.Wallet);
        }
        private void RunClose_Click(object sender, EventArgs e)
        {
            Image image1 = Properties.Resources.stop;
            Image image2 = Properties.Resources.play;
            switch (LP_Functionality.LP.running)
            {
                case true:
                    RunCloseButton.Image = image2;
                    break;
                case false:
                    RunCloseButton.Image = image1;
                    break;
            }
            RunCloseMiner();
        }
        private void StatsButton_Click(object sender, EventArgs e)
        {
            OpenPanel(Stats_Panel);
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            OpenPanel(ConsolePanel);
        }

        private void GraphButton_Click(object sender, EventArgs e)
        {
            OpenPanel(GraphPanel);
        }

        private void PaymentsButton_Click(object sender, EventArgs e)
        {
            OpenPanel(PaymentsPanel);
        }
        #endregion
    }
}
