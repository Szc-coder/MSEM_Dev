namespace MSEM_Dev.page
{
    partial class regForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Pwd2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.DP = new System.Windows.Forms.ComboBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "手机号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "年龄";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(297, 62);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(121, 23);
            this.Phone.TabIndex = 6;
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(297, 100);
            this.Pwd.Name = "Pwd";
            this.Pwd.PasswordChar = '*';
            this.Pwd.Size = new System.Drawing.Size(121, 23);
            this.Pwd.TabIndex = 7;
            // 
            // Pwd2
            // 
            this.Pwd2.Location = new System.Drawing.Point(297, 140);
            this.Pwd2.Name = "Pwd2";
            this.Pwd2.PasswordChar = '*';
            this.Pwd2.Size = new System.Drawing.Size(121, 23);
            this.Pwd2.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(297, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 23);
            this.name.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(297, 258);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(121, 23);
            this.age.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "部门";
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(297, 221);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(121, 25);
            this.sex.TabIndex = 13;
            // 
            // DP
            // 
            this.DP.FormattingEnabled = true;
            this.DP.Location = new System.Drawing.Point(297, 293);
            this.DP.Name = "DP";
            this.DP.Size = new System.Drawing.Size(121, 25);
            this.DP.TabIndex = 14;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(222, 359);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(75, 23);
            this.RegButton.TabIndex = 15;
            this.RegButton.Text = "注册";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 413);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.DP);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Pwd2);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regForm";
            this.Text = "regForm";
            this.Load += new System.EventHandler(this.regForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Phone;
        private TextBox Pwd;
        private TextBox Pwd2;
        private TextBox name;
        private TextBox age;
        private Label label7;
        private ComboBox sex;
        private ComboBox DP;
        private Button RegButton;
    }
}