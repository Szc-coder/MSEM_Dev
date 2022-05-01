using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MSEM_Dev.Uitls;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSEM_Dev.goble;
using MSEM_Dev;

namespace MSEM_Dev.page.EqFormChildred
{
    public partial class AddEq : Form
    {
        DataBase dataBase = new DataBase();

        public AddEq()
        {
            InitializeComponent();
        }

        public void init()
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

            supplier.DataSource = supllerName;
            supplier.ValueMember = "id";
            supplier.DisplayMember = "name";

            class_name.DataSource = className;
            class_name.ValueMember = "id";
            class_name.DisplayMember = "name";

            responsible_dp.DataSource = dpADataTable;
            responsible_dp.ValueMember = "dp_id";
            responsible_dp.DisplayMember = "name";
            
        }

        private void AddEq_Load(object sender, EventArgs e)
        {
            init();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                String Eq_name = eqname.Text;
                String SerialNamber = derial_namber.Text;
                DateTime PurchaseTime = purchase_time.Value;
                DateTime WarehousingTime = warehousing_time.Value;
                String Location = location.Text;
                String ResponsibleDp = responsible_dp.SelectedValue.ToString();
                Double DpPrice = System.Convert.ToDouble(price.Text);
                String Supplier = supplier.SelectedValue.ToString();
                String Class_name = class_name.SelectedValue.ToString();

                // TODO 添加重复与格式验证

                DataRow dr = EqForm.dataset.Tables[0].NewRow();
                dr[0] = MyGuid.GetGUID();
                dr[1] = Eq_name;
                dr[2] = SerialNamber;
                dr[3] = PurchaseTime;
                dr[4] = WarehousingTime;
                dr[5] = Location;
                dr[6] = ResponsibleDp;
                dr[7] = "正常";
                dr[8] = DpPrice;
                dr[9] = Supplier;
                dr[10] = Class_name;

                EqForm.dataset.Tables[0].Rows.Add(dr);
                EqForm.sdawitnScb.Update(EqForm.dataset);


                // String sql =
                //     $"insert into MEMS. [equipment] values('{MyGuid.GetGUID()}','{Eq_name}','{SerialNamber}','{PurchaseTime}','{WarehousingTime}','{Location}'" +
                //     $",'{ResponsibleDp}',1,'{DpPrice}','{Supplier}','{Class_name}')";
                //
                // dataBase.dosqlcom(sql);


                LOG log = new LOG();
                log.addLog(goble.Goble.Name,"添加设备","设备");

                MessageBox.Show("添加成功");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统异常!请联系管理员~");
            }
        }
    }
}
