using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TTTT
{
    class kho
    {
        public void tang(string mh,int s) {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            string str = "update hanghoa set SL_TK=SL_TK+"+s+" where ma_hh='"+mh+"'";
            SqlCommand c1 = new SqlCommand(str,con1);
            c1.ExecuteNonQuery();
        }
        public void giam(string mh, int s)
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            string str = "update hanghoa set SL_TK=SL_TK-" + s + " where ma_hh='" + mh + "'";
            SqlCommand c1 = new SqlCommand(str, con1);
            c1.ExecuteNonQuery();
        }
        public bool ton(string mh,int sl){
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            string str3 = "select SL_TK from hanghoa where MA_HH='"+mh+"'";
            SqlDataAdapter da1 = new SqlDataAdapter(str3, con1);
            DataTable dt = new DataTable();
            da1.Fill(dt);con1.Close();
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) >= sl) return true;
            else return false;
            
               
        }
    }
}
