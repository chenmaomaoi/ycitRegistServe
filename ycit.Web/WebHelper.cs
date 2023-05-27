using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ycit.Web
{
    public static class WebHelper
    {
        /// <summary>
        /// Unicode解码
        /// </summary>
        /// <param name="str"> 待解码的文本 </param>
        /// <returns> </returns>
        public static string DeUnicode(string str)
        {
            Regex reg = new Regex(@"(?i)\\[uU]([0-9a-f]{4})");
            return reg.Replace(str, delegate (Match m) { return ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString(); });
        }

        /// <summary>
        /// Get访问
        /// </summary>
        /// <param name="uri"> 地址 </param>
        /// <param name="cookieContainer"> cookieContainer </param>
        /// <param name="timeout"> 访问超时，默认5000ms </param>
        /// <returns> </returns>
        public static string Get(Uri uri, string cookieStr = null, int timeout = 5000)
        {
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(uri);
            if (!string.IsNullOrWhiteSpace(cookieStr))
            {
                request.Headers.Add("Cookie", cookieStr);
            }
            request.Timeout = timeout;
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.96 Safari/537.36 Edg/88.0.705.50";
            request.ContentType = "text/plain";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            return DeUnicode(reader.ReadToEnd());
        }

        /// <summary>
        /// Post访问
        /// </summary>
        /// <param name="uri"> 地址 </param>
        /// <param name="postData"> 数据 </param>
        /// <param name="cookieContainer"> cookieContainer </param>
        /// <param name="timeout"> 访问超时，默认5000ms </param>
        /// <returns> </returns>
        public static string Post(Uri uri, string postData, string cookieStr = null, int timeout = 5000)
        {
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(uri);
            request.Timeout = timeout;
            if (!string.IsNullOrWhiteSpace(cookieStr))
            {
                request.Headers.Add("Cookie", cookieStr);
            }
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.96 Safari/537.36 Edg/88.0.705.50";
            byte[] data = Encoding.UTF8.GetBytes(postData);//把字符串转换为字节
            request.ContentLength = data.Length; //请求长度
            using (Stream reqStream = request.GetRequestStream()) //获取
            {
                reqStream.Write(data, 0, data.Length);  //向当前流中写入字节
                reqStream.Close(); //关闭当前流
            }
            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();  //响应结果 如果请求不到会发生错误
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            return DeUnicode(reader.ReadToEnd());
        }
    }
}
