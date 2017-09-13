using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using Artifact.Api;

using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
namespace Artifact
{
    public partial class ChatForm : Form
    {
        private int maxId = 0;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void buttonCaputre_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(500);

            Image img = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            Graphics g = Graphics.FromImage(img);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);

            ScreenForm snap = new ScreenForm();
            snap.BackgroundImage = img;

            if (snap.ShowDialog() == DialogResult.OK)
            {
                //获取RichTextBox控件中鼠标焦点的索引位置 
                int startPosition = this.richTextBoxChat.SelectionStart;
                //从鼠标焦点处开始选中几个字符
                //this.richTextBoxMessage.SelectionLength = 2;
                //将图片粘贴到鼠标焦点位置(由于有选中2个字符，所以那2个字符会被图片覆盖)
                this.richTextBoxChat.Paste();
                Clipboard.Clear();
            }
            Thread.Sleep(300);
            this.Show();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (this.richTextBoxChat.Text == "")
            {
                MessageBox.Show("请填写信息。", "提示信息");
                this.richTextBoxChat.Focus();
                return;
            }

            try
            {
                //label1.Text = "正在发布中。。。。";
                Response res = new Response();

                Artifact.Api.Chat chat = new Api.Chat();
                string filePath = Application.StartupPath + "\\chat\\" + DateTime.Now.ToString("yyyyMMdd") + "\\";//存放到相对路径

                Random seed = new Random();


                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                string text = "";
                for (int i = 0; i < this.richTextBoxChat.TextLength; i++)
                {
                    this.richTextBoxChat.Select(i, 1);
                    RichTextBoxSelectionTypes rt = this.richTextBoxChat.SelectionType;
                    //MessageBox.Show(rt.ToString());
                    if (rt == RichTextBoxSelectionTypes.Object)
                    {
                        //label1.Text = "正在上传截图。。。。";
                        //当然也可能是其它的类型
                        //MessageBox.Show("这是一个图片");
                        this.richTextBoxChat.Copy();
                        Image img = Clipboard.GetImage();
                        if (img != null)
                        {
                            //string snapPath = filePath + DateTime.Now.ToString("HHmmss") + seed.Next(10, 99).ToString() + ".jpg";
                            //img.Save(snapPath, ImageFormat.Jpeg);

                            //上传到服务器
                            Snap snap = res.ChatUpload(img);
                            img.Dispose();

                            if (snap != null)
                            {
                                text += "<img src=\"" + snap.url + "\" data-preview-src=\"\" data-preview-group=\"1\"  class=\"msg-content-image\" />";
                            }
                        }
                        //label1.Text = "上传完成";
                    }
                    else
                        text += this.richTextBoxChat.SelectedText;

                }

                chat.chat_text = text;
                if (this.listBoxService.Items.Count > 0)
                {
                    User user = (User)this.listBoxService.SelectedItem;
                    chat.chat_user_id = user.user_id;
                }
                Artifact.Api.Chat chat_add = res.ChatCreate(chat);
                if (chat_add != null)
                {
                    this.richTextBoxChat.Text = "";
                    //MessageBox.Show("发布成功！", "提示信息");
                }
                else
                    MessageBox.Show("发布失败！" + res.message, "提示信息");

                //label1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取信息出错！" + ex.Message);
            }
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            try
            {
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.User> users =null;
                if(Program.user.user_is_service == "1")
                    users = res.ChatUser();
                else
                    users = res.UserService();
                if (users != null)
                {
                    this.bindingSourceService.DataSource = users;
                    this.listBoxService.DisplayMember = "user_name";
                    this.listBoxService.ValueMember = "user_id";
                    User user = selectUser();
                    this.labelCurrent.Text = user.user_name;
                }
                refreshChat();
            }
            catch (Exception)
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }
        }

        private void listBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = selectUser();
            this.labelCurrent.Text = user.user_name;
            this.richTextBoxHistory.Text = "";
            this.maxId = 0;
        }


        private User selectUser()
        {
            User user = new User();
            if (this.listBoxService.Items.Count > 0 && this.listBoxService.SelectedIndex>=0)
            {
                user = (User)this.listBoxService.SelectedItem;
                
            }

            return user;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            refreshChat();
        }


        public void refreshChat()
        {
            try
            {
                User user = selectUser();
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.Chat> chats = res.ChatList(this.maxId,user.user_id, 0, 20);
                if (chats != null)
                {
                    User currentUser = Program.user;
                    this.richTextBoxHistory.Select(this.richTextBoxHistory.TextLength, 0);
                    foreach (Artifact.Api.Chat chat in chats)
                    {
                        if (chat.user_id == currentUser.user_id)
                        {
                            this.richTextBoxHistory.SelectionAlignment = HorizontalAlignment.Right;
                        }
                        else
                        {
                            this.richTextBoxHistory.SelectionAlignment = HorizontalAlignment.Left;
                        }
                        this.richTextBoxHistory.AppendText(chat.user + " " + chat.chat_created + "\n" + chat.chat_text + "\n\n");
                        //this.richTextBoxHistory.AppendText(chat.to_user + " " + chat.chat_created + "\n" + chat.chat_text + "\n\n");
                        if (this.maxId < Int32.Parse(chat.chat_id))
                            this.maxId = Int32.Parse(chat.chat_id);

                    }

                    Regex regImg = new Regex(@"(?i)<img\b[^>]*?src\s*=(['""]?)(?<imgUrl>[^'""]+)\1[^>]*?>");
                    MatchCollection matches = regImg.Matches(this.richTextBoxHistory.Text);

                    string[] sUrlList = new string[matches.Count];
                    foreach (Match match in matches)
                    {

                        string url = @match.Groups["imgUrl"].Value;
                        Bitmap bmp = new Bitmap((new System.Net.WebClient()).OpenRead(url));
                        Clipboard.SetImage(bmp);
                        string src = "<img src='" + url + "' />";
                        int pos = this.richTextBoxHistory.Find(src);
                        this.richTextBoxHistory.Select(pos, src.Length);
                        this.richTextBoxHistory.Paste();
                        this.richTextBoxHistory.Refresh();
                        Clipboard.Clear();
                    }

                    //让文本框获取焦点
                    this.richTextBoxHistory.Focus();
                    //设置光标的位置到文本尾
                    this.richTextBoxHistory.Select(this.richTextBoxHistory.TextLength, 0);
                    //滚动到控件光标处
                    this.richTextBoxHistory.ScrollToCaret();
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
            catch (Exception)
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }
        }
    }
}
