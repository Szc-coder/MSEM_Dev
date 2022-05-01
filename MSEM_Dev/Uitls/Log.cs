using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MSEM_Dev.goble;

namespace MSEM_Dev.Uitls
{
    // 封装LOG类，添加log的时候只需要使用addlog方法
    public class LOG
    {
        public void addLog(String name, String type, String target)
        {
            try
            {
                DateTime now = DateTime.Now;
                String sql = $"insert into MEMS.[log] values ('{Goble.Name}','{type}','{now.ToString()}','{target}')";
                DataBase data = new DataBase();
                data.dosqlcom(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
