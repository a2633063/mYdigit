using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数码之家签到
{
    public partial class Form1 : Form
    {

        int webBrowser1_state = -1;
        int web_max_state = 1;

        string args = null;
        HtmlElementCollection mHtmlAll;
        public Form1()
        {
            InitializeComponent();
            webBrowser1_state = -1;
            btnLogin_Click(null, null);
        }
        public Form1(string[] args)
        {
            this.args = args[0];

            InitializeComponent();
            try
            {
                web_max_state = Convert.ToInt32(this.args);
                webBrowser1_state = 0;
                switch (web_max_state)
                {
                    case 0: this.Text = "数码之家-自动登录"; break;
                    case 1: this.Text = "数码之家-自动登录"; break;
                    case 2: this.Text = "数码之家-自动打卡"; break;
                    case 3: this.Text = "数码之家-打卡后退出"; break;
                }
            }
            catch (Exception)
            {
                this.args = null;
                this.Text = "数码之家-参数错误";
                //throw;
            }
            //MessageBox.Show("args[0]:"+ args[0] +"\r\n+state:"+ web_max_state);
            btnLogin_Click(null, null);
        }

        private void setting_save(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnUrtGo_Click(object sender, EventArgs e)
        {
            if (url.Text.Length < 3)
            {
                url.Text = "http://www.mydigit.cn/u.php";
            }
            if (!url.Text.StartsWith("http://") && !url.Text.StartsWith("https://"))
            {
                url.Text = "http://" + url.Text;
            }
            webBrowser1.Navigate(url.Text);
            webBrowser1_state = -1;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            url.Text = webBrowser1.Url.ToString();
            timer1.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            url.Text = "http://www.mydigit.cn/u.php";
            btnUrtGo_Click(null, null);
            webBrowser1_state = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (web_max_state < webBrowser1_state) return;
            switch (webBrowser1_state)
            {//0:进入登录页面并点击登录;1:确认登录结果;2:点击签到按钮;3:签到完成自动退出;
                case 0: //刚进入http://www.mydigit.cn/u.php页面 判断是否登录过
                    try
                    {
                        if (webBrowser1.Document.All["pwuser"] != null)
                        {
                            if (txtLoginID.Text.Length < 1 || txtLoginPassword.Text.Length < 1)
                            {
                                MessageBox.Show("请先输入账号密码");
                                break;
                            }
                        }
                        webBrowser1.Document.All["pwuser"].SetAttribute("value", txtLoginID.Text);
                        webBrowser1.Document.All["pwpwd"].SetAttribute("value", txtLoginPassword.Text);
                        mHtmlAll = webBrowser1.Document.GetElementsByTagName("Button");

                        if (mHtmlAll.Count < 2) break;
                        for (int i = 0; i < mHtmlAll.Count; i++)
                        {
                            if (mHtmlAll[i].InnerText.Equals("登录"))
                            {
                                mHtmlAll[i].InvokeMember("click");
                                Log.Text = "正在登录...";
                                webBrowser1_state = 1;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //错误,可能已经登录成功,直接判断登录结果 
                        timer1.Enabled = true;
                        webBrowser1_state = 1;
                        //throw;
                    }
                    break;
                case 1:
                    Log.Text = "登录结果....";
                    bool result_login = false;
                    mHtmlAll = webBrowser1.Document.GetElementsByTagName("a");
                    foreach (HtmlElement he in mHtmlAll)
                    {
                        if (he.OuterText != null && he.OuterText.Equals("我的空间"))
                        {
                            result_login = true;

                            break;
                        }
                    }
                    if (result_login)
                    {
                        Log.Text = "登录成功";
                        webBrowser1_state = 2;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        Log.Text = "登录失败!";
                        webBrowser1_state = -1;
                    }
                    break;
                case 2:
                    //登录成功,点击签到按钮
                    bool result_button = false;
                    mHtmlAll = webBrowser1.Document.GetElementsByTagName("span");
                    foreach (HtmlElement he in mHtmlAll)
                    {
                        if (he.OuterText != null)
                            Console.WriteLine(he.OuterText);
                        if (he.OuterText != null && he.OuterText.EndsWith("打卡"))
                        {

                            result_button = true;
                            he.InvokeMember("click");
                            break;
                        }
                    }
                    if (result_button)
                    {
                        Log.Text = "打卡完成";
                        webBrowser1_state = 3;
                    }
                    else
                    {
                        Log.Text = "打卡失败!";
                        webBrowser1_state = -1;
                    }

                    break;
                case 3:
                    if (args != null)
                        this.Close();
                    break;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            web_max_state = 2;
            btnLogin_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
    }
}
