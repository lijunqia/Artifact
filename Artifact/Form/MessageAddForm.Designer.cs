namespace Artifact
{
    partial class MessageAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageAddForm));
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxExp = new System.Windows.Forms.CheckBox();
            this.buttonCaputre = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxNotice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(601, 426);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(298, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "确定发布(&S)";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxExp
            // 
            this.checkBoxExp.AutoSize = true;
            this.checkBoxExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxExp.Location = new System.Drawing.Point(48, 15);
            this.checkBoxExp.Name = "checkBoxExp";
            this.checkBoxExp.Size = new System.Drawing.Size(93, 16);
            this.checkBoxExp.TabIndex = 2;
            this.checkBoxExp.Text = "体验用户查看";
            this.checkBoxExp.UseVisualStyleBackColor = true;
            // 
            // buttonCaputre
            // 
            this.buttonCaputre.BackColor = System.Drawing.Color.Red;
            this.buttonCaputre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaputre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCaputre.Location = new System.Drawing.Point(441, 12);
            this.buttonCaputre.Name = "buttonCaputre";
            this.buttonCaputre.Size = new System.Drawing.Size(102, 23);
            this.buttonCaputre.TabIndex = 3;
            this.buttonCaputre.Text = "截图(&C)";
            this.buttonCaputre.UseVisualStyleBackColor = false;
            this.buttonCaputre.Click += new System.EventHandler(this.buttonCaputre_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxNotice);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCaputre);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxExp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxText);
            this.splitContainer1.Size = new System.Drawing.Size(601, 494);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 4;
            // 
            // checkBoxNotice
            // 
            this.checkBoxNotice.AutoSize = true;
            this.checkBoxNotice.Location = new System.Drawing.Point(180, 15);
            this.checkBoxNotice.Name = "checkBoxNotice";
            this.checkBoxNotice.Size = new System.Drawing.Size(72, 16);
            this.checkBoxNotice.TabIndex = 5;
            this.checkBoxNotice.Text = "通知信息";
            this.checkBoxNotice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // MessageAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 494);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageAddForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发布信息";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxExp;
        private System.Windows.Forms.Button buttonCaputre;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNotice;
    }
}