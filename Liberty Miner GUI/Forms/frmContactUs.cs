using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public frmContactUs()
        {
            InitializeComponent();
            Cef.Shutdown();
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chromiumWebBrowser1.LoadUrlAsync(LP_Functionality.ContactApiURL);
            chromiumWebBrowser1.Size = new System.Drawing.Size(21, 23);
        }

        private void frmContactUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
