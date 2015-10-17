using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

namespace Artifact.Api
{
    class Response
    {
        public string code { get; set; }
        public string message { get; set; }
        public string items { get; set; }
        public string extra { get; set; }

        protected string apiUserLogin = "http://api.zhongyi8888.com/site/login?";
        protected string apiUserList = "http://api.zhongyi8888.com/user?";
        protected string apiUserService = "http://api.zhongyi8888.com/user/service?";
        protected string apiUserCreate = "http://api.zhongyi8888.com/user/create?";
        protected string apiUserUpdate = "http://api.zhongyi8888.com/user/update?";
        protected string apiUserDelete = "http://api.zhongyi8888.com/user/delete?";
        protected string apiUserReset = "http://api.zhongyi8888.com/user/reset?";
        protected string apiMessageCreate = "http://api.zhongyi8888.com/message/create?";
        protected string apiMessageList = "http://api.zhongyi8888.com/message?";
        protected string apiMessageDelete = "http://api.zhongyi8888.com/message/delete?";
        protected string apiMessageUpload = "http://api.zhongyi8888.com/message/upload?";
        protected string apiChatCreate = "http://api.zhongyi8888.com/chat/create?";
        protected string apiChatList = "http://api.zhongyi8888.com/chat?";
        protected string apiChatDelete = "http://api.zhongyi8888.com/chat/delete?";
        protected string apiChatUpload = "http://api.zhongyi8888.com/chat/upload?";
        protected string apiChatUser = "http://api.zhongyi8888.com/chat/user?";

