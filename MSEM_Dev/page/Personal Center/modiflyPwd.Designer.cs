namespace MSEM_Dev.page.Personal_Center
{
    partial class modiflyPwd
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
            this.label3 = new System.Windows.Forms.Label();
            this.uodata = new System.Windows.Forms.Button();
            this.norPwd = new System.Windows.Forms.TextBox();
            this.NewPwd = new System.Windows.Forms.TextBox();
            this.NewPwdC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认新密码";
            // 
            // uodata
            // 
            this.uodata.Location = new System.Drawing.Point(144, 207);
            this.uodata.Name = "uodata";
            this.uodata.Size = new System.Drawing.Size(75, 23);
            this.uodata.TabIndex = 3;
            this.uodata.Text = "修改密码";
            this.uodata.UseVisualStyleBackColor = true;
            this.uodata.Click += new System.EventHandler(this.uodata_Click);
            // 
            // norPwd
            // 
            this.norPwd.Location = new System.Drawing.Point(190, 50);
            this.norPwd.Name = "norPwd";
            this.norPwd.Size = new System.Drawing.Size(100, 23);
            this.norPwd.TabIndex = 4;
            // 
            // NewPwd
            // 
            this.NewPwd.Location = new System.Drawing.Point(190, 103);
            this.NewPwd.Name = "NewPwd";
            this.NewPwd.Size = new System.Drawing.Size(100, 23);
            this.NewPwd.TabIndex = 5;
            // 
            // NewPwdC
            // 
            this.NewPwdC.Location = new System.Drawing.Point(190, 157);
            this.NewPwdC.Name = "NewPwdC";
            this.NewPwdC.Size = new System.Drawing.Size(100, 23);
            this.NewPwdC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码长度在8-16位之间！！！";
            // 
            // modiflyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewPwdC);
            this.Controls.Add(this.NewPwd);
            this.Controls.Add(this.norPwd);
            this.Controls.Add(this.uodata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modiflyPwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button uodata;
        private TextBox norPwd;
        private TextBox NewPwd;
        private TextBox NewPwdC;
        private Label label4;
    }
}