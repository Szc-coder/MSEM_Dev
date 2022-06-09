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
    public partial class moreOptionSelectAns : Form
    {
        public List<String> list { get; set; }
        DataBase dataBase = new DataBase();

        public moreOptionSelectAns()
        {
            InitializeComponent();
        }

        private void moreOptionSelectAns_Load(object sender, EventArgs e)
        {
            string ids = "(";
            for (int i = 0; i < list.Count; i++)
            {
                ids +="'" + list[i].ToString() + "'";
                if (i != list.Count - 1)
                {
                    ids += ",";
                }
                else
                {
                    ids += ")";
                }
            }
            string sql = $"select * from MEMS.equipment where respon_user_id in {ids}";
            dataGridView1.DataSource = dataBase.getDs(sql, "ans").Tables["ans"];
        }
    }
}