        public List<User> ChatUser()
        {
            User manageUser = Program.user;
            this.SendApi(this.apiChatUser + "token=" + manageUser.token);

            try
            {
                if (this.items != "")
                {
                    /*下面是解析JArray的部分*/
                    JArray jList = JArray.Parse(this.items); //将pois部分视为一个JObject，JArray解析这个JObject的字符串
                    User user = null;      //存储附近的某个地点的信息
                    List<User> users = new List<User>();  //附近位置的列表
                    for (int i = 0; i < jList.Count; ++i)  //遍历JArray
                    {
                        Console.WriteLine(" jlist " + i.ToString() + jList[i].ToString());
                        user = (User)JsonConvert.DeserializeObject(jList[i].ToString(), typeof(User));
                        users.Add(user);
                    }

                    return users;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message list 出错 " + ex.Message);
                return null;
            }

        }

        public Snap ChatUpload(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            byte[] buffer = ms.GetBuffer();
            ms.Close();

            User user = Program.user;
            this.SendPostApi(this.apiChatUpload, "token=" + user.token + "&image=" + HttpUtility.UrlEncode(Convert.ToBase64String(buffer)));

            try
            {
                if (this.items != "")
                {
                    return (Snap)JsonConvert.DeserializeObject(this.items, typeof(Snap));
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API chat upload 出错 " + ex.Message);
                return null;
            }

        }
        public bool ChatDelete(string id)
        {
            User user = Program.user;
            this.SendApi(this.apiChatDelete + "token=" + user.token + "&id=" + id);

            try
            {
                if (this.code == "0")
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API Chat add 出错 " + ex.Message);
                return false;
            }

        }

        public Chat ChatCreate(Chat chat)
        {
            User user = Program.user;
            this.SendPostApi(this.apiChatCreate, "token=" + user.token + "&text=" + chat.chat_text + "&to=" + chat.chat_user_id);

            try
            {
                if (this.items != "")
                {
                    return (Chat)JsonConvert.DeserializeObject(this.items, typeof(Chat));
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API Chat add 出错 " + ex.Message);
                return null;
            }

        }

        public List<Chat> ChatList(int maxId = 0, string to = "", int page = 0, int size = 20, string q = "")
        {
            User manageUser = Program.user;
            this.SendApi(this.apiChatList + "token=" + manageUser.token + "&min=" + maxId.ToString() + "&to=" + to.ToString() + "&page=" + page.ToString() + "&size=" + size.ToString() + "&q=" + q);

            try
            {
                if (this.items != "")
                {
                    /*下面是解析JArray的部分*/
                    JArray jList = JArray.Parse(this.items); //将pois部分视为一个JObject，JArray解析这个JObject的字符串
                    Chat chat = null;      //存储附近的某个地点的信息
                    List<Chat> chats = new List<Chat>();  //附近位置的列表
                    for (int i = 0; i < jList.Count; ++i)  //遍历JArray
                    {
                        Console.WriteLine(" jlist " + i.ToString() + jList[i].ToString());
                        chat = (Chat)JsonConvert.DeserializeObject(jList[i].ToString(), typeof(Chat));
                        chats.Add(chat);
                    }

                    return chats;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API Chat list 出错 " + ex.Message);
                return null;
            }

        }


        public Snap MessageUpload(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            byte[] buffer = ms.GetBuffer();
            ms.Close();

            User user = Program.user;
            this.SendPostApi(this.apiMessageUpload, "token=" + user.token + "&image=" + HttpUtility.UrlEncode(Convert.ToBase64String(buffer)));

            try
            {
                if (this.items != "")
                {
                    return (Snap)JsonConvert.DeserializeObject(this.items, typeof(Snap));
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message upload 出错 " + ex.Message);
                return null;
            }

        }
        public bool MessageDelete(string id)
        {
            User user = Program.user;
            this.SendApi(this.apiMessageDelete + "token=" + user.token + "&id=" + id);

            try
            {
                if (this.code == "0")
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message add 出错 " + ex.Message);
                return false;
            }

        }

        public Message MessageCreate(Message message)
        {
            User user = Program.user;
            this.SendPostApi(this.apiMessageCreate, "token=" + user.token + "&text=" + message.message_text + "&exp=" + message.message_is_exp + "&time=" + message.message_time);

            try
            {
                if (this.items != "")
                {
                    return (Message)JsonConvert.DeserializeObject(this.items, typeof(Message));
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message add 出错 " + ex.Message);
                return null;
            }

        }

        public List<Message> MessageList(int maxId = 0, int page = 0, int size = 20, string q = "")
        {
            User manageUser = Program.user;
            this.SendApi(this.apiMessageList + "token=" + manageUser.token + "&min=" + maxId.ToString() + "&page=" + page + "&size=" + size + "&q=" + q);

            try
            {
                if (this.items != "")
                {
                    /*下面是解析JArray的部分*/
                    JArray jList = JArray.Parse(this.items); //将pois部分视为一个JObject，JArray解析这个JObject的字符串
                    Message message = null;      //存储附近的某个地点的信息
                    List<Message> messages = new List<Message>();  //附近位置的列表
                    for (int i = 0; i < jList.Count; ++i)  //遍历JArray
                    {
                        Console.WriteLine(" jlist " + i.ToString() + jList[i].ToString());
                        message = (Message)JsonConvert.DeserializeObject(jList[i].ToString(), typeof(Message));
                        messages.Add(message);
                    }

                    return messages;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message list 出错 " + ex.Message);
                return null;
            }

        }


        public List<User> UserService()
        {
            User manageUser = Program.user;
            this.SendApi(this.apiUserService + "token=" + manageUser.token );

            try
            {
                if (this.items != "")
                {
                    /*下面是解析JArray的部分*/
                    JArray jList = JArray.Parse(this.items); //将pois部分视为一个JObject，JArray解析这个JObject的字符串
                    User user = null;      //存储附近的某个地点的信息
                    List<User> users = new List<User>();  //附近位置的列表
                    for (int i = 0; i < jList.Count; ++i)  //遍历JArray
                    {
                        Console.WriteLine(" jlist " + i.ToString() + jList[i].ToString());
                        user = (User)JsonConvert.DeserializeObject(jList[i].ToString(), typeof(User));
                        users.Add(user);
                    }

                    return users;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message list 出错 " + ex.Message);
                return null;
            }

        }

        public List<User> UserList(int maxId = 0, int page = 0, int size = 20, string q = "")
        {
            User manageUser = Program.user;
            this.SendApi(this.apiUserList + "token=" + manageUser.token + "&min=" + maxId.ToString() + "&size=" + size.ToString() + "&page=" + page.ToString() + "&q=" + q);

            try
            {
                if (this.items != "")
                {
                    /*下面是解析JArray的部分*/
                    JArray jList = JArray.Parse(this.items); //将pois部分视为一个JObject，JArray解析这个JObject的字符串
                    User user = null;      //存储附近的某个地点的信息
                    List<User> users = new List<User>();  //附近位置的列表
                    for (int i = 0; i < jList.Count; ++i)  //遍历JArray
                    {
                        Console.WriteLine(" jlist " + i.ToString() + jList[i].ToString());
                        user = (User)JsonConvert.DeserializeObject(jList[i].ToString(), typeof(User));
                        users.Add(user);
                    }

                    return users;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message list 出错 " + ex.Message);
                return null;
            }

        }


        public User UserCreate(User user)
        {
            User manageUser = Program.user;
            this.SendApi(this.apiUserCreate + "token=" + manageUser.token + "&code=" + user.user_code + "&pwd=" + user.user_password + "&role=" + user.role_id + "&name=" + user.user_name + "&expire=" + user.user_expire + "&mobile=" + user.user_mobile + "&email=" + user.user_email + "&remark=" + user.user_remark + "&pcode=" + user.user_parent_code + "&service=" + user.user_is_service);

            try
            {
                if (this.items != "")
                {
                    return (User)JsonConvert.DeserializeObject(this.items, typeof(User));
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API create 出错 " + ex.Message);
                return null;
            }

        }


        public User UserUpdate(User user)
        {
            User manageUser = Program.user;
            this.SendApi(this.apiUserUpdate + "token=" + manageUser.token + "&id=" + user.user_id + "&code=" + user.user_code + "&pwd=" + user.user_password + "&role=" + user.role_id + "&name=" + user.user_name + "&expire=" + user.user_expire + "&mobile=" + user.user_mobile + "&email=" + user.user_email + "&remark=" + user.user_remark + "&pcode=" + user.user_parent_code + "&service=" + user.user_is_service);

            try
            {
                if (this.items != "")
                {
                    return (User)JsonConvert.DeserializeObject(this.items, typeof(User));
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API update 出错 " + ex.Message);
                return null;
            }

        }
        public bool UserDelete(string id)
        {
            User manageUser = Program.user;
            this.SendApi(this.apiUserDelete + "token=" + manageUser.token + "&id=" + id);

            try
            {
                if (this.code == "0")
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API message add 出错 " + ex.Message);
                return false;
            }

        }

        public bool UserReset(string old, string pwd)
        {
            User manageUser = Program.user;
            this.SendApi(this.apiUserReset + "token=" + manageUser.token + "&old=" + old + "&pwd=" + pwd);

            try
            {
                if (this.code == "0")
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API reset 出错 " + ex.Message);
                return false;
            }
        }

        public User UserLogin(string code, string pwd)
        {
            this.SendApi(this.apiUserLogin + "code=" + code + "&pwd=" + pwd);

            try
            {
                if (this.items != "")
                {
                    return Program.user = (User)JsonConvert.DeserializeObject(this.items, typeof(User));
                    
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API login 出错 " + ex.Message);
                return null;
            }
        }

        public void SendApi(string uri)
        {
            try
            {
                WebClient client = new WebClient();
                client.Proxy = null;
                Console.WriteLine(" uri " + uri);
                string apiText = client.DownloadString(uri);
                Console.WriteLine(" 返回 "+apiText);
                JObject jsonObj = JObject.Parse(apiText);
                if (jsonObj.Count > 1)
                {
                    this.code = jsonObj["code"].ToString();
                    this.message = jsonObj["message"].ToString();
                    this.extra = ((jsonObj.Property("extra") == null || jsonObj.Property("extra").ToString() == "") ? "" : jsonObj["extra"].ToString());
                    this.items = jsonObj["items"].ToString();
                    //Console.WriteLine(" 返回  items" + this.items);
                    if (this.items == "[]")
                        this.items = "";
                    if (this.code == "1004")
                    {
                        if (Program.loginForm.IsDisposed == true)
                        {
                            Program.loginForm = new LoginForm();
                            Program.loginForm.Show();
                        }
                        if (Program.loginForm.ShowDialog() != DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API 出错 " + ex.Message);
            }
        }


        public void SendFileApi(string file, string uri, string data)
        {
            try
            {
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);

                byte[] byteFile = new byte[fs.Length];

                fs.Read(byteFile, 0, Convert.ToInt32(fs.Length));

                fs.Close();


                var webclient = new WebClient();

                webclient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                byte[] buffer = webclient.UploadData(uri, "POST", byteArray);


                string responseContent = Encoding.UTF8.GetString(buffer);
                Console.WriteLine("post 返回" + responseContent);


                JObject jsonObj = JObject.Parse(responseContent);
                if (jsonObj.Count > 1)
                {
                    this.code = jsonObj["code"].ToString();
                    this.message = jsonObj["message"].ToString();
                    this.items = jsonObj["items"].ToString();
                    this.extra = ((jsonObj.Property("extra") == null || jsonObj.Property("extra").ToString() == "") ? "" : jsonObj["extra"].ToString());
                    //Console.WriteLine("post 返回  items" + this.items);
                    if (this.items == "[]")
                        this.items = "";
                    if (this.code == "1004")
                    {
                        if (Program.loginForm.IsDisposed == true)
                        {
                            Program.loginForm = new LoginForm();
                            Program.loginForm.Show();
                        }
                        if (Program.loginForm.ShowDialog() != DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API 出错 " + ex.Message);
            }
        }

        /// <summary>
        /// 提交POST数据
        /// </summary>
        /// <param name="uri">提交地址</param>
        /// <param name="data">参数，字符串，如aa=ff&ss=sdf</param>
        public void SendPostApi(string uri,string data)
        {
            try
            {

                WebClient wc = new WebClient();

                // 采取POST方式必须加的Header
                wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                byte[] postData = Encoding.UTF8.GetBytes(data);

                byte[] responseData = wc.UploadData(uri, "POST", postData); // 得到返回字符流
                string responseContent = Encoding.UTF8.GetString(responseData);


                JObject jsonObj = JObject.Parse(responseContent);
                if (jsonObj.Count > 1)
                {
                    this.code = jsonObj["code"].ToString();
                    this.message = jsonObj["message"].ToString();
                    this.items = jsonObj["items"].ToString();
                    this.extra = ((jsonObj.Property("extra") == null || jsonObj.Property("extra").ToString() == "") ? "" : jsonObj["extra"].ToString());
                    Console.WriteLine("post 返回  items" + this.items);
                    if (this.items == "[]")
                        this.items = "";
                    if (this.code == "1004")
                    {
                        if (Program.loginForm.IsDisposed == true)
                        {
                            Program.loginForm = new LoginForm();
                            Program.loginForm.Show();
                        }
                        if (Program.loginForm.ShowDialog() != DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" API 出错 " + ex.Message);
            }
        }
    }
}
