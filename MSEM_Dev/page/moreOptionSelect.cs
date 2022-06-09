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
    public partial class moreOptionSelect : Form
    {
        DataBase dataBase = new DataBase();
        public moreOptionSelect()
        {
            InitializeComponent();
        }

        void init()
        {
            string sql = "select * from MEMS.[user]";
            dataGridView1.DataSource = dataBase.getDs(sql, "users").Tables["users"];
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[8].EditedFormattedValue.ToString() == "True")
                    {
                        list.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    }
                }
            }
            moreOptionSelectAns mo = new moreOptionSelectAns();
            mo.list = list;
            mo.ShowDialog();
        }

        private void moreOptionSelect_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
