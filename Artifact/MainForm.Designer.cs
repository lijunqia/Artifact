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
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.buttonChat = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.buttonMessageList = new System.Windows.Forms.Button();
            this.buttonMessageAdd = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonUserOnline = new System.Windows.Forms.Button();
            this.buttonUserList = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowserMessage = new System.Windows.Forms.WebBrowser();
            this.richTextBoxMessageList = new System.Windows.Forms.RichTextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.buttonCaputre = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonNotice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.groupBoxMessage.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = global::Artifact.Properties.Resources.search_ico;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.buttonSearch.Location = new System.Drawing.Point(161, 70);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(26, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonNotice);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxAvatar);
            this.splitContainer1.Panel1.Controls.Add(this.buttonChat);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMessage);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxUser);
            this.splitContainer1.Panel1.Controls.Add(this.buttonResetPassword);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxKey);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Size = new System.Drawing.Size(1004, 661);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(68, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 14);
            this.labelName.TabIndex = 11;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAvatar.ErrorImage = global::Artifact.Properties.Resources._1;
            this.pictureBoxAvatar.Image = global::Artifact.Properties.Resources._1;
            this.pictureBoxAvatar.InitialImage = global::Artifact.Properties.Resources._1;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 10;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // buttonChat
            // 
            this.buttonChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonChat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChat.ForeColor = System.Drawing.Color.White;
            this.buttonChat.Image = global::Artifact.Properties.Resources._2;
            this.buttonChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChat.Location = new System.Drawing.Point(0, 112);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(200, 55);
            this.buttonChat.TabIndex = 8;
            this.buttonChat.Text = "联系客服(&K)";
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(436, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "关闭(&E)";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMessage.Controls.Add(this.buttonMessageList);
            this.groupBoxMessage.Controls.Add(this.buttonMessageAdd);
            this.groupBoxMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxMessage.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxMessage.Location = new System.Drawing.Point(0, 376);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(198, 114);
            this.groupBoxMessage.TabIndex = 7;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Visible = false;
            // 
            // buttonMessageList
            // 
            this.buttonMessageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonMessageList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMessageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMessageList.Location = new System.Drawing.Point(0, 61);
            this.buttonMessageList.Name = "buttonMessageList";
            this.buttonMessageList.Size = new System.Drawing.Size(200, 55);
            this.buttonMessageList.TabIndex = 1;
            this.buttonMessageList.Text = "管理信息(&L)";
            this.buttonMessageList.UseVisualStyleBackColor = false;
            this.buttonMessageList.Click += new System.EventHandler(this.buttonMessageList_Click);
            // 
            // buttonMessageAdd
            // 
            this.buttonMessageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonMessageAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMessageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMessageAdd.Location = new System.Drawing.Point(0, 7);
            this.buttonMessageAdd.Name = "buttonMessageAdd";
            this.buttonMessageAdd.Size = new System.Drawing.Size(200, 55);
            this.buttonMessageAdd.TabIndex = 0;
            this.buttonMessageAdd.Text = "发布信息(&I)";
            this.buttonMessageAdd.UseVisualStyleBackColor = false;
            this.buttonMessageAdd.Click += new System.EventHandler(this.buttonMessageAdd_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUser.Controls.Add(this.buttonUserOnline);
            this.groupBoxUser.Controls.Add(this.buttonUserList);
            this.groupBoxUser.Controls.Add(this.buttonUserAdd);
            this.groupBoxUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxUser.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxUser.Location = new System.Drawing.Point(0, 490);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(20);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(198, 169);
            this.groupBoxUser.TabIndex = 6;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Visible = false;
            // 
            // buttonUserOnline
            // 
            this.buttonUserOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonUserOnline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonUserOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserOnline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUserOnline.Location = new System.Drawing.Point(0, 61);
            this.buttonUserOnline.Name = "buttonUserOnline";
            this.buttonUserOnline.Size = new System.Drawing.Size(200, 55);
            this.buttonUserOnline.TabIndex = 2;
            this.buttonUserOnline.Text = "在线用户(&O)";
            this.buttonUserOnline.UseVisualStyleBackColor = false;
            // 
            // buttonUserList
            // 
            this.buttonUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonUserList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUserList.Location = new System.Drawing.Point(0, 115);
            this.buttonUserList.Name = "buttonUserList";
            this.buttonUserList.Size = new System.Drawing.Size(200, 55);
            this.buttonUserList.TabIndex = 1;
            this.buttonUserList.Text = "管理用户(&M)";
            this.buttonUserList.UseVisualStyleBackColor = false;
            this.buttonUserList.Click += new System.EventHandler(this.buttonUserList_Click);
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonUserAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUserAdd.Location = new System.Drawing.Point(0, 7);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(200, 55);
            this.buttonUserAdd.TabIndex = 0;
            this.buttonUserAdd.Text = "添加用户(&U)";
            this.buttonUserAdd.UseVisualStyleBackColor = false;
            this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResetPassword.Image = global::Artifact.Properties.Resources._3;
            this.buttonResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetPassword.Location = new System.Drawing.Point(0, 166);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(200, 55);
            this.buttonResetPassword.TabIndex = 5;
            this.buttonResetPassword.Text = "修改密码(&R)";
            this.buttonResetPassword.UseVisualStyleBackColor = false;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.textBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxKey.ForeColor = System.Drawing.Color.White;
            this.textBoxKey.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxKey.Location = new System.Drawing.Point(13, 70);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(148, 26);
            this.textBoxKey.TabIndex = 3;
            this.textBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKey_KeyPress);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonMin);
            this.splitContainer2.Panel1.Controls.Add(this.webBrowserMessage);
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxMessageList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(801, 659);
            this.splitContainer2.SplitterDistance = 482;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 3;
            // 
            // webBrowserMessage
            // 
            this.webBrowserMessage.AllowNavigation = false;
            this.webBrowserMessage.AllowWebBrowserDrop = false;
            this.webBrowserMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMessage.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMessage.Name = "webBrowserMessage";
            this.webBrowserMessage.Size = new System.Drawing.Size(801, 482);
            this.webBrowserMessage.TabIndex = 2;
            this.webBrowserMessage.WebBrowserShortcutsEnabled = false;
            // 
            // richTextBoxMessageList
            // 
            this.richTextBoxMessageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessageList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxMessageList.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxMessageList.Location = new System.Drawing.Point(-62, 90);
            this.richTextBoxMessageList.Name = "richTextBoxMessageList";
            this.richTextBoxMessageList.ShowSelectionMargin = true;
            this.richTextBoxMessageList.Size = new System.Drawing.Size(753, 463);
            this.richTextBoxMessageList.TabIndex = 1;
            this.richTextBoxMessageList.Text = "";
            this.richTextBoxMessageList.Visible = false;
            this.richTextBoxMessageList.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxMessageList_LinkClicked);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.richTextBoxMessage);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.labelTips);
            this.splitContainer3.Panel2.Controls.Add(this.buttonCaputre);
            this.splitContainer3.Panel2.Controls.Add(this.buttonSend);
            this.splitContainer3.Panel2.Controls.Add(this.buttonExit);
            this.splitContainer3.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer3.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer3_Panel2_MouseDown);
            this.splitContainer3.Panel2MinSize = 40;
            this.splitContainer3.Size = new System.Drawing.Size(801, 176);
            this.splitContainer3.SplitterDistance = 135;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 1;
            this.splitContainer3.TabStop = false;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.White;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMessage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxMessage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBoxMessage.Location = new System.Drawing.Point(10, 10);
            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(781, 115);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTips.Location = new System.Drawing.Point(81, 14);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(0, 12);
            this.labelTips.TabIndex = 2;
            // 
            // buttonCaputre
            // 
            this.buttonCaputre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonCaputre.FlatAppearance.BorderSize = 0;
            this.buttonCaputre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaputre.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCaputre.Location = new System.Drawing.Point(555, 5);
            this.buttonCaputre.Name = "buttonCaputre";
            this.buttonCaputre.Size = new System.Drawing.Size(100, 28);
            this.buttonCaputre.TabIndex = 1;
            this.buttonCaputre.Text = "截图(&C)";
            this.buttonCaputre.UseVisualStyleBackColor = false;
            this.buttonCaputre.Click += new System.EventHandler(this.buttonCaputre_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSend.Location = new System.Drawing.Point(674, 5);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "发送(&S)";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(751, -1);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(28, 23);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.Text = "--";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonNotice
            // 
            this.buttonNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonNotice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNotice.Image = global::Artifact.Properties.Resources._3;
            this.buttonNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotice.Location = new System.Drawing.Point(-1, 220);
            this.buttonNotice.Name = "buttonNotice";
            this.buttonNotice.Size = new System.Drawing.Size(200, 55);
            this.buttonNotice.TabIndex = 12;
            this.buttonNotice.Text = "最新公告(&B)";
            this.buttonNotice.UseVisualStyleBackColor = false;
            this.buttonNotice.Click += new System.EventHandler(this.buttonNotice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Artifact.Properties.Resources.chat_bg;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天窗口";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxMessageList;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TextBox textBoxKey;
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCaputre;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.WebBrowser webBrowserMessage;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonNotice;
    }
}

