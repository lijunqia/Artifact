using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Artifact.Api;
namespace Artifact
{
    public partial class UserResetPasswordForm : Form
    {
        public UserResetPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (this.textBoxOldPassword.Text == "")
            {
                MessageBox.Show("请填写旧密码。", "提示信息");
                this.textBoxOldPassword.Focus();
                return;
            }
            if (this.textBoxNewPassword.Text == "")
            {
                MessageBox.Show("请填写新密码。", "提示信息");
                this.textBoxNewPassword.Focus();
                return;
            }

            try
            {
                Response res = new Response();
                User user = Program.user;
                if (user != null)
                {
                    if (res.UserReset(this.textBoxOldPassword.Text,this.textBoxNewPassword.Text))
                    {
                        MessageBox.Show("修改成功！");
                    }
                    else
                        MessageBox.Show("修改失败！"+res.message);

                }
                else
                {
                    MessageBox.Show("登录过期！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取信息出错！" + ex.Message);
            }
        }
    }
}
