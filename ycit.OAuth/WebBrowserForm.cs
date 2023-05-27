using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ycit
{
    internal partial class WebBrowserForm : Form
    {
        //private const int URLMON_OPTION_USERAGENT = 0x10000001;

        public UserInfo UserInfo { get; set; }=new UserInfo();

        private readonly string url;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"> 账号 </param>
        /// <param name="password"> 密码 </param>
        /// <param name="url"> 登录地址 </param>
        /// <param name="visible"> 窗口是否可见 </param>
        public WebBrowserForm(string username, string password, string url, bool visible = false)
        {
            InitializeComponent();

            this.url = url;
            if (!visible)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            SuppressWininetBehavior();

            UserInfo.Username = username;
            UserInfo.Password = password;
            //ChangeUserAgent("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.96 Safari/537.36 Edg/88.0.705.50");
            this.webBrowser.Url = new Uri(url);

            //while (webBrowser.ReadyState != WebBrowserReadyState.Complete)
            //{
            //    Application.DoEvents();
            //}

            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        public WebBrowserForm(UserInfo userInfo, string url) : this(userInfo.Username, userInfo.Password, url) { }

        /******用于修改UA******
        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);

        /// <summary>
        /// 修改UserAgent
        /// </summary>
        /// <param name="userAgent"> </param>
        private void ChangeUserAgent(string userAgent)
        {
            UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, userAgent, userAgent.Length, 0);
        }
        */

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetSetOption(int hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        /// <summary>
        /// 使用InternetSetOption操作wininet.dll清除webbrowser里的cookie
        /// </summary>
        private static unsafe void SuppressWininetBehavior()
        {
            /* SOURCE: http://msdn.microsoft.com/en-us/library/windows/desktop/aa385328%28v=vs.85%29.aspx
                * INTERNET_OPTION_SUPPRESS_BEHAVIOR (81):
                *      A general purpose option that is used to suppress behaviors on a process-wide basis.
                *      The lpBuffer parameter of the function must be a pointer to a DWORD containing the specific behavior to suppress.
                *      This option cannot be queried with InternetQueryOption.
                *
                * INTERNET_SUPPRESS_COOKIE_PERSIST (3):
                *      Suppresses the persistence of cookies, even if the server has specified them as persistent.
                *      Version:  Requires Internet Explorer 8.0 or later.
                */
            int option = (int)3/* INTERNET_SUPPRESS_COOKIE_PERSIST*/;
            int* optionPtr = &option;

            bool success = InternetSetOption(0, 81/*INTERNET_OPTION_SUPPRESS_BEHAVIOR*/, new IntPtr(optionPtr), sizeof(int));
            if (!success)
            {
                throw new Exception("清理cookie失败");
            }
        }

        /// <summary>
        /// 加载完成
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.Document.Title == "盐城工学院健康信息报送系统")
            {
                //自动填充账号密码
                webBrowser.Document.GetElementById("username").SetAttribute("value", UserInfo.Username);
                webBrowser.Document.GetElementById("password").SetAttribute("value", UserInfo.Password);
            }
            else if (webBrowser.Document.Title.Contains("个人信息"))
            {
                //保存cookie
                UserInfo.Csrftoken = GetInfoByCookie(url, "csrftoken");
                UserInfo.Sessionid = GetInfoByCookie(url, "sessionid");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int InternetSetCookieEx(string lpszURL, string lpszCookieName, string lpszCookieData, int dwFlags, IntPtr dwReserved);

        /// <summary>
        /// 获取cookie
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string GetCookieString(string url)
        {
            // Determine the size of the cookie     
            uint datasize = 256;
            StringBuilder cookieData = new StringBuilder((int)datasize);

            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x2000, IntPtr.Zero))
            {
                if (datasize < 0)
                    return null;

                // Allocate stringbuilder large enough to hold the cookie     
                cookieData = new StringBuilder((int)datasize);
                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, IntPtr.Zero))
                    return null;
            }
            return cookieData.ToString();
        }

        /// <summary>
        /// 获取指定cookie条目的信息
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private string GetInfoByCookie(string url, string type)
        {
            //string cookStr = "cbAccount=11111;systemAccountId=0;systemCode=aaa";
            string cookStr = GetCookieString(url);//传参是获取cookie的URL
            if (cookStr != null && !"".Equals(cookStr))
            {
                string[] sArray = Regex.Split(cookStr, ";", RegexOptions.IgnoreCase);
                foreach (string cookie in sArray)
                {
                    string[] cookieArry = Regex.Split(cookie, "=", RegexOptions.IgnoreCase);
                    foreach (string cook in cookieArry)
                    {
                        string tmpCook = cook.Trim();
                        if (tmpCook == type)
                        {
                            return cookieArry[1];
                        }
                    }
                }
            }
            return "";
        }
    }
}
