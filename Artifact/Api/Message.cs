using System;
using System.Collections.Generic;
using System.Text;

namespace Artifact.Api
{
    class Message
    {
        public string message_id { get; set; }
        public string user_id { get; set; }
        public string message_text { get; set; }
        public string message_time { get; set; }
        public string message_is_exp { get; set; }
        public string message_created { get; set; }
        public string message_updated { get; set; }
    }
}
