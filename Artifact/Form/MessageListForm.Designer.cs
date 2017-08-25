namespace Artifact
{
    partial class MessageListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageListForm));
            this.dataGridViewMessageList = new System.Windows.Forms.DataGridView();
            this.messageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagetextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageisexpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagecreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelLoading = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelTotalPage = new System.Windows.Forms.Label();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.buttonPre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessageList)).BeginInit();
            this.contextMenuStripManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMessageList
            // 
            this.dataGridViewMessageList.AllowUserToAddRows = false;
            this.dataGridViewMessageList.AllowUserToOrderColumns = true;
            this.dataGridViewMessageList.AutoGenerateColumns = false;
            this.dataGridViewMessageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageidDataGridViewTextBoxColumn,
            this.messagetextDataGridViewTextBoxColumn,
            this.messageisexpDataGridViewTextBoxColumn,
            this.messagecreatedDataGridViewTextBoxColumn});
            this.dataGridViewMessageList.ContextMenuStrip = this.contextMenuStripManage;
            this.dataGridViewMessageList.DataSource = this.messageBindingSource;
            this.dataGridViewMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMessageList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMessageList.Name = "dataGridViewMessageList";
            this.dataGridViewMessageList.ReadOnly = true;
            this.dataGridViewMessageList.RowHeadersWidth = 20;
            this.dataGridViewMessageList.RowTemplate.Height = 23;
            this.dataGridViewMessageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMessageList.ShowCellErrors = false;
            this.dataGridViewMessageList.ShowRowErrors = false;
            this.dataGridViewMessageList.Size = new System.Drawing.Size(717, 495);
            this.dataGridViewMessageList.TabIndex = 0;
            // 
            // messageidDataGridViewTextBoxColumn
            // 
            this.messageidDataGridViewTextBoxColumn.DataPropertyName = "message_id";
            this.messageidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.messageidDataGridViewTextBoxColumn.Name = "messageidDataGridViewTextBoxColumn";
            this.messageidDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageidDataGridViewTextBoxColumn.Width = 50;
            // 
            // messagetextDataGridViewTextBoxColumn
            // 
            this.messagetextDataGridViewTextBoxColumn.DataPropertyName = "message_text";
            this.messagetextDataGridViewTextBoxColumn.HeaderText = "内容";
            this.messagetextDataGridViewTextBoxColumn.Name = "messagetextDataGridViewTextBoxColumn";
            this.messagetextDataGridViewTextBoxColumn.ReadOnly = true;
            this.messagetextDataGridViewTextBoxColumn.Width = 400;
            // 
            // messageisexpDataGridViewTextBoxColumn
            // 
            this.messageisexpDataGridViewTextBoxColumn.DataPropertyName = "message_is_exp";
            this.messageisexpDataGridViewTextBoxColumn.HeaderText = "是否体验";
            this.messageisexpDataGridViewTextBoxColumn.Name = "messageisexpDataGridViewTextBoxColumn";
            this.messageisexpDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageisexpDataGridViewTextBoxColumn.Width = 80;
            // 
            // messagecreatedDataGridViewTextBoxColumn
            // 
            this.messagecreatedDataGridViewTextBoxColumn.DataPropertyName = "message_created";
            this.messagecreatedDataGridViewTextBoxColumn.HeaderText = "发布时间";
            this.messagecreatedDataGridViewTextBoxColumn.Name = "messagecreatedDataGridViewTextBoxColumn";
            this.messagecreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStripManage
            // 
            this.contextMenuStripManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDelete});
            this.contextMenuStripManage.Name = "contextMenuStripManage";
            this.contextMenuStripManage.Size = new System.Drawing.Size(142, 26);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItemDelete.Text = "删除信息(&D)";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(Artifact.Api.Message);
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewMessageList);
            this.splitContainer1.Size = new System.Drawing.Size(717, 547);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelLoading
            // 
            this.labelLoading.Location = new System.Drawing.Point(570, 17);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(100, 17);
            this.labelLoading.TabIndex = 19;
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Red;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLast.Location = new System.Drawing.Point(514, 12);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(32, 23);
            this.buttonLast.TabIndex = 18;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.Red;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFirst.Location = new System.Drawing.Point(317, 13);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(30, 23);
            this.buttonFirst.TabIndex = 17;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Red;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNext.Location = new System.Drawing.Point(475, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(33, 23);
            this.buttonNext.TabIndex = 16;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelTotalPage
            // 
            this.labelTotalPage.AutoSize = true;
            this.labelTotalPage.Location = new System.Drawing.Point(436, 18);
            this.labelTotalPage.Name = "labelTotalPage";
            this.labelTotalPage.Size = new System.Drawing.Size(11, 12);
            this.labelTotalPage.TabIndex = 15;
            this.labelTotalPage.Text = "/";
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(390, 15);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(40, 21);
            this.textBoxPage.TabIndex = 14;
            // 
            // buttonPre
            // 
            this.buttonPre.BackColor = System.Drawing.Color.Red;
            this.buttonPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPre.Location = new System.Drawing.Point(353, 13);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(31, 23);
            this.buttonPre.TabIndex = 13;
            this.buttonPre.Text = "<";
            this.buttonPre.UseVisualStyleBackColor = false;
            this.buttonPre.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "关键字：";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Red;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(215, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "查询(&Q)";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKey.Location = new System.Drawing.Point(84, 15);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(125, 21);
            this.textBoxKey.TabIndex = 10;
            // 
            // MessageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 547);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息列表";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessageList)).EndInit();
            this.contextMenuStripManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMessageList;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagetextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageisexpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messagecreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripManage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelTotalPage;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}