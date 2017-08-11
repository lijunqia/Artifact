namespace Artifact
{
    partial class NoticeForm
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
            this.webBrowserNotice = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserNotice
            // 
            this.webBrowserNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserNotice.Location = new System.Drawing.Point(0, 0);
            this.webBrowserNotice.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserNotice.Name = "webBrowserNotice";
            this.webBrowserNotice.Size = new System.Drawing.Size(698, 503);
            this.webBrowserNotice.TabIndex = 0;
            // 
            // NoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 503);
            this.Controls.Add(this.webBrowserNotice);
            this.Name = "NoticeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "最新公告";
            this.Load += new System.EventHandler(this.NoticeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserNotice;
    }
}