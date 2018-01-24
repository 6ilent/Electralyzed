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
            this.GPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.UPD_Label = new System.Windows.Forms.LinkLabel();
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
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPanel
            // 
            this.GPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GPanel.BackgroundImage")));
            this.GPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GPanel.Controls.Add(this.UPD_Label);
            this.GPanel.Controls.Add(this.C_Label);
            this.GPanel.Controls.Add(this.Connect_Button);
            this.GPanel.Controls.Add(this.Password_TextBox);
            this.GPanel.Controls.Add(this.Password_Label);
            this.GPanel.Controls.Add(this.IP_TextBox);
            this.GPanel.Controls.Add(this.Password_Separator);
            this.GPanel.Controls.Add(this.Connect_Label);
            this.GPanel.Controls.Add(this.Connect_Separator);
            this.GPanel.Controls.Add(this.IP_Label);
            this.GPanel.Controls.Add(this.IP_Separator);
            this.GPanel.Controls.Add(this.Ver_Label);
            this.GPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(79)))), ((int)(((byte)(98)))));
            this.GPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.GPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(79)))), ((int)(((byte)(98)))));
            this.GPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.GPanel.Location = new System.Drawing.Point(0, 0);
            this.GPanel.Name = "GPanel";
            this.GPanel.Quality = 10;
            this.GPanel.Size = new System.Drawing.Size(500, 300);
            this.GPanel.TabIndex = 0;
            // 
            // UPD_Label
            // 
            this.UPD_Label.ActiveLinkColor = System.Drawing.Color.LightSteelBlue;
            this.UPD_Label.AutoSize = true;
            this.UPD_Label.BackColor = System.Drawing.Color.Transparent;
            this.UPD_Label.LinkColor = System.Drawing.Color.LightSteelBlue;
            this.UPD_Label.Location = new System.Drawing.Point(441, 278);
            this.UPD_Label.Name = "UPD_Label";
            this.UPD_Label.Size = new System.Drawing.Size(47, 13);
            this.UPD_Label.TabIndex = 6;
            this.UPD_Label.TabStop = true;
            this.UPD_Label.Text = "Updates";
            this.UPD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UPD_Label.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            this.UPD_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UPD_Label_LinkClicked);
            // 
            // C_Label
            // 
            this.C_Label.AutoSize = true;
            this.C_Label.BackColor = System.Drawing.Color.Transparent;
            this.C_Label.ForeColor = System.Drawing.Color.White;
            this.C_Label.Location = new System.Drawing.Point(230, 278);
            this.C_Label.Name = "C_Label";
            this.C_Label.Size = new System.Drawing.Size(41, 13);
            this.C_Label.TabIndex = 5;
            this.C_Label.Text = "Ready!";
            // 
            // Connect_Button
            // 
            this.Connect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Connect_Button.Location = new System.Drawing.Point(195, 230);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(110, 23);
            this.Connect_Button.TabIndex = 4;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.White;
            this.Password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.Password_TextBox.Location = new System.Drawing.Point(195, 120);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(110, 13);
            this.Password_TextBox.TabIndex = 3;
            this.Password_TextBox.Text = "alpine";
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.Color.White;
            this.Password_Label.Location = new System.Drawing.Point(206, 80);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(86, 20);
            this.Password_Label.TabIndex = 2;
            this.Password_Label.Text = "Password";
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.BackColor = System.Drawing.Color.White;
            this.IP_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(76)))));
            this.IP_TextBox.Location = new System.Drawing.Point(195, 49);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(110, 13);
            this.IP_TextBox.TabIndex = 3;
            this.IP_TextBox.Text = "xxx.xxx.x.xxx";
            this.IP_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_Separator
            // 
            this.Password_Separator.BackColor = System.Drawing.Color.Transparent;
            this.Password_Separator.ForeColor = System.Drawing.Color.White;
            this.Password_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Password_Separator.LineThickness = 2;
            this.Password_Separator.Location = new System.Drawing.Point(195, 103);
            this.Password_Separator.Name = "Password_Separator";
            this.Password_Separator.Size = new System.Drawing.Size(110, 10);
            this.Password_Separator.TabIndex = 1;
            this.Password_Separator.Transparency = 255;
            this.Password_Separator.Vertical = false;
            // 
            // Connect_Label
            // 
            this.Connect_Label.AutoSize = true;
            this.Connect_Label.BackColor = System.Drawing.Color.Transparent;
            this.Connect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Label.ForeColor = System.Drawing.Color.White;
            this.Connect_Label.Location = new System.Drawing.Point(212, 189);
            this.Connect_Label.Name = "Connect_Label";
            this.Connect_Label.Size = new System.Drawing.Size(76, 20);
            this.Connect_Label.TabIndex = 2;
            this.Connect_Label.Text = "Connect";
            // 
            // Connect_Separator
            // 
            this.Connect_Separator.BackColor = System.Drawing.Color.Transparent;
            this.Connect_Separator.ForeColor = System.Drawing.Color.White;
            this.Connect_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Connect_Separator.LineThickness = 2;
            this.Connect_Separator.Location = new System.Drawing.Point(195, 212);
            this.Connect_Separator.Name = "Connect_Separator";
            this.Connect_Separator.Size = new System.Drawing.Size(110, 10);
            this.Connect_Separator.TabIndex = 1;
            this.Connect_Separator.Transparency = 255;
            this.Connect_Separator.Vertical = false;
            // 
            // IP_Label
            // 
            this.IP_Label.AutoSize = true;
            this.IP_Label.BackColor = System.Drawing.Color.Transparent;
            this.IP_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Label.ForeColor = System.Drawing.Color.White;
            this.IP_Label.Location = new System.Drawing.Point(202, 9);
            this.IP_Label.Name = "IP_Label";
            this.IP_Label.Size = new System.Drawing.Size(97, 20);
            this.IP_Label.TabIndex = 2;
            this.IP_Label.Text = "IP Address";
            // 
            // IP_Separator
            // 
            this.IP_Separator.BackColor = System.Drawing.Color.Transparent;
            this.IP_Separator.ForeColor = System.Drawing.Color.White;
            this.IP_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IP_Separator.LineThickness = 2;
            this.IP_Separator.Location = new System.Drawing.Point(195, 32);
            this.IP_Separator.Name = "IP_Separator";
            this.IP_Separator.Size = new System.Drawing.Size(110, 10);
            this.IP_Separator.TabIndex = 1;
            this.IP_Separator.Transparency = 255;
            this.IP_Separator.Vertical = false;
            // 
            // Ver_Label
            // 
            this.Ver_Label.AutoSize = true;
            this.Ver_Label.BackColor = System.Drawing.Color.Transparent;
            this.Ver_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ver_Label.ForeColor = System.Drawing.Color.White;
            this.Ver_Label.Location = new System.Drawing.Point(12, 278);
            this.Ver_Label.Name = "Ver_Label";
            this.Ver_Label.Size = new System.Drawing.Size(45, 13);
            this.Ver_Label.TabIndex = 0;
            this.Ver_Label.Text = "Version ";
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // LoadUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.GPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electralyzed";
            this.Load += new System.EventHandler(this.LoadUp_Load);
            this.GPanel.ResumeLayout(false);
            this.GPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel GPanel;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox IP_TextBox;
        private Bunifu.Framework.UI.BunifuSeparator Password_Separator;
        private System.Windows.Forms.Label IP_Label;
        private Bunifu.Framework.UI.BunifuSeparator IP_Separator;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private System.Windows.Forms.Label C_Label;
        private System.Windows.Forms.Label Ver_Label;
        private System.Windows.Forms.LinkLabel UPD_Label;
        private System.Windows.Forms.Label Connect_Label;
        private Bunifu.Framework.UI.BunifuSeparator Connect_Separator;
    }
}

