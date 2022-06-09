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
    public partial class morePageSelectAns : Form
    {
        private DataBase dataBase = new DataBase();
        public String DepId { get; set; }

        public morePageSelectAns()
        {
            InitializeComponent();
        }

        private void morePageSelectAns_Load(object sender, EventArgs e)
        {
            string sql = $"Select * from MEMS.[user] where department = '{DepId}'";
            dataGridView1.DataSource = dataBase.getDs(sql, "users").Tables["users"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
