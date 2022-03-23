using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ycit;
using RegistServe.DB.Domain;

namespace RegistServe
{
    internal static class Logger
    {
        public static void Logging(UserInfo userInfo, string message, LogLevel level = LogLevel.Info)
        {
            //记录日志
            RegistLog log = new RegistLog
            {
                GUID = Guid.NewGuid().ToString(),
                Username = userInfo.Username,
                Name = userInfo.Name,
                LogLevel = level,
                Time = DateTime.Now,
                Message = message
            };
            Program.UnitWork.Add<RegistLog>(log);
            Program.UnitWork.Save();
        }

        
    }
}
