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
    public partial class EqReairForm : Form
    {
        public string EqName;
        public string EqID;

        // 设备维修申请，需要填写
        // 申请类型、内容描述
        public EqReairForm()
        {
            InitializeComponent();
        }

        private void EqReairForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("维修");
            comboBox1.Items.Add("保养");
            comboBox1.Items.Add("报废检测");
            label3.Text += EqName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into MEMS.repair values(" +
                         $"'{MyGuid.GetGUID()}','{comboBox1.Text}'," +
                         $"'等待接受','{Goble.userId}','{Goble.Dp}','', '{DateTime.Now.ToString()}'," +
                         $"'','{textBox1.Text}', '' ,'' ,0 ,'{EqID}')";
            var result = MessageBox.Show("请保证当前选择的设备正确!", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    DataBase data = new DataBase();
                    data.dosqlcom(sql);
                    MessageBox.Show("申请成功,请等待工作人员回复");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("系统异常");
                }
            }
        }
    }
}
