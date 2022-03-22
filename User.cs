using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ycit
{
    public class User
    {
        /// <summary>
        /// 登录地址
        /// </summary>
        public const string URL = "https://health.xiamin.tech";

        public const string PathLogin = "/login/";

        public const string PathProfile = "/user/profile/";

        public const string PathRegist = "/system/registry/";

        /// <summary>
        /// 浏览器UA
        /// </summary>
        private const string UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_1 like Mac OS X) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1 Edg/99.0.4844.74";

        /// <summary>
        /// ChromeDriver目录
        /// </summary>
        private const string ChromeDriverPath = @"C:\Program Files\Google\Chrome\Application";

        /// <summary>
        /// 可以进行填报
        /// </summary>
        private const string CanFill = "进入上报";

        /// <summary>
        /// 已填报
        /// </summary>
        private const string Filled = "今日已上报";

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// csrftoken
        /// </summary>
        public string Csrftoken { get; private set; }

        /// <summary>
        /// sessionid
        /// </summary>
        public string Sessionid { get; private set; }

        public User(string username = null, string password = null, string csrftoken = null, string sessionid = null)
        {
            Username = username;
            Password = password;
            Csrftoken = csrftoken;
            Sessionid = sessionid;
        }

        /// <summary>
        /// 登录，并且获取Cookie
        /// </summary>
        /// <returns> </returns>
        [STAThread]
        public bool Login()
        {
            WebBrowserForm form = new WebBrowserForm(Username, Password, UserAgent);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Csrftoken = form.Csrftoken;
                Sessionid = form.Sessionid;
                Name = form.uName;
                form.Dispose();
                return true;
            }
            else
            {
                form.Dispose();
                return false;
            }
        }

        /// <summary>
        /// 用于判定现认证信息是否有效
        /// </summary>
        /// <returns></returns>
        public bool HasLogin()
        {
            return WebHelper.Get(new Uri(URL), $"csrftoken={this.Csrftoken};sessionid={this.Sessionid}", userAgent: UserAgent).Contains("个人信息");
        }

        /// <summary>
        /// 填报
        /// </summary>
        /// <returns>必然 return true，不然会抛出异常</returns>
        /// <exception cref="登录失效"></exception>
        /// <exception cref="非上报时间"></exception>
        /// <exception cref="填报发生意外错误"></exception>
        public bool Regist()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"User-Agent={UserAgent}");

            ChromeDriver chromeDriver = new ChromeDriver(ChromeDriverPath, options)
            {
                Url = URL
            };

            try
            {
                //设置cookie
                chromeDriver.Manage().Cookies.DeleteAllCookies();
                chromeDriver.Manage().Cookies.AddCookie(new Cookie("csrftoken", Csrftoken, new Uri(URL).Host, "/", null));
                chromeDriver.Manage().Cookies.AddCookie(new Cookie("sessionid", Sessionid, new Uri(URL).Host, "/", null));

                //打开填报页面
                chromeDriver.Navigate().GoToUrl(URL + PathProfile);
                new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 3));

                //获取当前状态
                string state;
                try
                {
                    state = chromeDriver.FindElement(By.Id("regist_button")).Text;
                }
                catch (Exception)
                {
                    throw new Exception("未找到填报按钮，可能是登录信息失效，需要重新登录");
                }

                if (state == CanFill)
                {
                    //点击填报按钮
                    chromeDriver.FindElement(By.Id("regist_button")).Click();
                    Thread.Sleep(2000);

                    //使用上次填报的内容
                    if (new Uri(chromeDriver.Url).AbsolutePath == PathRegist)
                    {
                        try
                        {
                            chromeDriver.FindElement(By.CssSelector(".van-dialog__confirm")).Click();
                        }
                        catch (Exception)
                        {
                            throw new Exception("使用上次填报内容失败，找不到元素 .van-dialog__confirm");
                        }
                    }
                    else
                    {
                        throw new Exception("打开填报页面失败");
                    }

                    //等待页面返回，检查填报状态
                    for (int i = 0; i < 50; i++)
                    {
                        try
                        {
                            if (chromeDriver.FindElement(By.Id("regist_button")).Text == Filled)
                            {
                                chromeDriver.Close();
                                return true;
                            }
                        }
                        catch (Exception)
                        {
                            Thread.Sleep(200);
                        }
                    }

                    throw new Exception("填报完成但等待返回页面超时");
                }
                else if (state == Filled)
                {
                    chromeDriver.Close();
                    return true;
                }
                else
                {
                    throw new Exception(state);
                }
            }
            catch (Exception)
            {
                chromeDriver.Close();
                throw;
            }
        }
    }
}
