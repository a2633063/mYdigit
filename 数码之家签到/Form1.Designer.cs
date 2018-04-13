namespace 数码之家签到
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.btnUrtGo = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel_Log = new System.Windows.Forms.Panel();
            this.Log = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.ProxyPort = new System.Windows.Forms.NumericUpDown();
            this.ProxyPW = new System.Windows.Forms.TextBox();
            this.ProxyID = new System.Windows.Forms.TextBox();
            this.ProxyUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProxyPort)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 171);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1047, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkUseProxy);
            this.groupBox1.Controls.Add(this.ProxyPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProxyPW);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProxyID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProxyUrl);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(757, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 126);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代理设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "代理地址:";
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(6, 20);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(72, 16);
            this.chkUseProxy.TabIndex = 108;
            this.chkUseProxy.Text = "使用代理";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            // 
            // btnUrtGo
            // 
            this.btnUrtGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrtGo.Location = new System.Drawing.Point(1003, 144);
            this.btnUrtGo.Name = "btnUrtGo";
            this.btnUrtGo.Size = new System.Drawing.Size(56, 21);
            this.btnUrtGo.TabIndex = 116;
            this.btnUrtGo.Text = "Go";
            this.btnUrtGo.UseVisualStyleBackColor = true;
            this.btnUrtGo.Click += new System.EventHandler(this.btnUrtGo_Click);
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url.Location = new System.Drawing.Point(12, 144);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(985, 21);
            this.url.TabIndex = 115;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSign);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLoginPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLoginID);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 126);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网页登录设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(183, 72);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel_Log
            // 
            this.panel_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Log.Controls.Add(this.Log);
            this.panel_Log.Controls.Add(this.button1);
            this.panel_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Log.Location = new System.Drawing.Point(0, 680);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(1071, 20);
            this.panel_Log.TabIndex = 118;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(0, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(994, 18);
            this.Log.TabIndex = 0;
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(102, 72);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 7;
            this.btnSign.Text = "打卡";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::数码之家签到.Properties.Settings.Default, "txtLoginPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLoginPassword.Location = new System.Drawing.Point(59, 41);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(199, 21);
            this.txtLoginPassword.TabIndex = 4;
            this.txtLoginPassword.Text = global::数码之家签到.Properties.Settings.Default.txtLoginPassword;
            this.txtLoginPassword.Leave += new System.EventHandler(this.setting_save);
            // 
            // txtLoginID
            // 
            this.txtLoginID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::数码之家签到.Properties.Settings.Default, "txtLoginID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLoginID.Location = new System.Drawing.Point(59, 14);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(199, 21);
            this.txtLoginID.TabIndex = 2;
            this.txtLoginID.Text = global::数码之家签到.Properties.Settings.Default.txtLoginID;
            this.txtLoginID.Leave += new System.EventHandler(this.setting_save);
            // 
            // ProxyPort
            // 
            this.ProxyPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::数码之家签到.Properties.Settings.Default, "ProxyPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyPort.Location = new System.Drawing.Point(236, 42);
            this.ProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ProxyPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProxyPort.Name = "ProxyPort";
            this.ProxyPort.Size = new System.Drawing.Size(55, 21);
            this.ProxyPort.TabIndex = 107;
            this.ProxyPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProxyPort.Value = global::数码之家签到.Properties.Settings.Default.ProxyPort;
            // 
            // ProxyPW
            // 
            this.ProxyPW.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::数码之家签到.Properties.Settings.Default, "ProxyPW", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyPW.Location = new System.Drawing.Point(69, 96);
            this.ProxyPW.Name = "ProxyPW";
            this.ProxyPW.PasswordChar = '*';
            this.ProxyPW.Size = new System.Drawing.Size(222, 21);
            this.ProxyPW.TabIndex = 4;
            this.ProxyPW.Text = global::数码之家签到.Properties.Settings.Default.ProxyPW;
            this.ProxyPW.Leave += new System.EventHandler(this.setting_save);
            // 
            // ProxyID
            // 
            this.ProxyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::数码之家签到.Properties.Settings.Default, "ProxyID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyID.Location = new System.Drawing.Point(69, 69);
            this.ProxyID.Name = "ProxyID";
            this.ProxyID.Size = new System.Drawing.Size(222, 21);
            this.ProxyID.TabIndex = 2;
            this.ProxyID.Text = global::数码之家签到.Properties.Settings.Default.ProxyID;
            this.ProxyID.Leave += new System.EventHandler(this.setting_save);
            // 
            // ProxyUrl
            // 
            this.ProxyUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::数码之家签到.Properties.Settings.Default, "ProxyUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProxyUrl.Location = new System.Drawing.Point(69, 42);
            this.ProxyUrl.Name = "ProxyUrl";
            this.ProxyUrl.Size = new System.Drawing.Size(161, 21);
            this.ProxyUrl.TabIndex = 0;
            this.ProxyUrl.Text = global::数码之家签到.Properties.Settings.Default.ProxyUrl;
            this.ProxyUrl.Leave += new System.EventHandler(this.setting_save);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(994, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 18);
            this.button1.TabIndex = 1;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 700);
            this.Controls.Add(this.panel_Log);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUrtGo);
            this.Controls.Add(this.url);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "数码之家";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProxyPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.NumericUpDown ProxyPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProxyPW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProxyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProxyUrl;
        private System.Windows.Forms.Button btnUrtGo;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel_Log;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button button1;
    }
}

