namespace RegistServe
{
    partial class FormSetAlarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check_AlarmEnable = new System.Windows.Forms.CheckBox();
            this.numeric_Hour = new System.Windows.Forms.NumericUpDown();
            this.numeric_Minute = new System.Windows.Forms.NumericUpDown();
            this.btn_Set = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "分：";
            // 
            // check_AlarmEnable
            // 
            this.check_AlarmEnable.AutoSize = true;
            this.check_AlarmEnable.Location = new System.Drawing.Point(17, 81);
            this.check_AlarmEnable.Name = "check_AlarmEnable";
            this.check_AlarmEnable.Size = new System.Drawing.Size(70, 22);
            this.check_AlarmEnable.TabIndex = 2;
            this.check_AlarmEnable.Text = "启用";
            this.check_AlarmEnable.UseVisualStyleBackColor = true;
            // 
            // numeric_Hour
            // 
            this.numeric_Hour.Location = new System.Drawing.Point(84, 7);
            this.numeric_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numeric_Hour.Name = "numeric_Hour";
            this.numeric_Hour.Size = new System.Drawing.Size(61, 28);
            this.numeric_Hour.TabIndex = 3;
            // 
            // numeric_Minute
            // 
            this.numeric_Minute.Location = new System.Drawing.Point(84, 43);
            this.numeric_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numeric_Minute.Name = "numeric_Minute";
            this.numeric_Minute.Size = new System.Drawing.Size(61, 28);
            this.numeric_Minute.TabIndex = 4;
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(93, 75);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 33);
            this.btn_Set.TabIndex = 5;
            this.btn_Set.Text = "确定";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // FormSetAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 116);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.numeric_Minute);
            this.Controls.Add(this.numeric_Hour);
            this.Controls.Add(this.check_AlarmEnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "定时填报";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Minute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_AlarmEnable;
        private System.Windows.Forms.NumericUpDown numeric_Hour;
        private System.Windows.Forms.NumericUpDown numeric_Minute;
        private System.Windows.Forms.Button btn_Set;
    }
}