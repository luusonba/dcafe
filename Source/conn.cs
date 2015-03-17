using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TTTT
{
    class conn
    {
        public SqlConnection con() {
            string str = "server=linhngu-pc;database=vd;uid=linh;pwd=linh";
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }
        public string cachso(string f)
        {
            string d = "", e = "";
            int i;
            for (i = 0; i < f.Length; i++)
            {
                d = Convert.ToString(f[i]) + d;
            }
            for (i = 0; i < d.Length; i++)
            {
                e = Convert.ToString(d[i]) + e;
                if ((i + 1) % 3 == 0 && (i+1)!=d.Length) e = "," + e;
            }
            return e;
        }
    }
    public class class1
    {
        public static string stt_px;
        public static string stt_pn;
    }
}
