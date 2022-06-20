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
using MSEM_Dev.goble;

namespace MSEM_Dev.page
{
    public partial class EqLBForm : Form
    {
        DataBase dataBase = new DataBase();
        private DataSet allEq = null;
        private DataSet leanedEq = null;

        public EqLBForm()
        {
            InitializeComponent();
        }

        private void init()
        {
            string sql = "select * from MEMS.equipment";
            allEq = dataBase.getDs(sql, "alleq");

            string leadedSql =
                $"select * from MEMS.equipment where equipment.id in (select equipment from MEMS.lending_record where lending_dp = '{Goble.Dp}')";
            leanedEq = dataBase.getDs(leadedSql, "leanedEq");

            dataGridView1.DataSource = allEq.Tables[0];
        }

        private void lendingApply_Click(object sender, EventArgs e)
        {
            string eqid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string borrowedDpId = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            int state = 0;
            string app_time = DateTime.Now.ToString();

            string appSql =
                $"INSERT INTO MEMS.lending_record values ('{MyGuid.GetGUID()}'," +
                $" '{eqid}', '{Goble.Dp}', '{borrowedDpId}', '{Goble.userId}','申请中'," +
                $"'{app_time}','','')";

            string updateSql = "update MEMS.lending_record " +
                               "set state = '申请中' " +
                               $"where id ='{eqid}'";

            string updateEqSql = "update MEMS.equipment " +
                               "set state = '申请借出中' " +
                               $"where id ='{eqid}'";

            try
            {
                dataBase.dosqlcom(appSql);
                dataBase.dosqlcom(updateSql);
                dataBase.dosqlcom(updateEqSql);
                MessageBox.Show("申请成功，请等待审核");
                init();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常!");
            }
        }

        private void showJustLending_CheckStateChanged(object sender, EventArgs e)
        {
            if (showJustLending.Checked)
            {
                dataGridView1.DataSource = leanedEq.Tables[0];
            }
            else
            {
                dataGridView1.DataSource = allEq.Tables[0];
            }
        }

        private void EqLBForm_Load(object sender, EventArgs e)
        {
            init();
        }

        private void back_Click(object sender, EventArgs e)
        {
            string eqid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string borrowedDpId = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            string state =  dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            if (!state.Equals("已借入"))
            {
                MessageBox.Show("只能选择本部门已借入的设备");
                return;
            }
            else
            {
                string updateEqSql = "update MEMS.equipment " +
                                     "set state = '归还申请中' " +
                                     $"where id ='{eqid}'";
                string updateSql = "update MEMS.lending_record " +
                                   "set state = '归还申请中' " +
                                   $"where id ='{eqid}'";
                try
                {
                    dataBase.dosqlcom(updateEqSql);
                    dataBase.dosqlcom(updateSql);
                    MessageBox.Show("申请成功,请等待借出部门审核");
                    init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("系统异常");
                }
            }

        }
    }
}
