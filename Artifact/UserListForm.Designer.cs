namespace Artifact
{
    partial class UserListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.user_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPre = new System.Windows.Forms.Button();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.labelTotalPage = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userexpireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usermobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userremarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlasttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlastipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userisexpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usercreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userupdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            this.contextMenuStripUser.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.AllowUserToAddRows = false;
            this.dataGridViewUserList.AllowUserToOrderColumns = true;
            this.dataGridViewUserList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.roleidDataGridViewTextBoxColumn,
            this.usercodeDataGridViewTextBoxColumn,
            this.user_password,
            this.userexpireDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.usermobileDataGridViewTextBoxColumn,
            this.useremailDataGridViewTextBoxColumn,
            this.userremarkDataGridViewTextBoxColumn,
            this.userlasttimeDataGridViewTextBoxColumn,
            this.userlastipDataGridViewTextBoxColumn,
            this.userloginnumDataGridViewTextBoxColumn,
            this.userisexpDataGridViewTextBoxColumn,
            this.usercreatedDataGridViewTextBoxColumn,
            this.userupdatedDataGridViewTextBoxColumn});
            this.dataGridViewUserList.ContextMenuStrip = this.contextMenuStripUser;
            this.dataGridViewUserList.DataSource = this.userBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUserList.RowHeadersWidth = 20;
            this.dataGridViewUserList.RowTemplate.Height = 23;
            this.dataGridViewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserList.Size = new System.Drawing.Size(786, 513);
            this.dataGridViewUserList.TabIndex = 0;
            this.dataGridViewUserList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserList_CellValueChanged);
            // 
            // user_password
            // 
            this.user_password.DataPropertyName = "user_password";
            this.user_password.HeaderText = "密码";
            this.user_password.Name = "user_password";
            // 
            // contextMenuStripUser
            // 
            this.contextMenuStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete});
            this.contextMenuStripUser.Name = "contextMenuStripUser";
            this.contextMenuStripUser.Size = new System.Drawing.Size(137, 26);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemDelete.Text = "删除用户(&D)";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelLoading);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLast);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFirst);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNext);
            this.splitContainer1.Panel1.Controls.Add(this.labelTotalPage);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPre);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxKey);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewUserList);
            this.splitContainer1.Size = new System.Drawing.Size(786, 561);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBoxKey
            // 
            this.textBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKey.Location = new System.Drawing.Point(71, 14);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(125, 21);
            this.textBoxKey.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Red;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(202, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "查询(&Q)";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "关键字：";
            // 
            // buttonPre
            // 
            this.buttonPre.BackColor = System.Drawing.Color.Red;
            this.buttonPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPre.Location = new System.Drawing.Point(340, 12);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(31, 23);
            this.buttonPre.TabIndex = 3;
            this.buttonPre.Text = "<";
            this.buttonPre.UseVisualStyleBackColor = false;
            this.buttonPre.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(377, 14);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(40, 21);
            this.textBoxPage.TabIndex = 4;
            // 
            // labelTotalPage
            // 
            this.labelTotalPage.AutoSize = true;
            this.labelTotalPage.Location = new System.Drawing.Point(423, 17);
            this.labelTotalPage.Name = "labelTotalPage";
            this.labelTotalPage.Size = new System.Drawing.Size(11, 12);
            this.labelTotalPage.TabIndex = 5;
            this.labelTotalPage.Text = "/";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Red;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNext.Location = new System.Drawing.Point(462, 11);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(33, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.Red;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFirst.Location = new System.Drawing.Point(304, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(30, 23);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Red;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLast.Location = new System.Drawing.Point(501, 11);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(32, 23);
            this.buttonLast.TabIndex = 8;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.Location = new System.Drawing.Point(557, 16);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(100, 17);
            this.labelLoading.TabIndex = 9;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.useridDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.useridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 50;
            // 
            // roleidDataGridViewTextBoxColumn
            // 
            this.roleidDataGridViewTextBoxColumn.DataPropertyName = "role_id";
            this.roleidDataGridViewTextBoxColumn.HeaderText = "角色";
            this.roleidDataGridViewTextBoxColumn.Name = "roleidDataGridViewTextBoxColumn";
            this.roleidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleidDataGridViewTextBoxColumn.Width = 80;
            // 
            // usercodeDataGridViewTextBoxColumn
            // 
            this.usercodeDataGridViewTextBoxColumn.DataPropertyName = "user_code";
            this.usercodeDataGridViewTextBoxColumn.HeaderText = "账号";
            this.usercodeDataGridViewTextBoxColumn.Name = "usercodeDataGridViewTextBoxColumn";
            // 
            // userexpireDataGridViewTextBoxColumn
            // 
            this.userexpireDataGridViewTextBoxColumn.DataPropertyName = "user_expire";
            this.userexpireDataGridViewTextBoxColumn.HeaderText = "过期时间";
            this.userexpireDataGridViewTextBoxColumn.Name = "userexpireDataGridViewTextBoxColumn";
            this.userexpireDataGridViewTextBoxColumn.Width = 130;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // usermobileDataGridViewTextBoxColumn
            // 
            this.usermobileDataGridViewTextBoxColumn.DataPropertyName = "user_mobile";
            this.usermobileDataGridViewTextBoxColumn.HeaderText = "手机";
            this.usermobileDataGridViewTextBoxColumn.Name = "usermobileDataGridViewTextBoxColumn";
            // 
            // useremailDataGridViewTextBoxColumn
            // 
            this.useremailDataGridViewTextBoxColumn.DataPropertyName = "user_email";
            this.useremailDataGridViewTextBoxColumn.HeaderText = "邮箱";
            this.useremailDataGridViewTextBoxColumn.Name = "useremailDataGridViewTextBoxColumn";
            // 
            // userremarkDataGridViewTextBoxColumn
            // 
            this.userremarkDataGridViewTextBoxColumn.DataPropertyName = "user_remark";
            this.userremarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.userremarkDataGridViewTextBoxColumn.Name = "userremarkDataGridViewTextBoxColumn";
            // 
            // userlasttimeDataGridViewTextBoxColumn
            // 
            this.userlasttimeDataGridViewTextBoxColumn.DataPropertyName = "user_last_time";
            this.userlasttimeDataGridViewTextBoxColumn.HeaderText = "登录时间";
            this.userlasttimeDataGridViewTextBoxColumn.Name = "userlasttimeDataGridViewTextBoxColumn";
            // 
            // userlastipDataGridViewTextBoxColumn
            // 
            this.userlastipDataGridViewTextBoxColumn.DataPropertyName = "user_last_ip";
            this.userlastipDataGridViewTextBoxColumn.HeaderText = "登录IP";
            this.userlastipDataGridViewTextBoxColumn.Name = "userlastipDataGridViewTextBoxColumn";
            // 
            // userloginnumDataGridViewTextBoxColumn
            // 
            this.userloginnumDataGridViewTextBoxColumn.DataPropertyName = "user_login_num";
            this.userloginnumDataGridViewTextBoxColumn.HeaderText = "次数";
            this.userloginnumDataGridViewTextBoxColumn.Name = "userloginnumDataGridViewTextBoxColumn";
            // 
            // userisexpDataGridViewTextBoxColumn
            // 
            this.userisexpDataGridViewTextBoxColumn.DataPropertyName = "user_is_exp";
            this.userisexpDataGridViewTextBoxColumn.HeaderText = "是否体验";
            this.userisexpDataGridViewTextBoxColumn.Name = "userisexpDataGridViewTextBoxColumn";
            // 
            // usercreatedDataGridViewTextBoxColumn
            // 
            this.usercreatedDataGridViewTextBoxColumn.DataPropertyName = "user_created";
            this.usercreatedDataGridViewTextBoxColumn.HeaderText = "添加时间";
            this.usercreatedDataGridViewTextBoxColumn.Name = "usercreatedDataGridViewTextBoxColumn";
            // 
            // userupdatedDataGridViewTextBoxColumn
            // 
            this.userupdatedDataGridViewTextBoxColumn.DataPropertyName = "user_updated";
            this.userupdatedDataGridViewTextBoxColumn.HeaderText = "更新时间";
            this.userupdatedDataGridViewTextBoxColumn.Name = "userupdatedDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Artifact.Api.User);
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 561);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理用户";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            this.contextMenuStripUser.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn userexpireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usermobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userremarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlasttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlastipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userloginnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userisexpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userupdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonPre;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelTotalPage;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label labelLoading;
    }
}