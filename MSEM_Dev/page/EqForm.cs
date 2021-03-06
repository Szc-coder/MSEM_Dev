using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using MSEM_Dev.goble;
using MSEM_Dev.Uitls;
using MSEM_Dev.page.EqFormChildred;
using System.Threading;
using DataTable = System.Data.DataTable;


namespace MSEM_Dev.page
{
    public partial class EqForm : Form
    {
        // 采用全局变量方式定义dataset和SqlDataAdapter

        private DataBase data = new DataBase();
        public static DataSet dataset = new DataSet();
        public static SqlDataAdapter sdawitnScb = null;
        private Boolean WTimeIsChange = false;


        public EqForm()
        {
            InitializeComponent();
        }

        public void DataGridReflash()
        {
            string sql = "";


            if (Goble.Role_name == "admin")
            {
                sql = "select * from MEMS.[equipment]";
            }
            else
            {
                sql = $"select * from MEMS.[equipment] where responsible_dp = '{Goble.Dp}'";
            }

            sdawitnScb = data.getSdaWithSqlCommandBuilder(sql);
            sdawitnScb.Fill(dataset);
            EqDataGridView.DataSource = dataset.Tables[0];
        }

        public void init()
        {
            String SelectDp = "select dp_id,name from MEMS.[department]";
            String[] dpIdAndNameList = { "dp_id", "name" };
            DataTable dpADataTable = data.getTable(SelectDp, dpIdAndNameList);
            selectDpBox.DataSource = dpADataTable;
            selectDpBox.ValueMember = "dp_id";
            selectDpBox.DisplayMember = "name";
            selectDpBox.SelectedIndex = -1;
        }



        private void EqForm_Load(object sender, EventArgs e)
        {
            DataGridReflash();
            init();
        }

        private void Reflash_Click(object sender, EventArgs e)
        {
            EqDataGridView.DataSource = dataset.Tables[0];
            selectDpBox.SelectedIndex = -1;
            WTimeIsChange = false;
            selectByBuyTime.Value = DateTime.Now;
            selectByBuyTime2.Value = DateTime.Now;
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
                DialogResult dialogResult = MessageBox.Show("请注意，该操作不可逆", "警告", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
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
            int row = EqDataGridView.SelectedRows[0].Index;
            String id = EqDataGridView.Rows[row].Cells[0].Value.ToString();
            eq.id = id;
            eq.Show();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            EqDataGridView.DataSource = dataset.Tables[0];

            string id = selectByIdBox.Text;
            string ser = selectBySer.Text;
            string name = selectByName.Text;
            DateTime buyTime = selectByBuyTime.Value;
            DateTime wTiem = selectByBuyTime2.Value;
            string dp = "";

            string linqStr = "";

            if (!id.Equals(""))
            {
                linqStr += $"id = '{id}'";
            }

            if (!ser.Equals("") && !linqStr.Equals(""))
            {
                linqStr += $" and serial_number = '{ser}'";
            }
            else if(!ser.Equals(""))
            {
                linqStr += $"serial_number = '{ser}'";
            }

            if (!name.Equals("") && !linqStr.Equals(""))
            {
                linqStr += $" and name Like '%{name}%'";
            }
            else if(!name.Equals(""))
            {
                linqStr += $"name Like '%{name}%'";
            }

            if (WTimeIsChange == true && !linqStr.Equals(""))
            {
                linqStr +=
                    $" and purchase_time > '{selectByBuyTime.Value.ToString()}' and purchase_time < '{selectByBuyTime2.Value.ToString()}'";
            }
            else if (WTimeIsChange == true)
            {
                linqStr +=
                    $"purchase_time > '{selectByBuyTime.Value.ToString()}' and purchase_time < '{selectByBuyTime2.Value.ToString()}'";
            }

            if (selectDpBox.SelectedIndex != -1 && !linqStr.Equals(""))
            {
                linqStr += $" and responsible_dp = '{selectDpBox.SelectedValue.ToString()}'";
            }
            else if (selectDpBox.SelectedIndex != -1)
            {
                linqStr += $"responsible_dp = '{selectDpBox.SelectedValue.ToString()}'";
            }

            DataTable dt = dataset.Tables[0].Copy();
            DataView selectData = dt.DefaultView;
            selectData.RowFilter = linqStr;
            EqDataGridView.DataSource = selectData;
        }

        private void selectByWTime_ValueChanged(object sender, EventArgs e)
        {
            this.WTimeIsChange  = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WTimeIsChange = false;
            selectByBuyTime.Value = DateTime.Now;
            selectByBuyTime2.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = EqDataGridView.SelectedCells[0].RowIndex;
            string EqName = EqDataGridView.Rows[row].Cells[1].Value.ToString();
            string EqId = EqDataGridView.Rows[row].Cells[0].Value.ToString();
            EqReairForm eqReairForm = new EqReairForm();
            eqReairForm.EqName = EqName;
            eqReairForm.EqID = EqId;
            eqReairForm.ShowDialog();
        }

        private void ToExcel_Click(object sender, EventArgs e)
        {
            dataGirdToExcel.ExportToExcel(EqDataGridView, "设备汇总");
        }

        private void EqDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string Eqid = EqDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ShowImage show = new ShowImage();
                show.EqName = Eqid;
                show.ShowDialog();
            }
        }
    }
}
