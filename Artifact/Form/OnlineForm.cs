﻿using System;
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
    public partial class OnlineForm : Form
    {
        public OnlineForm()
        {
            InitializeComponent();
            Response res = new Response();
            this.webBrowserOnline.Navigate(new Uri(res.getHtmlOnline()));
        }
    }
}
