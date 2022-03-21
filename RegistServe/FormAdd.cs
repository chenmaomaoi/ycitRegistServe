using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ycit;

namespace RegistServe
{
    public partial class FormAdd : Form
    {
        public User user { get; set; }

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            user = new User(text_Username.Text, text_Password.Text);
            if (user.Login())
            {
                //todo:登录成功，获取基本信息
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
