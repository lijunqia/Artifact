namespace Artifact
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.bindingSourceService = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxHistory = new System.Windows.Forms.RichTextBox();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.buttonCaputre = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(735, 609);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.labelCurrent);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxService);
            this.splitContainer2.Size = new System.Drawing.Size(172, 609);
            this.splitContainer2.SplitterDistance = 65;
            this.splitContainer2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前聊天：";
            // 
            // labelCurrent
            // 
            this.labelCurrent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCurrent.ForeColor = System.Drawing.Color.Red;
            this.labelCurrent.Location = new System.Drawing.Point(28, 31);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(100, 23);
            this.labelCurrent.TabIndex = 2;
            // 
            // listBoxService
            // 
            this.listBoxService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxService.DataSource = this.bindingSourceService;
            this.listBoxService.DisplayMember = "user_name";
            this.listBoxService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxService.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 19;
            this.listBoxService.Location = new System.Drawing.Point(0, 0);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(172, 540);
            this.listBoxService.TabIndex = 0;
            this.listBoxService.SelectedIndexChanged += new System.EventHandler(this.listBoxService_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.richTextBoxHistory);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBoxChat);
            this.splitContainer3.Panel2.Controls.Add(this.buttonCaputre);
            this.splitContainer3.Panel2.Controls.Add(this.buttonSend);
            this.splitContainer3.Size = new System.Drawing.Size(559, 609);
            this.splitContainer3.SplitterDistance = 304;
            this.splitContainer3.TabIndex = 3;
            // 
            // richTextBoxHistory
            // 
            this.richTextBoxHistory.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxHistory.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxHistory.Name = "richTextBoxHistory";
            this.richTextBoxHistory.Size = new System.Drawing.Size(559, 304);
            this.richTextBoxHistory.TabIndex = 0;
            this.richTextBoxHistory.Text = "";
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxChat.EnableAutoDragDrop = true;
            this.richTextBoxChat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxChat.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBoxChat.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.Size = new System.Drawing.Size(559, 248);
            this.richTextBoxChat.TabIndex = 0;
            this.richTextBoxChat.Text = "";
            // 
            // buttonCaputre
            // 
            this.buttonCaputre.BackColor = System.Drawing.Color.Red;
            this.buttonCaputre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaputre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCaputre.Location = new System.Drawing.Point(323, 266);
            this.buttonCaputre.Name = "buttonCaputre";
            this.buttonCaputre.Size = new System.Drawing.Size(75, 23);
            this.buttonCaputre.TabIndex = 2;
            this.buttonCaputre.Text = "截图(&C)";
            this.buttonCaputre.UseVisualStyleBackColor = false;
            this.buttonCaputre.Click += new System.EventHandler(this.buttonCaputre_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.Red;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSend.Location = new System.Drawing.Point(126, 266);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
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
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 609);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "聊天窗口";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceService)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCaputre;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox richTextBoxHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.BindingSource bindingSourceService;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}