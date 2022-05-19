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

namespace MSEM_Dev.page
{
    public partial class EqDeclare : Form
    {
        DataBase dataBase = new DataBase();

        public EqDeclare()
        {
            InitializeComponent();
        }

        private void init()
        {
            String selectCla = "select id,name from MEMS.[class]";
            String selectSup = "select id,name from MEMS.[supplier]";

            String[] classIdAndNameList = { "id", "name" };
            String[] supllersIdAndNameList = { "id", "name" };

            DataTable className = dataBase.getTable(selectCla, classIdAndNameList);
            DataTable supllerName = dataBase.getTable(selectSup, supllersIdAndNameList);

            superBox.DataSource = supllerName;
            superBox.ValueMember = "id";
            superBox.DisplayMember = "name";

            classBox.DataSource = className;
            classBox.ValueMember = "id";
            classBox.DisplayMember = "name";

        }

        private void clear()
        {
            nameBox.Text = "";
            eqNumBox.Text = "";
            resonBox.Text = "";
            classBox.SelectedIndex = 0;
            superBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameBox.Text.Equals("") || eqNumBox.Text.Equals("") || resonBox.Text.Equals(""))
            {
                MessageBox.Show("内容不能为空!");
            }
            else
            {
                try
                {
                    string name = nameBox.Text;
                    int eqNum = Convert.ToInt16(eqNumBox.Text);
                    string reson = resonBox.Text;
                    int cla = Convert.ToInt16(classBox.SelectedValue.ToString());
                    string supId = superBox.SelectedValue.ToString();

                    string sql =
                        $"INSERT INTO MEMS.purchase VALUES ('{Uitls.MyGuid.GetGUID()}','{Goble.Dp}','{Goble.userId}','{name}',{eqNum},'审核中','{DateTime.Now}','{reson}',{cla},'{supId}')";
                    dataBase.dosqlcom(sql);
                    LOG log = new LOG();
                    log.addLog("添加采购请求", "insert", "purchase:" + name);
                    MessageBox.Show("添加成功");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请求失败，请联系管理员");
                }

            }
        }

        private void EqDeclare_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
