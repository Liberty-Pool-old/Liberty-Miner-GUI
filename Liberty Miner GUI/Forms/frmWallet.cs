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
using LP;
using LP.Data;

namespace LibertyMinerGUI
{
    public partial class frmWallet : Form
    {
        Form1 form;
        string WalletAddress = Properties.Settings.Default.Wallet;
        public frmWallet(Form1 form1)
        {
            InitializeComponent();
            OpenPanel(Stats_Panel);
            form = form1;
            LoadData();
            InitTimer();
        }
        void LoadData() 
        {
            CopyWalletButton.Text = "Copy:" + WalletAddress;
            //
            WalletData walletData = LP_Functionality.FetchWalletData(WalletAddress);
            HashLbl.Text = walletData.Hashes;
            PaidLbl.Text = walletData.Paid;
            PendingLbl.Text = walletData.Pending;
            //
            if (form.running) RunCloseButton.Image = Properties.Resources.stop;
            
        }
        void OpenPanel(Panel panel) 
        {
            List<Panel> panels = new List<Panel>() { ConsolePanel, Stats_Panel, PaymentsPanel, GraphPanel};
            foreach(Panel p in panels) 
            {
                if(p.Equals(panel)) 
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

            if (form.running && !form.xmrig.HasExited) 
            {
                form.xmrig.Kill();
            }
            else
            {
                form.xmrig = LP_Functionality.RunMiner();
                form.xmrig.OutputDataReceived += process_OutputDataReceived;
                ConsolePanel.Visible = true;
                Stats_Panel.Visible = false;
            }
        }

        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            XmrigOutput.Text = e.Data.ToString();
        }

        #region BACKGROUND WORKER
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
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
            RunCloseMiner();
            Image image1 = Properties.Resources.stop;
            Image image2 = Properties.Resources.play;
            switch (form.running)
            {
                case true:
                    form.running = false;
                    RunCloseButton.Image = image2;
                    break;
                case false:
                    form.running = true;
                    RunCloseButton.Image = image1;
                    break;
            }
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
