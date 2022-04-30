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
using MSEM_Dev.goble;
using MSEM_Dev.page;
using System.Data;
using System.Data.SqlClient;

namespace MSEM_Dev.page.Personal_Center
{
    public partial class modiflyPwd : Form
    {
        public modiflyPwd()
        {
            InitializeComponent();
        }

        private void uodata_Click(object sender, EventArgs e)
        {
            string sql = $"update MEMS.[user] set password ='{NewPwd.Text}' where phone = '{Goble.phone}' and password = '{norPwd.Text}'";
            
            if(!Valied.isTrueLen(NewPwd.Text,7,17))
            {
                MessageBox.Show("密码不符合规范");
            }

            if(!NewPwd.Text.Equals(NewPwdC.Text))
            {
                MessageBox.Show("两次输入密码不匹配！");
            }

            DataBase data = new DataBase();
            try
            {
                data.dosqlcom(sql);
                MessageBox.Show("修改成功!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("用户原密码错误或者数据库异常！");
            }

        }
    }
}
