using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KlasaProcess
{
    public partial class Form1 : Form
    {

    class ProcessStartInfo 
        {
            ProcessStartInfo processStartInfo = null;

            public ProcessWindowStyle WindowsStyle { get; internal set; }
            public string Arguments { get; internal set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInternetExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }

        private void btnStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process.Start("IExplore.exe");
            startInfo.WindowsStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
        }
    }
}
