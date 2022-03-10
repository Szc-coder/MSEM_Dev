using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSEM_Dev.Uitls;
using System.Data.SqlClient;

namespace MSEM_Dev.page.UserFormChildren
{
    public partial class UpdataUserForm : Form
    {

        DataBase dataBase = new DataBase();

        public string id { get; set; }


        public UpdataUserForm(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void UpdataUserForm_Load(object sender, EventArgs e)
        {
            

            string valied = $"select * from MEMS.[user] where id = '{this.id}'";
            SqlDataReader dataReder = dataBase.getsdr(valied);
            dataReder.Read();



            Pwd.Text = dataReder[1].ToString().Trim();

            name.Text = dataReder[2].ToString();
            Phone.Text = dataReder[3].ToString();
            sex.Text = dataReder[4].ToString();
            age.Text = dataReder[5].ToString();
            
            dataReder.Close();

            if(goble.Goble.Role_name != "admin")
            {
                RoleCom.Visible = false;
                DPcom.Visible = false;
            }
            else
            {
                string RoleSql = "select * from MEMS.[role_class]";
                SqlDataReader roles = dataBase.getsdr(RoleSql);
                while(roles.Read())
                {
                    RoleCom.Items.Add(roles[1].ToString());
                }
                roles.Close();
                string DpSql = "select * from MEMS.[department]";
                SqlDataReader Dps = dataBase.getsdr(DpSql);
                while(Dps.Read())
                {
                    DPcom.Items.Add(Dps[1].ToString());
                }
                Dps.Close();
            }

        }

        private void RegButton_Click(object sender, EventArgs e)
        {

            if (!Valied.isTrueLen(Phone.Text, 10, 12) || !Valied.isTrueLen(Pwd.Text, 7, 21) || !Valied.isTrueLen(name.Text, 0, 10) || !Valied.isTrueNum(Convert.ToInt32(age.Text), 17, 120))
            {
                MessageBox.Show("个人信息错误！请重新输入");
                return;
            }

            string PhoneSql = $"select * from MEMS.[user] where phone = '{Phone.Text}'";
            SqlDataReader PhoneData = dataBase.getsdr(PhoneSql);
            int count = 0;
            while(PhoneData.Read())
            {
                count++;
            }
            if(count > 1)
            {
                MessageBox.Show("该手机号已经存在!");
                return;
            }

            string Dpid = "";
            foreach (string key in goble.RoleAndDp.dps.Keys)
            {
                if (goble.RoleAndDp.dps[key].Equals(DPcom.Text))
                {
                    Dpid = key;
                    break;
                }
            }

            string UpdataSql = $"update MEMS.[user] set password ='{Pwd.Text}', name='{name.Text}', phone='{Phone.Text}', sex='{sex.SelectedItem}', age = {age.Text}, role ={RoleCom.SelectedIndex}, department='{Dpid}' where id = '{id}'";
            try
            {
                dataBase.dosqlcom(UpdataSql);
                MessageBox.Show("修改成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败!");
                return;
            }
        }
    }
}
