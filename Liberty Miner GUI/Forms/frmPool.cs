using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LP.Data;
using LP;
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
            LoadData();
            InitTimer();
        }
        public void LoadData() 
        {
            PoolData poolData = LP_Functionality.FetchPoolData();
            BlocksFLbl.Text = poolData.BlocksFound.ToString();
            xmrPriceLbl.Text = poolData.xmrPrice.ToString();
            TotalPaymentsLbl.Text = poolData.TotalPayments.ToString();
            //XmrEffortLbl.Text = poolData.;
            PoolHashLbl.Text = poolData.PoolHashrate;
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
    }
}
