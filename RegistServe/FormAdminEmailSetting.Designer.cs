namespace RegistServe
{
    partial class FormAdminEmailSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_EnableSysLogEmail = new System.Windows.Forms.CheckBox();
            this.btn_Cancer = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.text_ServerAndPort = new System.Windows.Forms.TextBox();
            this.text_UserName = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.text_RecvSysLogAddr = new System.Windows.Forms.TextBox();
            this.chk_EnableEmailNotification = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.text_Password);
            this.groupBox1.Controls.Add(this.text_UserName);
            this.groupBox1.Controls.Add(this.text_ServerAndPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件服务器设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "系统发件用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "系统发件密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "日志收件地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.chk_EnableEmailNotification);
            this.groupBox2.Controls.Add(this.text_RecvSysLogAddr);
            this.groupBox2.Controls.Add(this.chk_EnableSysLogEmail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志邮件";
            // 
            // chk_EnableSysLogEmail
            // 
            this.chk_EnableSysLogEmail.AutoSize = true;
            this.chk_EnableSysLogEmail.Location = new System.Drawing.Point(164, 61);
            this.chk_EnableSysLogEmail.Name = "chk_EnableSysLogEmail";
            this.chk_EnableSysLogEmail.Size = new System.Drawing.Size(214, 22);
            this.chk_EnableSysLogEmail.TabIndex = 4;
            this.chk_EnableSysLogEmail.Text = "发送日志邮件(管理员)";
            this.chk_EnableSysLogEmail.UseVisualStyleBackColor = true;
            // 
            // btn_Cancer
            // 
            this.btn_Cancer.Location = new System.Drawing.Point(311, 320);
            this.btn_Cancer.Name = "btn_Cancer";
            this.btn_Cancer.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancer.TabIndex = 6;
            this.btn_Cancer.Text = "取消";
            this.btn_Cancer.UseVisualStyleBackColor = true;
            this.btn_Cancer.Click += new System.EventHandler(this.btn_Cancer_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(228, 320);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 33);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // text_ServerAndPort
            // 
            this.text_ServerAndPort.Location = new System.Drawing.Point(164, 27);
            this.text_ServerAndPort.Name = "text_ServerAndPort";
            this.text_ServerAndPort.Size = new System.Drawing.Size(210, 28);
            this.text_ServerAndPort.TabIndex = 3;
            // 
            // text_UserName
            // 
            this.text_UserName.Location = new System.Drawing.Point(164, 65);
            this.text_UserName.Name = "text_UserName";
            this.text_UserName.Size = new System.Drawing.Size(210, 28);
            this.text_UserName.TabIndex = 4;
            // 
            // text_Password
            // 
            this.text_Password.Location = new System.Drawing.Point(164, 99);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(210, 28);
            this.text_Password.TabIndex = 5;
            // 
            // text_RecvSysLogAddr
            // 
            this.text_RecvSysLogAddr.Location = new System.Drawing.Point(164, 27);
            this.text_RecvSysLogAddr.Name = "text_RecvSysLogAddr";
            this.text_RecvSysLogAddr.Size = new System.Drawing.Size(210, 28);
            this.text_RecvSysLogAddr.TabIndex = 6;
            // 
            // chk_EnableEmailNotification
            // 
            this.chk_EnableEmailNotification.AutoSize = true;
            this.chk_EnableEmailNotification.Location = new System.Drawing.Point(164, 89);
            this.chk_EnableEmailNotification.Name = "chk_EnableEmailNotification";
            this.chk_EnableEmailNotification.Size = new System.Drawing.Size(196, 22);
            this.chk_EnableEmailNotification.TabIndex = 7;
            this.chk_EnableEmailNotification.Text = "启用邮件提醒(用户)";
            this.chk_EnableEmailNotification.UseVisualStyleBackColor = true;
            // 
            // FormAdminEmailSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 392);
            this.Controls.Add(this.btn_Cancer);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminEmailSetting";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "FormAdminEmailSetting";
            this.Load += new System.EventHandler(this.FormAdminEmailSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_EnableSysLogEmail;
        private System.Windows.Forms.Button btn_Cancer;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.TextBox text_UserName;
        private System.Windows.Forms.TextBox text_ServerAndPort;
        private System.Windows.Forms.TextBox text_RecvSysLogAddr;
        private System.Windows.Forms.CheckBox chk_EnableEmailNotification;
    }
}