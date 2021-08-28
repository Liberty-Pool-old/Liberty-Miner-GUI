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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LibertyMinerGUI
{
    public partial class frmContactUs : Form
    {
        public frmContactUs()
        {
            InitializeComponent();
                Contact_Us_Panel.Visible = true;
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
