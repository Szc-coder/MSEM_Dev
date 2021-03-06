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
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MSEM_Dev.page
{
    public partial class applicationReview : Form
    {
        DataBase dataBase = new DataBase();

        public applicationReview()
        {
            InitializeComponent();
        }

        void init()
        {
            string sql = $"select * from MEMS.purchase";
            SqlDataReader sdr = dataBase.getsdr(sql);
            while (sdr.Read())
            {
                int newInd = dataGridView1.Rows.Add();
                dataGridView1.Rows[newInd].Cells[0].Value = sdr[0];
                dataGridView1.Rows[newInd].Cells[1].Value = sdr[1];
                dataGridView1.Rows[newInd].Cells[2].Value = sdr[2];
                dataGridView1.Rows[newInd].Cells[3].Value = sdr[3];
                dataGridView1.Rows[newInd].Cells[4].Value = sdr[4];
                dataGridView1.Rows[newInd].Cells[5].Value = sdr[5];
                dataGridView1.Rows[newInd].Cells[6].Value = sdr[6];
                dataGridView1.Rows[newInd].Cells[7].Value = sdr[7];
                dataGridView1.Rows[newInd].Cells[8].Value = sdr[8];
                dataGridView1.Rows[newInd].Cells[10].Value = sdr[9];
            }

        }

        private void applicationReview_Load(object sender, EventArgs e)
        {
            init();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                string text = $"备注：\n{dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}";
                MessageBox.Show(text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] ids = { };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)row.Cells[10];
                if (Convert.ToBoolean(ck.Value))
                {
                    ids.Append(row.Cells[0].Value.ToString());
                }
            }

            if (ids.Length < 1)
            {
                MessageBox.Show("未选择任何设备！");
                return;
            }

            try
            {
                string idStrings = "";
                foreach (var id in ids)
                {
                    idStrings += id + ",";
                }

                idStrings = idStrings.Substring(0, idStrings.Length - 1);

                string sql = $"update purchase set status = '通过' where id in '{idStrings}'";
                dataBase.dosqlcom(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show("系统异常!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ids = { };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)row.Cells[10];
                if (Convert.ToBoolean(ck.Value))
                {
                    ids.Append(row.Cells[0].Value.ToString());
                }
            }

            if (ids.Length < 1)
            {
                MessageBox.Show("未选择任何设备！");
                return;
            }

            try
            {
                string idStrings = "";
                foreach (var id in ids)
                {
                    idStrings += id + ",";
                }

                idStrings = idStrings.Substring(0, idStrings.Length - 1);

                string sql = $"update purchase set status = '驳回' where id in '{idStrings}'";
                dataBase.dosqlcom(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show("系统异常!");
            }
        }
    }
}
