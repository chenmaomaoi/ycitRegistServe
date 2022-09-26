using Newtonsoft.Json;
using RegistServe.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistServe
{
    public static class Program
    {
        /// <summary>
        /// 用于保存设置的文件
        /// </summary>
        public const string SETTING_JSON = "setting.json";

        public static UnitWork<BaseDBContext> UnitWork { get; set; }

        public static Setting Setting = new Setting();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            UnitWork = new UnitWork<BaseDBContext>(new BaseDBContext());

            //加载配置
            if (File.Exists(SETTING_JSON))
            {
                try
                {
                    Setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(SETTING_JSON));
                }
                catch (Exception)
                {
                    File.Delete(SETTING_JSON);
                }
            }

            Application.ApplicationExit += Application_ApplicationExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            //保存配置文件
            File.WriteAllText(SETTING_JSON, JsonConvert.SerializeObject(Setting));
        }
    }
}
