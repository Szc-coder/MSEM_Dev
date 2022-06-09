using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSEM_Dev.goble;
using MSEM_Dev.Uitls;

namespace MSEM_Dev.page
{
    public partial class EqWhForm : Form
    {
        private DataBase dataBase = new DataBase();

        public EqWhForm()
        {
            InitializeComponent();
        }

        private void init()
        {

            String selectSup = "select id,name from MEMS.[supplier]";
            String selectCla = "select id,name from MEMS.[class]";
            String SelectDp = "select dp_id,name from MEMS.[department]";



            String[] classIdAndNameList = { "id", "name" };
            String[] supllersIdAndNameList = { "id", "name" };
            String[] dpIdAndNameList = { "dp_id", "name" };

            DataTable dpADataTable = dataBase.getTable(SelectDp, dpIdAndNameList);
            DataTable className = dataBase.getTable(selectCla, classIdAndNameList);
            DataTable supllerName = dataBase.getTable(selectSup, supllersIdAndNameList);

            supllierBox.DataSource = supllerName;
            supllierBox.ValueMember = "id";
            supllierBox.DisplayMember = "name";

            claBox.DataSource = className;
            claBox.ValueMember = "id";
            claBox.DisplayMember = "name";

            DpComBox.DataSource = dpADataTable;
            DpComBox.ValueMember = "dp_id";
            DpComBox.DisplayMember = "name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(EqNameBox.Text.Equals("") || numCob.Text.Equals("") || locationBox.Text.Equals("")||serBox.Text.Equals(""))
            {
                MessageBox.Show("设备信息不能为空");
                return;
            }

            String ID = MyGuid.GetGUID();
            string insertWhSql = $"insert into MEMS.warehousing values('{ID}'," +
                                 $"'{DpComBox.SelectedValue.ToString()}','{goble.Goble.userId}'," +
                                 $"'{buyTimeBox.Value.ToString()}','{WhTimeBox.Value.ToString()}'," +
                                 $"'{locationBox.Text}','{EqNameBox.Text}',{Convert.ToInt32(numCob.Text)}," +
                                 $"'{supllierBox.SelectedValue.ToString()}')";

            try
            {
                // dataBase.dosqlcom(insertEqSql);
                dataBase.dosqlcom(insertWhSql);

                LOG log = new LOG();
                log.addLog("添加入库记录","insert",$"Wh_id:{ID}");
                // log.addLog("添加设备","insert",$"eqId:{eqid}");

                int num = Convert.ToInt16(numCob.Text);

                for (int i = 0; i < num; i++)
                {
                    string eqid = MyGuid.GetGUID();
                    string insertEqSql = $"insert into MEMS.equipment values('{eqid}','{EqNameBox.Text}'," +
                                         $"'{serBox.Text}','{buyTimeBox.Value.ToString()}','{WhTimeBox.Value.ToString()}'," +
                                         $"'{locationBox.Text}','{DpComBox.SelectedValue.ToString()}','已入库'," +
                                         $"{Convert.ToInt32(onePriBox.Text)},'{supllierBox.SelectedValue}','{claBox.SelectedValue}')";
                    dataBase.dosqlcom(insertEqSql);
                    log.addLog("添加设备", "insert", $"eqId:{eqid}");
                }
                MessageBox.Show("添加成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常，请联系管理员!");
            }

        }

        private void EqWhForm_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
