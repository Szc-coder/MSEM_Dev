using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MSEM_Dev.goble;
using MSEM_Dev.Uitls;
using MSEM_Dev.page.EqFormChildred;



namespace MSEM_Dev.page
{
    public partial class EqForm : Form
    {
        DataBase data = new DataBase();


        public EqForm()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            string sql = "";
            EqDataGridView.Rows.Clear();
            if (Goble.Role_name == "admin")
            {
                sql = $"select * from MEMS.[equipment]";
            }
            else
            {
                sql = $"select * from MEMS.[equipment] where responsible_dp = '{Goble.Dp}'";
            }
            SqlDataReader datareader = data.getsdr(sql);



            while (datareader.Read())
            {
                EqDataGridView.Rows.Add(datareader[0].ToString(), datareader[1].ToString(), datareader[2].ToString(), datareader[3].ToString(),
                                        datareader[4].ToString(), datareader[5].ToString(), datareader[6].ToString(), datareader[7].ToString(),
                                        datareader[8].ToString(), datareader[9].ToString(), datareader[10].ToString());
            }
            datareader.Close();

        }

        private void EqForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Reflash_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void AddEq_Click(object sender, EventArgs e)
        {
            AddEq addEq = new AddEq();
            addEq.Show();
        }
    }
}
