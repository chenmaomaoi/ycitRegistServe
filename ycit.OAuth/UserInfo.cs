using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ycit
{
    public class UserInfo
    {
        public UserInfo(string username = null, string password = null, string csrftoken = null, string sessionid = null)
        {
            this.Username = username;
            this.Password = password;
            this.Csrftoken = csrftoken;
            this.Sessionid = sessionid;
        }

        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// csrftoken
        /// </summary>
        public string Csrftoken { get; set; }

        /// <summary>
        /// sessionid
        /// </summary>
        public string Sessionid { get; set; }
    }
}
