using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistServe.DB.Domain;
using ycit;

namespace RegistServe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            Refersh();
        }

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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int selectIndex = dataGridView.CurrentCell.RowIndex;
            string selectGUID = dataGridView.Rows[selectIndex].Cells["dGUID"].Value.ToString();

            UserInfo selectUserInfo = Program.UnitWork.Find<UserInfo>(p => p.GUID == selectGUID).First();

            FormAddAndUpdate add = new FormAddAndUpdate(selectUserInfo);

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                Program.UnitWork.Update(add.userInfo);
                Program.UnitWork.Save();
            }

            Refersh();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }

            int selectIndex = dataGridView.CurrentCell.RowIndex;
            string selectGUID = dataGridView.Rows[selectIndex].Cells[0].Value.ToString();

            Program.UnitWork.Delete<UserInfo>(p => p.GUID == selectGUID);
            Program.UnitWork.Save();

            Refersh();
        }

        private void btn_Regist_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            //todo:单独填报
            int selectIndex = dataGridView.CurrentCell.RowIndex;


        }

        private void check_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                item.Cells["dSelect"].Value = check_SelectAll.Checked;
            }
        }

        private void check_SelectFailed_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if (!(bool)item.Cells["dLastRegistState"].Value)
                {
                    item.Cells["dSelect"].Value = check_SelectFailed.Checked;
                }
            }
        }
    }
}
