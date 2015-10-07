using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Artifact.Api;

using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading;
using System.IO;

namespace Artifact
{
    public partial class MessageAddForm : Form
    {
        public MessageAddForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.richTextBoxText.Text == "")
            {
                MessageBox.Show("请填写信息。", "提示信息");
                this.richTextBoxText.Focus();
                return;
            }

            try
            {
                label1.Text = "正在发布中。。。。";
                Response res = new Response();
                int exp = this.checkBoxExp.Checked ? 1 : 0;
                Artifact.Api.Message message = new Api.Message();
                message.message_is_exp = exp.ToString();
                string filePath = Application.StartupPath + "\\snap\\" + DateTime.Now.ToString("yyyyMMdd") + "\\";//存放到相对路径

                Random seed = new Random();


                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                string text = "";
                for (int i = 0; i < this.richTextBoxText.TextLength; i++)
                {
                    this.richTextBoxText.Select(i, 1);
                    RichTextBoxSelectionTypes rt = this.richTextBoxText.SelectionType;
                    //MessageBox.Show(rt.ToString());
                    if (rt == RichTextBoxSelectionTypes.Object)
                    {
                        label1.Text = "正在上传截图。。。。";
                        //当然也可能是其它的类型
                        //MessageBox.Show("这是一个图片");
                        this.richTextBoxText.Copy();
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
                                text += "<img src='"+snap.url+"' />" ;
                            }
                        }
                        label1.Text = "上传完成";
                    }
                    else
                        text += this.richTextBoxText.SelectedText;

                }
                
                message.message_text = text;

                Artifact.Api.Message message_add = res.MessageCreate(message);
                if (message_add != null)
                {
                    this.richTextBoxText.Text = "";
                    MessageBox.Show("发布成功！","提示信息");
                }
                else
                    MessageBox.Show("发布失败！" + res.message, "提示信息");
                
                label1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取信息出错！" + ex.Message);
            }

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
                int startPosition = this.richTextBoxText.SelectionStart;
                //从鼠标焦点处开始选中几个字符
                this.richTextBoxText.SelectionLength = 2;
                //将图片粘贴到鼠标焦点位置(由于有选中2个字符，所以那2个字符会被图片覆盖)
                this.richTextBoxText.Paste();
                Clipboard.Clear();
            }
            Thread.Sleep(300);
            this.Show();
        }
    }
}
