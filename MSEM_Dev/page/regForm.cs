using System.Data;
using MSEM_Dev.Uitls;
using System.Data.SqlClient;

namespace MSEM_Dev.page
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        
        public DataSet dataset;

        private void regForm_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            string sql = "select * from MEMS.[department]";
            dataset = dataBase.getDs(sql, "department");
            foreach(DataRow Dr in dataset.Tables[0].Rows)
            {
                DP.Items.Add(Dr[1]);
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            string valied = $"select * from MEMS.[user] where phone = '{Phone.Text}'";
            SqlDataReader dataReder = dataBase.getsdr(valied);
            dataReder.Read();
            if(dataReder.HasRows)
            {
                MessageBox.Show("该手机号已存在，请重新输入");
                return;
            }

            if (!Valied.isPhone(Phone.Text)||Pwd.Text!=Pwd2.Text||!Valied.isTrueLen(Pwd.Text,7,21)||!Valied.isTrueLen(name.Text,0,10)||!Valied.isTrueNum(Convert.ToInt32(age.Text),17,120))
            {
                MessageBox.Show("个人信息错误！请重新输入");
                return;
            }

            DataTable dt = dataset.Tables[0];
            var dpId = from dp in dt.AsEnumerable() where dp.Field<string>("name")== DP.Text select dp[0];
            string ansDpId = "";
            dpId.ToList().ForEach(dp => { ansDpId = dp.ToString(); });
            string guid = MyGuid.GetGUID();
            string md5Pwd = Valied.md5Hash(Pwd.Text);
            string sql = string.Format($"insert into MEMS.[user] values('{guid}','{md5Pwd}','{name.Text}','{Phone.Text}','{sex.Text}','{age.Text}','{2}','{ansDpId}')");
            dataBase.dosqlcom(sql);

            

            MessageBox.Show("注册成功，默认权限为科室设备管理员，若非科室设备管理员请联系科室主任或院长办公室进行更改权限");
            this.Close();
            
        }
    }
}
