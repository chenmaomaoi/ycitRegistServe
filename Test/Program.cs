using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ycit;

namespace Test
{
    internal class Program
    {
        static System.Timers.Timer timer;
        static User user;

        [STAThread]
        static void Main(string[] args)
        {
            user = new User("42280119990902281X",
                            "c1325242398",
                            "xqzu41ueJK5P0tcz2QnBmv72YBWNu7l3Kk9UQQs6rmH5ydpfGCfwO6ssK5k7gwj5",
                            "94zj4srtvk1zk8evjv59tu7qxz2n25s1");

            user.Login();

            try
            {
                if (user.Regist())
                {
                    Console.WriteLine("填报成功");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"填报失败：{ex}");
            }

            InitTimer();

            Console.WriteLine("已启动");
            Console.ReadKey();
        }

        /// <summary>
        /// 初始化Timer控件
        /// </summary>
        private static void InitTimer()
        {
            //设置定时间隔(毫秒为单位)
            int interval = 1000 * 60;
            timer = new System.Timers.Timer(interval)
            {
                //设置执行一次（false）还是一直执行(true)
                AutoReset = true,
                //设置是否执行System.Timers.Timer.Elapsed事件
                Enabled = true
            };
            //绑定Elapsed事件
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 得到 hour minute second  如果等于某个值就开始执行
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            //int intSecond = e.SignalTime.Second;
            // 定制时间,在00：00：00 的时候执行
            int iHour = 00;
            int iMinute = 10;
            //int iSecond = 00;
            // 设置 每天的00：00：00开始执行程序
            if (intHour == iHour && intMinute == iMinute/* && intSecond == iSecond*/)
            {
                try
                {
                    if (user.Regist())
                    {
                        Console.WriteLine("填报成功");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"填报失败：{ex}");
                }
            }
        }
    }
}
