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
using RegistServe.DB.Domain;

namespace RegistServe
{
    public partial class FormAddAndUpdate : Form
    {
        public User user { get; set; }

        public UserInfo userInfo { get; private set; }

        /// <summary>
        /// 构造
        /// </summary>
        /// <remarks>初始化窗口数据</remarks>
        /// <param name="userInfo"></param>
        public FormAddAndUpdate(UserInfo userInfo = null)
        {
            InitializeComponent();
            if (userInfo == null)
            {
                this.userInfo = new UserInfo();
            }
            else
            {
                this.userInfo = userInfo;
                this.text_GUID.Text = this.userInfo.GUID.ToString();
                this.text_Username.Text = this.userInfo.Username;
                this.text_Password.Text = this.userInfo.Password;
                this.text_Name.Text = this.userInfo.Name;
                this.text_Csrftoken.Text = this.userInfo.Csrftoken;
                this.text_Sessionid.Text = this.userInfo.Sessionid;

                this.text_QQ.Text = this.userInfo.QQ;
                this.text_Remark.Text = this.userInfo.Remark;

                this.dateTimePicker_StartTime.Value = this.userInfo.StartTime;
                this.dateTimePicker_EndTime.Value = this.userInfo.EndTime;
                this.dateTimePicker_LastRegistTime.Value = this.userInfo.LastRegistTime;
                this.text_LastRegistState.Text = this.userInfo.LastRegistState.ToString();
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            user = new User(text_Username.Text, text_Password.Text);
            if (user.Login())
            {
                MessageBox.Show("登录成功");
                this.text_Name.Text = user.Name;
                this.text_Csrftoken.Text = user.Csrftoken;
                this.text_Sessionid.Text = user.Sessionid;
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            userInfo.Username = this.text_Username.Text;
            userInfo.Password = this.text_Password.Text;
            userInfo.Name = this.text_Name.Text;
            userInfo.Csrftoken = this.text_Csrftoken.Text;
            userInfo.Sessionid = this.text_Sessionid.Text;
            userInfo.QQ = this.text_QQ.Text;
            userInfo.Remark = this.text_Remark.Text;
            userInfo.StartTime = this.dateTimePicker_StartTime.Value;
            userInfo.EndTime = this.dateTimePicker_EndTime.Value;

            if (string.IsNullOrWhiteSpace(userInfo.GUID))
            {
                userInfo.LastRegistTime = DateTime.Now;
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 查看日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Log_Click(object sender, EventArgs e)
        {
            FormLogViewer logViewer = new FormLogViewer(userInfo.Username);
            logViewer.ShowDialog(this);
        }
    }
}
