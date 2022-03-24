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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_ViewLogs = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCsrftoken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSessionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLastRegistTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLastRegistState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_User = new System.Windows.Forms.GroupBox();
            this.btn_UpdateSelect = new System.Windows.Forms.Button();
            this.check_SelectAll = new System.Windows.Forms.CheckBox();
            this.btn_DelectSelect = new System.Windows.Forms.Button();
            this.btn_RegistSelect = new System.Windows.Forms.Button();
            this.check_SelectFailed = new System.Windows.Forms.CheckBox();
            this.btn_ViewAllLogs = new System.Windows.Forms.Button();
            this.group_Alarm = new System.Windows.Forms.GroupBox();
            this.numeric_Hour = new System.Windows.Forms.NumericUpDown();
            this.numeric_Minute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.check_AlarmEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.group_User.SuspendLayout();
            this.group_Alarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minute)).BeginInit();
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
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dSelect,
            this.dGUID,
            this.dName,
            this.dUsername,
            this.dPassword,
            this.dCsrftoken,
            this.dSessionid,
            this.dStartTime,
            this.dEndTime,
            this.dLastRegistTime,
            this.dLastRegistState,
            this.dQQ,
            this.dRemark});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1525, 799);
            this.dataGridView.TabIndex = 4;
            // 
            // dSelect
            // 
            this.dSelect.HeaderText = " ";
            this.dSelect.MinimumWidth = 8;
            this.dSelect.Name = "dSelect";
            this.dSelect.Width = 50;
            // 
            // dGUID
            // 
            this.dGUID.HeaderText = "GUID";
            this.dGUID.MinimumWidth = 8;
            this.dGUID.Name = "dGUID";
            this.dGUID.ReadOnly = true;
            this.dGUID.Visible = false;
            this.dGUID.Width = 8;
            // 
            // dName
            // 
            this.dName.HeaderText = "姓名";
            this.dName.MinimumWidth = 8;
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
            this.dName.Width = 150;
            // 
            // dUsername
            // 
            this.dUsername.HeaderText = "账号";
            this.dUsername.MinimumWidth = 8;
            this.dUsername.Name = "dUsername";
            this.dUsername.ReadOnly = true;
            this.dUsername.Visible = false;
            this.dUsername.Width = 150;
            // 
            // dPassword
            // 
            this.dPassword.HeaderText = "密码";
            this.dPassword.MinimumWidth = 8;
            this.dPassword.Name = "dPassword";
            this.dPassword.ReadOnly = true;
            this.dPassword.Visible = false;
            this.dPassword.Width = 150;
            // 
            // dCsrftoken
            // 
            this.dCsrftoken.HeaderText = "Csrftoken";
            this.dCsrftoken.MinimumWidth = 8;
            this.dCsrftoken.Name = "dCsrftoken";
            this.dCsrftoken.ReadOnly = true;
            this.dCsrftoken.Visible = false;
            this.dCsrftoken.Width = 150;
            // 
            // dSessionid
            // 
            this.dSessionid.HeaderText = "Sessionid";
            this.dSessionid.MinimumWidth = 8;
            this.dSessionid.Name = "dSessionid";
            this.dSessionid.ReadOnly = true;
            this.dSessionid.Visible = false;
            this.dSessionid.Width = 150;
            // 
            // dStartTime
            // 
            this.dStartTime.HeaderText = "开始时间";
            this.dStartTime.MinimumWidth = 8;
            this.dStartTime.Name = "dStartTime";
            this.dStartTime.ReadOnly = true;
            this.dStartTime.Visible = false;
            this.dStartTime.Width = 150;
            // 
            // dEndTime
            // 
            this.dEndTime.HeaderText = "结束时间";
            this.dEndTime.MinimumWidth = 8;
            this.dEndTime.Name = "dEndTime";
            this.dEndTime.ReadOnly = true;
            this.dEndTime.Width = 150;
            // 
            // dLastRegistTime
            // 
            this.dLastRegistTime.HeaderText = "最后一次填报日期";
            this.dLastRegistTime.MinimumWidth = 8;
            this.dLastRegistTime.Name = "dLastRegistTime";
            this.dLastRegistTime.ReadOnly = true;
            this.dLastRegistTime.Width = 150;
            // 
            // dLastRegistState
            // 
            this.dLastRegistState.HeaderText = "最后一次填报状态";
            this.dLastRegistState.MinimumWidth = 8;
            this.dLastRegistState.Name = "dLastRegistState";
            this.dLastRegistState.ReadOnly = true;
            this.dLastRegistState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dLastRegistState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dLastRegistState.Width = 150;
            // 
            // dQQ
            // 
            this.dQQ.HeaderText = "QQ";
            this.dQQ.MinimumWidth = 8;
            this.dQQ.Name = "dQQ";
            this.dQQ.ReadOnly = true;
            this.dQQ.Width = 150;
            // 
            // dRemark
            // 
            this.dRemark.HeaderText = "备注";
            this.dRemark.MinimumWidth = 8;
            this.dRemark.Name = "dRemark";
            this.dRemark.ReadOnly = true;
            this.dRemark.Width = 150;
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
            // group_Alarm
            // 
            this.group_Alarm.Controls.Add(this.numeric_Hour);
            this.group_Alarm.Controls.Add(this.numeric_Minute);
            this.group_Alarm.Controls.Add(this.label2);
            this.group_Alarm.Controls.Add(this.check_AlarmEnable);
            this.group_Alarm.Controls.Add(this.label1);
            this.group_Alarm.Location = new System.Drawing.Point(1543, 301);
            this.group_Alarm.Name = "group_Alarm";
            this.group_Alarm.Size = new System.Drawing.Size(127, 127);
            this.group_Alarm.TabIndex = 8;
            this.group_Alarm.TabStop = false;
            this.group_Alarm.Text = "定时填报";
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
            // check_AlarmEnable
            // 
            this.check_AlarmEnable.AutoSize = true;
            this.check_AlarmEnable.Location = new System.Drawing.Point(13, 95);
            this.check_AlarmEnable.Name = "check_AlarmEnable";
            this.check_AlarmEnable.Size = new System.Drawing.Size(70, 22);
            this.check_AlarmEnable.TabIndex = 7;
            this.check_AlarmEnable.Text = "启用";
            this.check_AlarmEnable.UseVisualStyleBackColor = true;
            this.check_AlarmEnable.CheckedChanged += new System.EventHandler(this.check_AlarmEnable_CheckedChanged);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 823);
            this.Controls.Add(this.btn_ViewAllLogs);
            this.Controls.Add(this.group_Alarm);
            this.Controls.Add(this.group_User);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.group_User.ResumeLayout(false);
            this.group_User.PerformLayout();
            this.group_Alarm.ResumeLayout(false);
            this.group_Alarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minute)).EndInit();
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
        private System.Windows.Forms.GroupBox group_Alarm;
        private System.Windows.Forms.Button btn_UpdateSelect;
        private System.Windows.Forms.Button btn_DelectSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCsrftoken;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSessionid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLastRegistTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dLastRegistState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRemark;
        private System.Windows.Forms.NumericUpDown numeric_Minute;
        private System.Windows.Forms.NumericUpDown numeric_Hour;
        private System.Windows.Forms.CheckBox check_AlarmEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

