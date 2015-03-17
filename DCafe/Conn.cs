using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DCafe
{
    class Conn
    {
        public SqlConnection Cn;

        public SqlConnection openConn() 
        {
            string strCn = "Data Source=315QUANLM4W8\\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True";            
            Cn = new SqlConnection(strCn);
            if (Cn != null && Cn.State != ConnectionState.Open) 
            {
                Cn.Open();   
            }            
            return Cn;
        }

        public void closeConn()
        {
            if (Cn != null && Cn.State != ConnectionState.Closed)
            {
                Cn.Close();
            }            
        }
    }
}
