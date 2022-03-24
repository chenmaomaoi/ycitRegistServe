using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using RegistServe.DB.Domain;
using ycit;

namespace RegistServe
{
    public partial class FormMain : Form
    {

        private static System.Timers.Timer timer;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        private void Refersh()
        {
            dataGridView.Rows.Clear();
            IQueryable<UserInfo> userInfos = Program.UnitWork.Finds<UserInfo>(p => p.GUID != null);
            foreach (UserInfo item in userInfos)
            {
                object[] obj = new object[dataGridView.ColumnCount];
                obj[0] = (object)false;

                object[] tmpObj = item.ToObjicts();

                for (int i = 0; i < tmpObj.Count(); i++)
                {
                    obj[i + 1] = tmpObj[i];
                }

                dataGridView.Rows.Add(obj);
            }
        }

        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            Refersh();
            InitTimer();
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddAndUpdate add = new FormAddAndUpdate();

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                add.userInfo.GUID = Guid.NewGuid().ToString();
                Program.UnitWork.Add(add.userInfo);
                Program.UnitWork.Save();
            }

            Refersh();
        }

        /// <summary>
        /// 选择所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                item.Cells[dSelect.Name].Value = check_SelectAll.Checked;
            }
        }

        /// <summary>
        /// 选择上次填报失败的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_SelectFailed_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if (!(bool)item.Cells[dLastRegistState.Name].Value)
                {
                    item.Cells[dSelect.Name].Value = check_SelectFailed.Checked;
                }
            }
        }

        /// <summary>
        /// 查看选中的日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewLogs_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }

            //检查所有复选框，复选框有选中则修改单项
            bool flag = false;
            List<string> selectUsernames = new List<string>();

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if ((bool)item.Cells[dSelect.Name].Value)
                {
                    selectUsernames.Add(item.Cells[dUsername.Name].Value.ToString());

                    flag = true;
                }
            }

            if (!flag)
            {
                int selectIndex = dataGridView.CurrentCell.RowIndex;
                selectUsernames.Add(dataGridView.Rows[selectIndex].Cells[dUsername.Name].Value.ToString());
            }

            FormLogViewer logViewer = new FormLogViewer(selectUsernames.ToArray());
            logViewer.ShowDialog(this);
        }

        /// <summary>
        /// 填报选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RegistSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            //检查所有复选框，复选框有选中则修改单项
            bool flag = false;

            //todo:改造foreach，提升性能（experssion）
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if ((bool)item.Cells[dSelect.Name].Value)
                {
                    string s = item.Cells[dGUID.Name].Value.ToString();
                    UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == s).First();
                    MessageBox.Show(Regist(selectUserInfo));
                    flag = true;
                }
            }

            if (!flag)
            {
                int selectIndex = dataGridView.CurrentCell.RowIndex;
                string selectGUID = dataGridView.Rows[selectIndex].Cells[dGUID.Name].Value.ToString();

                UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == selectGUID).First();
                MessageBox.Show(Regist(selectUserInfo));
            }

            Program.UnitWork.Save();
            Refersh();
        }

        /// <summary>
        /// 填报
        /// </summary>
        /// <param name="userInfo"></param>
        private string Regist(UserInfo userInfo)
        {
            string message;
            bool registState = false;
            LogLevel level = LogLevel.Info;

            User user = new User(csrftoken: userInfo.Csrftoken, sessionid: userInfo.Sessionid);
            try
            {
                registState = user.Regist();
                message = registState ? "填报成功" : "填报失败";
                level = registState ? LogLevel.Info : LogLevel.Error;
            }
            catch (InvalidOperationException ex)
            {
                message = ex.Message;
                level = LogLevel.Error;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                level = LogLevel.Warning;
            }
            userInfo.LastRegistTime = DateTime.Now;
            userInfo.LastRegistState = registState;
            Program.UnitWork.Update(userInfo);

            Logger.Logging(userInfo, message, level);
            return message;
        }

        /// <summary>
        /// 删除选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DelectSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            //检查所有复选框，复选框有选中则修改单项
            bool flag = false;
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if ((bool)item.Cells[dSelect.Name].Value)
                {
                    string s = item.Cells[dGUID.Name].Value.ToString();
                    UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == s).First();
                    Delete(selectUserInfo);

                    flag = true;
                }
            }

            if (!flag)
            {
                int selectIndex = dataGridView.CurrentCell.RowIndex;
                string selectGUID = dataGridView.Rows[selectIndex].Cells[dGUID.Name].Value.ToString();

                UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == selectGUID).First();
                Delete(selectUserInfo);
            }

            Program.UnitWork.Save();
            Refersh();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="userInfo"></param>
        private void Delete(UserInfo userInfo)
        {
            Program.UnitWork.Delete(userInfo);
        }

        /// <summary>
        /// 修改选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdateSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            //检查所有复选框，复选框有选中则修改单项
            bool flag = false;
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if ((bool)item.Cells[dSelect.Name].Value)
                {
                    string s = item.Cells[dGUID.Name].Value.ToString();
                    UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == s).First();
                    Update(selectUserInfo);

                    flag = true;
                }
            }

            if (!flag)
            {
                int selectIndex = dataGridView.CurrentCell.RowIndex;
                string selectGUID = dataGridView.Rows[selectIndex].Cells[dGUID.Name].Value.ToString();

                UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == selectGUID).First();
                Update(selectUserInfo);
            }

            Program.UnitWork.Save();
            Refersh();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="userInfo"></param>
        private void Update(UserInfo userInfo)
        {
            FormAddAndUpdate add = new FormAddAndUpdate(userInfo);

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                Program.UnitWork.Update(add.userInfo);
            }
        }

        /// <summary>
        /// 查看所有日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ViewAllLogs_Click(object sender, EventArgs e)
        {
            FormLogViewer logViewer = new FormLogViewer();
            logViewer.ShowDialog(this);
        }

        /// <summary>
        /// 初始化Timer控件
        /// </summary>
        private void InitTimer()
        {
            //设置定时间隔(毫秒为单位)
            int interval = 1000 * 60;
            timer = new System.Timers.Timer(interval)
            {
                //设置执行一次（false）还是一直执行(true)
                AutoReset = true,
                //设置是否执行System.Timers.Timer.Elapsed事件
                Enabled = check_AlarmEnable.Checked
            };
            //绑定Elapsed事件
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // 得到 hour minute second  如果等于某个值就开始执行
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            //int intSecond = e.SignalTime.Second;
            // 定制时间,在00：00：00 的时候执行
            int iHour = (int)numeric_Hour.Value;
            int iMinute = (int)numeric_Minute.Value;
            //int iSecond = 00;
            // 设置 每天的00：00：00开始执行程序
            if (intHour == iHour && intMinute == iMinute/* && intSecond == iSecond*/)
            {
                //全部填报
                IQueryable<UserInfo> userInfos = Program.UnitWork.Find<UserInfo>();

                foreach (UserInfo userInfo in userInfos)
                {
                    Regist(userInfo);
                }

                Program.UnitWork.Save();
                this.Invoke(new EventHandler(delegate
                {
                    Refersh();
                }));
            }
        }

        private void check_AlarmEnable_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = check_AlarmEnable.Checked;
        }
    }
}
