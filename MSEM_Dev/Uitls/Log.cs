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
    public class LOG
    {
        public void addLog(String name, String type, String target)
        {
            try
            {
                DateTime now = DateTime.Now;
                String sql = $"insert into MEMS.[log] values ({MyGuid.GetGUID()},{Goble.Name},{type},{now.ToString()},{target})";
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
