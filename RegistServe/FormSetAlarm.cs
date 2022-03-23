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
    public partial class FormSetAlarm : Form
    {
        public FormSetAlarm()
        {
            InitializeComponent();

            numeric_Hour.Value = Program.HH;
            numeric_Minute.Value = Program.MM;
            check_AlarmEnable.Checked = Program.AlarmEnabled;
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            Program.HH = (ushort)numeric_Hour.Value;
            Program.MM = (ushort)numeric_Minute.Value;
            Program.AlarmEnabled = check_AlarmEnable.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
