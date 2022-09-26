namespace RegistServe
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_ViewLogs = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.group_User = new System.Windows.Forms.GroupBox();
            this.btn_UpdateSelect = new System.Windows.Forms.Button();
            this.check_SelectAll = new System.Windows.Forms.CheckBox();
            this.btn_DelectSelect = new System.Windows.Forms.Button();
            this.btn_RegistSelect = new System.Windows.Forms.Button();
            this.check_SelectFailed = new System.Windows.Forms.CheckBox();
            this.btn_ViewAllLogs = new System.Windows.Forms.Button();
            this.group_Timer = new System.Windows.Forms.GroupBox();
            this.numeric_Hour = new System.Windows.Forms.NumericUpDown();
            this.numeric_Minute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.check_TimerEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csrftokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRegistTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRegistStateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enableEmailNotificationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.group_User.SuspendLayout();
            this.group_Timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_ViewLogs
            // 
            this.btn_ViewLogs.Location = new System.Drawing.Point(6, 239);
            this.btn_ViewLogs.Name = "btn_ViewLogs";
            this.btn_ViewLogs.Size = new System.Drawing.Size(106, 33);
            this.btn_ViewLogs.TabIndex = 3;
            this.btn_ViewLogs.Text = "查看日志";
            this.btn_ViewLogs.UseVisualStyleBackColor = true;
            this.btn_ViewLogs.Click += new System.EventHandler(this.btn_ViewLogs_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelectedDataGridViewCheckBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.csrftokenDataGridViewTextBoxColumn,
            this.sessionidDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.lastRegistTimeDataGridViewTextBoxColumn,
            this.lastRegistStateDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.enableEmailNotificationDataGridViewCheckBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.userInfoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1525, 799);
            this.dataGridView.TabIndex = 4;
            // 
            // group_User
            // 
            this.group_User.Controls.Add(this.btn_UpdateSelect);
            this.group_User.Controls.Add(this.btnAdd);
            this.group_User.Controls.Add(this.btn_ViewLogs);
            this.group_User.Controls.Add(this.check_SelectAll);
            this.group_User.Controls.Add(this.btn_DelectSelect);
            this.group_User.Controls.Add(this.btn_RegistSelect);
            this.group_User.Controls.Add(this.check_SelectFailed);
            this.group_User.Location = new System.Drawing.Point(1543, 12);
            this.group_User.Name = "group_User";
            this.group_User.Size = new System.Drawing.Size(127, 283);
            this.group_User.TabIndex = 5;
            this.group_User.TabStop = false;
            this.group_User.Text = "用户管理";
            // 
            // btn_UpdateSelect
            // 
            this.btn_UpdateSelect.Location = new System.Drawing.Point(6, 200);
            this.btn_UpdateSelect.Name = "btn_UpdateSelect";
            this.btn_UpdateSelect.Size = new System.Drawing.Size(106, 33);
            this.btn_UpdateSelect.TabIndex = 5;
            this.btn_UpdateSelect.Text = "修改";
            this.btn_UpdateSelect.UseVisualStyleBackColor = true;
            this.btn_UpdateSelect.Click += new System.EventHandler(this.btn_UpdateSelect_Click);
            // 
            // check_SelectAll
            // 
            this.check_SelectAll.AutoSize = true;
            this.check_SelectAll.Location = new System.Drawing.Point(6, 66);
            this.check_SelectAll.Name = "check_SelectAll";
            this.check_SelectAll.Size = new System.Drawing.Size(70, 22);
            this.check_SelectAll.TabIndex = 2;
            this.check_SelectAll.Text = "全选";
            this.check_SelectAll.UseVisualStyleBackColor = true;
            this.check_SelectAll.CheckedChanged += new System.EventHandler(this.check_SelectAll_CheckedChanged);
            // 
            // btn_DelectSelect
            // 
            this.btn_DelectSelect.Location = new System.Drawing.Point(6, 161);
            this.btn_DelectSelect.Name = "btn_DelectSelect";
            this.btn_DelectSelect.Size = new System.Drawing.Size(106, 33);
            this.btn_DelectSelect.TabIndex = 4;
            this.btn_DelectSelect.Text = "删除";
            this.btn_DelectSelect.UseVisualStyleBackColor = true;
            this.btn_DelectSelect.Click += new System.EventHandler(this.btn_DelectSelect_Click);
            // 
            // btn_RegistSelect
            // 
            this.btn_RegistSelect.Location = new System.Drawing.Point(6, 122);
            this.btn_RegistSelect.Name = "btn_RegistSelect";
            this.btn_RegistSelect.Size = new System.Drawing.Size(106, 33);
            this.btn_RegistSelect.TabIndex = 1;
            this.btn_RegistSelect.Text = "填报";
            this.btn_RegistSelect.UseVisualStyleBackColor = true;
            this.btn_RegistSelect.Click += new System.EventHandler(this.btn_RegistSelect_Click);
            // 
            // check_SelectFailed
            // 
            this.check_SelectFailed.AutoSize = true;
            this.check_SelectFailed.Location = new System.Drawing.Point(6, 94);
            this.check_SelectFailed.Name = "check_SelectFailed";
            this.check_SelectFailed.Size = new System.Drawing.Size(106, 22);
            this.check_SelectFailed.TabIndex = 3;
            this.check_SelectFailed.Text = "填报失败";
            this.check_SelectFailed.UseVisualStyleBackColor = true;
            this.check_SelectFailed.CheckedChanged += new System.EventHandler(this.check_SelectFailed_CheckedChanged);
            // 
            // btn_ViewAllLogs
            // 
            this.btn_ViewAllLogs.Location = new System.Drawing.Point(1549, 434);
            this.btn_ViewAllLogs.Name = "btn_ViewAllLogs";
            this.btn_ViewAllLogs.Size = new System.Drawing.Size(106, 33);
            this.btn_ViewAllLogs.TabIndex = 3;
            this.btn_ViewAllLogs.Text = "所有日志";
            this.btn_ViewAllLogs.UseVisualStyleBackColor = true;
            this.btn_ViewAllLogs.Click += new System.EventHandler(this.btn_ViewAllLogs_Click);
            // 
            // group_Timer
            // 
            this.group_Timer.Controls.Add(this.numeric_Hour);
            this.group_Timer.Controls.Add(this.numeric_Minute);
            this.group_Timer.Controls.Add(this.label2);
            this.group_Timer.Controls.Add(this.check_TimerEnable);
            this.group_Timer.Controls.Add(this.label1);
            this.group_Timer.Location = new System.Drawing.Point(1543, 301);
            this.group_Timer.Name = "group_Timer";
            this.group_Timer.Size = new System.Drawing.Size(127, 127);
            this.group_Timer.TabIndex = 8;
            this.group_Timer.TabStop = false;
            this.group_Timer.Text = "定时填报";
            // 
            // numeric_Hour
            // 
            this.numeric_Hour.Location = new System.Drawing.Point(60, 27);
            this.numeric_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numeric_Hour.Name = "numeric_Hour";
            this.numeric_Hour.Size = new System.Drawing.Size(61, 28);
            this.numeric_Hour.TabIndex = 8;
            // 
            // numeric_Minute
            // 
            this.numeric_Minute.Location = new System.Drawing.Point(60, 61);
            this.numeric_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numeric_Minute.Name = "numeric_Minute";
            this.numeric_Minute.Size = new System.Drawing.Size(61, 28);
            this.numeric_Minute.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "分：";
            // 
            // check_TimerEnable
            // 
            this.check_TimerEnable.AutoSize = true;
            this.check_TimerEnable.Location = new System.Drawing.Point(13, 95);
            this.check_TimerEnable.Name = "check_TimerEnable";
            this.check_TimerEnable.Size = new System.Drawing.Size(70, 22);
            this.check_TimerEnable.TabIndex = 7;
            this.check_TimerEnable.Text = "启用";
            this.check_TimerEnable.UseVisualStyleBackColor = true;
            this.check_TimerEnable.CheckedChanged += new System.EventHandler(this.check_TimerEnable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "时：";
            // 
            // isSelectedDataGridViewCheckBoxColumn
            // 
            this.isSelectedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "";
            this.isSelectedDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
            this.isSelectedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isSelectedDataGridViewCheckBoxColumn.Width = 8;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "账号";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 80;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 116;
            // 
            // csrftokenDataGridViewTextBoxColumn
            // 
            this.csrftokenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.csrftokenDataGridViewTextBoxColumn.DataPropertyName = "Csrftoken";
            this.csrftokenDataGridViewTextBoxColumn.HeaderText = "Csrftoken";
            this.csrftokenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.csrftokenDataGridViewTextBoxColumn.Name = "csrftokenDataGridViewTextBoxColumn";
            this.csrftokenDataGridViewTextBoxColumn.ReadOnly = true;
            this.csrftokenDataGridViewTextBoxColumn.Visible = false;
            this.csrftokenDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessionidDataGridViewTextBoxColumn
            // 
            this.sessionidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sessionidDataGridViewTextBoxColumn.DataPropertyName = "Sessionid";
            this.sessionidDataGridViewTextBoxColumn.HeaderText = "Sessionid";
            this.sessionidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sessionidDataGridViewTextBoxColumn.Name = "sessionidDataGridViewTextBoxColumn";
            this.sessionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessionidDataGridViewTextBoxColumn.Visible = false;
            this.sessionidDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 116;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 116;
            // 
            // lastRegistTimeDataGridViewTextBoxColumn
            // 
            this.lastRegistTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastRegistTimeDataGridViewTextBoxColumn.DataPropertyName = "LastRegistTime";
            this.lastRegistTimeDataGridViewTextBoxColumn.HeaderText = "最后填报时间";
            this.lastRegistTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastRegistTimeDataGridViewTextBoxColumn.Name = "lastRegistTimeDataGridViewTextBoxColumn";
            this.lastRegistTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastRegistTimeDataGridViewTextBoxColumn.Width = 108;
            // 
            // lastRegistStateDataGridViewCheckBoxColumn
            // 
            this.lastRegistStateDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastRegistStateDataGridViewCheckBoxColumn.DataPropertyName = "LastRegistState";
            this.lastRegistStateDataGridViewCheckBoxColumn.HeaderText = "最后填报状态";
            this.lastRegistStateDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.lastRegistStateDataGridViewCheckBoxColumn.Name = "lastRegistStateDataGridViewCheckBoxColumn";
            this.lastRegistStateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.lastRegistStateDataGridViewCheckBoxColumn.Width = 78;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "邮箱";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 75;
            // 
            // enableEmailNotificationDataGridViewCheckBoxColumn
            // 
            this.enableEmailNotificationDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enableEmailNotificationDataGridViewCheckBoxColumn.DataPropertyName = "EnableEmailNotification";
            this.enableEmailNotificationDataGridViewCheckBoxColumn.HeaderText = "启用邮件提醒";
            this.enableEmailNotificationDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.enableEmailNotificationDataGridViewCheckBoxColumn.Name = "enableEmailNotificationDataGridViewCheckBoxColumn";
            this.enableEmailNotificationDataGridViewCheckBoxColumn.ReadOnly = true;
            this.enableEmailNotificationDataGridViewCheckBoxColumn.Width = 78;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(RegistServe.DB.Domain.UserInfo);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 823);
            this.Controls.Add(this.btn_ViewAllLogs);
            this.Controls.Add(this.group_Timer);
            this.Controls.Add(this.group_User);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.group_User.ResumeLayout(false);
            this.group_User.PerformLayout();
            this.group_Timer.ResumeLayout(false);
            this.group_Timer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_ViewLogs;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox group_User;
        private System.Windows.Forms.Button btn_RegistSelect;
        private System.Windows.Forms.Button btn_ViewAllLogs;
        private System.Windows.Forms.CheckBox check_SelectFailed;
        private System.Windows.Forms.CheckBox check_SelectAll;
        private System.Windows.Forms.GroupBox group_Timer;
        private System.Windows.Forms.Button btn_UpdateSelect;
        private System.Windows.Forms.Button btn_DelectSelect;
        private System.Windows.Forms.NumericUpDown numeric_Minute;
        private System.Windows.Forms.NumericUpDown numeric_Hour;
        private System.Windows.Forms.CheckBox check_TimerEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csrftokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRegistTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lastRegistStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enableEmailNotificationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}

