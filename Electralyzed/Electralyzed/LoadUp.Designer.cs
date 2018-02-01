namespace Electralyzed
{
    partial class LoadUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadUp));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UPD_Label = new System.Windows.Forms.Label();
            this.UPD_Switch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.Min_Label = new System.Windows.Forms.Label();
            this.Exit_Label = new System.Windows.Forms.Label();
            this.G_Label = new System.Windows.Forms.LinkLabel();
            this.C_Label = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.Password_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Connect_Label = new System.Windows.Forms.Label();
            this.Connect_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.IP_Label = new System.Windows.Forms.Label();
            this.IP_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Ver_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 10;
            this.Elipse.TargetControl = this;
            // 
            // UPD_Label
            // 
            this.UPD_Label.AutoSize = true;
            this.UPD_Label.BackColor = System.Drawing.Color.Transparent;
            this.UPD_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UPD_Label.ForeColor = System.Drawing.Color.White;
            this.UPD_Label.Location = new System.Drawing.Point(8, 9);
            this.UPD_Label.Name = "UPD_Label";
            this.UPD_Label.Size = new System.Drawing.Size(84, 13);
            this.UPD_Label.TabIndex = 26;
            this.UPD_Label.Text = "Update Checks:";
            // 
            // UPD_Switch
            // 
            this.UPD_Switch.BackColor = System.Drawing.Color.Transparent;
            this.UPD_Switch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UPD_Switch.BackgroundImage")));
            this.UPD_Switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UPD_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPD_Switch.Location = new System.Drawing.Point(11, 25);
            this.UPD_Switch.Name = "UPD_Switch";
            this.UPD_Switch.OffColor = System.Drawing.Color.Gray;
            this.UPD_Switch.OnColor = System.Drawing.Color.LightSteelBlue;
            this.UPD_Switch.Size = new System.Drawing.Size(35, 20);
            this.UPD_Switch.TabIndex = 25;
            this.UPD_Switch.Value = true;
            this.UPD_Switch.OnValueChange += new System.EventHandler(this.UPD_Switch_OnValueChange);
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.BackColor = System.Drawing.Color.Transparent;
            this.Min_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Min_Label.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Min_Label.Location = new System.Drawing.Point(451, 9);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(17, 18);
            this.Min_Label.TabIndex = 24;
            this.Min_Label.Text = "_";
            this.Min_Label.Click += new System.EventHandler(this.Min_Label_Click);
            // 
            // Exit_Label
            // 
            this.Exit_Label.AutoSize = true;
            this.Exit_Label.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Label.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Exit_Label.Location = new System.Drawing.Point(474, 9);
            this.Exit_Label.Name = "Exit_Label";
            this.Exit_Label.Size = new System.Drawing.Size(19, 18);
            this.Exit_Label.TabIndex = 23;
            this.Exit_Label.Text = "X";
            this.Exit_Label.Click += new System.EventHandler(this.Exit_Label_Click);
            // 
            // G_Label
            // 
            this.G_Label.ActiveLinkColor = System.Drawing.Color.LightSteelBlue;
            this.G_Label.AutoSize = true;
            this.G_Label.BackColor = System.Drawing.Color.Transparent;
            this.G_Label.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.G_Label.Location = new System.Drawing.Point(453, 278);
            this.G_Label.Name = "G_Label";
            this.G_Label.Size = new System.Drawing.Size(40, 13);
            this.G_Label.TabIndex = 22;
            this.G_Label.TabStop = true;
            this.G_Label.Text = "GitHub";
            this.G_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.G_Label.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            this.G_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.G_Label_LinkClicked);
            // 
            // C_Label
            // 
            this.C_Label.AutoSize = true;
            this.C_Label.BackColor = System.Drawing.Color.Transparent;
            this.C_Label.ForeColor = System.Drawing.Color.White;
            this.C_Label.Location = new System.Drawing.Point(235, 278);
            this.C_Label.Name = "C_Label";
            this.C_Label.Size = new System.Drawing.Size(41, 13);
            this.C_Label.TabIndex = 21;
            this.C_Label.Text = "Ready!";
            // 
            // Connect_Button
            // 
            this.Connect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Connect_Button.Location = new System.Drawing.Point(200, 230);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(110, 23);
            this.Connect_Button.TabIndex = 20;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.White;
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Password_TextBox.Location = new System.Drawing.Point(200, 120);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(110, 13);
            this.Password_TextBox.TabIndex = 18;
            this.Password_TextBox.Text = "alpine";
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.White;
            this.Password_Label.Location = new System.Drawing.Point(211, 80);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(86, 20);
            this.Password_Label.TabIndex = 15;
            this.Password_Label.Text = "Password";
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.BackColor = System.Drawing.Color.White;
            this.IP_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.IP_TextBox.Location = new System.Drawing.Point(200, 49);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(110, 13);
            this.IP_TextBox.TabIndex = 19;
            this.IP_TextBox.Text = "xxx.xxx.x.xxx";
            this.IP_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Separator
            // 
            this.Password_Separator.BackColor = System.Drawing.Color.Transparent;
            this.Password_Separator.ForeColor = System.Drawing.Color.White;
            this.Password_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Password_Separator.LineThickness = 2;
            this.Password_Separator.Location = new System.Drawing.Point(200, 103);
            this.Password_Separator.Name = "Password_Separator";
            this.Password_Separator.Size = new System.Drawing.Size(110, 10);
            this.Password_Separator.TabIndex = 12;
            this.Password_Separator.Transparency = 255;
            this.Password_Separator.Vertical = false;
            // 
            // Connect_Label
            // 
            this.Connect_Label.AutoSize = true;
            this.Connect_Label.BackColor = System.Drawing.Color.Transparent;
            this.Connect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Label.ForeColor = System.Drawing.Color.White;
            this.Connect_Label.Location = new System.Drawing.Point(217, 189);
            this.Connect_Label.Name = "Connect_Label";
            this.Connect_Label.Size = new System.Drawing.Size(76, 20);
            this.Connect_Label.TabIndex = 16;
            this.Connect_Label.Text = "Connect";
            // 
            // Connect_Separator
            // 
            this.Connect_Separator.BackColor = System.Drawing.Color.Transparent;
            this.Connect_Separator.ForeColor = System.Drawing.Color.White;
            this.Connect_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Connect_Separator.LineThickness = 2;
            this.Connect_Separator.Location = new System.Drawing.Point(200, 212);
            this.Connect_Separator.Name = "Connect_Separator";
            this.Connect_Separator.Size = new System.Drawing.Size(110, 10);
            this.Connect_Separator.TabIndex = 13;
            this.Connect_Separator.Transparency = 255;
            this.Connect_Separator.Vertical = false;
            // 
            // IP_Label
            // 
            this.IP_Label.AutoSize = true;
            this.IP_Label.BackColor = System.Drawing.Color.Transparent;
            this.IP_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Label.ForeColor = System.Drawing.Color.White;
            this.IP_Label.Location = new System.Drawing.Point(207, 9);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(97, 20);
            this.IP_Label.TabIndex = 17;
            this.IP_Label.Text = "IP Address";
            // 
            // IP_Separator
            // 
            this.IP_Separator.BackColor = System.Drawing.Color.Transparent;
            this.IP_Separator.ForeColor = System.Drawing.Color.White;
            this.IP_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IP_Separator.LineThickness = 2;
            this.IP_Separator.Location = new System.Drawing.Point(200, 32);
            this.IP_Separator.Name = "IP_Separator";
            this.IP_Separator.Size = new System.Drawing.Size(110, 10);
            this.IP_Separator.TabIndex = 14;
            this.IP_Separator.Transparency = 255;
            this.IP_Separator.Vertical = false;
            // 
            // Ver_Label
            // 
            this.Ver_Label.AutoSize = true;
            this.Ver_Label.BackColor = System.Drawing.Color.Transparent;
            this.Ver_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver_Label.ForeColor = System.Drawing.Color.White;
            this.Ver_Label.Location = new System.Drawing.Point(17, 278);
            this.Ver_Label.Name = "Ver_Label";
            this.Ver_Label.Size = new System.Drawing.Size(45, 13);
            this.Ver_Label.TabIndex = 11;
            this.Ver_Label.Text = "Version ";
            // 
            // LoadUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Electralyzed.Properties.Resources.LoadUP_Background;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.UPD_Label);
            this.Controls.Add(this.UPD_Switch);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.Exit_Label);
            this.Controls.Add(this.G_Label);
            this.Controls.Add(this.C_Label);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.IP_TextBox);
            this.Controls.Add(this.Password_Separator);
            this.Controls.Add(this.Connect_Label);
            this.Controls.Add(this.Connect_Separator);
            this.Controls.Add(this.IP_Label);
            this.Controls.Add(this.IP_Separator);
            this.Controls.Add(this.Ver_Label);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electralyzed";
            this.Load += new System.EventHandler(this.LoadUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label UPD_Label;
        private Bunifu.Framework.UI.BunifuiOSSwitch UPD_Switch;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.LinkLabel G_Label;
        private System.Windows.Forms.Label C_Label;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox IP_TextBox;
        private Bunifu.Framework.UI.BunifuSeparator Password_Separator;
        private System.Windows.Forms.Label Connect_Label;
        private Bunifu.Framework.UI.BunifuSeparator Connect_Separator;
        private System.Windows.Forms.Label IP_Label;
        private Bunifu.Framework.UI.BunifuSeparator IP_Separator;
        private System.Windows.Forms.Label Ver_Label;
    }
}

