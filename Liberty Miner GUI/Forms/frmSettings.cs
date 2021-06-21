using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibertyMinerGUI;
using LP.Data;
using LP;

namespace LibertyMinerGUI
{
    public partial class frmSettings : Form
    {
        Form1 form_1;
        public frmSettings(Form1 form1)
        {
            InitializeComponent();
            LoadSettings();
            form_1 = form1;
        }
        private void batterybtn_Click(object sender, EventArgs e)
        {
            GraphicalFunctionality.ToggleTrueFalseButton(batteryBtn,Properties.Settings.Default.PauseOnBattery);
        }

        void LoadSettings() 
        {
            ConfigData configData = LP_Functionality.FetchConfigData();
            walletTxt.Text = configData.Wallet;
            workerTxt.Text = configData.Worker;
            cpuCombo.SelectedIndex = configData.Cpu;
            coinCombo.SelectedIndex = configData.Coin;
            startupBtn.Text = configData.RunOnStartUp.ToString();
            batteryBtn.Text = configData.PauseOnBattery.ToString();
            errorWarningLbl.Visible = false;
        }
        private async void applyButton_Click(object sender, EventArgs e)
        {
            if (!LP_Functionality.IsWalletValid(walletTxt.Text)) 
            {
                errorWarningLbl.Visible = true;
                return;
            }
            bool startUp = startupBtn.Text == "True";
            bool battery = batteryBtn.Text == "True";
            ConfigData configData = new ConfigData
                (wallet: walletTxt.Text,
                worker: workerTxt.Text,
                cpu: cpuCombo.SelectedIndex
                , coin: coinCombo.SelectedIndex,
                startup: startUp,
                battery: battery);
            LP_Functionality.SaveConfigData(configData);
            await Task.Delay(450);
            form_1.GoToWalletPanel();
        }

    }
}
