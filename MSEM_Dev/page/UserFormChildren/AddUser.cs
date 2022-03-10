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
using MSEM_Dev.goble;

namespace MSEM_Dev.page.UserFormChildren
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();


            if (!Valied.isTrueLen(Phone.Text, 10, 12) || Pwd.Text != Pwd2.Text || !Valied.isTrueLen(Pwd.Text, 7, 21) || !Valied.isTrueLen(name.Text, 0, 10) || !Valied.isTrueNum(Convert.ToInt32(age.Text), 17, 120))
            {
                MessageBox.Show("个人信息错误！请重新输入");
                return;
            }

            string valied = $"select * from MEMS.[user] where phone = '{Phone.Text}'";
            SqlDataReader dataReder = dataBase.getsdr(valied);
            dataReder.Read();
            if (dataReder.HasRows)
            {
                MessageBox.Show("该手机号已存在，请重新输入");
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
                    int roleid = 3;
                    foreach(int i in RoleAndDp.roles.Keys)
                    {
                        if(RoleAndDp.roles[i].Equals(RoleCom.Text))
                        {
                            roleid = i;
                            break;
                        }
                    }

                    string Dpid = "";
                    foreach(string key in RoleAndDp.dps.Keys)
                    {
                        if(RoleAndDp.dps[key].Equals(DPcom.Text))
                        {
                            Dpid = key;
                            break;
                        }
                    }

                    string sql = string.Format($"insert into MEMS.[user] values('{guid}','{Pwd.Text}','{name.Text}','{Phone.Text}','{sex.Text}','{age.Text}',{roleid},'{Dpid}')");
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

                
                foreach (int key in RoleAndDp.roles.Keys)
                {
                    RoleCom.Items.Add(RoleAndDp.roles[key]);
                }

                foreach (string key in RoleAndDp.dps.Keys)
                {
                    DPcom.Items.Add(RoleAndDp.dps[key]);
                }
            }
        }
    }
}
