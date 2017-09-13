namespace Artifact
{
    partial class WallpaperForm
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
            this.webBrowserWallpaper = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserWallpaper
            // 
            this.webBrowserWallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWallpaper.Location = new System.Drawing.Point(0, 0);
            this.webBrowserWallpaper.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWallpaper.Name = "webBrowserWallpaper";
            this.webBrowserWallpaper.Size = new System.Drawing.Size(765, 495);
            this.webBrowserWallpaper.TabIndex = 0;
            this.webBrowserWallpaper.Url = new System.Uri("http://www.43p.net/", System.UriKind.Absolute);
            // 
            // WallpaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 495);
            this.Controls.Add(this.webBrowserWallpaper);
            this.Name = "WallpaperForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电脑壁纸";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserWallpaper;
    }
}