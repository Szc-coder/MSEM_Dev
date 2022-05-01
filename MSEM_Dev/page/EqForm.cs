using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using MSEM_Dev.goble;
using MSEM_Dev.Uitls;
using MSEM_Dev.page.EqFormChildred;
using System.Threading;


namespace MSEM_Dev.page
{
    public partial class EqForm : Form
    {
        // 采用全局变量方式定义dataset和SqlDataAdapter

        DataBase data = new DataBase();
        public static DataSet dataset = new DataSet();
        public static SqlDataAdapter sdawitnScb = null;

        public EqForm()
        {
            InitializeComponent();
        }

        public void DataGridReflash()
        {
            string sql = "";
            EqDataGridView.DataSource = null;
            dataset = new DataSet();
            if (Goble.Role_name == "admin")
            {
                sql = $"select * from MEMS.[equipment]";
            }
            else
            {
                sql = $"select * from MEMS.[equipment] where responsible_dp = '{Goble.Dp}'";
            }

            try
            {
                sdawitnScb = data.getSdaWithSqlCommandBuilder(sql);
                sdawitnScb.Fill(dataset);
                EqDataGridView.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载错误，请点击刷新!");
            }

            
        }

        private void EqForm_Load(object sender, EventArgs e)
        {
            DataGridReflash();
        }

        private void Reflash_Click(object sender, EventArgs e)
        {
            DataGridReflash();
        }

        private void AddEq_Click(object sender, EventArgs e)
        {
            AddEq addEq = new AddEq();
            addEq.Show();
        }

        private void deleteEq_Click(object sender, EventArgs e)
        {
            try
            {
                int row = EqDataGridView.SelectedCells[0].RowIndex;
                String id = EqDataGridView.Rows[row].Cells[0].Value.ToString();
                // String Sql = $"DELETE FROM MEMS.[equipment] WHERE id = '{id}'";
                DialogResult dialogResult = MessageBox.Show("请注意，该操作不可逆", "警告", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {  
                    // DataBase dataBase = new DataBase();
                    // dataBase.dosqlcom(Sql);
                    // MessageBox.Show("删除成功!");
                    // Refresh();
                    dataset.Tables[0].Rows[EqDataGridView.SelectedCells[0].RowIndex].Delete();
                    sdawitnScb.Update(dataset);
                    LOG log = new LOG();
                    log.addLog(goble.Goble.Name,"删除", "设备id："+id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常");
            }
        }

        private void updataEq_Click(object sender, EventArgs e)
        {
            updataEq eq = new updataEq();
            int row = EqDataGridView.SelectedCells[0].RowIndex;
            String id = EqDataGridView.Rows[row].Cells[0].Value.ToString();
            eq.id = id;
            eq.Show();
        }
    }
}
