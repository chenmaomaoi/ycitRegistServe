using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ycit
{
    public class Regist
    {
        private UserInfo _userInfo;

        public Regist(UserInfo userInfo) => _userInfo = userInfo;

        public Regist(string csrftoken, string sessionid) : this(new UserInfo(csrftoken: csrftoken, sessionid: sessionid)) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="非上报时间，请在每天北京时间10:00前完成上报"></exception>
        public bool Do()
        {
            if (User.HasLogin(_userInfo))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("User-Agent=Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_1 like Mac OS X) AppleWebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1 Edg/99.0.4844.74");

                ChromeDriver chromeDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application", options)
                {
                    Url = "https://health.xiamin.tech"
                };

                //设置cookie
                chromeDriver.Manage().Cookies.DeleteAllCookies();
                chromeDriver.Manage().Cookies.AddCookie(new Cookie("csrftoken", _userInfo.Csrftoken, "health.xiamin.tech", "/", null));
                chromeDriver.Manage().Cookies.AddCookie(new Cookie("sessionid", _userInfo.Sessionid, "health.xiamin.tech", "/", null));

                //打开页面填报
                chromeDriver.Navigate().GoToUrl("https://health.xiamin.tech/user/profile/");

                //等待加载完毕
                new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 3));

                //获取当前状态

                string state = chromeDriver.FindElement(By.Id("regist_button")).Text;
                if (state == "非上报时间，请在每天北京时间10:00前完成上报")
                {
                    throw new Exception("非上报时间，请在每天北京时间10:00前完成上报");
                }
                else
                {

                }

                // Test name: 填报
                // 2 | click | id=regist_button | 
                chromeDriver.FindElement(By.Id("regist_button")).Click();

                Thread.Sleep(1000);

                // 3 | click | css=.van-dialog__confirm | 
                chromeDriver.FindElement(By.CssSelector(".van-dialog__confirm")).Click();


                // 4 | close |  | 
                chromeDriver.Close();


                //检查当前填报状态

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
