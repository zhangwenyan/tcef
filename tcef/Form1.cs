using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcef
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser browser = null;
        public Form1()
        {
            InitializeComponent();

           // Text = "CefSharp";
          //  WindowState = FormWindowState.Maximized;

             browser = new ChromiumWebBrowser("http://hao123.com")
            {
                Dock = DockStyle.Fill,
            };
            toolStripContainer1.ContentPanel.Controls.Add(browser);

            //  browser.LoadingStateChanged += OnLoadingStateChanged;

            //browser.ConsoleMessage += OnBrowserConsoleMessage;
            //  browser.StatusMessage += OnBrowserStatusMessage;
            //  browser.TitleChanged += OnBrowserTitleChanged;
            //  browser.AddressChanged += OnBrowserAddressChanged;

            //  var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            //   var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            /// DisplayOutput(version);
            /// 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Load("javascript:alert()");
        }
    }
}
