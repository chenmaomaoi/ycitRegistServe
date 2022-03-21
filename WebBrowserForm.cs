using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ycit
{
    internal partial class WebBrowserForm : Form
    {
        private const int URLMON_OPTION_USERAGENT = 0x10000001;

        /// <summary>
        /// 账号
        /// </summary>
        private readonly string Username;

        /// <summary>
        /// 密码
        /// </summary>
        private readonly string Password;

        /// <summary>
        /// csrftoken
        /// </summary>
        public string Csrftoken { get; private set; }

        /// <summary>
        /// sessionid
        /// </summary>
        public string Sessionid { get; private set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string uName { get; private set; }

        /// <summary>
        /// 用于登录获取cookie
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userAgent"></param>
        /// <exception cref="清理cookie失败"></exception>
        /// <exception cref="获取cookie失败"></exception>
        public WebBrowserForm(string username, string password, string userAgent = null)
        {
            InitializeComponent();

            this.Username = username;
            this.Password = password;

            SuppressWininetBehavior();
            if (!string.IsNullOrWhiteSpace(userAgent))
            {
                ChangeUserAgent(userAgent);
            }

            this.webBrowser.Url = new Uri(User.URL + User.PathLogin);

            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

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

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetSetOption(int hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        /// <summary>
        /// 使用InternetSetOption操作wininet.dll清除webbrowser里的cookie
        /// </summary>
        /// <exception cref="清理cookie失败"></exception>
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
            int option = 3/* INTERNET_SUPPRESS_COOKIE_PERSIST*/;
            int* optionPtr = &option;

            if (!InternetSetOption(0, 81/*INTERNET_OPTION_SUPPRESS_BEHAVIOR*/, new IntPtr(optionPtr), sizeof(int)))
            {
                throw new Exception("清理cookie失败");
            }
        }

        /// <summary>
        /// 加载完成
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        /// <exception cref="获取cookie失败"></exception>
        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.Url.AbsolutePath == User.PathLogin)
            {
                //自动填充账号密码
                webBrowser.Document.GetElementById("username").SetAttribute("value", this.Username);
                webBrowser.Document.GetElementById("password").SetAttribute("value", this.Password);
            }
            else if (webBrowser.Url.AbsolutePath == User.PathProfile)
            {
                //保存cookie
                this.Csrftoken = GetInfoByCookie(User.URL, "csrftoken");
                this.Sessionid = GetInfoByCookie(User.URL, "sessionid");

                //获取姓名
                foreach (HtmlElement item in webBrowser.Document.All)
                {
                    if (item.TagName == "H4")
                    {
                        this.uName = item.OuterText;
                        break;
                    }
                }

                this.DialogResult = !string.IsNullOrWhiteSpace(this.Csrftoken) && !string.IsNullOrWhiteSpace(this.Sessionid)
                    ? DialogResult.OK
                    : throw new Exception("获取cookie失败");
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
