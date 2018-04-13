namespace 数码之家签到
{
    partial class FrmAbout
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAbout = new System.Windows.Forms.GroupBox();
            this.groupBoxAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(200, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 134);
            this.label1.TabIndex = 1;
            this.label1.Text = "版本更新\r\n参数功能:\r\n0:自动登录\r\n1:自动登录\r\n2:自动签到\r\n3:签到后退出\r\n其他:无效\r\n\r\n\r\n作者:Zip\r\n邮箱:Zip_zhang@fox" +
    "mail.com";
            // 
            // groupBoxAbout
            // 
            this.groupBoxAbout.Controls.Add(this.btnClose);
            this.groupBoxAbout.Controls.Add(this.label1);
            this.groupBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAbout.Name = "groupBoxAbout";
            this.groupBoxAbout.Size = new System.Drawing.Size(294, 154);
            this.groupBoxAbout.TabIndex = 1;
            this.groupBoxAbout.TabStop = false;
            this.groupBoxAbout.Text = "当前版本:";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 175);
            this.Controls.Add(this.groupBoxAbout);
            this.Name = "FrmAbout";
            this.Text = "FrmAbout";
            this.groupBoxAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAbout;
    }
}