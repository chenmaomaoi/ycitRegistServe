namespace RegistServe
{
    partial class FormLogViewer
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLogLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dGUID,
            this.dUsername,
            this.dName,
            this.dLogLevel,
            this.dTime,
            this.dMessage});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1421, 785);
            this.dataGridView.TabIndex = 0;
            // 
            // dGUID
            // 
            this.dGUID.HeaderText = "GUID";
            this.dGUID.MinimumWidth = 8;
            this.dGUID.Name = "dGUID";
            this.dGUID.ReadOnly = true;
            this.dGUID.Visible = false;
            this.dGUID.Width = 150;
            // 
            // dUsername
            // 
            this.dUsername.HeaderText = "账号";
            this.dUsername.MinimumWidth = 8;
            this.dUsername.Name = "dUsername";
            this.dUsername.ReadOnly = true;
            this.dUsername.Width = 150;
            // 
            // dName
            // 
            this.dName.HeaderText = "姓名";
            this.dName.MinimumWidth = 8;
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
            this.dName.Width = 150;
            // 
            // dLogLevel
            // 
            this.dLogLevel.HeaderText = "日志级别";
            this.dLogLevel.MinimumWidth = 8;
            this.dLogLevel.Name = "dLogLevel";
            this.dLogLevel.ReadOnly = true;
            this.dLogLevel.Width = 150;
            // 
            // dTime
            // 
            this.dTime.HeaderText = "时间";
            this.dTime.MinimumWidth = 8;
            this.dTime.Name = "dTime";
            this.dTime.ReadOnly = true;
            this.dTime.Width = 150;
            // 
            // dMessage
            // 
            this.dMessage.HeaderText = "消息";
            this.dMessage.MinimumWidth = 8;
            this.dMessage.Name = "dMessage";
            this.dMessage.ReadOnly = true;
            this.dMessage.Width = 150;
            // 
            // FormLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 809);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLogViewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMessage;
    }
}