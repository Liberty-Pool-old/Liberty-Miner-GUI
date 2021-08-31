using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibertyMinerGUI.Data;

namespace LibertyMinerGUI
{
    public partial class frmWallet : Form
    {
        string WalletAddress = Properties.Settings.Default.Wallet;
        public frmWallet()
        {
            InitializeComponent();
            Initialize_UI();
            LoadPayments();
            LoadData();
            InitTimer();
        }
        #region UI
        void Initialize_UI()
        {
            consoleControl1.InternalRichTextBox.ForeColor = Color.Lime;
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            OpenPanel(Stats_Panel);
            LP_Functionality.LP.frmwallet = this;
        }
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
        #region Payments
        void LoadPayments()
        {
            RichTextBox box = payments_displayconsole.InternalRichTextBox;
            box.Text = "Loading...";
            List<WalletPayment> payments = LP_Functionality.GetWalletPayments();
            if (payments[0].Amount == "Nein")
            {
                box.Clear();
                LP_Functionality.Print(box, "No payments yet 😭 ");
                LP_Functionality.Print(box, "If you wanna know when are going to be the next payments, you can go to the Pool Section and you can check it there 😀 ");
            }
            else
            {
                box.Clear();
                foreach (WalletPayment payment in payments)
                {
                    LP_Functionality.Print(box, payment.Time + ": " + payment.Amount);
                    LP_Functionality.Print(box, "-------------------------------------------------");
                }
            }
        }
        private void payments_refresh_btn_Click(object sender, EventArgs e)
        {
            LoadPayments();
        }
        #endregion
        #endregion
        #region Data Syncing/Loading
        void LoadData()
        {
            CopyWalletButton.Text = "Copy:" + WalletAddress;
            if (Stats_Panel.Visible) LoadStatsAsync();
            if (ConsolePanel.Visible) LoadConsole();
            //
            if (LP_Functionality.LP.running) RunCloseButton.Image = Properties.Resources.stop;
        }
        public void LoadConsole()
        {
            consoleControl1.InternalRichTextBox.Text = LP_Functionality.LP.xmrigOutput;
        }
        // This is func is done in order to prevent the console reseting bug
        private void consoleControl1_Enter(object sender, EventArgs e)
        {
            ActiveControl = ConsolePanel;
        }
        async Task LoadStatsAsync()
        {
            if (await LP_Functionality.InternetConnectionAvailableAsync())
            {
                LP_Functionality.FetchWalletData(WalletAddress);
                WalletData walletData = LP_Functionality.walletData;
                //
                if (walletData != null)
                {
                    HashLbl.Text = walletData.Hashes;
                    PaidLbl.Text = walletData.Paid;
                    PendingLbl.Text = walletData.Pending;
                }
            }
            else
            {
                string error = "Trying to connect to the internet...";
                HashLbl.Text = error;
                PaidLbl.Text = error;
                PendingLbl.Text = error;
            }
            RAMlbl.Text = LP_Functionality.TotalMemoryUsagePercentage();
            CPULbl.Text = LP_Functionality.GetCPUtemp();
            //
            string elapsedHours = LP_Functionality.LP.xmrigWatch.Elapsed.Duration().Hours.ToString();
            string elapsedMins = LP_Functionality.LP.xmrigWatch.Elapsed.Duration().Minutes.ToString();
            string elapsedSecs = LP_Functionality.LP.xmrigWatch.Elapsed.Duration().Seconds.ToString();
            string elapsedTime = elapsedHours + ":" + elapsedMins + ":" + elapsedSecs;
            if (LP_Functionality.LP.running) XMRIG_Duration_Lbl.Text = elapsedTime;
        }
        #endregion
        async void RunCloseMiner()
        {
            if (LP_Functionality.isMinerOpen())
            {
                LP_Functionality.KillMiner();
            }
            else
            {
                await Task.Run(() => LP_Functionality.RunMiner());
                //
                OpenPanel(ConsolePanel);
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
        #region Payment
        async void UpdatePaymentThreshold()
        {
            if (await  LP_Functionality.InternetConnectionAvailableAsync())
            {
                string url = "https://liberty-pool.com/api/user/updateThreshold";
                var wb = new WebClient();
                var data = new NameValueCollection();
                data["username"] = WalletAddress;
                data["threshold"] = thresholdAmountTxt.Text;
                var response = wb.UploadValues(url, "POST", data);
            }
        }
        #endregion
        #region Buttons
        private void CopyWalletButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Settings.Default.Wallet);
        }
        private void RunClose_Click(object sender, EventArgs e)
        {
            // Resources:
            Image image1 = Properties.Resources.stop;
            Image image2 = Properties.Resources.play;
            //
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
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            OpenPanel(PaymentsPanel);
        }
        private void batteryBtn_Click(object sender, EventArgs e)
        {
            UpdatePaymentThreshold();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePaymentThreshold();
        }
        #endregion


    }
}
