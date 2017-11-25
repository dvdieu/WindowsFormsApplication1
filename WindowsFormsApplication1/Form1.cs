using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using static WindowsFormsApplication1.AutoClick;
using Mouse_Click_Simulator;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initChrom();
            this.KeyPreview = true;
            tab.Dock = DockStyle.Fill;            
        }

        public ChromiumWebBrowser chrome;
        MousePoint mousePoint;
        private IntPtr iHandle;

        void initChrom()
        {
            Cef.Initialize(new CefSettings());
            chrome = new ChromiumWebBrowser("http://bon.club");
            this.Web.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.FrameLoadEnd += Chrome_FrameLoadEnd;
        }

        private void Chrome_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            try
            {
                iHandle = this.Handle;
            }
            catch(Exception ex)
            {

            }
            chrome.ShowDevTools();
        }

        private void themSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Win32.SendMessage(iHandle, Win32.WM_LBUTTONDOWN, 0x00000001, mousePoint.X);
            Win32.SendMessage(iHandle, Win32.WM_LBUTTONUP, 0x00000000, mousePoint.Y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)       // F2
            {
                // Do what you want here
                this.mousePoint = AutoClick.GetCursorPosition();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }
    }
}
