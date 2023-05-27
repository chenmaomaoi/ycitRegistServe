using System;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Linq;

namespace ycit
{
    public class User
    {
        /// <summary>
        /// 登录地址
        /// </summary>
        private const string URL = "https://health.xiamin.tech";

        /// <summary>
        /// 用户信息
        /// </summary>
        public UserInfo UserInfo { get;private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="csrftoken"></param>
        /// <param name="sessionid"></param>
        public User(string username, string password, string csrftoken = null, string sessionid = null)
             : this(new UserInfo(username, password, csrftoken, sessionid)) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfo">用户信息</param>
        public User(UserInfo userInfo) => this.UserInfo = userInfo;

        /// <summary>
        /// 登录，并且获取Cookie
        /// </summary>
        /// <param name="csrftoken"></param>
        /// <param name="sessionid"></param>
        /// <returns> </returns>
        public bool Login()
        {
            WebBrowserForm form = new WebBrowserForm(UserInfo.Username, UserInfo.Password, URL, true);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UserInfo.Csrftoken = form.UserInfo.Csrftoken;
                UserInfo.Sessionid = form.UserInfo.Sessionid;

                form.Dispose();
                //判断当前cookie是否有效
                return HasLogin();
            }
            else
            {
                form.Dispose();
                throw new Exception("登录取消");
            }
        }

        /// <summary>
        /// 用于判定现认证信息是否有效
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public static bool HasLogin(UserInfo userInfo)
        {
            return WebHelper.Get(new Uri(URL), $"csrftoken={userInfo.Csrftoken};sessionid={userInfo.Sessionid}").Contains("个人信息");
        }

        /// <summary>
        /// 用于判定现认证信息是否有效
        /// </summary>
        /// <returns></returns>
        public bool HasLogin() => HasLogin(UserInfo);
    }
}
