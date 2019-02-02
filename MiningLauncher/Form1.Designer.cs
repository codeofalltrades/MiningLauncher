namespace MiningLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblunknown = new System.Windows.Forms.Label();
            this.txtMinerExePath = new System.Windows.Forms.TextBox();
            this.ctrMainPoolUrl = new System.Windows.Forms.TextBox();
            this.ctrMainPoolWorkerUsername = new System.Windows.Forms.TextBox();
            this.ctrMainPoolWorkerPassword = new System.Windows.Forms.TextBox();
            this.btnSuperDefault = new System.Windows.Forms.Button();
            this.btnVeilDefault = new System.Windows.Forms.Button();
            this.ctrIntensity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctrMainPoolAlgo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTrex = new System.Windows.Forms.Button();
            this.btnCCminer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrDevices = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrRetries = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctrRetryPause = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ctrTimeout = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ctrTimeLimit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ctrTempColor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrRestartTemp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ctrMaxTemp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCoinblockersDefault = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(498, 369);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 37);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(594, 369);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 37);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events:";
            // 
            // txtEventLog
            // 
            this.txtEventLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEventLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEventLog.Location = new System.Drawing.Point(13, 493);
            this.txtEventLog.Multiline = true;
            this.txtEventLog.Name = "txtEventLog";
            this.txtEventLog.ReadOnly = true;
            this.txtEventLog.Size = new System.Drawing.Size(671, 98);
            this.txtEventLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miner .exe file path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Worker username:";
            // 
            // lblunknown
            // 
            this.lblunknown.AutoSize = true;
            this.lblunknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunknown.Location = new System.Drawing.Point(340, 77);
            this.lblunknown.Name = "lblunknown";
            this.lblunknown.Size = new System.Drawing.Size(136, 20);
            this.lblunknown.TabIndex = 7;
            this.lblunknown.Text = "Worker password:";
            // 
            // txtMinerExePath
            // 
            this.txtMinerExePath.Location = new System.Drawing.Point(11, 51);
            this.txtMinerExePath.Name = "txtMinerExePath";
            this.txtMinerExePath.Size = new System.Drawing.Size(516, 20);
            this.txtMinerExePath.TabIndex = 1;
            // 
            // ctrMainPoolUrl
            // 
            this.ctrMainPoolUrl.Location = new System.Drawing.Point(8, 44);
            this.ctrMainPoolUrl.Name = "ctrMainPoolUrl";
            this.ctrMainPoolUrl.Size = new System.Drawing.Size(508, 26);
            this.ctrMainPoolUrl.TabIndex = 7;
            // 
            // ctrMainPoolWorkerUsername
            // 
            this.ctrMainPoolWorkerUsername.Location = new System.Drawing.Point(150, 97);
            this.ctrMainPoolWorkerUsername.Name = "ctrMainPoolWorkerUsername";
            this.ctrMainPoolWorkerUsername.Size = new System.Drawing.Size(177, 26);
            this.ctrMainPoolWorkerUsername.TabIndex = 9;
            // 
            // ctrMainPoolWorkerPassword
            // 
            this.ctrMainPoolWorkerPassword.Location = new System.Drawing.Point(339, 97);
            this.ctrMainPoolWorkerPassword.Name = "ctrMainPoolWorkerPassword";
            this.ctrMainPoolWorkerPassword.Size = new System.Drawing.Size(177, 26);
            this.ctrMainPoolWorkerPassword.TabIndex = 10;
            // 
            // btnSuperDefault
            // 
            this.btnSuperDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuperDefault.Location = new System.Drawing.Point(6, 25);
            this.btnSuperDefault.Name = "btnSuperDefault";
            this.btnSuperDefault.Size = new System.Drawing.Size(121, 30);
            this.btnSuperDefault.TabIndex = 15;
            this.btnSuperDefault.Text = "Suprnova";
            this.btnSuperDefault.UseVisualStyleBackColor = true;
            this.btnSuperDefault.Click += new System.EventHandler(this.btnSuperDefault_Click);
            // 
            // btnVeilDefault
            // 
            this.btnVeilDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeilDefault.Location = new System.Drawing.Point(6, 61);
            this.btnVeilDefault.Name = "btnVeilDefault";
            this.btnVeilDefault.Size = new System.Drawing.Size(121, 29);
            this.btnVeilDefault.TabIndex = 16;
            this.btnVeilDefault.Text = "Veilmine";
            this.btnVeilDefault.UseVisualStyleBackColor = true;
            this.btnVeilDefault.Click += new System.EventHandler(this.btnVeilDefault_Click);
            // 
            // ctrIntensity
            // 
            this.ctrIntensity.Location = new System.Drawing.Point(8, 53);
            this.ctrIntensity.Name = "ctrIntensity";
            this.ctrIntensity.Size = new System.Drawing.Size(81, 26);
            this.ctrIntensity.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Intensity:";
            // 
            // ctrMainPoolAlgo
            // 
            this.ctrMainPoolAlgo.Location = new System.Drawing.Point(8, 97);
            this.ctrMainPoolAlgo.Name = "ctrMainPoolAlgo";
            this.ctrMainPoolAlgo.Size = new System.Drawing.Size(125, 26);
            this.ctrMainPoolAlgo.TabIndex = 8;
            this.ctrMainPoolAlgo.TextChanged += new System.EventHandler(this.ctrMainPoolAlgo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Algorithm:";
            // 
            // btnTrex
            // 
            this.btnTrex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrex.Location = new System.Drawing.Point(6, 61);
            this.btnTrex.Name = "btnTrex";
            this.btnTrex.Size = new System.Drawing.Size(121, 29);
            this.btnTrex.TabIndex = 28;
            this.btnTrex.Text = "T-Rex";
            this.btnTrex.UseVisualStyleBackColor = true;
            this.btnTrex.Click += new System.EventHandler(this.btnTrex_Click);
            // 
            // btnCCminer
            // 
            this.btnCCminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCminer.Location = new System.Drawing.Point(6, 25);
            this.btnCCminer.Name = "btnCCminer";
            this.btnCCminer.Size = new System.Drawing.Size(121, 30);
            this.btnCCminer.TabIndex = 27;
            this.btnCCminer.Text = "CC Miner";
            this.btnCCminer.UseVisualStyleBackColor = true;
            this.btnCCminer.Click += new System.EventHandler(this.btnCCminer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ctrDevices
            // 
            this.ctrDevices.Location = new System.Drawing.Point(95, 53);
            this.ctrDevices.Name = "ctrDevices";
            this.ctrDevices.Size = new System.Drawing.Size(112, 26);
            this.ctrDevices.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Devices";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrMainPoolUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblunknown);
            this.groupBox1.Controls.Add(this.ctrMainPoolWorkerUsername);
            this.groupBox1.Controls.Add(this.ctrMainPoolWorkerPassword);
            this.groupBox1.Controls.Add(this.ctrMainPoolAlgo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 134);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Pool";
            // 
            // ctrRetries
            // 
            this.ctrRetries.Location = new System.Drawing.Point(112, 47);
            this.ctrRetries.Name = "ctrRetries";
            this.ctrRetries.Size = new System.Drawing.Size(98, 26);
            this.ctrRetries.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Retries:";
            // 
            // ctrRetryPause
            // 
            this.ctrRetryPause.Location = new System.Drawing.Point(218, 47);
            this.ctrRetryPause.Name = "ctrRetryPause";
            this.ctrRetryPause.Size = new System.Drawing.Size(98, 26);
            this.ctrRetryPause.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(218, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Retry Pause:";
            // 
            // ctrTimeout
            // 
            this.ctrTimeout.Location = new System.Drawing.Point(6, 47);
            this.ctrTimeout.Name = "ctrTimeout";
            this.ctrTimeout.Size = new System.Drawing.Size(98, 26);
            this.ctrTimeout.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Timeout:";
            // 
            // ctrTimeLimit
            // 
            this.ctrTimeLimit.Location = new System.Drawing.Point(324, 47);
            this.ctrTimeLimit.Name = "ctrTimeLimit";
            this.ctrTimeLimit.Size = new System.Drawing.Size(98, 26);
            this.ctrTimeLimit.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(324, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Time Limit:";
            // 
            // ctrTempColor
            // 
            this.ctrTempColor.Location = new System.Drawing.Point(11, 46);
            this.ctrTempColor.Name = "ctrTempColor";
            this.ctrTempColor.Size = new System.Drawing.Size(80, 22);
            this.ctrTempColor.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Color:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrRestartTemp);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.ctrMaxTemp);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.ctrTempColor);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(213, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 81);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature Settings";
            // 
            // ctrRestartTemp
            // 
            this.ctrRestartTemp.Location = new System.Drawing.Point(193, 46);
            this.ctrRestartTemp.Name = "ctrRestartTemp";
            this.ctrRestartTemp.Size = new System.Drawing.Size(110, 22);
            this.ctrRestartTemp.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(193, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 99;
            this.label17.Text = "Restart Temp:";
            // 
            // ctrMaxTemp
            // 
            this.ctrMaxTemp.Location = new System.Drawing.Point(101, 46);
            this.ctrMaxTemp.Name = "ctrMaxTemp";
            this.ctrMaxTemp.Size = new System.Drawing.Size(80, 22);
            this.ctrMaxTemp.TabIndex = 5;
            this.ctrMaxTemp.TextChanged += new System.EventHandler(this.ctrMaxTemp_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(101, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Max Temp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctrRetries);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ctrTimeLimit);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.ctrRetryPause);
            this.groupBox3.Controls.Add(this.ctrTimeout);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 83);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network Settings";
            // 
            // btnCoinblockersDefault
            // 
            this.btnCoinblockersDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinblockersDefault.Location = new System.Drawing.Point(6, 96);
            this.btnCoinblockersDefault.Name = "btnCoinblockersDefault";
            this.btnCoinblockersDefault.Size = new System.Drawing.Size(121, 29);
            this.btnCoinblockersDefault.TabIndex = 45;
            this.btnCoinblockersDefault.Text = "Coinblockers";
            this.btnCoinblockersDefault.UseVisualStyleBackColor = true;
            this.btnCoinblockersDefault.Click += new System.EventHandler(this.btnCoinblockersDefault_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ctrIntensity);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.ctrDevices);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 105);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GPU Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSuperDefault);
            this.groupBox5.Controls.Add(this.btnCoinblockersDefault);
            this.groupBox5.Controls.Add(this.btnVeilDefault);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(549, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 134);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pool Defaults";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCCminer);
            this.groupBox6.Controls.Add(this.btnTrex);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(549, 192);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(135, 97);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Miner Defaults";
            // 
            // txtArguments
            // 
            this.txtArguments.Location = new System.Drawing.Point(13, 444);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(671, 20);
            this.txtArguments.TabIndex = 50;
            this.txtArguments.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Command parameters:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(700, 601);
            this.Controls.Add(this.txtArguments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMinerExePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mining Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblunknown;
        private System.Windows.Forms.TextBox txtMinerExePath;
        private System.Windows.Forms.TextBox ctrMainPoolUrl;
        private System.Windows.Forms.TextBox ctrMainPoolWorkerUsername;
        private System.Windows.Forms.TextBox ctrMainPoolWorkerPassword;
        private System.Windows.Forms.Button btnSuperDefault;
        private System.Windows.Forms.Button btnVeilDefault;
        private System.Windows.Forms.TextBox ctrIntensity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctrMainPoolAlgo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTrex;
        private System.Windows.Forms.Button btnCCminer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox ctrDevices;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ctrRetries;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ctrRetryPause;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ctrTimeout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ctrTimeLimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ctrTempColor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ctrRestartTemp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ctrMaxTemp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCoinblockersDefault;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label5;
    }
}

