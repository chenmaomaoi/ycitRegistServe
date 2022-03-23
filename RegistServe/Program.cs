using RegistServe.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistServe
{
    public static class Program
    {
        public static UnitWork<BaseDBContext> UnitWork { get; set; }

        public static bool AlarmEnabled = false;

        public static ushort HH = 0;
        public static ushort MM = 0;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            UnitWork = new UnitWork<BaseDBContext>(new BaseDBContext());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
