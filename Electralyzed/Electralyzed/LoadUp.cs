using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace Electralyzed
{
    public partial class LoadUp : Form
    {
        public LoadUp()
        {
            InitializeComponent();
        }

        //GLOBAL VARIABLES
        string ip, username, password;

        private void LoadUp_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Program Files\7-Zip\7z.exe"))
            {
                MessageBox.Show(@"This application requires 7zip to be installed! Please install and relaunch! (7Zip must be installed in 'C:\Program Files')", "ERROR!", MessageBoxButtons.OK);
                Application.Exit();
            }
            Ver_Label.Text += Properties.Settings.Default.versionNum;
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            ip = IP_TextBox.Text;
            username = Username_TextBox.Text;
            password = Password_TextBox.Text;

            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = ip,
                UserName = username,
                Password = password,
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };

            C_Label.Text = "Attempting to connect...";

            using (Session session = new Session())
            {
                session.Open(sessionOptions);
                C_Label.Text = "Success!";
                session.Close();
                this.Hide();
                Electralyzed EM = new Electralyzed(IP_TextBox.Text, Username_TextBox.Text, Password_TextBox.Text);
                EM.ShowDialog();
            }
        }

        private void UPD_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/6ilent/Electralyzed/releases");
        }
    }
}
