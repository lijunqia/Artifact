using System;
using System.Collections.Generic;
using System.Text;

namespace Artifact.Api
{
    public class User
    {
        public string user_id { get; set; }
        public string role_id { get; set; }
        public string user_code { get; set; }
        public string user_parent_code { get; set; }
        public string user_password { get; set; }
        public string user_name { get; set; }
        public string user_mobile { get; set; }
        public string user_email { get; set; }
        public string user_expire { get; set; }
        public string user_last_time { get; set; }
        public string user_last_ip { get; set; }
        public string user_login_num { get; set; }
        public string user_is_delete { get; set; }
        public string user_is_exp { get; set; }
        public string user_remark { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string user_is_service { get; set; }


        public string token { get; set; }


    }
}
