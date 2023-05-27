using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ycit.OAuth;
using ycit.Regist;

namespace ycit
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user = new User("42280119990902281X", "c1325242398", "xlawNzHTxmM21KGOtBTA7kjbC9JY5OiuOdZgugvwCQ3c2C2hcRALFp4PVdN4J7Dx", "mtxplggwv5upcauwuta3catob7vddee9");
            //user.Login();
            Regist.Regist regist = new Regist.Regist(user.UserInfo);
            regist.Do();

            Console.ReadKey();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
