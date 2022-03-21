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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_ViewLogs = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.group_User = new System.Windows.Forms.GroupBox();
            this.group_All = new System.Windows.Forms.GroupBox();
            this.btn_ViewAllLogs = new System.Windows.Forms.Button();
            this.btn_AlarmDo = new System.Windows.Forms.Button();
            this.btn_RegistSelect = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Regist = new System.Windows.Forms.Button();
            this.group_System = new System.Windows.Forms.GroupBox();
            this.check_SelectAll = new System.Windows.Forms.CheckBox();
            this.check_SelectFailed = new System.Windows.Forms.CheckBox();
            this.btn_DelectSelect = new System.Windows.Forms.Button();
            this.btn_UpdateSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.group_User.SuspendLayout();
            this.group_All.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.group_System.SuspendLayout();
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
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(6, 105);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(106, 33);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(6, 66);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(106, 33);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_ViewLogs
            // 
            this.btn_ViewLogs.Location = new System.Drawing.Point(6, 183);
            this.btn_ViewLogs.Name = "btn_ViewLogs";
            this.btn_ViewLogs.Size = new System.Drawing.Size(106, 33);
            this.btn_ViewLogs.TabIndex = 3;
            this.btn_ViewLogs.Text = "查看日志";
            this.btn_ViewLogs.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1278, 768);
            this.dataGridView.TabIndex = 4;
            // 
            // group_User
            // 
            this.group_User.Controls.Add(this.btn_Regist);
            this.group_User.Controls.Add(this.btnAdd);
            this.group_User.Controls.Add(this.btn_Update);
            this.group_User.Controls.Add(this.btn_ViewLogs);
            this.group_User.Controls.Add(this.btn_Delete);
            this.group_User.Location = new System.Drawing.Point(1296, 12);
            this.group_User.Name = "group_User";
            this.group_User.Size = new System.Drawing.Size(127, 225);
            this.group_User.TabIndex = 5;
            this.group_User.TabStop = false;
            this.group_User.Text = "单用户";
            // 
            // group_All
            // 
            this.group_All.Controls.Add(this.btn_UpdateSelect);
            this.group_All.Controls.Add(this.btn_DelectSelect);
            this.group_All.Controls.Add(this.check_SelectFailed);
            this.group_All.Controls.Add(this.check_SelectAll);
            this.group_All.Controls.Add(this.btn_RegistSelect);
            this.group_All.Location = new System.Drawing.Point(1296, 243);
            this.group_All.Name = "group_All";
            this.group_All.Size = new System.Drawing.Size(127, 203);
            this.group_All.TabIndex = 6;
            this.group_All.TabStop = false;
            this.group_All.Text = "批量操作";
            // 
            // btn_ViewAllLogs
            // 
            this.btn_ViewAllLogs.Location = new System.Drawing.Point(6, 66);
            this.btn_ViewAllLogs.Name = "btn_ViewAllLogs";
            this.btn_ViewAllLogs.Size = new System.Drawing.Size(106, 33);
            this.btn_ViewAllLogs.TabIndex = 3;
            this.btn_ViewAllLogs.Text = "所有日志";
            this.btn_ViewAllLogs.UseVisualStyleBackColor = true;
            // 
            // btn_AlarmDo
            // 
            this.btn_AlarmDo.Location = new System.Drawing.Point(6, 27);
            this.btn_AlarmDo.Name = "btn_AlarmDo";
            this.btn_AlarmDo.Size = new System.Drawing.Size(106, 33);
            this.btn_AlarmDo.TabIndex = 2;
            this.btn_AlarmDo.Text = "定时填报";
            this.btn_AlarmDo.UseVisualStyleBackColor = true;
            // 
            // btn_RegistSelect
            // 
            this.btn_RegistSelect.Location = new System.Drawing.Point(6, 83);
            this.btn_RegistSelect.Name = "btn_RegistSelect";
            this.btn_RegistSelect.Size = new System.Drawing.Size(106, 33);
            this.btn_RegistSelect.TabIndex = 1;
            this.btn_RegistSelect.Text = "填报";
            this.btn_RegistSelect.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 792);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1435, 31);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 24);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn_Regist
            // 
            this.btn_Regist.Location = new System.Drawing.Point(6, 144);
            this.btn_Regist.Name = "btn_Regist";
            this.btn_Regist.Size = new System.Drawing.Size(106, 33);
            this.btn_Regist.TabIndex = 4;
            this.btn_Regist.Text = "填报";
            this.btn_Regist.UseVisualStyleBackColor = true;
            // 
            // group_System
            // 
            this.group_System.Controls.Add(this.btn_ViewAllLogs);
            this.group_System.Controls.Add(this.btn_AlarmDo);
            this.group_System.Location = new System.Drawing.Point(1296, 452);
            this.group_System.Name = "group_System";
            this.group_System.Size = new System.Drawing.Size(127, 107);
            this.group_System.TabIndex = 8;
            this.group_System.TabStop = false;
            this.group_System.Text = "系统";
            // 
            // check_SelectAll
            // 
            this.check_SelectAll.AutoSize = true;
            this.check_SelectAll.Location = new System.Drawing.Point(6, 27);
            this.check_SelectAll.Name = "check_SelectAll";
            this.check_SelectAll.Size = new System.Drawing.Size(70, 22);
            this.check_SelectAll.TabIndex = 2;
            this.check_SelectAll.Text = "全部";
            this.check_SelectAll.UseVisualStyleBackColor = true;
            // 
            // check_SelectFailed
            // 
            this.check_SelectFailed.AutoSize = true;
            this.check_SelectFailed.Location = new System.Drawing.Point(6, 55);
            this.check_SelectFailed.Name = "check_SelectFailed";
            this.check_SelectFailed.Size = new System.Drawing.Size(106, 22);
            this.check_SelectFailed.TabIndex = 3;
            this.check_SelectFailed.Text = "填报失败";
            this.check_SelectFailed.UseVisualStyleBackColor = true;
            // 
            // btn_DelectSelect
            // 
            this.btn_DelectSelect.Location = new System.Drawing.Point(6, 122);
            this.btn_DelectSelect.Name = "btn_DelectSelect";
            this.btn_DelectSelect.Size = new System.Drawing.Size(106, 33);
            this.btn_DelectSelect.TabIndex = 4;
            this.btn_DelectSelect.Text = "删除";
            this.btn_DelectSelect.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateSelect
            // 
            this.btn_UpdateSelect.Location = new System.Drawing.Point(6, 161);
            this.btn_UpdateSelect.Name = "btn_UpdateSelect";
            this.btn_UpdateSelect.Size = new System.Drawing.Size(106, 33);
            this.btn_UpdateSelect.TabIndex = 5;
            this.btn_UpdateSelect.Text = "修改";
            this.btn_UpdateSelect.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 823);
            this.Controls.Add(this.group_System);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.group_All);
            this.Controls.Add(this.group_User);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.group_User.ResumeLayout(false);
            this.group_All.ResumeLayout(false);
            this.group_All.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.group_System.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_ViewLogs;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox group_User;
        private System.Windows.Forms.GroupBox group_All;
        private System.Windows.Forms.Button btn_AlarmDo;
        private System.Windows.Forms.Button btn_RegistSelect;
        private System.Windows.Forms.Button btn_ViewAllLogs;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_Regist;
        private System.Windows.Forms.CheckBox check_SelectFailed;
        private System.Windows.Forms.CheckBox check_SelectAll;
        private System.Windows.Forms.GroupBox group_System;
        private System.Windows.Forms.Button btn_UpdateSelect;
        private System.Windows.Forms.Button btn_DelectSelect;
    }
}

