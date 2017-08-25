namespace Artifact
{
    partial class MusicForm
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
            this.webBrowserMusic = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserMusic
            // 
            this.webBrowserMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMusic.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMusic.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMusic.Name = "webBrowserMusic";
            this.webBrowserMusic.ScriptErrorsSuppressed = true;
            this.webBrowserMusic.Size = new System.Drawing.Size(852, 517);
            this.webBrowserMusic.TabIndex = 0;
            this.webBrowserMusic.Url = new System.Uri("http://www.o9l.net/", System.UriKind.Absolute);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 517);
            this.Controls.Add(this.webBrowserMusic);
            this.Name = "MusicForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐频道";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMusic;
    }
}