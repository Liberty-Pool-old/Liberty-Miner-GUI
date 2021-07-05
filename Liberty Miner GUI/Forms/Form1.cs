using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LibertyMinerGUI;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LibertyMinerGUI
{
    
    public partial class Form1 : Form
    {
        #region UI Movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pnlFormLoader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void lbltitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region UI
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        #endregion
        frmWallet frmwallet;
        frmPool frmPool;
        frmAbout frmAbout;
        frmSettings frmSettings;
        frmContactUs frmContactUs;
        public Updater updater = new Updater();

        public void CloseBWSubForms() 
        {
            if (frmwallet != null) frmwallet.Close();
            if (frmAbout != null) frmAbout.Close();
            if (frmSettings != null) frmSettings.Close();
            if (frmPool != null) frmPool.Close();
            if (frmContactUs != null) frmContactUs.Close();
        }
        public Form1()
        {
            InitializeComponent();
            //
            updater.ShowDialog();
            updater.Close();
            _Close += new FunctionDelegate(CloseForm);
            //
            LP_Functionality.LP.form1 = this;
            //
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnWallet.Height;
            pnlNav.Top = btnWallet.Top;
            pnlNav.Left = btnWallet.Left;

            lbltitle.Text = "Wallet Stats:";
            frmWallet frmWallet_vrb = new frmWallet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmwallet = frmWallet_vrb;
            frmWallet_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmWallet_vrb);
            frmWallet_vrb.Show();
            //
            if (LP_Functionality.IsResolutionRightForHighDPH())
            {
                System.Windows.SystemParameters.PrimaryScreenWidth.ToString();
            }
        }
        private void btnWallet_Click(object sender, EventArgs e)
        {
            GoToWalletPanel();
        }
        public void GoToWalletPanel() 
        {
            CloseBWSubForms();
            //
            pnlNav.Height = btnWallet.Height;
            pnlNav.Top = btnWallet.Top;
            pnlNav.Left = btnWallet.Left;
            btnWallet.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Wallet Stats:";
            this.pnlFormLoader.Controls.Clear();
            frmWallet frmWallet_vrb = new frmWallet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmWallet_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmWallet_vrb);
            frmWallet_vrb.Show();
        }
        private void btnPool_Click(object sender, EventArgs e)
        {
            CloseBWSubForms();
            //
            pnlNav.Height = btnPool.Height;
            pnlNav.Top = btnPool.Top;
            btnPool.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Pool Stats:";
            this.pnlFormLoader.Controls.Clear();
            frmPool frmPool_vrb = new frmPool() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPool_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmPool_vrb);
            frmPool_vrb.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            CloseBWSubForms();
            //
            pnlNav.Height = btnAnnouncements.Height;
            pnlNav.Top = btnAnnouncements.Top;
            btnAnnouncements.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmAbout frmAbout_vrb = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbout_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAbout_vrb);
            frmAbout_vrb.Show();
            lbltitle.Text = "";
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            CloseBWSubForms();
            //
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            frmwallet.Stats_Panel.Visible = false;
            frmwallet.Close();
            this.pnlFormLoader.Controls.Clear();
            frmContactUs frmContactUs_vrb = new frmContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmContactUs_vrb.FormBorderStyle = FormBorderStyle.None;
            // Initialize cef with the provided settings
            // Create a browser component
            // Add it to the form and fill it to the form window.
            this.pnlFormLoader.Controls.Add(frmContactUs_vrb);
            frmContactUs_vrb.Show();
            lbltitle.Text = "Contact Us:";
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            CloseBWSubForms();
            //
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmSettings frmSettings_vrb = new frmSettings(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSettings_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmSettings_vrb);
            frmSettings_vrb.Show();
            lbltitle.Text = "";
        }

        private void btnWallet_Leave(object sender, EventArgs e)
        {
            btnWallet.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPool_Leave(object sender, EventArgs e)
        {
            btnPool.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnnouncements_Leave(object sender, EventArgs e)
        {
            btnAnnouncements.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xmrPrice_DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(46, 51, 73), ButtonBorderStyle.Solid);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LP_Functionality.KillMiner();
        }
        #region Thread Calls
        public delegate void FunctionDelegate();
        public FunctionDelegate _Close;
        void CloseForm() 
        {
            CloseBWSubForms();
            Close();
        }
        #endregion
    }
}
