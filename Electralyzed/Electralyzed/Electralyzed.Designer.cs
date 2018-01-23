namespace Electralyzed
{
    partial class Electralyzed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electralyzed));
            this.MStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tweakCompatabilitySheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBDownloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DEB_Label = new System.Windows.Forms.Label();
            this.DEB_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.DEB_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DEB_Button = new System.Windows.Forms.Button();
            this.Action_Label = new System.Windows.Forms.Label();
            this.Action_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Install_Button = new System.Windows.Forms.Button();
            this.Uninstall_Button = new System.Windows.Forms.Button();
            this.O_TextBox = new System.Windows.Forms.TextBox();
            this.otherToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uICacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MStrip
            // 
            this.MStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.MStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.otherToolsToolStripMenuItem});
            this.MStrip.Location = new System.Drawing.Point(0, 0);
            this.MStrip.Name = "MStrip";
            this.MStrip.Size = new System.Drawing.Size(784, 24);
            this.MStrip.TabIndex = 0;
            this.MStrip.Text = "MStrip";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tweakCompatabilitySheetToolStripMenuItem,
            this.dEBDownloaderToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tweakCompatabilitySheetToolStripMenuItem
            // 
            this.tweakCompatabilitySheetToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.tweakCompatabilitySheetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tweakCompatabilitySheetToolStripMenuItem.Name = "tweakCompatabilitySheetToolStripMenuItem";
            this.tweakCompatabilitySheetToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.tweakCompatabilitySheetToolStripMenuItem.Text = "Tweak Compatability Sheet";
            this.tweakCompatabilitySheetToolStripMenuItem.Click += new System.EventHandler(this.tweakCompatabilitySheetToolStripMenuItem_Click);
            // 
            // dEBDownloaderToolStripMenuItem
            // 
            this.dEBDownloaderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.dEBDownloaderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dEBDownloaderToolStripMenuItem.Name = "dEBDownloaderToolStripMenuItem";
            this.dEBDownloaderToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.dEBDownloaderToolStripMenuItem.Text = "DEB Downloader";
            this.dEBDownloaderToolStripMenuItem.Click += new System.EventHandler(this.dEBDownloaderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DEB_Label
            // 
            this.DEB_Label.AutoSize = true;
            this.DEB_Label.BackColor = System.Drawing.Color.Transparent;
            this.DEB_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEB_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.DEB_Label.Location = new System.Drawing.Point(12, 39);
            this.DEB_Label.Name = "DEB_Label";
            this.DEB_Label.Size = new System.Drawing.Size(117, 20);
            this.DEB_Label.TabIndex = 1;
            this.DEB_Label.Text = "Select a DEB";
            // 
            // DEB_Separator
            // 
            this.DEB_Separator.BackColor = System.Drawing.Color.Transparent;
            this.DEB_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.DEB_Separator.LineThickness = 1;
            this.DEB_Separator.Location = new System.Drawing.Point(12, 62);
            this.DEB_Separator.Name = "DEB_Separator";
            this.DEB_Separator.Size = new System.Drawing.Size(291, 10);
            this.DEB_Separator.TabIndex = 2;
            this.DEB_Separator.Transparency = 255;
            this.DEB_Separator.Vertical = false;
            // 
            // DEB_TextBox
            // 
            this.DEB_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DEB_TextBox.Enabled = false;
            this.DEB_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DEB_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.DEB_TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.DEB_TextBox.HintText = "";
            this.DEB_TextBox.isPassword = false;
            this.DEB_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.DEB_TextBox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.DEB_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.DEB_TextBox.LineThickness = 3;
            this.DEB_TextBox.Location = new System.Drawing.Point(12, 79);
            this.DEB_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DEB_TextBox.Name = "DEB_TextBox";
            this.DEB_TextBox.Size = new System.Drawing.Size(209, 33);
            this.DEB_TextBox.TabIndex = 3;
            this.DEB_TextBox.Text = "C:\\";
            this.DEB_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DEB_Button
            // 
            this.DEB_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.DEB_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DEB_Button.ForeColor = System.Drawing.Color.White;
            this.DEB_Button.Location = new System.Drawing.Point(228, 89);
            this.DEB_Button.Name = "DEB_Button";
            this.DEB_Button.Size = new System.Drawing.Size(75, 23);
            this.DEB_Button.TabIndex = 4;
            this.DEB_Button.Text = "Select";
            this.DEB_Button.UseVisualStyleBackColor = false;
            this.DEB_Button.Click += new System.EventHandler(this.DEB_Button_Click);
            // 
            // Action_Label
            // 
            this.Action_Label.AutoSize = true;
            this.Action_Label.BackColor = System.Drawing.Color.Transparent;
            this.Action_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Action_Label.Location = new System.Drawing.Point(12, 131);
            this.Action_Label.Name = "Action_Label";
            this.Action_Label.Size = new System.Drawing.Size(164, 20);
            this.Action_Label.TabIndex = 1;
            this.Action_Label.Text = "Install or Uninstall?";
            // 
            // Action_Separator
            // 
            this.Action_Separator.BackColor = System.Drawing.Color.Transparent;
            this.Action_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Action_Separator.LineThickness = 1;
            this.Action_Separator.Location = new System.Drawing.Point(12, 154);
            this.Action_Separator.Name = "Action_Separator";
            this.Action_Separator.Size = new System.Drawing.Size(209, 10);
            this.Action_Separator.TabIndex = 2;
            this.Action_Separator.Transparency = 255;
            this.Action_Separator.Vertical = false;
            // 
            // Install_Button
            // 
            this.Install_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Install_Button.Enabled = false;
            this.Install_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Install_Button.ForeColor = System.Drawing.Color.White;
            this.Install_Button.Location = new System.Drawing.Point(12, 170);
            this.Install_Button.Name = "Install_Button";
            this.Install_Button.Size = new System.Drawing.Size(75, 23);
            this.Install_Button.TabIndex = 4;
            this.Install_Button.Text = "Install";
            this.Install_Button.UseVisualStyleBackColor = false;
            this.Install_Button.Click += new System.EventHandler(this.Install_Button_Click);
            // 
            // Uninstall_Button
            // 
            this.Uninstall_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Uninstall_Button.Enabled = false;
            this.Uninstall_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uninstall_Button.ForeColor = System.Drawing.Color.White;
            this.Uninstall_Button.Location = new System.Drawing.Point(146, 170);
            this.Uninstall_Button.Name = "Uninstall_Button";
            this.Uninstall_Button.Size = new System.Drawing.Size(75, 23);
            this.Uninstall_Button.TabIndex = 4;
            this.Uninstall_Button.Text = "Uninstall";
            this.Uninstall_Button.UseVisualStyleBackColor = false;
            this.Uninstall_Button.Click += new System.EventHandler(this.Uninstall_Button_Click);
            // 
            // O_TextBox
            // 
            this.O_TextBox.BackColor = System.Drawing.Color.White;
            this.O_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.O_TextBox.Location = new System.Drawing.Point(338, 27);
            this.O_TextBox.Multiline = true;
            this.O_TextBox.Name = "O_TextBox";
            this.O_TextBox.ReadOnly = true;
            this.O_TextBox.Size = new System.Drawing.Size(435, 342);
            this.O_TextBox.TabIndex = 5;
            this.O_TextBox.Text = "Ready when you are!";
            this.O_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // otherToolsToolStripMenuItem
            // 
            this.otherToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickCommandsToolStripMenuItem});
            this.otherToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.otherToolsToolStripMenuItem.Name = "otherToolsToolStripMenuItem";
            this.otherToolsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.otherToolsToolStripMenuItem.Text = "Other Tools";
            // 
            // quickCommandsToolStripMenuItem
            // 
            this.quickCommandsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.quickCommandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respringToolStripMenuItem,
            this.uICacheToolStripMenuItem});
            this.quickCommandsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quickCommandsToolStripMenuItem.Name = "quickCommandsToolStripMenuItem";
            this.quickCommandsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quickCommandsToolStripMenuItem.Text = "Quick Commands";
            // 
            // respringToolStripMenuItem
            // 
            this.respringToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.respringToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.respringToolStripMenuItem.Name = "respringToolStripMenuItem";
            this.respringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.respringToolStripMenuItem.Text = "Respring";
            this.respringToolStripMenuItem.Click += new System.EventHandler(this.respringToolStripMenuItem_Click);
            // 
            // uICacheToolStripMenuItem
            // 
            this.uICacheToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.uICacheToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.uICacheToolStripMenuItem.Name = "uICacheToolStripMenuItem";
            this.uICacheToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uICacheToolStripMenuItem.Text = "UICache";
            this.uICacheToolStripMenuItem.Click += new System.EventHandler(this.uICacheToolStripMenuItem_Click);
            // 
            // Electralyzed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.O_TextBox);
            this.Controls.Add(this.Uninstall_Button);
            this.Controls.Add(this.Install_Button);
            this.Controls.Add(this.DEB_Button);
            this.Controls.Add(this.DEB_TextBox);
            this.Controls.Add(this.Action_Separator);
            this.Controls.Add(this.DEB_Separator);
            this.Controls.Add(this.Action_Label);
            this.Controls.Add(this.DEB_Label);
            this.Controls.Add(this.MStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MStrip;
            this.Name = "Electralyzed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electralyzed";
            this.MStrip.ResumeLayout(false);
            this.MStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tweakCompatabilitySheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEBDownloaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label DEB_Label;
        private Bunifu.Framework.UI.BunifuSeparator DEB_Separator;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DEB_TextBox;
        private System.Windows.Forms.Button DEB_Button;
        private System.Windows.Forms.Label Action_Label;
        private Bunifu.Framework.UI.BunifuSeparator Action_Separator;
        private System.Windows.Forms.Button Install_Button;
        private System.Windows.Forms.Button Uninstall_Button;
        private System.Windows.Forms.TextBox O_TextBox;
        private System.Windows.Forms.ToolStripMenuItem otherToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uICacheToolStripMenuItem;
    }
}