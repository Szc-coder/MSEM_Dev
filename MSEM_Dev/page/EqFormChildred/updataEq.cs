using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSEM_Dev.Uitls;

namespace MSEM_Dev.page.EqFormChildred
{
    public partial class updataEq : Form
    {
        DataBase dataBase = new DataBase();

        public String id { get; set; }


        public updataEq()
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

            DataRow selectRow = EqForm.dataset.Tables[0].Select($"id = {id}")[0];
            eqname.Text = selectRow[1].ToString();
            derial_namber.Text = selectRow[2].ToString();
            purchase_time.Value = (DateTime)selectRow[3];
            warehousing_time.Value = (DateTime)selectRow[4];
            location.Text = selectRow[5].ToString();
            price.Text = selectRow[7].ToString();

        }


        private void updataEq_Load(object sender, EventArgs e)
        {
            init();
        }

        private void insert_Click(object sender, EventArgs e)
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
            String state = states.SelectedValue.ToString();

            // TODO 添加重复与格式验证

            DataRow dr = EqForm.dataset.Tables[0].Select($"id = {id}")[0];
            dr[1] = Eq_name;
            dr[2] = SerialNamber;
            dr[3] = PurchaseTime;
            dr[4] = WarehousingTime;
            dr[5] = Location;
            dr[6] = ResponsibleDp;
            dr[7] = state;
            dr[8] = DpPrice;
            dr[9] = Supplier;
            dr[10] = Class_name;

            EqForm.sdawitnScb.Update(EqForm.dataset);

        }
    }
}
