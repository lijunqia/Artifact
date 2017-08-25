using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Artifact.Api;

using Newtonsoft.Json;
namespace Artifact
{
    public partial class MessageListForm : Form
    {
        int pageSize = 0;     //每页显示行数
        int totalRecord = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号

        public MessageListForm()
        {
            InitializeComponent();
        }

        private void MessageListForm_Load(object sender, EventArgs e)
        {
            this.bindData();
            /* 
            try
            {
                Response res = new Response();
                    System.Collections.Generic.List<Artifact.Api.Message> messages = res.MessageList(0, 300);
                    if (messages != null)
                    {
                        this.messageBindingSource.DataSource = messages;
                    }


            }
            catch (Exception ex)
            {
                //MessageBox.Show("获取信息出错！" + ex.Message);
            }*/
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dataGridViewMessageList.DataSource == null || this.dataGridViewMessageList.CurrentRow == null)
                {
                    return;
                }
                else
                {
                    if (this.dataGridViewMessageList.SelectedRows.Count > 0)
                    {
                        DialogResult dr = MessageBox.Show("确定删除选中的记录? ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            try
                            {
                                Response res = new Response();
                                //遍历所选中的dataGridView记录行  
                                foreach (DataGridViewRow row in this.dataGridViewMessageList.SelectedRows)
                                {
                                    //取dataGridView1中的第三列的值
                                    string id = row.Cells[0].Value.ToString();
                                    this.dataGridViewMessageList.Rows.Remove(row);
                                    res.MessageDelete(id);
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

        public void bindData(int page = 0, int size = 20, string q = "")
        {
            this.labelLoading.Text = "正在加载。。。";
            try
            {
                Response res = new Response();
                System.Collections.Generic.List<Artifact.Api.Message> messages = res.MessageList(0, page, size, q);
                if (messages != null)
                {
                    Extra extra = (Extra)JsonConvert.DeserializeObject(res.extra.ToString(), typeof(Extra));
                    this.pageCount = extra.pages;
                    this.pageCurrent = extra.page;
                    this.pageSize = extra.size;
                    this.totalRecord = extra.total;
                    this.messageBindingSource.DataSource = messages;
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
                if (this.pageCount > (this.pageCurrent + 1))
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.bindData(0, 20, this.textBoxKey.Text);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {

            this.bindData(0, 20, this.textBoxKey.Text);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            this.bindData(this.pageCurrent + 1, 20, this.textBoxKey.Text);
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
