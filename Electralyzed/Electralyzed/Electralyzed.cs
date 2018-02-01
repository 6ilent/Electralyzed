﻿using System;
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
using WinSCP;

namespace Electralyzed
{
    public partial class Electralyzed : Form
    {
        public Electralyzed(string IP_Textbox, string Password_TextBox)
        {
            InitializeComponent();
            ip = IP_Textbox;
            password = Password_TextBox;
        }

        //GLOBAL VARIABLES
        string ip, password, action = "0", EDir = @"C:\E_Temp";

        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_Label_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            MessageBox.Show("Developed by 6ilent" + Environment.NewLine + "SFTP Protocols By WinSCP" + Environment.NewLine + "File Decompressing Library By 7Zip (I used parts of the 7-Zip program, 7-Zip is licensed under the GNU LGPL license, www.7-zip.org", "About", MessageBoxButtons.OK);
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Install:" + Environment.NewLine + "1. Select a DEB you want to install" + Environment.NewLine + "2. Click 'Install'" + Environment.NewLine + "3. Wait for the process to complete" + Environment.NewLine + "4. Done!" + Environment.NewLine + Environment.NewLine + "Uninstall:" + Environment.NewLine + "1. Select the SAME DEB you used for install" + Environment.NewLine + "2. Click 'Uninstall'" + Environment.NewLine + "3. Wait for the process to complete" + Environment.NewLine + "4. Done!", "Usage", MessageBoxButtons.OK);
        }

