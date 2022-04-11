using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace RegistServe.Utils
{
    public class EmailSender
    {
        private static string ServerAddress;

        private static string UserName;
        private static string Password;
        private static string From;
        private static string To;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverAndPort">服务器地址，主机名:端口</param>
        /// <param name="userName">发件人邮箱用户名</param>
        /// <param name="password">发件人邮箱密码（授权码）</param>
        /// <param name="from">发件人地址</param>
        /// <param name="to">收件人地址，多个用“;”隔开</param>
        public EmailSender(string serverAndPort, string userName, string password, string from, string to)
        {
            ServerAddress = serverAndPort;
            UserName = userName;
            Password = password;
            From = from;
            AddTo(to);
        }
        public EmailSender(string serverAndPort, string userName, string password, string from) : this(serverAndPort, userName, password, from, "")
        {
        }
        /// <summary>
        /// 添加发件人
        /// </summary>
        /// <param name="emailAddr">发件人地址，多个用“;”隔开</param>
        public void AddTo(string emailAddr)
        {
            if (!string.IsNullOrEmpty(emailAddr))
            {
                To += AddSemicolonToAddress(emailAddr);
            }
        }
        private string AddSemicolonToAddress(string addrs)
        {
            if (addrs.Last() == ';')
            {
                return addrs;
            }
            else
            {
                return addrs + ";";
            }
        }
        /// <summary>
        /// 清空收件人
        /// </summary>
        public void ClearTo()
        {
            To = "";
        }
        /// <summary>
        /// 获取收件人列表
        /// </summary>
        /// <param name="to">字符串形式</param>
        /// <returns>列表形式</returns>
        public List<string> GetToList(string to)
        {
            var toList = to.Split(';');
            var result = new List<string>();
            foreach (string toAddress in toList)
            {
                if (string.IsNullOrWhiteSpace(toAddress))
                {
                    continue;
                }
                result.Add(toAddress);
            }
            return result;
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="subject">主题</param>
        /// <param name="body">内容</param>
        /// <param name="to">指定收件人，为null时发送给属性To记录的所有人</param>
        public void Send(string subject, string body, string to = null)
        {
            MailMessage msg = new MailMessage();
            msg.Subject = subject;
            msg.Body = body;
            msg.From = new MailAddress(From);
            if (string.IsNullOrEmpty(to))
            {
                // 如果未指定收件人，则为To属性值（发送给所有人）
                to = To;
            }
            var toList = GetToList(to);
            if (!toList.Any())
            {
                throw new Exception("没有指定收件人！");
            }
            foreach (string toAddress in toList)
            {
                if (string.IsNullOrWhiteSpace(toAddress))
                {
                    continue;
                }
                msg.To.Add(toAddress.Trim());
            }
            SmtpClient client = new SmtpClient();
            var ipPort = ServerAddress.Split(':');
            client.Host = ipPort[0];
            client.Port = int.Parse(ipPort[1]);
            client.UseDefaultCredentials = false;
            NetworkCredential credential = new NetworkCredential(UserName, Password);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = credential;
            client.Send(msg);
        }
    }
}
