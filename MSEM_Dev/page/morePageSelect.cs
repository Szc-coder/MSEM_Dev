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
namespace MSEM_Dev.page
{
    public partial class morePageSelect : Form
    {
        public morePageSelect()
        {
            InitializeComponent();
        }

        DataBase dataBase  = new DataBase();

        void init()
        {
            string sql = "select * from MEMS.department";
            dataGridView1.DataSource = dataBase.getDs(sql, "users").Tables["users"];
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());
        }

        private void morePageSelect_Load(object sender, EventArgs e)
        {
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dep_id = "";
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[5];
                    if (cell.EditedFormattedValue.ToString().Equals("True"))
                    {
                        dep_id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }

                }
            }
            morePageSelectAns mo = new morePageSelectAns();
            mo.DepId = dep_id;
            mo.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[5];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    checkCell.Value = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
