using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Artifact.Api;

namespace Artifact
{
    static class Program
    {
        public static User user;

        public static LoginForm loginForm;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //*************************直接启动登陆界面***************************
            //检查当前软件是否已经启动，如果已经启动，提示信息不能重复启动
            bool openExe = false;
            System.Threading.Mutex mm = new System.Threading.Mutex(true, Application.ProductName, out openExe);
            if (!openExe)
            {
                MessageBox.Show("你已经启动该程序！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //显示登陆用户界面
            loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
