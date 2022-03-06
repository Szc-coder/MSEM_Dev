using MSEM_Dev.page.UserFormChildren;
using System.Data.SqlClient;
using MSEM_Dev.Uitls;
using MSEM_Dev.goble;

namespace MSEM_Dev.page
{
    public partial class UserForm : Form
    {
        DataBase data = new DataBase();

        public UserForm()
        {
            InitializeComponent();
        }


        public void Refresh()
        {

            string sql = "";
            UserDataGridView.Rows.Clear();
            if(Goble.Role_name == "admin")
            {
                sql = $"select * from MEMS.[user]";
            }
            else
            {
                sql =  $"select * from MEMS.[user] where department = '{Goble.Dp}'";
            }
            SqlDataReader datareader = data.getsdr(sql);
            while(datareader.Read())
            {
                UserDataGridView.Rows.Add(datareader[0].ToString(), datareader[1].ToString(), datareader[2].ToString(), datareader[3].ToString(), datareader[4].ToString(), datareader[5].ToString(), datareader[6].ToString(), datareader[7].ToString());
            }
            datareader.Close(); 
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (Goble.Role_name != "ADMIN")
            {
                MessageBox.Show("目前非院长办公室外，其余部门仅允许添加本部门普通设备管理员，其余角色请联系院长办公室");
            }
            AddUser add = new AddUser();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = UserDataGridView.SelectedRows[0].Cells[0].ToString();
                string text = $"确定删除{id}该用户吗？";
                DialogResult result = MessageBox.Show("消息提示",text,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    string sql = $"delete from MEMS.[user] where id = '{id}'";
                    data.dosqlcom(sql);
                    MessageBox.Show("删除成功");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
