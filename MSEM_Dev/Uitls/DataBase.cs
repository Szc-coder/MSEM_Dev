using System.Data;
using System.Data.SqlClient;

namespace MSEM_Dev.Uitls
{
    class DataBase
    {
        public static SqlConnection My_Conn;
        public static string openConnstr = @"Server=DESKTOP-Q0IJ4KU;Database=MEMS;User ID=sa;Password=qwe123580.00;";

        public static SqlConnection getcon()
        {
            My_Conn = new SqlConnection(openConnstr);
            My_Conn.Open();
            return My_Conn;
        }

        public void con_open()
        {
            getcon();
        }


        public void conn_close()
        {
            if (My_Conn.State == ConnectionState.Open)
            {
                My_Conn.Close();
                My_Conn.Dispose();
            }
        }

        public SqlDataReader getsdr(string sqlstr)
        {
            getcon();
            SqlCommand My_com = My_Conn.CreateCommand();
            My_com.CommandText = sqlstr;
            SqlDataReader My_Reader = My_com.ExecuteReader();
            return My_Reader;
        }

        public void dosqlcom(string sqlstr)
        {
            getcon();
            SqlCommand sqlcom = new SqlCommand(sqlstr, My_Conn);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            conn_close();
        }

        public DataSet getDs(string sqlstr, string tableName)
        {
            getcon();
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlstr, My_Conn);
            sqlda.Fill(dataSet, tableName);
            conn_close();
            return dataSet;
        }

        public DataTable getTable(string sqlstr,String[] rowName)
        {
            getcon();
            SqlDataAdapter dt = new SqlDataAdapter(sqlstr,My_Conn);
            DataTable dataTable = new DataTable();
            foreach(String name in rowName)
            {
                dataTable.Columns.Add(name);
            }
            
            dt.Fill(dataTable);
            conn_close();
            return dataTable;
        }

    }
}
