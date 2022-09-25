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
        public TimerConfig TimerConfig = new TimerConfig();

        //todo:增加管理员邮件设置
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
}
