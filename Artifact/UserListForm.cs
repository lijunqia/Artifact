using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using Artifact.Api;
namespace Artifact
{
    public partial class UserListForm : Form
    {
        int pageSize = 0;     //每页显示行数
        int totalRecord = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号


        public UserListForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dataGridViewUserList.DataSource == null || this.dataGridViewUserList.CurrentRow == null)
                {
                    return;
                }
                else
                {
                    if (this.dataGridViewUserList.SelectedRows.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("确定删除选中的记录? ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            try
                            {
                                Response res = new Response();
                                //遍历所选中的dataGridView记录行  
                                foreach (DataGridViewRow row in this.dataGridViewUserList.SelectedRows)
                                {
                                    //取dataGridView1中的第三列的值
                                    string id = row.Cells[0].Value.ToString();
                                    if (id.Equals("1")) break;
                                    this.dataGridViewUserList.Rows.Remove(row);
                                    res.UserDelete(id);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "提示");
                            }
                            //删除后执行刷新操作
                        }
                    }
                }
            }
            catch (Exception )
            {
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            this.bindData();
            /*
            try
            {
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.User> users = res.UserList();
                if (users != null)
                {
                    Extra extra = (Extra)JsonConvert.DeserializeObject(res.extra.ToString(), typeof(Extra));
                    this.pageCount = extra.pages;
                    this.pageCurrent = extra.page;
                    this.pageSize = extra.size;
                    this.totalRecord = extra.total;

                    this.userBindingSource.DataSource = users;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }*/
        }


        private void dataGridViewUserList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (this.dataGridViewUserList.DataSource == null || this.dataGridViewUserList.CurrentRow == null)
                {
                    return;
                }
                else
                {
                    if (this.dataGridViewUserList.SelectedRows.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("数据有更改，是否保存? ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            try
                            {
                                Response res = new Response();
                                DataGridViewRow row = this.dataGridViewUserList.CurrentRow;
                                User user = new User();
                                user.user_id = row.Cells[0].Value.ToString();
                                user.role_id = row.Cells[1].Value.ToString();
                                user.user_code = row.Cells[2].Value.ToString();
                                user.user_password = row.Cells[3].Value.ToString();
                                user.user_expire = row.Cells[4].Value.ToString();
                                user.user_name = row.Cells[5].Value.ToString();
                                user.user_mobile = row.Cells[6].Value.ToString();
                                user.user_email = row.Cells[7].Value.ToString();
                                user.user_remark = row.Cells[8].Value.ToString();

                                if (res.UserUpdate(user) != null)
                                    MessageBox.Show("保存成功", "提示");

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "提示");
                            }
                            //删除后执行刷新操作
                        }
                    }
                }
            }
            catch (Exception )
            {
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.bindData(0, 20, this.textBoxKey.Text);
            /*
            this.dataGridViewUserList.ClearSelection();
            this.dataGridViewUserList.ForeColor = Color.Black;
            foreach (DataGridViewRow dgvr in dataGridViewUserList.Rows)//遍历所有行
            {
                foreach (DataGridViewCell dgvc in dgvr.Cells)//遍历行中的所有单元格
                {
                    if (dgvc.Value.ToString().Contains(this.textBoxKey.Text))//如果单元格中的值符合
                    {
                        dgvr.Selected = true;//单元格被选中
                        dgvr.DefaultCellStyle.ForeColor = Color.Red;
                    }

                }
            }*/
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.bindData(0, 20, this.textBoxKey.Text);
            /*
            try
            {
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.User> users = res.UserList();
                if (users != null)
                {
                    Extra extra = (Extra)JsonConvert.DeserializeObject(res.extra.ToString(), typeof(Extra));
                    this.pageCount = extra.pages;
                    this.pageCurrent = extra.page;
                    this.pageSize = extra.size;
                    this.totalRecord = extra.total;

                    this.userBindingSource.DataSource = users;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }*/
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.bindData(this.pageCurrent+1,20, this.textBoxKey.Text);
        }


        public void bindData(int page=0, int size=20, string q="")
        {
            this.labelLoading.Text = "正在加载。。。";
            try
            {
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.User> users = res.UserList(0,page,size,q);
                if (users != null)
                {
                    Extra extra = (Extra)JsonConvert.DeserializeObject(res.extra.ToString(), typeof(Extra));
                    this.pageCount = extra.pages;
                    this.pageCurrent = extra.page;
                    this.pageSize = extra.size;
                    this.totalRecord = extra.total;

                    this.userBindingSource.DataSource = users;
                }

                this.textBoxPage.Text = (this.pageCurrent + 1).ToString();
                this.labelTotalPage.Text = "/" + this.pageCount.ToString();

                //有下一页
                if (this.pageCurrent > 0)
                {
                    this.buttonFirst.Enabled = true;
                    this.buttonPre.Enabled = true;
                }
                else
                {
                    this.buttonFirst.Enabled = false;
                    this.buttonPre.Enabled = false;
                }
                if (this.pageCount > (this.pageCurrent+1))
                {
                    this.buttonNext.Enabled = true;
                    this.buttonLast.Enabled = true;
                }
                else //无下一页
                {
                    this.buttonNext.Enabled = false;
                    this.buttonLast.Enabled = false;
                }


            }
            catch (Exception )
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }

            this.labelLoading.Text = "";
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            this.bindData(this.pageCurrent - 1, 20, this.textBoxKey.Text);

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.bindData(this.pageCount - 1, 20, this.textBoxKey.Text);
        }

    }
}
