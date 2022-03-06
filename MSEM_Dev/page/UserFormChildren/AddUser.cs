using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MSEM_Dev.Uitls;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSEM_Dev.page.UserFormChildren
{
    public partial class AddUser : Form
    {

        DataSet RoleDS;
        DataSet DpDS;

        public AddUser()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            string valied = $"select * from MEMS.[user] where phone = '{Phone.Text}'";
            SqlDataReader dataReder = dataBase.getsdr(valied);
            dataReder.Read();
            if (dataReder.HasRows)
            {
                MessageBox.Show("该手机号已存在，请重新输入");
                return;
            }


            if (!Valied.isTrueLen(Phone.Text,10,12) || Pwd.Text != Pwd2.Text || !Valied.isTrueLen(Pwd.Text, 7, 21) || !Valied.isTrueLen(name.Text, 0, 10) || !Valied.isTrueNum(Convert.ToInt32(age.Text), 17, 120))
            {
                MessageBox.Show("个人信息错误！请重新输入");
                return;
            }

            string guid = MyGuid.GetGUID();

            try
            {
                if (goble.Goble.Role_name != "admin")
                {
                    string sql = string.Format($"insert into MEMS.[user] values('{guid}','{Pwd.Text}','{name.Text}','{Phone.Text}','{sex.Text}','{age.Text}','{2}','{goble.Goble.Dp}')");
                    dataBase.dosqlcom(sql);
                    MessageBox.Show("添加成功，默认权限为科室设备管理员，若非科室设备管理员请联系科室主任或院长办公室进行更改权限");
                    this.Close();
                }
                else
                {
                    DataTable roles = RoleDS.Tables[0];
                    var ro = from dp in roles.AsEnumerable() where dp.Field<string>("role_name") == RoleCom.Text select dp[0];
                    string role = "";
                    ro.ToList().ForEach(dp => { role = dp.ToString(); });

                    DataTable dt = DpDS.Tables[0];
                    var DPID = from dp in dt.AsEnumerable() where dp.Field<string>("name") == DPcom.Text select dp[0];
                    string ansDpId = "";
                    DPID.ToList().ForEach(dp => { ansDpId = dp.ToString(); });

                    string sql = string.Format($"insert into MEMS.[user] values('{guid}','{Pwd.Text}','{name.Text}','{Phone.Text}','{sex.Text}','{age.Text}','{Convert.ToInt32(role)}','{ansDpId}')");
                    dataBase.dosqlcom(sql);
                    MessageBox.Show("添加成功");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常，请联系管理员");
            }

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if(goble.Goble.Role_name != "admin")
            {
                label7.Visible = false;
                label8.Visible = false;
                DPcom.Visible = false;  
                RoleCom.Visible = false;

            }
            else
            {

                DataBase dataBase = new DataBase();
                string sql = "select * from MEMS.[department]";
                DpDS = dataBase.getDs(sql, "department");
                foreach (DataRow Dr in DpDS.Tables[0].Rows)
                {
                    DPcom.Items.Add(Dr[1]);
                }



                string sql2 = "select * from MEMS.[role_class]";
                RoleDS = dataBase.getDs(sql2, "role_class");
                foreach (DataRow Dr in RoleDS.Tables[0].Rows)
                {
                    RoleCom.Items.Add(Dr[1]);
                }
            }
        }
    }
}
