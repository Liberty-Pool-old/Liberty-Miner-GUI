using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LibertyMinerGUI.Data;
using LibertyMinerGUI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyMinerGUI
{
    public partial class frmPool : Form
    {
        public frmPool()
        {
            InitializeComponent();
            LoadDataAsync();
            InitTimer();
        }
        public async Task LoadDataAsync()
        {
            if (await LP_Functionality.InternetConnectionAvailableAsync())
            {
                PoolData poolData = await LP_Functionality.FetchPoolDataAsync();
                BlocksFLbl.Text = poolData.BlocksFound.ToString();
                xmrPriceLbl.Text = poolData.xmrPrice.ToString();
                TotalPaymentsLbl.Text = poolData.TotalPayments.ToString();
                WorldHashrateLbl.Text = poolData.WorldXMRHashrate;
                nextPaymentDateLbl.Text = LP_Functionality.GetNextPaymentDate();
                PoolHashLbl.Text = poolData.PoolHashrate;
            }
            else 
            {
                string error = "Trying to connect to the internet...";
                BlocksFLbl.Text = error;
                xmrPriceLbl.Text = error;
                TotalPaymentsLbl.Text = error;
                WorldHashrateLbl.Text = error;
                nextPaymentDateLbl.Text = error;
                PoolHashLbl.Text = error;
            }
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
            LoadDataAsync();
        }
        #endregion
    }
}
