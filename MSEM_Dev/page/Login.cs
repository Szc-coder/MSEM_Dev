using MSEM_Dev.page;
using MSEM_Dev.Uitls;
using System.Data.SqlClient;
using MSEM_Dev.goble;
using System.Data;

namespace MSEM_Dev.page
{
    public partial class Login : Form
    {
        public static string phone = "";
        DataBase dataBase = new DataBase();

        public Login()
        {
            InitializeComponent();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(userNameTextBox.Text )||Valied.isTrueLen(passwordTextBox.Text,8,20))
            {
                bool isTruePwd = Valied.cheakUsernamePwa(userNameTextBox.Text, passwordTextBox.Text);
                if(isTruePwd)
                {
                    string sql = $"select name, role_name ,department,phone,u.id from MEMS.[user] as u join MEMS.[role_class] as rc on rc.id = u.role where phone = '{userNameTextBox.Text}'";
                    SqlDataReader role = dataBase.getsdr(sql);
                    role.Read();

                    Goble.Dp = (string)role["department"];
                    Goble.Name = (string)role["name"];
                    Goble.Role_name = (string)role["role_name"];
                    Goble.phone = (string)role["phone"];
                    Goble.userId = (string)role["id"];

                    index index = new index(this);
                    index.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("账号名或者密码错误！");
                }
            }
            else
            {
                MessageBox.Show("账号名或者密码错误！");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                dataBase.con_open();
                dataBase.conn_close();
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            catch
            {
                MessageBox.Show("数据库连接错误！");
                Application.Exit();
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            regForm reg = new regForm();
            reg.Show();
        }
    }
}
