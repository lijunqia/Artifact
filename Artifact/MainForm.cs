using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;

//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using Artifact.Api;

using System.Text.RegularExpressions;
namespace Artifact
{
    public partial class MainForm : Form
    {
        private int maxId = 0;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += " - "+Program.user.user_code;
                switch (Int32.Parse(Program.user.role_id))
                {
                    case 1://管理员
                        this.groupBoxMessage.Visible = true;
                        this.groupBoxUser.Visible = true;
                        break;
                    case 2://信息
                        this.groupBoxMessage.Visible = true;
                        this.groupBoxUser.Visible = false;
                        break;
                    case 3://用户 
                        this.groupBoxMessage.Visible = false;
                        this.groupBoxUser.Visible = true;
                        break;
                    case 4://会员
                    case 5://体验会员
                    default:
                        this.groupBoxUser.Visible = false;
                        this.groupBoxMessage.Visible = false;
                        break;
                }
                /*
                if (Program.user.user_is_service == "1")
                {
                    this.buttonChat.Visible = false;
                }
                else
                {
                    this.buttonChat.Visible = true;
                }
                */
                this.setMessage(10);


            }
            catch (Exception )
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }

        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            this.setMessage(20);

        }
        /// <summary>
        /// 获取信息并显示
        /// </summary>
        /// <param name="size">获取条数</param>
        private void setMessage(int size=10)
        {
            try
            {
                this.richTextBoxMessageList.Select(this.richTextBoxMessageList.TextLength, 0);
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.Message> messages = res.MessageList(this.maxId,0, size);
                if (messages != null)
                {
                    foreach (Artifact.Api.Message message in messages)
                    {
                        this.richTextBoxMessageList.AppendText(message.message_time + "\n" + message.message_text + "\n\n");
                        if (this.maxId < Int32.Parse(message.message_id))
                            this.maxId = Int32.Parse(message.message_id);

                    }

                    Regex regImg = new Regex(@"(?i)<img\b[^>]*?src\s*=(['""]?)(?<imgUrl>[^'""]+)\1[^>]*?>");
                    MatchCollection matches = regImg.Matches(this.richTextBoxMessageList.Text);

                    string[] sUrlList = new string[matches.Count];
                    foreach (Match match in matches)
                    {

                        string url = @match.Groups["imgUrl"].Value;
                        Bitmap bmp = new Bitmap((new System.Net.WebClient()).OpenRead(url));
                        Clipboard.SetImage(bmp);
                        string src = "<img src='" + url + "' />";
                        int pos = this.richTextBoxMessageList.Find(src);
                        this.richTextBoxMessageList.Select(pos, src.Length);
                        this.richTextBoxMessageList.Paste();
                        this.richTextBoxMessageList.Refresh();
                        Clipboard.Clear();
                    }

                    //让文本框获取焦点
                    this.richTextBoxMessageList.Focus();
                    //设置光标的位置到文本尾
                    this.richTextBoxMessageList.Select(this.richTextBoxMessageList.TextLength, 0);
                    //滚动到控件光标处
                    this.richTextBoxMessageList.ScrollToCaret();
                    if (this.WindowState == FormWindowState.Minimized)
                        this.WindowState = FormWindowState.Normal;

                    String wav = @"msg.wav";
                    if (System.IO.File.Exists(wav))
                    {
                        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(wav);
                        sp.Play();
                    }
                }

            }
            catch (Exception )
            {
                //MessageBox.Show("登录过期！" + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int pos = this.richTextBoxMessageList.Find(this.textBoxKey.Text);
            this.richTextBoxMessageList.Select(pos, this.textBoxKey.Text.Length);
            this.richTextBoxMessageList.SelectionColor = Color.Red;
            this.richTextBoxMessageList.Focus();
        }

        private void buttonMessageAdd_Click(object sender, EventArgs e)
        {
            MessageAddForm frm = new MessageAddForm();
            frm.ShowDialog();

        }

        private void buttonMessageList_Click(object sender, EventArgs e)
        {

            MessageListForm frm = new MessageListForm();
            frm.ShowDialog();
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {

            UserCreateForm frm = new UserCreateForm();
            frm.ShowDialog();
        }

        private void buttonUserList_Click(object sender, EventArgs e)
        {
            UserListForm frm = new UserListForm();
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            UserResetPasswordForm frm = new UserResetPasswordForm();
            frm.ShowDialog();

        }

        private void richTextBoxMessageList_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", e.LinkText);

        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            ChatForm frm = new ChatForm();
            frm.Show();

        }

    }

}
