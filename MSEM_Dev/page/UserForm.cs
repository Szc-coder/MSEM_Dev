    using MSEM_Dev.page.UserFormChildren;
using System.Data.SqlClient;
using MSEM_Dev.Uitls;
using MSEM_Dev.goble;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

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



            while (datareader.Read())
            {
                UserDataGridView.Rows.Add(datareader[0].ToString(), datareader[1].ToString(), datareader[2].ToString(), datareader[3].ToString(), datareader[4].ToString(), datareader[5].ToString(), goble.RoleAndDp.roles[datareader.GetInt32(6)], RoleAndDp.dps[datareader[7].ToString()]);
            }
            datareader.Close(); 
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RoleAndDp.initRoleAndDP();
            DataSet dr = data.getDs("select * from MEMS.[department]","dp");

            DpBox.DataSource = dr.Tables["dp"];
            DpBox.DisplayMember = "name";
            DpBox.ValueMember = "dp_id";
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
                string id = UserDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if(id == null)
                {
                    MessageBox.Show("未选择用户");
                    return;
                }
                string text = $"确定删除{id}该用户吗？";
                DialogResult result = MessageBox.Show(text,"警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    string sql = $"delete from MEMS.[user] where id = '{id}'";
                    data.dosqlcom(sql);
                    MessageBox.Show("删除成功");
                    Refresh();
                }

            }catch (Exception ex)
            {
                MessageBox.Show("删除失败");
            }
        }

        private void selectBT_Click(object sender, EventArgs e)
        {
            string userPhone = userPhoneTb.Text;
            string userName = userNameTb.Text;


            string sql = $"select * from MEMS.[user] where ";

            if(userPhone != "")
            {
                sql += $"phone = '{userPhone}' ";
            }

            if(userName != "")
            {
                if(userPhone !="")
                {
                    sql += $"and name like '%{userName}%'";
                }
                else
                {
                    sql += $"name like '%{userName}%'";
                }
            }

            if(DpBox.SelectedValue.ToString()!= "")
            {
                if (userPhone != "" || userName != "")
                {
                    sql += $"and department = '{DpBox.SelectedValue.ToString()}'";
                }
                else
                {
                    sql += $"department = '{DpBox.SelectedValue.ToString()}'";
                }
            }


            SqlDataReader selectData = data.getsdr(sql);

            if(!selectData.HasRows)
            {
                MessageBox.Show("不存在该用户，请检查查询条件！");
                return ;
            }

            UserDataGridView.Rows.Clear();
            while (selectData.Read())
            {
                UserDataGridView.Rows.Add(selectData[0].ToString(), selectData[1].ToString(), selectData[2].ToString(), selectData[3].ToString(), selectData[4].ToString(), selectData[5].ToString(), selectData[6].ToString(), selectData[7].ToString());
            }
            selectData.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = UserDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            UpdataUserForm frm = new UpdataUserForm(id);
            frm.Show();
        }

        private void ToExBT_Click(object sender, EventArgs e)
        {
            try
            {
                //String path = "";

                //dialog 有异常，待定

/*                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择文件夹";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                }
                else
                {
                    return;
                }*/

                dataGirdToExcel.ToExcel("C:\\Users\\qqab1\\Desktop\\用户信息.xls", UserDataGridView);
                MessageBox.Show("导出成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show("导出出错，请联系管理员");
            }
        }
    }
}
