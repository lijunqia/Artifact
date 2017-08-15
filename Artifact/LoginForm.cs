using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Artifact.Api;
using System.Runtime.InteropServices;
namespace Artifact
{
    public partial class LoginForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            if (this.textBoxCode.Text == "")
            {
                MessageBox.Show("请填写账号。", "提示信息");
                this.textBoxCode.Focus();
                return;
            }
            if (this.textBoxPassword.Text == "")
            {
                MessageBox.Show("请填写密码。", "提示信息");
                this.textBoxPassword.Focus();
                return;
            }

            Response res = new Response();
            try
            {
                User user = res.UserLogin(this.textBoxCode.Text, this.textBoxPassword.Text);
                if (user != null)
                {

                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("登录失败！" + res.message, "操作提示");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("登录失败！","操作提示");
                //Console.WriteLine(" form login 出错 " + ex.Message);
            }
        }


        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();

            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
        

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                buttonSubmit_Click(sender, e);
        }
    }
}
