using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MSEM_Dev.Uitls;

namespace MSEM_Dev.goble
{
    public static class RoleAndDp
    {
        public static Dictionary<string, string> dps { get; set; }
        public static Dictionary<int, string> roles { get; set; }

        public static void initRoleAndDP()
        {
            DataBase data = new DataBase();

            dps = new Dictionary<string, string>();
            roles = new Dictionary<int, string>();

            string dpsSql = "select * from MEMS.[department]";
            string roleSql = "select * from MEMS.[role_class]";

            SqlDataReader dpsDR = data.getsdr(dpsSql);
            SqlDataReader rolesDR = data.getsdr(roleSql);

            while(dpsDR.Read())
            {
                dps.Add(dpsDR[0].ToString(), dpsDR[1].ToString());
            }

            while(rolesDR.Read())
            {
                roles.Add(rolesDR.GetInt32(0), rolesDR[1].ToString());
            }
        }
    }
}
