using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artifact.Api;

namespace Artifact
{
    public partial class NoticeForm : Form
    {
        public NoticeForm()
        {
            InitializeComponent();
        }

        private void NoticeForm_Load(object sender, EventArgs e)
        {
            Response res = new Response();
            this.webBrowserNotice.Navigate(new Uri(res.getHtmlNotice()));
        }
    }
}
