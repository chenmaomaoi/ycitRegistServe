﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistServe.DB.Domain
{
    [Table(nameof(RegistLog))]
    public class RegistLog
    {
        /// <summary>
        /// GUID
        /// </summary>
        [Key]
        [Required]
        public string GUID { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }

        public object[] ToObject()
        {
            return new object[] { GUID, Username, Name, LogLevel, Time, Message };
        }
    }

    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }
}
