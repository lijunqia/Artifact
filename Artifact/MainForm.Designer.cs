namespace Artifact
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.buttonMessageList = new System.Windows.Forms.Button();
            this.buttonMessageAdd = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonUserOnline = new System.Windows.Forms.Button();
            this.buttonUserList = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.richTextBoxMessageList = new System.Windows.Forms.RichTextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttonChat = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(71, 114);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "搜索(&S)";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Red;
            this.splitContainer1.Panel1.Controls.Add(this.buttonChat);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExit);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMessage);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxUser);
            this.splitContainer1.Panel1.Controls.Add(this.buttonResetPassword);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxLogo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxKey);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxMessageList);
            this.splitContainer1.Size = new System.Drawing.Size(996, 655);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Brown;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(71, 254);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "退出系统(&E)";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.buttonMessageList);
            this.groupBoxMessage.Controls.Add(this.buttonMessageAdd);
            this.groupBoxMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMessage.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxMessage.Location = new System.Drawing.Point(0, 292);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(250, 162);
            this.groupBoxMessage.TabIndex = 7;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "信息发布";
            this.groupBoxMessage.Visible = false;
            // 
            // buttonMessageList
            // 
            this.buttonMessageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMessageList.Location = new System.Drawing.Point(71, 92);
            this.buttonMessageList.Name = "buttonMessageList";
            this.buttonMessageList.Size = new System.Drawing.Size(100, 23);
            this.buttonMessageList.TabIndex = 1;
            this.buttonMessageList.Text = "管理信息(&L)";
            this.buttonMessageList.UseVisualStyleBackColor = true;
            this.buttonMessageList.Click += new System.EventHandler(this.buttonMessageList_Click);
            // 
            // buttonMessageAdd
            // 
            this.buttonMessageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMessageAdd.Location = new System.Drawing.Point(71, 34);
            this.buttonMessageAdd.Name = "buttonMessageAdd";
            this.buttonMessageAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonMessageAdd.TabIndex = 0;
            this.buttonMessageAdd.Text = "发布信息(&I)";
            this.buttonMessageAdd.UseVisualStyleBackColor = true;
            this.buttonMessageAdd.Click += new System.EventHandler(this.buttonMessageAdd_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.buttonUserOnline);
            this.groupBoxUser.Controls.Add(this.buttonUserList);
            this.groupBoxUser.Controls.Add(this.buttonUserAdd);
            this.groupBoxUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxUser.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxUser.Location = new System.Drawing.Point(0, 454);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(250, 201);
            this.groupBoxUser.TabIndex = 6;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "用户管理";
            this.groupBoxUser.Visible = false;
            // 
            // buttonUserOnline
            // 
            this.buttonUserOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserOnline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUserOnline.Location = new System.Drawing.Point(71, 150);
            this.buttonUserOnline.Name = "buttonUserOnline";
            this.buttonUserOnline.Size = new System.Drawing.Size(100, 23);
            this.buttonUserOnline.TabIndex = 2;
            this.buttonUserOnline.Text = "在线用户";
            this.buttonUserOnline.UseVisualStyleBackColor = true;
            this.buttonUserOnline.Visible = false;
            // 
            // buttonUserList
            // 
            this.buttonUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUserList.Location = new System.Drawing.Point(71, 94);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(100, 23);
            this.buttonUserList.TabIndex = 1;
            this.buttonUserList.Text = "管理用户(&U)";
            this.buttonUserList.UseVisualStyleBackColor = true;
            this.buttonUserList.Click += new System.EventHandler(this.buttonUserList_Click);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUserAdd.Location = new System.Drawing.Point(71, 41);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonUserAdd.TabIndex = 0;
            this.buttonUserAdd.Text = "添加用户(&C)";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResetPassword.Location = new System.Drawing.Point(71, 160);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(100, 23);
            this.buttonResetPassword.TabIndex = 5;
            this.buttonResetPassword.Text = "修改密码(&R)";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = global::Artifact.Properties.Resources._20150413020559439;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 65);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键字：";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxKey.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxKey.Location = new System.Drawing.Point(71, 81);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(158, 19);
            this.textBoxKey.TabIndex = 0;
            // 
            // richTextBoxMessageList
            // 
            this.richTextBoxMessageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMessageList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxMessageList.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxMessageList.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxMessageList.Name = "richTextBoxMessageList";
            this.richTextBoxMessageList.ShowSelectionMargin = true;
            this.richTextBoxMessageList.Size = new System.Drawing.Size(745, 655);
            this.richTextBoxMessageList.TabIndex = 1;
            this.richTextBoxMessageList.Text = "";
            this.richTextBoxMessageList.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxMessageList_LinkClicked);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // buttonChat
            // 
            this.buttonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChat.ForeColor = System.Drawing.Color.Transparent;
            this.buttonChat.Location = new System.Drawing.Point(71, 208);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(100, 23);
            this.buttonChat.TabIndex = 8;
            this.buttonChat.Text = "联系客服(&C)";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(996, 655);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "中亿喊单神器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxMessageList;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Button buttonMessageList;
        private System.Windows.Forms.Button buttonMessageAdd;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button buttonUserOnline;
        private System.Windows.Forms.Button buttonUserList;
        private System.Windows.Forms.Button buttonUserAdd;
        private System.Windows.Forms.Button buttonChat;
    }
}

