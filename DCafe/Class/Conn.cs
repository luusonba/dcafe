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
			// USER-4FE94ECC99\SQLEXPRESS
            string strCn = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True";            
            Cn = new SqlConnection(strCn);                        
            return Cn;
        }
    }
}
