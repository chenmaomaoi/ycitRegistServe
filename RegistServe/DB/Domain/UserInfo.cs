using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using Z.EntityFramework.Extensions;

namespace RegistServe.DB.Domain
{
    [Table(nameof(UserInfo))]
    public class UserInfo
    {
        /// <summary>
        /// 用于在表头添加选择框，请勿更改
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// GUID
        /// </summary>
        [Key]
        [Required]
        public string GUID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// csrftoken
        /// </summary>
        public string Csrftoken { get; set; }

        /// <summary>
        /// sessionid
        /// </summary>
        public string Sessionid { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 停止日期
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 最后一次填报日期
        /// </summary>
        public DateTime LastRegistTime { get; set; }

        /// <summary>
        /// 最后一次填报是否成功
        /// </summary>
        public bool LastRegistState { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 启用邮箱提醒
        /// </summary>
        public bool EnableEmailNotification { get; set; }
    }
}
