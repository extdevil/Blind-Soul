namespace Blind_Soul
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this._formMover = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._cloudflareStatus = new System.Windows.Forms.Label();
            this._steamStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._farlightStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._anticheatStatus = new System.Windows.Forms.Label();
            this.autoChecker = new System.Windows.Forms.Timer(this.components);
            this._dllStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._selectPathBtn = new System.Windows.Forms.Button();
            this._gamePath = new System.Windows.Forms.Label();
            this.hack1 = new System.Windows.Forms.CheckBox();
            this.hack2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startHackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _formMover
            // 
            this._formMover.BackColor = System.Drawing.Color.DodgerBlue;
            this._formMover.Dock = System.Windows.Forms.DockStyle.Top;
            this._formMover.ForeColor = System.Drawing.SystemColors.ControlText;
            this._formMover.Location = new System.Drawing.Point(100, 0);
            this._formMover.Name = "_formMover";
            this._formMover.Size = new System.Drawing.Size(468, 10);
            this._formMover.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "BLIND SOUL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(100, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 16);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(100, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "~ by Devil (v1.0)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cloudflare :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Steam :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cloudflareStatus
            // 
            this._cloudflareStatus.AutoSize = true;
            this._cloudflareStatus.BackColor = System.Drawing.Color.Transparent;
            this._cloudflareStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cloudflareStatus.ForeColor = System.Drawing.Color.Tomato;
            this._cloudflareStatus.Location = new System.Drawing.Point(155, 119);
            this._cloudflareStatus.Name = "_cloudflareStatus";
            this._cloudflareStatus.Size = new System.Drawing.Size(144, 21);
            this._cloudflareStatus.TabIndex = 7;
            this._cloudflareStatus.Text = "Not Connnected";
            this._cloudflareStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._cloudflareStatus.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // _steamStatus
            // 
            this._steamStatus.AutoSize = true;
            this._steamStatus.BackColor = System.Drawing.Color.Transparent;
            this._steamStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._steamStatus.ForeColor = System.Drawing.Color.Tomato;
            this._steamStatus.Location = new System.Drawing.Point(155, 154);
            this._steamStatus.Name = "_steamStatus";
            this._steamStatus.Size = new System.Drawing.Size(107, 21);
            this._steamStatus.TabIndex = 8;
            this._steamStatus.Text = "Not Running";
            this._steamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._steamStatus.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Farlight :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _farlightStatus
            // 
            this._farlightStatus.AutoSize = true;
            this._farlightStatus.BackColor = System.Drawing.Color.Transparent;
            this._farlightStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._farlightStatus.ForeColor = System.Drawing.Color.Tomato;
            this._farlightStatus.Location = new System.Drawing.Point(155, 190);
            this._farlightStatus.Name = "_farlightStatus";
            this._farlightStatus.Size = new System.Drawing.Size(107, 21);
            this._farlightStatus.TabIndex = 10;
            this._farlightStatus.Text = "Not Running";
            this._farlightStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._farlightStatus.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Anticheat :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _anticheatStatus
            // 
            this._anticheatStatus.AutoSize = true;
            this._anticheatStatus.BackColor = System.Drawing.Color.Transparent;
            this._anticheatStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._anticheatStatus.ForeColor = System.Drawing.Color.Tomato;
            this._anticheatStatus.Location = new System.Drawing.Point(155, 227);
            this._anticheatStatus.Name = "_anticheatStatus";
            this._anticheatStatus.Size = new System.Drawing.Size(115, 21);
            this._anticheatStatus.TabIndex = 12;
            this._anticheatStatus.Text = "Not Bypassed";
            this._anticheatStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._anticheatStatus.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // autoChecker
            // 
            this.autoChecker.Enabled = true;
            this.autoChecker.Interval = 1000;
            this.autoChecker.Tick += new System.EventHandler(this.autoChecker_Tick);
            // 
            // _dllStatus
            // 
            this._dllStatus.AutoSize = true;
            this._dllStatus.BackColor = System.Drawing.Color.Transparent;
            this._dllStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dllStatus.ForeColor = System.Drawing.Color.Tomato;
            this._dllStatus.Location = new System.Drawing.Point(155, 263);
            this._dllStatus.Name = "_dllStatus";
            this._dllStatus.Size = new System.Drawing.Size(109, 21);
            this._dllStatus.TabIndex = 14;
            this._dllStatus.Text = "Not Injected";
            this._dllStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._dllStatus.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dll :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _selectPathBtn
            // 
            this._selectPathBtn.BackColor = System.Drawing.Color.Transparent;
            this._selectPathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._selectPathBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._selectPathBtn.ForeColor = System.Drawing.Color.White;
            this._selectPathBtn.Location = new System.Drawing.Point(414, 144);
            this._selectPathBtn.Name = "_selectPathBtn";
            this._selectPathBtn.Size = new System.Drawing.Size(151, 31);
            this._selectPathBtn.TabIndex = 15;
            this._selectPathBtn.Text = "Select game path";
            this._selectPathBtn.UseVisualStyleBackColor = false;
            this._selectPathBtn.Click += new System.EventHandler(this._selectPathBtn_Click);
            // 
            // _gamePath
            // 
            this._gamePath.AutoEllipsis = true;
            this._gamePath.BackColor = System.Drawing.Color.Transparent;
            this._gamePath.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._gamePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this._gamePath.Location = new System.Drawing.Point(358, 178);
            this._gamePath.Name = "_gamePath";
            this._gamePath.Size = new System.Drawing.Size(266, 21);
            this._gamePath.TabIndex = 16;
            this._gamePath.Text = "No path selected";
            this._gamePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hack1
            // 
            this.hack1.AutoSize = true;
            this.hack1.Checked = true;
            this.hack1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hack1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.hack1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hack1.Location = new System.Drawing.Point(54, 447);
            this.hack1.Name = "hack1";
            this.hack1.Size = new System.Drawing.Size(15, 14);
            this.hack1.TabIndex = 19;
            this.hack1.UseVisualStyleBackColor = true;
            this.hack1.CheckedChanged += new System.EventHandler(this.hack1_CheckedChanged);
            // 
            // hack2
            // 
            this.hack2.AutoSize = true;
            this.hack2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.hack2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hack2.Location = new System.Drawing.Point(385, 447);
            this.hack2.Name = "hack2";
            this.hack2.Size = new System.Drawing.Size(15, 14);
            this.hack2.TabIndex = 21;
            this.hack2.UseVisualStyleBackColor = true;
            this.hack2.CheckedChanged += new System.EventHandler(this.hack2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(84, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "----------------------------------Select cheat menu------------------------------" +
    "----";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startHackBtn
            // 
            this.startHackBtn.BackColor = System.Drawing.Color.Transparent;
            this.startHackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startHackBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.startHackBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.startHackBtn.Location = new System.Drawing.Point(414, 239);
            this.startHackBtn.Name = "startHackBtn";
            this.startHackBtn.Size = new System.Drawing.Size(151, 31);
            this.startHackBtn.TabIndex = 24;
            this.startHackBtn.Text = "Start hack";
            this.startHackBtn.UseVisualStyleBackColor = false;
            this.startHackBtn.Click += new System.EventHandler(this.startHackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Blind_Soul.Properties.Resources.hack2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(403, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 186);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Blind_Soul.Properties.Resources.hack1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(84, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 186);
            this.panel2.TabIndex = 20;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImage = global::Blind_Soul.Properties.Resources.crossBtn2;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.Location = new System.Drawing.Point(633, 15);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 20);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(103, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(484, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "(C) Copyrights 2023 The Devil. All rights reserved.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(668, 612);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startHackBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hack2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hack1);
            this.Controls.Add(this._gamePath);
            this.Controls.Add(this._selectPathBtn);
            this.Controls.Add(this._dllStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._anticheatStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._farlightStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._steamStatus);
            this.Controls.Add(this._cloudflareStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this._formMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.Text = "Blind Soul - by Devil";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.Shown += new System.EventHandler(this.MainUI_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _formMover;
        private System.Windows.Forms.Panel closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _cloudflareStatus;
        private System.Windows.Forms.Label _steamStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _farlightStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _anticheatStatus;
        private System.Windows.Forms.Timer autoChecker;
        private System.Windows.Forms.Label _dllStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _selectPathBtn;
        private System.Windows.Forms.Label _gamePath;
        private System.Windows.Forms.CheckBox hack1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox hack2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startHackBtn;
        private System.Windows.Forms.Label label8;
    }
}

