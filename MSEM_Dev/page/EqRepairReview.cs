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
    public partial class EqRepairReview : Form
    {
        DataBase dataBase = new DataBase();

        public EqRepairReview()
        {
            InitializeComponent();
        }

        private void EqRepairReview_Load(object sender, EventArgs e)
        {
            string sql = $"select * from MEMS.repair";

            try
            {
                dataGridView1.DataSource = dataBase.getDs(sql, "repair").Tables["repair"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常");
            }
        }


    }
}
