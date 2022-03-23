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
using System.Linq.Expressions;
using LinqKit;

namespace RegistServe
{
    public partial class FormLogViewer : Form
    {
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="usernames">若为空，则查看所有人的日志</param>
        public FormLogViewer(params string[] usernames)
        {
            InitializeComponent();

            //加载日志
            dataGridView.Rows.Clear();

            IQueryable<RegistLog> registLogs = Program.UnitWork.Finds<RegistLog>(GetExpression(usernames));

            foreach (RegistLog registLog in registLogs)
            {
                dataGridView.Rows.Add(registLog.ToObject());
            }
        }

        private Expression<Func<RegistLog, bool>> GetExpression(params string[] usernames)
        {
            ExpressionStarter<RegistLog> expression = PredicateBuilder.New<RegistLog>(true);
            foreach (string username in usernames)
            {
                if (!string.IsNullOrWhiteSpace(username))
                {
                    expression = expression.Or(p => p.Username == username);
                }
            }
            return expression;

        }

    }
}
