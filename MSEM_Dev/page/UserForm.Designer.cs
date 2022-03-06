namespace MSEM_Dev.page
{
    partial class UserForm
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
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.Id_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.权限 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userPhoneTb = new System.Windows.Forms.TextBox();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.userPhoneLb = new System.Windows.Forms.Label();
            this.NamelB = new System.Windows.Forms.Label();
            this.selectBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToAddRows = false;
            this.UserDataGridView.AllowUserToDeleteRows = false;
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_c,
            this.password_c,
            this.name_c,
            this.phone_c,
            this.sex_c,
            this.age_c,
            this.权限,
            this.department_c});
            this.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.UserDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UserDataGridView.MultiSelect = false;
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersVisible = false;
            this.UserDataGridView.RowTemplate.Height = 25;
            this.UserDataGridView.Size = new System.Drawing.Size(906, 527);
            this.UserDataGridView.TabIndex = 0;
            // 
            // Id_c
            // 
            this.Id_c.HeaderText = "id";
            this.Id_c.Name = "Id_c";
            // 
            // password_c
            // 
            this.password_c.HeaderText = "密码";
            this.password_c.Name = "password_c";
            // 
            // name_c
            // 
            this.name_c.HeaderText = "姓名";
            this.name_c.Name = "name_c";
            // 
            // phone_c
            // 
            this.phone_c.HeaderText = "手机号";
            this.phone_c.Name = "phone_c";
            // 
            // sex_c
            // 
            this.sex_c.HeaderText = "性别";
            this.sex_c.Name = "sex_c";
            // 
            // age_c
            // 
            this.age_c.HeaderText = "年龄";
            this.age_c.Name = "age_c";
            // 
            // 权限
            // 
            this.权限.HeaderText = "role";
            this.权限.Name = "权限";
            // 
            // department_c
            // 
            this.department_c.HeaderText = "部门";
            this.department_c.Name = "department_c";
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(981, 77);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "增加用户";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除用户";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(981, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "修改用户";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // userPhoneTb
            // 
            this.userPhoneTb.Location = new System.Drawing.Point(1010, 330);
            this.userPhoneTb.Name = "userPhoneTb";
            this.userPhoneTb.Size = new System.Drawing.Size(100, 23);
            this.userPhoneTb.TabIndex = 4;
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(1010, 396);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(100, 23);
            this.userNameTb.TabIndex = 6;
            // 
            // userPhoneLb
            // 
            this.userPhoneLb.AutoSize = true;
            this.userPhoneLb.Location = new System.Drawing.Point(929, 333);
            this.userPhoneLb.Name = "userPhoneLb";
            this.userPhoneLb.Size = new System.Drawing.Size(44, 17);
            this.userPhoneLb.TabIndex = 7;
            this.userPhoneLb.Text = "手机号";
            // 
            // NamelB
            // 
            this.NamelB.AutoSize = true;
            this.NamelB.Location = new System.Drawing.Point(929, 402);
            this.NamelB.Name = "NamelB";
            this.NamelB.Size = new System.Drawing.Size(32, 17);
            this.NamelB.TabIndex = 8;
            this.NamelB.Text = "姓名";
            // 
            // selectBT
            // 
            this.selectBT.Location = new System.Drawing.Point(981, 450);
            this.selectBT.Name = "selectBT";
            this.selectBT.Size = new System.Drawing.Size(75, 23);
            this.selectBT.TabIndex = 9;
            this.selectBT.Text = "查询";
            this.selectBT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "通过手机号或者姓名查询用户";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBT);
            this.Controls.Add(this.NamelB);
            this.Controls.Add(this.userPhoneLb);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.userPhoneTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "UserForm";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView UserDataGridView;
        private DataGridViewTextBoxColumn Id_c;
        private DataGridViewTextBoxColumn password_c;
        private DataGridViewTextBoxColumn name_c;
        private DataGridViewTextBoxColumn phone_c;
        private DataGridViewTextBoxColumn sex_c;
        private DataGridViewTextBoxColumn age_c;
        private DataGridViewTextBoxColumn 权限;
        private DataGridViewTextBoxColumn department_c;
        private Button AddUser;
        private Button button2;
        private Button button3;
        private TextBox userPhoneTb;
        private TextBox userNameTb;
        private Label userPhoneLb;
        private Label NamelB;
        private Button selectBT;
        private Label label1;
        private Button button1;
    }
}