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
            return WebHelper.Get(new Uri(URL + PathProfile), $"csrftoken={this.Csrftoken};sessionid={this.Sessionid}", userAgent: UserAgent).Contains("个人信息");
        }

        /// <summary>
        /// 填报
        /// </summary>
        /// <returns>
        /// <para/><see langword="true"/>填报成功或已填报
        /// <para/><see langword="false"/>填报失败
        /// </returns>
        /// <exception cref="InvalidOperationException">Error</exception>
        /// <exception cref="未登录"></exception>
        /// <exception cref="打开个人信息页面失败"></exception>
        /// <exception cref="打开填报页面失败"></exception>
        /// <exception cref="使用上次填报内容失败，获取元素 .van-dialog__confirm 超时"></exception>
        /// <exception cref="填报完成但等待返回页面超时"></exception>
        /// <exception cref="Exception">Waring</exception>
        /// <exception cref="非填报时间等错误"></exception>
        public bool Regist()
        {
            if (!HasLogin())
            {
                throw new InvalidOperationException("未登录");
            }

            //初始化 ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"User-Agent={UserAgent}");
            ChromeDriver chromeDriver = new ChromeDriver(ChromeDriverPath, options)
            {
                Url = URL
            };

            try
            {
                //打开个人信息页面
                if (!GoToProfilePage(chromeDriver))
                {
                    throw new InvalidOperationException("打开个人信息页面失败");
                }

                //获取当前填报状态
                string vs = chromeDriver.FindElement(By.Id("regist_button")).Text;
                if (vs == CanFill)
                {
                    //未填报
                    if (!GotoRegistPage(chromeDriver))
                    {
                        throw new InvalidOperationException("打开填报页面失败");
                    }

                    //尝试使用上次填报的内容
                    return Confirm(chromeDriver);
                }
                else if (vs == Filled)
                {
                    //已填报
                    return true;
                }
                else
                {
                    //非填报时间等
                    throw new Exception(vs);
                }
            }
            catch
            {
                chromeDriver.Close();
                chromeDriver.Dispose();
                throw;
            }
        }

        /// <summary>
        /// 打开个人信息页面
        /// </summary>
        /// <param name="chromeDriver"></param>
        private bool GoToProfilePage(ChromeDriver chromeDriver)
        {
            try
            {
                //设置cookie
                chromeDriver.Manage().Cookies.DeleteAllCookies();
                chromeDriver.Manage().Cookies.AddCookie(new Cookie("csrftoken", Csrftoken, new Uri(URL).Host, "/", null));
                chromeDriver.Manage().Cookies.AddCookie(new Cookie("sessionid", Sessionid, new Uri(URL).Host, "/", null));

                //打开个人信息页面
                chromeDriver.Navigate().GoToUrl(URL + PathProfile);
                new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 3));

                //检查填报按钮是否存在
                _ = chromeDriver.FindElement(By.Id("regist_button")).Text;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 打开填报页面
        /// </summary>
        /// <param name="chromeDriver"></param>
        /// <returns></returns>
        private bool GotoRegistPage(ChromeDriver chromeDriver)
        {
            try
            {
                //点击填报按钮
                chromeDriver.FindElement(By.Id("regist_button")).Click();
                //检查是否跳转到了填报页面，并返回结果
                Thread.Sleep(100);
                return new Uri(chromeDriver.Url).AbsolutePath == PathRegist;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 尝试使用上次填报的内容
        /// </summary>
        /// <returns>填报结果</returns>
        /// <exception cref="InvalidOperationException"></exception>
        /// <exception cref="使用上次填报内容失败，获取元素 .van-dialog__confirm 超时"></exception>
        /// <exception cref="填报完成但等待返回页面超时"></exception>
        private bool Confirm(ChromeDriver chromeDriver)
        {
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    //使用上次填报的内容
                    chromeDriver.FindElement(By.CssSelector(".van-dialog__confirm")).Click();
                    Thread.Sleep(500);

                    //页面返回
                    if (new Uri(chromeDriver.Url).AbsolutePath == PathProfile)
                    {
                        //等待页面返回，检查填报状态
                        for (int j = 0; j < 50; j++)
                        {
                            try
                            {
                                return chromeDriver.FindElement(By.Id("regist_button")).Text == Filled;
                            }
                            catch (Exception)
                            {
                                Thread.Sleep(200);
                            }
                        }
                        throw new InvalidOperationException("填报完成但等待返回页面超时");
                    }
                }
                catch (Exception)
                {
                    Thread.Sleep(200);
                }
            }
            throw new InvalidOperationException("使用上次填报内容失败，获取元素 .van-dialog__confirm 超时");
        }
    }
}
