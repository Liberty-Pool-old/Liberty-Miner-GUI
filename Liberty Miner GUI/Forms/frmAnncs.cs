using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyMinerGUI
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            LoadAsync();
        }
        public async Task LoadAsync()
        {
            if (await LP_Functionality.InternetConnectionAvailableAsync())
            {
                errorPanel.Visible = false;
                //
                int lineCount = 0;
                StringBuilder output = new StringBuilder();
                string announcements = LP_Functionality.DownloadString(LP_Functionality.AnnouncementsApiURL);
                webBrowser1.AllowWebBrowserDrop = false;
                webBrowser1.DocumentText = announcements;
            }
            else
            {
                errorPanel.Visible = true;
                webBrowser1.Visible = false;
            }
        }
    }
}
