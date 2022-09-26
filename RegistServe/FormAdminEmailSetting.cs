using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistServe
{
    public partial class FormAdminEmailSetting : Form
    {
        public FormAdminEmailSetting()
        {
            InitializeComponent();
        }

        private void FormAdminEmailSetting_Load(object sender, EventArgs e)
        {
            //加载配置
            this.text_ServerAndPort.Text = Program.Setting.SysEmailConfig.ServerAndPort;
            this.text_UserName.Text = Program.Setting.SysEmailConfig.UserName;
            this.text_Password.Text = Program.Setting.SysEmailConfig.Password;
            this.text_RecvSysLogAddr.Text = Program.Setting.SysEmailConfig.RecvSysLogAddr;
            this.chk_EnableSysLogEmail.Checked = Program.Setting.SysEmailConfig.EnableSysLogEmail;
            this.chk_EnableEmailNotification.Checked = Program.Setting.SysEmailConfig.EnableEmailNotification;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //保存配置
            Program.Setting.SysEmailConfig.ServerAndPort = this.text_ServerAndPort.Text;
            Program.Setting.SysEmailConfig.UserName = this.text_UserName.Text;
            Program.Setting.SysEmailConfig.Password = this.text_Password.Text;
            Program.Setting.SysEmailConfig.RecvSysLogAddr = this.text_RecvSysLogAddr.Text;
            Program.Setting.SysEmailConfig.EnableSysLogEmail = this.chk_EnableSysLogEmail.Checked;
            Program.Setting.SysEmailConfig.EnableEmailNotification = this.chk_EnableEmailNotification.Checked;
        }

        private void btn_Cancer_Click(object sender, EventArgs e)
        {
            //取消
            this.Close();
        }
    }
}
