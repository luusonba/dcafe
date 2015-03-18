using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DCafe
{
    public class Conn
    {
        public SqlConnection Cn;

        public SqlConnection createConn() 
        {
            string strCn = "Data Source=USER-4FE94ECC99\\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True";            
            Cn = new SqlConnection(strCn);                        
            return Cn;
        }
    }
}
