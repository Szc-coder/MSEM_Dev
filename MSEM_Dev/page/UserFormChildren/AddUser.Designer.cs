namespace MSEM_Dev.page.UserFormChildren
{
    partial class AddUser
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
            this.RegButton = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Pwd2 = new System.Windows.Forms.TextBox();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DPcom = new System.Windows.Forms.ComboBox();
            this.RoleCom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(213, 378);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(75, 23);
            this.RegButton.TabIndex = 30;
            this.RegButton.Text = "添加";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(277, 201);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(121, 25);
            this.sex.TabIndex = 28;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(277, 238);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(121, 23);
            this.age.TabIndex = 26;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(277, 163);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 23);
            this.name.TabIndex = 25;
            // 
            // Pwd2
            // 
            this.Pwd2.Location = new System.Drawing.Point(277, 120);
            this.Pwd2.Name = "Pwd2";
            this.Pwd2.PasswordChar = '*';
            this.Pwd2.Size = new System.Drawing.Size(121, 23);
            this.Pwd2.TabIndex = 24;
            // 
            // Pwd
            // 
            this.Pwd.Location = new System.Drawing.Point(277, 80);
            this.Pwd.Name = "Pwd";
            this.Pwd.PasswordChar = '*';
            this.Pwd.Size = new System.Drawing.Size(121, 23);
            this.Pwd.TabIndex = 23;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(277, 42);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(121, 23);
            this.Phone.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "手机号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "部门";
            // 
            // DPcom
            // 
            this.DPcom.FormattingEnabled = true;
            this.DPcom.Location = new System.Drawing.Point(277, 267);
            this.DPcom.Name = "DPcom";
            this.DPcom.Size = new System.Drawing.Size(121, 25);
            this.DPcom.TabIndex = 32;
            // 
            // RoleCom
            // 
            this.RoleCom.FormattingEnabled = true;
            this.RoleCom.Location = new System.Drawing.Point(277, 298);
            this.RoleCom.Name = "RoleCom";
            this.RoleCom.Size = new System.Drawing.Size(121, 25);
            this.RoleCom.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "权限";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 422);
            this.Controls.Add(this.RoleCom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DPcom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.sex);
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
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegButton;
        private ComboBox sex;
        private TextBox age;
        private TextBox name;
        private TextBox Pwd2;
        private TextBox Pwd;
        private TextBox Phone;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox DPcom;
        private ComboBox RoleCom;
        private Label label8;
    }
}