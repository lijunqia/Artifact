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
    public partial class UserCreateForm : Form
    {
        public static string id;
        public UserCreateForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
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
            try
            {
                Response res = new Response();
                Artifact.Api.User user = new Api.User();
                user.user_code = this.textBoxCode.Text;
                user.user_name = this.textBoxName.Text;
                user.user_password = this.textBoxPassword.Text;
                user.user_remark = this.richTextBoxRemark.Text;
                user.role_id = this.comboBoxRole.SelectedIndex.ToString();
                user.user_expire = this.dateTimePickerExpire.Text;
                user.user_email = "";
                user.user_mobile = "";

                Artifact.Api.User user_add = res.UserCreate(user);
                if (user_add != null)
                {
                    MessageBox.Show("添加成功！");
                    this.textBoxCode.Text = "";
                }
                else
                    MessageBox.Show("添加失败！" + res.message);


            }
            catch (Exception ex)
            {
                MessageBox.Show("获取信息出错！" + ex.Message);
            }
        }
    }
}
