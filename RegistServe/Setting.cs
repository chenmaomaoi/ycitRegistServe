using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistServe
{
    /// <summary>
    /// 设置
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// 定时填报配置
        /// </summary>
        public TimerConfig TimerConfig = new TimerConfig();

        /// <summary>
        /// 系统日志邮件配置
        /// </summary>
        public SysEmailConfig SysEmailConfig = new SysEmailConfig();
    }

    /// <summary>
    /// 定时填报相关
    /// </summary>
    public class TimerConfig
    {
        public UInt16 Hour = 7;
        public UInt16 Minute = 0; 
        public bool Enable = true;
    }

    /// <summary>
    /// 系统邮件相关
    /// </summary>
    public class SysEmailConfig
    {
        public string ServerAndPort = "smtp.163.com:25";
        public string UserName = "";
        public string Password = "";
        public string RecvSysLogAddr = "";
        public bool EnableSysLogEmail = false;
        public bool EnableEmailNotification = false;
    }
}
