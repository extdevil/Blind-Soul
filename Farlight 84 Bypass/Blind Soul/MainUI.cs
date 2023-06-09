using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Devil;
using System.Threading;
using System.IO;
using System.Reflection;
using Blind_Soul.Properties;

namespace Blind_Soul
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            UXWorker cMover = new UXWorker();
            cMover.CustomFormMover(_formMover, this);

            // Enable double-buffering to prevent flickering
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            UpdateStyles();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // Enables drop shadow effect
                return cp;
            }
        }

        // Declare a variable to store the form shadow color
        private Color formShadowColor = Color.FromArgb(60, 0, 0, 0); // Change the color and opacity as desired
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the form shadow
            using (SolidBrush shadowBrush = new SolidBrush(formShadowColor))
            {
                e.Graphics.FillRectangle(shadowBrush, new Rectangle(-10, -10, Width + 20, Height + 20));
            }
        }

        private string[] GetConnectedDNS()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    if (dnsAddresses != null && dnsAddresses.Count > 0)
                    {
                        string[] dnsServers = new string[dnsAddresses.Count];
                        for (int i = 0; i < dnsAddresses.Count; i++)
                        {
                            dnsServers[i] = dnsAddresses[i].ToString();
                        }

                        return dnsServers;
                    }
                }
            }

            return null;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl.Text.StartsWith("Not "))
            {
                lbl.ForeColor = Color.Tomato;
            }
            else
            {
                lbl.ForeColor = Color.SpringGreen;
            }

            if (lbl.Name == "_farlightStatus" && lbl.Text.StartsWith("Not "))
            {
                _anticheatStatus.Text = "Not Bypassed";
                _dllStatus.Text = "Not Injected";
                startHackBtn.Enabled = true;
            }
        }

        private void autoChecker_Tick(object sender, EventArgs e)
        {
            //Cloudflare
            if (Process.GetProcessesByName("Cloudflare WARP").Length != 0)
            {
                string[] dnsServers = GetConnectedDNS();
                if (dnsServers != null && dnsServers.Length > 1)
                {
                    _cloudflareStatus.Text = "Connected";
                }
                else
                {
                    _cloudflareStatus.Text = "Not Connected";
                }
            }
            else
            {
                _cloudflareStatus.Text = "Not Connected";
            }

            //Steam
            if (Process.GetProcessesByName("steam").Length != 0 && Process.GetProcessesByName("steamservice").Length != 0)
            {
                _steamStatus.Text = "Running";
            }
            else
            {
                _steamStatus.Text = "Not Running";
            }

            //Farlight
            if (Process.GetProcessesByName("SolarlandClient-Win64-Shipping").Length != 0)
            {
                _farlightStatus.Text = "Running";
            }
            else
            {
                _farlightStatus.Text = "Not Running";
            }
            Refresh();
            Thread.Sleep(50);
        }

        private void _selectPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Farlight 84 game folder";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fbd.SelectedPath + @"\EasyAntiCheat\Settings.json"))
                {
                    _gamePath.Text = fbd.SelectedPath + @"\EasyAntiCheat\Settings.json";
                    File.WriteAllText("LastPath.txt", fbd.SelectedPath + @"\EasyAntiCheat\Settings.json");
                }
                else
                {
                    MessageBox.Show("The selected folder isn't a valid Farlight 84 game folder !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void hack2_CheckedChanged(object sender, EventArgs e)
        {
            if (hack2.Checked)
            {
                hack1.Checked = false;
            }
        }

        private void hack1_CheckedChanged(object sender, EventArgs e)
        {
            if (hack1.Checked)
            {
                hack2.Checked = false;
            }
        }

        private void MainUI_Shown(object sender, EventArgs e)
        {
            
        }

        private void startHackBtn_Click(object sender, EventArgs e)
        {
            //VERIFICATION
            if (_gamePath.Text == "No path selected")
            {
                MessageBox.Show("Select path of the game folder to continue !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Process.GetProcessesByName("SolarlandClient-Win64-Shipping").Length != 0)
            {
                MessageBox.Show("Close the game to start the hack !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            startHackBtn.Enabled = false;

            //ANTI-CHEAT BYPASS
            var dat = File.ReadAllLines(_gamePath.Text);
            var back = File.ReadAllText(_gamePath.Text);
            for (int i = 0; i < dat.Length; i++)
            {
                if (dat[i].Contains("\"productid\":"))
                {
                    dat[i] = "    \"productid\": \"69\",";
                }
                if (dat[i].Contains("\"sandboxid\":"))
                {
                    dat[i] = "    \"sandboxid\": \"69\",";
                }
                if (dat[i].Contains("\"deploymentid\":"))
                {
                    dat[i] = "    \"deploymentid\": \"69\",";
                }
            }
            File.WriteAllLines(_gamePath.Text, dat);
            Process.Start("steam://rungameid/1928420");
            while (Process.GetProcessesByName("SolarlandClient-Win64-Shipping").Length == 0)
            {
                Thread.Sleep(1000);
            }

            File.WriteAllText(_gamePath.Text, back);
            _anticheatStatus.Text = "Bypassed";

            File.WriteAllBytes("hack1.dll", Properties.Resources.F84_V5);
            File.WriteAllBytes("hack2.dll", Properties.Resources.FARLIGHT);
            File.WriteAllBytes("Inject.exe", Properties.Resources.Inject_x64);

            MessageBox.Show("Anti-cheat bypassed successfully !\n\nPress 'OK' to Inject hack...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Injecting dll
            Process pr = new Process();
            pr.StartInfo.FileName = "Inject.exe";
            if (hack1.Checked)
            {
                pr.StartInfo.Arguments = "hack1.dll SolarlandClient-Win64-Shipping.exe";
            }
            else if (hack2.Checked)
            {
                pr.StartInfo.Arguments = "hack2.dll SolarlandClient-Win64-Shipping.exe";
            }
            pr.StartInfo.CreateNoWindow = true;
            pr.StartInfo.UseShellExecute = false;
            pr.Start();
            pr.WaitForExit();
            _dllStatus.Text = "Injected";
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            if (File.Exists("LastPath.txt"))
            {
                _gamePath.Text = File.ReadAllText("LastPath.txt");
            }
        }
    }
}
