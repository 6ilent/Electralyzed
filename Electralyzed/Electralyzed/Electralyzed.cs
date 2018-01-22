using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SevenZipExtractor;

namespace Electralyzed
{
    public partial class Electralyzed : Form
    {
        public Electralyzed(string IP_Textbox, string Username_TextBox, string Password_TextBox)
        {
            InitializeComponent();
            ip = IP_Textbox;
            username = Username_TextBox;
            password = Password_TextBox;
        }

        //GLOBAL VARIABLES
        string ip, username, password, action, EDir = @"C:\E_Temp";

        private void Electralyzed_Load(object sender, EventArgs e)
        {
            VerLabel.Text += Properties.Settings.Default.versionNum;
            FI_Timer.Start();
        }

        private void FI_Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += .1;

            if (this.Opacity == 1)
                FI_Timer.Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FO_Timer.Start();
        }

        private void FO_Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .1;

            if (this.Opacity == 0)
            {
                FO_Timer.Stop();
                this.Close();
            }
        }

        private void tweakCompatabilitySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1YptWW_bBdEQ9naYAfiZ2Aj4H93Y56I4xSYI29u4q_-Y/edit#gid=0");
        }

        private void dEBDownloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://s0n1c.org/cydia/");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by 6ilent" + Environment.NewLine + "SFTP Protocols By WinSCP" + Environment.NewLine + "File Decompressing Library By 7Zip");
        }

        private void DEB_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog DEBFileDialog = new OpenFileDialog();
            DEBFileDialog.InitialDirectory = @"C:\" + Environment.SpecialFolder.Desktop;
            DEBFileDialog.Title = "Select a .deb file";
            DEBFileDialog.DefaultExt = "deb";
            DEBFileDialog.Filter = "deb files (*.deb)|*.deb";

            if (DEBFileDialog.ShowDialog() == DialogResult.OK)
                DEB_TextBox.Text = DEBFileDialog.FileName;
        }

        private void DEB_TextBox_OnValueChanged(object sender, EventArgs e)
        {
            if (DEB_TextBox.Text == @"C:\")
            {
                Install_Button.Enabled = false;
                Uninstall_Button.Enabled = false;
            }
            else
            {
                Install_Button.Enabled = false;
                Uninstall_Button.Enabled = false;
            }
        }

        private void Install_Button_Click(object sender, EventArgs e)
        {
            action = "1";
            StartUnpack();
        }

        private void Uninstall_Button_Click(object sender, EventArgs e)
        {
            action = "2";
            StartUnpack();
        }

        public void StartUnpack()
        {
            //Checking temp folder
            Check4Temp();

            //Extracting deb
            ExtractDEB();

            //Extracting .lzma
            ExtractLZMA();

            //Extracting data.tar
            ExtractDATA();

            //Start Install/Uninstall
            StartAction();
        }

        private void Check4Temp()
        {
            O_TextBox.AppendText(Environment.NewLine + @"Checking if '\E_temp' exists...");
            if (!Directory.Exists(EDir))
            {
                O_TextBox.AppendText(Environment.NewLine + @"'\E_temp' does NOT exist! Creating...");
                Directory.CreateDirectory(EDir);
                O_TextBox.AppendText(Environment.NewLine + "Created!");
            }
            else if (Directory.Exists(EDir))
            {
                O_TextBox.AppendText(Environment.NewLine + @"'\E_temp' exists! Clearing the directory...");
                Directory.Delete(EDir);
                Directory.CreateDirectory(EDir);
                O_TextBox.AppendText(Environment.NewLine + "Cleared!");
            }
        }

        private void ExtractDEB()
        {
            O_TextBox.AppendText(Environment.NewLine + "Unpacking '" + DEB_TextBox.Text + "'...");
            using (ArchiveFile DEBFile = new ArchiveFile(DEB_TextBox.Text))
            {
                DEBFile.Extract(EDir);
                O_TextBox.AppendText(Environment.NewLine + "Unpacked DEB!");
            }
        }

        private void ExtractLZMA()
        {
            O_TextBox.AppendText(Environment.NewLine + "Unpacking 'data.tar.lzma'...");
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"C:\Program Files\7-Zip\7z.exe";
            processStartInfo.Arguments = @"e C:\E_temp\data.tar.lzma";
            O_TextBox.AppendText(Environment.NewLine + "Checking for duplicates...");
            if (File.Exists(@"data.tar"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Duplicate found! Removing...");
                File.Delete(@"data.tar");
                O_TextBox.AppendText(Environment.NewLine + "Removed!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No Duplicates found!");
            }
            var proc = Process.Start(processStartInfo);
            proc.WaitForExit();
            O_TextBox.AppendText(Environment.NewLine + "Unpacked! Moving...");
            File.Copy(@"data.tar", @"C:\E_temp\data.tar");
            O_TextBox.AppendText(Environment.NewLine + "Moved!");
            File.Delete(@"data.tar");
        }

        private void ExtractDATA()
        {
            O_TextBox.AppendText(Environment.NewLine + "Unpacking 'data.tar'...");
            using (ArchiveFile tardataFile = new ArchiveFile(@"C:\E_temp\data.tar"))
            {
                tardataFile.Extract(EDir);
                O_TextBox.AppendText(Environment.NewLine + "Unpacked 'data.tar'!");
            }
        }

        private void StartAction()
        {
            O_TextBox.AppendText(Environment.NewLine + "Re-establishing connection to iDevice...");
        }
    }
}
