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
            this.buttonWallpaper = new System.Windows.Forms.Button();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonNotice = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.buttonChat = new System.Windows.Forms.Button();
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
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.webBrowserMessage = new System.Windows.Forms.WebBrowser();
            this.buttonMin = new System.Windows.Forms.Button();
            this.combFontSize = new System.Windows.Forms.ComboBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnSubScript = new System.Windows.Forms.Button();
            this.btnSuperScript = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnUnderLine = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnStrikeLine = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnIdent = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnOutIdent = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnUl = new System.Windows.Forms.Button();
            this.buttonFace = new System.Windows.Forms.Button();
            this.checkBoxNotice = new System.Windows.Forms.CheckBox();
            this.checkBoxCut = new System.Windows.Forms.CheckBox();
            this.richTextBoxMessageList = new System.Windows.Forms.RichTextBox();
            this.buttonCaputre = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemReload = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.contextMenuStripRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = global::Artifact.Properties.Resources.search;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.buttonSearch.Image = global::Artifact.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(161, 64);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(26, 26);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Tag = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.btnButtonClick);
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonWallpaper);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMusic);
            this.splitContainer1.Panel1.Controls.Add(this.labelCount);
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
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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
            // buttonWallpaper
            // 
            this.buttonWallpaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonWallpaper.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonWallpaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWallpaper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWallpaper.Image = global::Artifact.Properties.Resources.picture;
            this.buttonWallpaper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWallpaper.Location = new System.Drawing.Point(0, 321);
            this.buttonWallpaper.Name = "buttonWallpaper";
            this.buttonWallpaper.Size = new System.Drawing.Size(200, 55);
            this.buttonWallpaper.TabIndex = 15;
            this.buttonWallpaper.Text = "电脑壁纸(&W)";
            this.buttonWallpaper.UseVisualStyleBackColor = false;
            this.buttonWallpaper.Click += new System.EventHandler(this.buttonWallpaper_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMusic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMusic.Image = global::Artifact.Properties.Resources.music;
            this.buttonMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusic.Location = new System.Drawing.Point(0, 267);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(200, 55);
            this.buttonMusic.TabIndex = 14;
            this.buttonMusic.Text = "音乐频道(&M)";
            this.buttonMusic.UseVisualStyleBackColor = false;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.ForeColor = System.Drawing.Color.Red;
            this.labelCount.Location = new System.Drawing.Point(145, 134);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 12);
            this.labelCount.TabIndex = 13;
            // 
            // buttonNotice
            // 
            this.buttonNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonNotice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNotice.Image = global::Artifact.Properties.Resources.icon_cancel_active;
            this.buttonNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotice.Location = new System.Drawing.Point(-1, 213);
            this.buttonNotice.Name = "buttonNotice";
            this.buttonNotice.Size = new System.Drawing.Size(200, 55);
            this.buttonNotice.TabIndex = 12;
            this.buttonNotice.Text = "最新公告(&B)";
            this.buttonNotice.UseVisualStyleBackColor = false;
            this.buttonNotice.Click += new System.EventHandler(this.buttonNotice_Click);
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
            this.pictureBoxAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.ErrorImage")));
            this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
            this.pictureBoxAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.InitialImage")));
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
            this.buttonChat.Image = ((System.Drawing.Image)(resources.GetObject("buttonChat.Image")));
            this.buttonChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChat.Location = new System.Drawing.Point(0, 105);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(200, 55);
            this.buttonChat.TabIndex = 8;
            this.buttonChat.Text = "联系客服(&K)";
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
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
            this.buttonUserOnline.Click += new System.EventHandler(this.buttonUserOnline_Click);
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
            this.buttonResetPassword.Image = global::Artifact.Properties.Resources.icon_signed_5;
            this.buttonResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetPassword.Location = new System.Drawing.Point(0, 159);
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
            this.textBoxKey.Location = new System.Drawing.Point(13, 64);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(148, 26);
            this.textBoxKey.TabIndex = 3;
            this.textBoxKey.Visible = false;
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(801, 659);
            this.splitContainer2.SplitterDistance = 503;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.buttonMin);
            this.splitContainer4.Panel1.Controls.Add(this.webBrowserMessage);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackgroundImage = global::Artifact.Properties.Resources.bar1;
            this.splitContainer4.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer4.Panel2.Controls.Add(this.combFontSize);
            this.splitContainer4.Panel2.Controls.Add(this.btnPic);
            this.splitContainer4.Panel2.Controls.Add(this.btnSubScript);
            this.splitContainer4.Panel2.Controls.Add(this.btnSuperScript);
            this.splitContainer4.Panel2.Controls.Add(this.btnBold);
            this.splitContainer4.Panel2.Controls.Add(this.btnLeft);
            this.splitContainer4.Panel2.Controls.Add(this.btnItalic);
            this.splitContainer4.Panel2.Controls.Add(this.btnCenter);
            this.splitContainer4.Panel2.Controls.Add(this.btnUnderLine);
            this.splitContainer4.Panel2.Controls.Add(this.btnRight);
            this.splitContainer4.Panel2.Controls.Add(this.btnStrikeLine);
            this.splitContainer4.Panel2.Controls.Add(this.btnFont);
            this.splitContainer4.Panel2.Controls.Add(this.btnIdent);
            this.splitContainer4.Panel2.Controls.Add(this.btnBackgroundColor);
            this.splitContainer4.Panel2.Controls.Add(this.btnOutIdent);
            this.splitContainer4.Panel2.Controls.Add(this.btnForeColor);
            this.splitContainer4.Panel2.Controls.Add(this.btnUl);
            this.splitContainer4.Panel2.Controls.Add(this.buttonFace);
            this.splitContainer4.Panel2.Controls.Add(this.checkBoxNotice);
            this.splitContainer4.Panel2.Controls.Add(this.checkBoxCut);
            this.splitContainer4.Panel2.Controls.Add(this.richTextBoxMessageList);
            this.splitContainer4.Panel2.Controls.Add(this.buttonCaputre);
            this.splitContainer4.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.splitContainer4.Panel2MinSize = 40;
            this.splitContainer4.Size = new System.Drawing.Size(801, 503);
            this.splitContainer4.SplitterDistance = 462;
            this.splitContainer4.SplitterWidth = 1;
            this.splitContainer4.TabIndex = 4;
            // 
            // webBrowserMessage
            // 
            this.webBrowserMessage.AllowNavigation = false;
            this.webBrowserMessage.AllowWebBrowserDrop = false;
            this.webBrowserMessage.ContextMenuStrip = this.contextMenuStripRight;
            this.webBrowserMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMessage.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserMessage.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMessage.Name = "webBrowserMessage";
            this.webBrowserMessage.ScriptErrorsSuppressed = true;
            this.webBrowserMessage.Size = new System.Drawing.Size(801, 462);
            this.webBrowserMessage.TabIndex = 2;
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Location = new System.Drawing.Point(778, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(24, 23);
            this.buttonMin.TabIndex = 3;
            this.buttonMin.Text = "--";
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // combFontSize
            // 
            this.combFontSize.FormattingEnabled = true;
            this.combFontSize.Items.AddRange(new object[] {
            "5",
            "5.5",
            "6.5",
            "7.5",
            "8",
            "9",
            "10",
            "10.5",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.combFontSize.Location = new System.Drawing.Point(185, 11);
            this.combFontSize.Name = "combFontSize";
            this.combFontSize.Size = new System.Drawing.Size(71, 20);
            this.combFontSize.TabIndex = 22;
            this.combFontSize.Text = "字体大小";
            this.combFontSize.Visible = false;
            this.combFontSize.SelectedIndexChanged += new System.EventHandler(this.combFontSize_SelectedIndexChanged);
            // 
            // btnPic
            // 
            this.btnPic.Image = global::Artifact.Properties.Resources.picture;
            this.btnPic.Location = new System.Drawing.Point(678, 9);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(24, 23);
            this.btnPic.TabIndex = 21;
            this.btnPic.Tag = "Pic";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnSubScript
            // 
            this.btnSubScript.Image = global::Artifact.Properties.Resources.subscript;
            this.btnSubScript.Location = new System.Drawing.Point(651, 9);
            this.btnSubScript.Name = "btnSubScript";
            this.btnSubScript.Size = new System.Drawing.Size(24, 23);
            this.btnSubScript.TabIndex = 20;
            this.btnSubScript.Tag = "SubScript";
            this.btnSubScript.UseVisualStyleBackColor = true;
            this.btnSubScript.Visible = false;
            this.btnSubScript.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnSuperScript
            // 
            this.btnSuperScript.Image = global::Artifact.Properties.Resources.superscript;
            this.btnSuperScript.Location = new System.Drawing.Point(624, 9);
            this.btnSuperScript.Name = "btnSuperScript";
            this.btnSuperScript.Size = new System.Drawing.Size(24, 23);
            this.btnSuperScript.TabIndex = 19;
            this.btnSuperScript.Tag = "SuperScript";
            this.btnSuperScript.UseVisualStyleBackColor = true;
            this.btnSuperScript.Visible = false;
            this.btnSuperScript.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnBold
            // 
            this.btnBold.Image = global::Artifact.Properties.Resources.bold;
            this.btnBold.Location = new System.Drawing.Point(597, 9);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(24, 23);
            this.btnBold.TabIndex = 18;
            this.btnBold.Tag = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Visible = false;
            this.btnBold.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::Artifact.Properties.Resources.align_left;
            this.btnLeft.Location = new System.Drawing.Point(570, 9);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(24, 23);
            this.btnLeft.TabIndex = 17;
            this.btnLeft.Tag = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnItalic
            // 
            this.btnItalic.Image = global::Artifact.Properties.Resources.italic;
            this.btnItalic.Location = new System.Drawing.Point(543, 9);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(24, 23);
            this.btnItalic.TabIndex = 16;
            this.btnItalic.Tag = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Visible = false;
            this.btnItalic.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnCenter
            // 
            this.btnCenter.Image = global::Artifact.Properties.Resources.align_center;
            this.btnCenter.Location = new System.Drawing.Point(516, 9);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(24, 23);
            this.btnCenter.TabIndex = 15;
            this.btnCenter.Tag = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Visible = false;
            this.btnCenter.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnUnderLine
            // 
            this.btnUnderLine.Image = global::Artifact.Properties.Resources.underline;
            this.btnUnderLine.Location = new System.Drawing.Point(489, 9);
            this.btnUnderLine.Name = "btnUnderLine";
            this.btnUnderLine.Size = new System.Drawing.Size(24, 23);
            this.btnUnderLine.TabIndex = 14;
            this.btnUnderLine.Tag = "UnderLine";
            this.btnUnderLine.UseVisualStyleBackColor = true;
            this.btnUnderLine.Visible = false;
            this.btnUnderLine.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnRight
            // 
            this.btnRight.Image = global::Artifact.Properties.Resources.align_right;
            this.btnRight.Location = new System.Drawing.Point(462, 9);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(24, 23);
            this.btnRight.TabIndex = 13;
            this.btnRight.Tag = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnStrikeLine
            // 
            this.btnStrikeLine.Image = global::Artifact.Properties.Resources.strikeout;
            this.btnStrikeLine.Location = new System.Drawing.Point(435, 9);
            this.btnStrikeLine.Name = "btnStrikeLine";
            this.btnStrikeLine.Size = new System.Drawing.Size(24, 23);
            this.btnStrikeLine.TabIndex = 12;
            this.btnStrikeLine.Tag = "StrikeLine";
            this.btnStrikeLine.UseVisualStyleBackColor = true;
            this.btnStrikeLine.Visible = false;
            this.btnStrikeLine.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnFont
            // 
            this.btnFont.Image = global::Artifact.Properties.Resources.font;
            this.btnFont.Location = new System.Drawing.Point(408, 9);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(24, 23);
            this.btnFont.TabIndex = 11;
            this.btnFont.Tag = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Visible = false;
            this.btnFont.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnIdent
            // 
            this.btnIdent.Image = global::Artifact.Properties.Resources.indent;
            this.btnIdent.Location = new System.Drawing.Point(381, 9);
            this.btnIdent.Name = "btnIdent";
            this.btnIdent.Size = new System.Drawing.Size(24, 23);
            this.btnIdent.TabIndex = 10;
            this.btnIdent.Tag = "Indent";
            this.btnIdent.UseVisualStyleBackColor = true;
            this.btnIdent.Visible = false;
            this.btnIdent.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Image = global::Artifact.Properties.Resources.background;
            this.btnBackgroundColor.Location = new System.Drawing.Point(354, 9);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(24, 23);
            this.btnBackgroundColor.TabIndex = 9;
            this.btnBackgroundColor.Tag = "BGColor";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Visible = false;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnOutIdent
            // 
            this.btnOutIdent.Image = global::Artifact.Properties.Resources.outdent;
            this.btnOutIdent.Location = new System.Drawing.Point(327, 9);
            this.btnOutIdent.Name = "btnOutIdent";
            this.btnOutIdent.Size = new System.Drawing.Size(24, 23);
            this.btnOutIdent.TabIndex = 8;
            this.btnOutIdent.Tag = "OutIndent";
            this.btnOutIdent.UseVisualStyleBackColor = true;
            this.btnOutIdent.Visible = false;
            this.btnOutIdent.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Image = global::Artifact.Properties.Resources.foreground;
            this.btnForeColor.Location = new System.Drawing.Point(300, 9);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(24, 23);
            this.btnForeColor.TabIndex = 7;
            this.btnForeColor.Tag = "ForeColor";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Visible = false;
            this.btnForeColor.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // btnUl
            // 
            this.btnUl.Image = global::Artifact.Properties.Resources.ul;
            this.btnUl.Location = new System.Drawing.Point(273, 9);
            this.btnUl.Name = "btnUl";
            this.btnUl.Size = new System.Drawing.Size(24, 23);
            this.btnUl.TabIndex = 6;
            this.btnUl.Tag = "Ul";
            this.btnUl.UseVisualStyleBackColor = true;
            this.btnUl.Visible = false;
            this.btnUl.Click += new System.EventHandler(this.btnButtonClick);
            // 
            // buttonFace
            // 
            this.buttonFace.BackColor = System.Drawing.Color.Transparent;
            this.buttonFace.FlatAppearance.BorderSize = 0;
            this.buttonFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFace.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonFace.Image = global::Artifact.Properties.Resources.face;
            this.buttonFace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFace.Location = new System.Drawing.Point(3, 2);
            this.buttonFace.Name = "buttonFace";
            this.buttonFace.Size = new System.Drawing.Size(40, 35);
            this.buttonFace.TabIndex = 5;
            this.buttonFace.Tag = "";
            this.buttonFace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipButton.SetToolTip(this.buttonFace, "表情");
            this.buttonFace.UseVisualStyleBackColor = false;
            this.buttonFace.Click += new System.EventHandler(this.buttonFace_Click);
            // 
            // checkBoxNotice
            // 
            this.checkBoxNotice.AutoSize = true;
            this.checkBoxNotice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxNotice.Location = new System.Drawing.Point(708, 13);
            this.checkBoxNotice.Name = "checkBoxNotice";
            this.checkBoxNotice.Size = new System.Drawing.Size(72, 16);
            this.checkBoxNotice.TabIndex = 4;
            this.checkBoxNotice.Text = "公告信息";
            this.checkBoxNotice.UseVisualStyleBackColor = true;
            this.checkBoxNotice.Visible = false;
            // 
            // checkBoxCut
            // 
            this.checkBoxCut.AutoSize = true;
            this.checkBoxCut.ForeColor = System.Drawing.Color.Black;
            this.checkBoxCut.Location = new System.Drawing.Point(83, 13);
            this.checkBoxCut.Name = "checkBoxCut";
            this.checkBoxCut.Size = new System.Drawing.Size(96, 16);
            this.checkBoxCut.TabIndex = 2;
            this.checkBoxCut.Text = "截图隐藏窗口";
            this.checkBoxCut.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMessageList
            // 
            this.richTextBoxMessageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessageList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxMessageList.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxMessageList.Location = new System.Drawing.Point(47, -127);
            this.richTextBoxMessageList.Name = "richTextBoxMessageList";
            this.richTextBoxMessageList.ShowSelectionMargin = true;
            this.richTextBoxMessageList.Size = new System.Drawing.Size(282, 100);
            this.richTextBoxMessageList.TabIndex = 1;
            this.richTextBoxMessageList.Text = "";
            this.richTextBoxMessageList.Visible = false;
            this.richTextBoxMessageList.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxMessageList_LinkClicked);
            // 
            // buttonCaputre
            // 
            this.buttonCaputre.FlatAppearance.BorderSize = 0;
            this.buttonCaputre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaputre.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCaputre.Image = global::Artifact.Properties.Resources.cap;
            this.buttonCaputre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaputre.Location = new System.Drawing.Point(37, 6);
            this.buttonCaputre.Name = "buttonCaputre";
            this.buttonCaputre.Size = new System.Drawing.Size(44, 28);
            this.buttonCaputre.TabIndex = 1;
            this.buttonCaputre.Tag = "";
            this.buttonCaputre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipButton.SetToolTip(this.buttonCaputre, "截图");
            this.buttonCaputre.UseVisualStyleBackColor = false;
            this.buttonCaputre.Click += new System.EventHandler(this.buttonCaputre_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.splitContainer3.Panel2.Controls.Add(this.buttonSend);
            this.splitContainer3.Panel2.Controls.Add(this.buttonExit);
            this.splitContainer3.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer3.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.splitContainer3.Panel2MinSize = 50;
            this.splitContainer3.Size = new System.Drawing.Size(801, 155);
            this.splitContainer3.SplitterDistance = 107;
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
            this.richTextBoxMessage.Size = new System.Drawing.Size(781, 87);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTips.Location = new System.Drawing.Point(81, 10);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(0, 12);
            this.labelTips.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSend.Location = new System.Drawing.Point(674, 6);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "发送(&S)";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(76)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(548, 6);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "关闭(&E)";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // contextMenuStripRight
            // 
            this.contextMenuStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReload});
            this.contextMenuStripRight.Name = "contextMenuStripRight";
            this.contextMenuStripRight.Size = new System.Drawing.Size(149, 26);
            // 
            // toolStripMenuItemReload
            // 
            this.toolStripMenuItemReload.Name = "toolStripMenuItemReload";
            this.toolStripMenuItemReload.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemReload.Text = "重新加载数据";
            this.toolStripMenuItemReload.Click += new System.EventHandler(this.toolStripMenuItemReload_Click);
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
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.contextMenuStripRight.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox checkBoxNotice;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.CheckBox checkBoxCut;
        private System.Windows.Forms.Button buttonFace;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnUl;
        private System.Windows.Forms.ComboBox combFontSize;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnSubScript;
        private System.Windows.Forms.Button btnSuperScript;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnUnderLine;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnStrikeLine;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnIdent;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnOutIdent;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button buttonWallpaper;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReload;
    }
}

