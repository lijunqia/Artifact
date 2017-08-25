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


using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading;

using System.Text.RegularExpressions;
using System.Security.Permissions;
using CustomUIControls;
using JRichText.Model;

namespace Artifact
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]

    public partial class MainForm : Form
    {
        public ImageList imageList;
        public ImageListPopup ilp;

        private int maxId = 0;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        public int syncMmaxId = 0;
        public int syncServiceMmaxId = 0;

        public MainForm()
        {
            InitializeComponent();
            Response res = new Response();
            this.webBrowserMessage.Navigate(new Uri(res.getHtmlMessage()));
            this.webBrowserMessage.ObjectForScripting = this;

            imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            imageList.ColorDepth = ColorDepth.Depth32Bit;       //32位的带alpha通道的可以直接透明 
            imageList.Images.AddStrip(new Bitmap(GetType(), "face2.bmp"));  //加载资源表情图片           

            ilp = new ImageListPopup();
            ilp.Init(imageList, 8, 8, 10, 2);   //水平、垂直线间距，表情显示的列和行 
            ilp.ItemClick += new ImageListPopupEventHandler(OnItemClicked);

            this.buttonMin.BringToFront();
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
                if(Int32.Parse(Program.user.role_id)<=3)
                {
                    this.checkBoxNotice.Visible = true;
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
                // this.setMessage(10);

                this.labelName.Text = Program.user.user_name;

                this.richTextBoxMessage.Focus();
            }
            catch (Exception )
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }

        }

        public void showWindow()
        {
            Beep(500, 700);
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }
        public void showServiceWindow(string count)
        {
            Beep(2766, 700);
            this.labelCount.Text = "[" + count.ToString() + "条]";
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }

        public void btnButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            BTNType btnType;
            if (Enum.TryParse<BTNType>(btn.Tag.ToString(), out btnType))
            {
                if (btnType == BTNType.Search)
                {
                    if (!string.IsNullOrEmpty(this.textBoxKey.Text.Trim()))
                    {
                        this.webBrowserMessage.Tag = this.textBoxKey.Text.Trim();
                    }
                    else
                    {
                        return;
                    }

                }
                IRichFormat richFomat = RichFormatFactory.CreateRichFormat(btnType);
                richFomat.SetFormat(this.richTextBoxMessage);
            }
        }

        private void combFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float fsize = 12.0f;
            if (combFontSize.SelectedIndex > -1)
            {
                if (float.TryParse(combFontSize.SelectedItem.ToString(), out fsize))
                {
                    richTextBoxMessage.Tag = fsize.ToString();
                    IRichFormat richFomat = RichFormatFactory.CreateRichFormat(BTNType.FontSize);
                    richFomat.SetFormat(this.richTextBoxMessage);
                }
                return;
            }
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            //this.setMessage(20);
            try
            {

                string html = webBrowserMessage.Document.GetElementById("syncform").GetAttribute("innerHTML");
                Console.WriteLine(" html " + html);
                int id = 0;
                int.TryParse(html, out id);
                if (id > 0 && syncMmaxId < id)
                {
                    syncMmaxId = id;
                    Beep(500, 700);
                    if (this.WindowState == FormWindowState.Minimized)
                    {

                        this.WindowState = FormWindowState.Normal;
                        this.TopMost = true;
                    }
                }
                html = webBrowserMessage.Document.GetElementById("syncserviceform").GetAttribute("innerHTML");
                Console.WriteLine(" html " + html);
                id = 0;
                int.TryParse(html, out id);
                if (id > 0 && syncServiceMmaxId < id)
                {
                    html = webBrowserMessage.Document.GetElementById("syncservicecount").GetAttribute("innerHTML");
                    syncServiceMmaxId = id;
                    Beep(2766, 700);
                    this.labelCount.Text = "[" + html + "条]";
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                        this.TopMost = true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception " + ex.Message);
            }
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
                        //Bitmap bmp = new Bitmap((new System.Net.WebClient()).OpenRead(url));
                        Image bmp = Image.FromFile(url);
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
//            int pos = this.richTextBoxMessageList.Find(this.textBoxKey.Text);
//            this.richTextBoxMessageList.Select(pos, this.textBoxKey.Text.Length);
//            this.richTextBoxMessageList.SelectionColor = Color.Red;
 //           this.richTextBoxMessageList.Focus();
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
            this.labelCount.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (this.richTextBoxMessage.Text == "")
            {
                //MessageBox.Show("请填写信息。", "提示信息");
                this.labelTips.Text = "请填写信息";
                this.richTextBoxMessage.Focus();
                return;
            }

            try
            {
                this.labelTips.Text = "正在发布中。。。。";
                Response res = new Response();
                int exp =  0;
                int notice = this.checkBoxNotice.Checked ? 1 : 0;
                Artifact.Api.Message message = new Api.Message();
                message.message_is_exp = exp.ToString();
                message.message_type = notice.ToString();
                string filePath = Application.StartupPath + "\\snap\\" + DateTime.Now.ToString("yyyyMMdd") + "\\";//存放到相对路径

                Random seed = new Random();


                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                string text = "";
                for (int i = 0; i < this.richTextBoxMessage.TextLength; i++)
                {
                    this.richTextBoxMessage.Select(i, 1);
                    RichTextBoxSelectionTypes rt = this.richTextBoxMessage.SelectionType;
                    //MessageBox.Show(rt.ToString());
                    if (rt == RichTextBoxSelectionTypes.Object)
                    {
                        this.labelTips.Text = "正在上传截图。。。。";
                        //当然也可能是其它的类型
                        //MessageBox.Show("这是一个图片");
                        this.richTextBoxMessage.Copy();
                        Image img = Clipboard.GetImage();
                        if (img != null)
                        {
                            //string snapPath = filePath + DateTime.Now.ToString("HHmmss") + seed.Next(10, 99).ToString() + ".jpg";
                            //img.Save(snapPath, ImageFormat.Jpeg);

                            //上传到服务器
                            Snap snap = res.MessageUpload(img);
                            img.Dispose();

                            if (snap != null)
                            {
                                text += "<img src='" + snap.url + "' />";
                            }
                        }
                        this.labelTips.Text = "上传完成";
                    }
                    else
                        text += this.richTextBoxMessage.SelectedText;

                }

                message.message_text = text;

                Artifact.Api.Message message_add = res.MessageCreate(message);
                if (message_add != null)
                {
                    this.richTextBoxMessage.Text = "";
                    this.richTextBoxMessage.Focus();
                    //MessageBox.Show("发布成功！", "提示信息");
                }
                else
                    MessageBox.Show("发布失败！" + res.message, "提示信息");

                this.labelTips.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取信息出错！" + ex.Message);
            }
        }

        private void buttonCaputre_Click(object sender, EventArgs e)
        {
            if(this.checkBoxCut.Checked)
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
                int startPosition = this.richTextBoxMessage.SelectionStart;
                //从鼠标焦点处开始选中几个字符
                //this.richTextBoxText.SelectionLength = 2;
                //将图片粘贴到鼠标焦点位置(由于有选中2个字符，所以那2个字符会被图片覆盖)
                this.richTextBoxMessage.Paste();
                Clipboard.Clear();
            }
            Thread.Sleep(300);
            this.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {


            ReleaseCapture();

            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void splitContainer3_Panel2_MouseDown(object sender, MouseEventArgs e)
        {


            ReleaseCapture();

            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();

            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void textBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonSearch_Click(sender, e);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonNotice_Click(object sender, EventArgs e)
        {

            NoticeForm frm = new NoticeForm();
            frm.Show();
        }

        private void buttonUserOnline_Click(object sender, EventArgs e)
        {
            OnlineForm frm = new OnlineForm();
            frm.Show();

        }

        /************************************************************************/
        /* 表情按钮点击                                                                                     */
        /************************************************************************/
        private void buttonFace_Click(object sender, EventArgs e)
        {
            Point pt = PointToScreen(new Point(splitContainer4.Panel2.Left, splitContainer4.Panel2.Top));
            ilp.Show(pt.X+200, pt.Y - 80);

        }

        /************************************************************************/
        /* 选择了表情                                                                                          */
        /************************************************************************/
        public void OnItemClicked(object sender, ImageListPopupEventArgs e)
        {
            Image img = imageList.Images[e.SelectedItem];
            Clipboard.SetDataObject(img);
            richTextBoxMessage.ReadOnly = false;
            richTextBoxMessage.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {

            MusicForm frm = new MusicForm();
            frm.Show();
        }

        private void buttonWallpaper_Click(object sender, EventArgs e)
        {

            WallpaperForm frm = new WallpaperForm();
            frm.Show();
        }
    }

}