        private void whatCanIDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently I Can:" + Environment.NewLine + Environment.NewLine + "Install Tweaks and Themes" + Environment.NewLine + "Uninstall Tweaks and Themes" + Environment.NewLine + "Execute some simple SSH commands", "What Can I Do?", MessageBoxButtons.OK);
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/6ilent/Electralyzed/issues");
        }

        private void DEB_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog DEBFileDialog = new OpenFileDialog();
            DEBFileDialog.InitialDirectory = @"C:\" + Environment.SpecialFolder.MyComputer;
            DEBFileDialog.Title = "Select a .deb file";
            DEBFileDialog.DefaultExt = "deb";
            DEBFileDialog.Filter = "deb files (*.deb)|*.deb";

            if (DEBFileDialog.ShowDialog() == DialogResult.OK)
            {
                DEB_TextBox.Text = DEBFileDialog.FileName;

                if (DEB_TextBox.Text == @"C:\")
                {
                    Install_Button.Enabled = false;
                    Uninstall_Button.Enabled = false;
                }
                else
                {
                    Install_Button.Enabled = true;
                    Uninstall_Button.Enabled = true;
                }
            }
        }

        private void Install_Button_Click(object sender, EventArgs e)
        {
            action = "1";
            DisabledState();
        }

        private void Uninstall_Button_Click(object sender, EventArgs e)
        {
            action = "2";
            DisabledState();
        }

        private void respringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string QComm = "respring";
            QuickCommands(QComm);
        }

        private void uICacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string QComm = "uicache";
            QuickCommands(QComm);
        }

        private void QuickCommands(string QComm)
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = ip,
                UserName = "root",
                Password = password,
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };
            Session session = new Session();
            session.Open(sessionOptions);

            if (QComm == "respring")
            {
                session.ExecuteCommand("killall -9 SpringBoard");
                MessageBox.Show("Respringing!", "Done!", MessageBoxButtons.OK);
            }
            else if (QComm == "uicache")
            {
                session.ExecuteCommand("uicache");
                MessageBox.Show("Running UICache! (May take up to 30 seconds)", "Done!", MessageBoxButtons.OK);
            }
            session.Close();
        }

        //ACTUAL DEB INSTALL
        private void DisabledState()
        {
            Exit_Label.Enabled = false;
            Min_Label.Enabled = false;
            DEB_Button.Enabled = false;
            Install_Button.Enabled = false;
            Uninstall_Button.Enabled = false;
            otherToolsToolStripMenuItem.Enabled = false;
            StartUnpack();
        }

        public void StartUnpack()
        {
            //Checking temp folder
            Check4Temp();

            //Extracting deb
            ExtractDEB();

            //Extracting .lzma or .gz
            ExtractDataFrom();

            //Extracting data.tar
            ExtractDATA();

            //Start Install/Uninstall
            StartAction();
        }

        private void Check4Temp()
        {
            O_TextBox.AppendText(Environment.NewLine + "");
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
                Directory.Delete(EDir, true);
                Directory.CreateDirectory(EDir);
                O_TextBox.AppendText(Environment.NewLine + "Cleared!");
            }
        }

        private void ExtractDEB()
        {
            O_TextBox.AppendText(Environment.NewLine + "");
            O_TextBox.AppendText(Environment.NewLine + "Unpacking '" + DEB_TextBox.Text + "'...");
            using (ArchiveFile DEBFile = new ArchiveFile(DEB_TextBox.Text))
            {
                DEBFile.Extract(EDir);
                O_TextBox.AppendText(Environment.NewLine + "Unpacked DEB!");
            }
        }

        private void ExtractDataFrom()
        {
            O_TextBox.AppendText(Environment.NewLine + "");
            O_TextBox.AppendText(Environment.NewLine + "Unpacking to 'data.tar'...");
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = Application.StartupPath + @"\7Z\7z.exe";
            processStartInfo.Arguments = @"e C:\E_temp\data.tar.lzma";
            var proc = Process.Start(processStartInfo);
            proc.WaitForExit();

            if (File.Exists(Application.StartupPath + @"\data.tar"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Unpacked! Moving...");
                File.Copy(@"data.tar", @"C:\E_temp\data.tar");
                O_TextBox.AppendText(Environment.NewLine + "Moved!");
                File.Delete(@"data.tar");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "File must be 'data.tar.gz'");
            }
        }

        private void ExtractDATA()
        {
            O_TextBox.AppendText(Environment.NewLine + "");
            if (File.Exists(EDir + @"\data.tar"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Unpacking 'data.tar'...");
                using (ArchiveFile tardataFile = new ArchiveFile(@"C:\E_temp\data.tar"))
                {
                    tardataFile.Extract(EDir);
                }
            }
            else if (File.Exists(EDir + @"\data.tar.gz"))
            {
                O_TextBox.AppendText(Environment.NewLine + "File is 'data.tar.gz'! Rerunning method...");
                O_TextBox.AppendText(Environment.NewLine + "Unpacking 'data.tar'...");
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = Application.StartupPath + @"\7Z\7z.exe";
                processStartInfo.Arguments = @"e C:\E_temp\data.tar.gz";
                var proc = Process.Start(processStartInfo);
                proc.WaitForExit();
                File.Copy(@"data.tar", @"C:\E_temp\data.tar");
                File.Delete(@"data.tar");
                O_TextBox.AppendText(Environment.NewLine + "Method ran successfully! Unpacking 'data.tar'...");
                using (ArchiveFile tar2dataFile = new ArchiveFile(@"C:\E_temp\data.tar"))
                {
                    tar2dataFile.Extract(EDir);
                }
            }

            O_TextBox.AppendText(Environment.NewLine + "Unpacked 'data.tar'!");
        }

        private void StartAction()
        {
            //Reconnect
            O_TextBox.AppendText(Environment.NewLine + "");
            O_TextBox.AppendText(Environment.NewLine + "Re-establishing connection to iDevice...");
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = ip,
                UserName = "root",
                Password = password,
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };
            Session session = new Session();
            session.Open(sessionOptions);
            O_TextBox.AppendText(Environment.NewLine + "Reconnected!");

            if (action == "1")
            {
                FINALINSTALL(session);
            }
            else if (action == "2")
            {
                FINALUNINSTALL(session);
            }

            //FINISHED
            //Asks for respring
            Respring(session);
            DeleteDEB(session);
            Cleanup();
            NormalState();
            session.Close();
        }

        private void FINALINSTALL(Session session)
        {
            //THEMES INSTALLER
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\Themes\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local themes folder found! Installing...");
                string[] themesArray = Directory.GetDirectories(EDir + @"\Library\Themes\");
                for (int themes  = 0; themes < themesArray.Length; themes++)
                {
                    O_TextBox.AppendText(Environment.NewLine + "Placing " + themesArray[themes] + "...");
                    session.PutFiles(themesArray[themes], "/bootstrap/Library/Themes/");
                    O_TextBox.AppendText(Environment.NewLine + "Placed " + themesArray[themes]);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished installing " + DEB_TextBox.Text + "!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No Themes folder found. (Probably not a theme.)");
            }

            //TWEAK - MOBILESUBSTRATE 
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\MobileSubstrate\DynamicLibraries\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local MobileSubstrate folder found! Installing...");
                string[] MSArray = Directory.GetFiles(EDir + @"\Library\MobileSubstrate\DynamicLibraries\");
                for (int MS = 0; MS < MSArray.Length; MS++)
                {
                    O_TextBox.AppendText(Environment.NewLine + "Placing " + MSArray[MS] + "...");
                    session.PutFiles(MSArray[MS], "/usr/lib/SBInject/");
                    O_TextBox.AppendText(Environment.NewLine + "Placed " + MSArray[MS]);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished installing MobileSubstrate!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No MobileSubstrate found.");
            }

            //TWEAK - PREFERENCELOADER
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\PreferenceLoader\Preferences\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local PreferenceLoader folder found! Installing...");
                string[] PLArray = Directory.GetFiles(EDir + @"\Library\PreferenceLoader\Preferences\");
                for (int PL = 0; PL < PLArray.Length; PL++)
                {
                    O_TextBox.AppendText(Environment.NewLine + "Placing " + PLArray[PL] + "...");
                    session.PutFiles(PLArray[PL], "/bootstrap/Library/PreferenceLoader/Preferences/");
                    O_TextBox.AppendText(Environment.NewLine + "Placed " + PLArray[PL]);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished installing PreferenceLoader!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No PreferenceLoader found.");
            }

            //TWEAK - PREFERENCEBUNDLES
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\PreferenceBundles\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local PreferenceBundles folder found! Installing...");
                string[] PBArray = Directory.GetDirectories(EDir + @"\Library\PreferenceBundles\");
                for (int PB = 0; PB < PBArray.Length; PB++)
                {
                    O_TextBox.AppendText(Environment.NewLine + "Placing " + PBArray[PB] + "...");
                    session.PutFiles(PBArray[PB], "/bootstrap/Library/PreferenceBundles/");
                    O_TextBox.AppendText(Environment.NewLine + "Placed " + PBArray[PB]);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished installing PreferenceBundles!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No PreferenceBundles found.");
            }

            //TWEAK - APPLICATION SUPPORT
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\Application Support\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local Application Support folder found! Installing...");
                string[] ASArray = Directory.GetDirectories(EDir + @"\Library\Application Support\");
                for (int AS = 0; AS < ASArray.Length; AS++)
                {
                    O_TextBox.AppendText(Environment.NewLine + "Placing " + ASArray[AS] + "...");
                    session.PutFiles(ASArray[AS], "/bootstrap/Library/Application Support/");
                    O_TextBox.AppendText(Environment.NewLine + "Placed " + ASArray[AS]);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished installing Application Support!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No Application Support found.");
            }

            //FINISHED!
            O_TextBox.AppendText(Environment.NewLine + "");
            O_TextBox.AppendText(Environment.NewLine + "Finished!");
        }

        private void FINALUNINSTALL(Session session)
        {
            //THEMES UNINSTALLER
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\Themes\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local themes folder found! Uninstalling...");
                string[] themesArray = Directory.GetDirectories(EDir + @"\Library\Themes\");
                string TFolder; //Actual Folder starts on character #25
                for (int themes = 0; themes < themesArray.Length; themes++)
                {
                    TFolder = themesArray[themes].Substring(25);
                    O_TextBox.AppendText(Environment.NewLine + "Removing " + TFolder + "...");
                    session.RemoveFiles("/bootstrap/Library/Themes/" + TFolder);
                    O_TextBox.AppendText(Environment.NewLine + "Removed " + TFolder);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished uninstalling " + DEB_TextBox.Text + "!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No Themes folder found. (Probably not a theme.)");
            }

            //TWEAK - MOBILESUBSTRATE 
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\MobileSubstrate\DynamicLibraries\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local MobileSubstrate folder found! Uninstalling...");
                string[] MSArray = Directory.GetFiles(EDir + @"\Library\MobileSubstrate\DynamicLibraries\");
                string MSFile; //Actual File starts on character #51
                for (int MS = 0; MS < MSArray.Length; MS++)
                {
                    MSFile = MSArray[MS].Substring(51);
                    O_TextBox.AppendText(Environment.NewLine + "Removing " + MSFile + "...");
                    session.RemoveFiles("/usr/lib/SBInject/" + MSFile);
                    O_TextBox.AppendText(Environment.NewLine + "Removed " + MSFile);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished uninstalling MobileSubstrate!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No MobileSubstrate found.");
            }

            //TWEAK - PREFERENCELOADER
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\PreferenceLoader\Preferences\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local PreferenceLoader folder found! Installing...");
                string[] PLArray = Directory.GetFiles(EDir + @"\Library\PreferenceLoader\Preferences\");
                string PLFile; //Actual File start on character #47
                for (int PL = 0; PL < PLArray.Length; PL++)
                {
                    PLFile = PLArray[PL].Substring(47);
                    O_TextBox.AppendText(Environment.NewLine + "Removing " + PLFile + "...");
                    session.RemoveFiles("/bootstrap/Library/PreferenceLoader/Preferences/" + PLFile);
                    O_TextBox.AppendText(Environment.NewLine + "Removed " + PLFile);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished uninstalling PreferenceLoader!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No PreferenceLoader found.");
            }

            //TWEAK - PREFERENCEBUNDLES
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\PreferenceBundles\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local PreferenceBundles folder found! Installing...");
                string[] PBArray = Directory.GetDirectories(EDir + @"\Library\PreferenceBundles\");
                string PBFolder; //Actual Folder start on character #36
                for (int PB = 0; PB < PBArray.Length; PB++)
                {
                    PBFolder = PBArray[PB].Substring(36);
                    O_TextBox.AppendText(Environment.NewLine + "Removing " + PBFolder + "...");
                    session.RemoveFiles("/bootstrap/Library/PreferenceBundles/" + PBFolder);
                    O_TextBox.AppendText(Environment.NewLine + "Removed " + PBFolder);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished uninstalling PreferenceBundles!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No PreferenceBundles found.");
            }

            //TWEAK - APPLICATIONSUPPORT
            O_TextBox.AppendText(Environment.NewLine + "");
            if (Directory.Exists(EDir + @"\Library\Application Support\"))
            {
                O_TextBox.AppendText(Environment.NewLine + "Local Application Support folder found! Installing...");
                string[] ASArray = Directory.GetDirectories(EDir + @"\Library\Application Support\");
                string ASFolder; //Actual Folder start on character #37
                for (int AS = 0; AS < ASArray.Length; AS++)
                {
                    ASFolder = ASArray[AS].Substring(37);
                    O_TextBox.AppendText(Environment.NewLine + "Removing " + ASFolder + "...");
                    session.RemoveFiles("/bootstrap/Library/Application Support/" + ASFolder);
                    O_TextBox.AppendText(Environment.NewLine + "Removed " + ASFolder);
                }
                O_TextBox.AppendText(Environment.NewLine + "Finished uninstalling Application Support!");
            }
            else
            {
                O_TextBox.AppendText(Environment.NewLine + "No Application Support found.");
            }

            //FINISHED!
            O_TextBox.AppendText(Environment.NewLine + "");
            O_TextBox.AppendText(Environment.NewLine + "Finished!");

        }

        private void Respring(Session session)
        {
            O_TextBox.AppendText(Environment.NewLine + "");
            DialogResult RespringYN = MessageBox.Show("Do you want me to Respring?", "Respring?", MessageBoxButtons.YesNo);
            if (RespringYN == DialogResult.Yes)
            {
                O_TextBox.AppendText(Environment.NewLine + "Attempting to kill 'SpringBoard'...");
                session.ExecuteCommand("killall -9 SpringBoard");
                O_TextBox.AppendText(Environment.NewLine + "Killed!");
            }
        }

        private void DeleteDEB(Session session)
        {
            O_TextBox.AppendText(Environment.NewLine + "");
            DialogResult DeleteYN = MessageBox.Show("Do you want me to delete the .deb now that is has been installed?", "Delete .deb?", MessageBoxButtons.YesNo);
            if (DeleteYN == DialogResult.Yes)
            {
                O_TextBox.AppendText(Environment.NewLine + "Deleting...");
                File.Delete(DEB_TextBox.Text);
                O_TextBox.AppendText(Environment.NewLine + "Deleted!");
            }
        }

        private void Cleanup()
        {
            O_TextBox.AppendText(Environment.NewLine + "");
            O_TextBox.AppendText(Environment.NewLine + "Cleaning up...");
            Directory.Delete(EDir, true);
        }

        private void NormalState()
        {
            Exit_Label.Enabled = true;
            Min_Label.Enabled = true;
            DEB_Button.Enabled = true;
            Install_Button.Enabled = false;
            Uninstall_Button.Enabled = false;
            otherToolsToolStripMenuItem.Enabled = true;
            O_TextBox.Text = "Ready when you are!";
            DEB_TextBox.Text = @"C:\";
            action = "0";
        }
    }
}
