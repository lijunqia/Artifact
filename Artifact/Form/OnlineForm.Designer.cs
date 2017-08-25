namespace Artifact
{
    partial class OnlineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineForm));
            this.webBrowserOnline = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserOnline
            // 
            this.webBrowserOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserOnline.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserOnline.Location = new System.Drawing.Point(0, 0);
            this.webBrowserOnline.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserOnline.Name = "webBrowserOnline";
            this.webBrowserOnline.Size = new System.Drawing.Size(646, 462);
            this.webBrowserOnline.TabIndex = 0;
            this.webBrowserOnline.WebBrowserShortcutsEnabled = false;
            // 
            // OnlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 462);
            this.Controls.Add(this.webBrowserOnline);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OnlineForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线用户";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserOnline;
    }
}