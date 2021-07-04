using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace LibertyMinerGUI
{
    public partial class frmContactUs : Form
    {
        const string FromEmail = "libertypoolmessagesender@gmail.com";
        public frmContactUs()
        {
            InitializeComponent();
            if (LP_Functionality.IsResolutionRightForHighDPH())
            {
                Contact_Us_Panel.Visible = false;
                Cef.Shutdown();
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
                chromiumWebBrowser1.Dock = DockStyle.Fill;
                chromiumWebBrowser1.LoadUrlAsync(LP_Functionality.ContactApiURL);
                chromiumWebBrowser1.Size = new System.Drawing.Size(21, 23);
            }
            else
            {
                Contact_Us_Panel.Visible = true;
                chromiumWebBrowser1.Visible = false;
            }
        }
        private void frmContactUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
        }

        private void Contact_Us_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:liberty-pool@libercrypto.com");
        }

        private void OpenDiscordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/pWuRHGFbJY");
        }
    }
}
