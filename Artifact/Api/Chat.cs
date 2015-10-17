using System;
using System.Collections.Generic;
using System.Text;

namespace Artifact.Api
{
    class Chat
    {
        public string chat_id { get; set; }
        public string user_id { get; set; }
        public string chat_user_id { get; set; }
        public string chat_text { get; set; }
        public string chat_is_read { get; set; }
        public string chat_created { get; set; }
        public string chat_updated { get; set; }
        public string user { get; set; }
        public string to_user { get; set; }
    }
}
