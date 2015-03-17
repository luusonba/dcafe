using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string str = " ";
        

        public static string ToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;

            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str = str + "đồng chẵn";

        }

        void load_mkh() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select rtrim(MA_KH) from KHACH_HANG";
            
            MKH.Items.Clear();
            MKH.Items.Add("");
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                MKH.Items.Add(b1.Rows[i][0].ToString());
            }
            MKH.Text = b1.Rows[0][0].ToString();
            MKH.Text = "";
            
            con1.Close();
        }
        void load_mhh()
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select rtrim(MA_HH),rtrim(ma_vach) from HANGHOA";
            //MHH.Text = "";
            MHH.Items.Clear();
            mv.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            
            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                MHH.Items.Add(b1.Rows[i][0].ToString());
                mv.Items.Add(b1.Rows[i][1].ToString());
            }

            //MHH.Text=b1.Rows[0][0].ToString();

            con1.Close();
        }
        /*void load_mhh(string a)
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select MA_HH from HANGHOA ma_hh like('%"+a+"%')";
            MHH.Text = "";
            MHH.Items.Clear();
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();

            dl.Fill(b1);
            for (int i = 0; i < b1.Rows.Count; i++)
            {
                MHH.Items.Add(b1.Rows[i][0].ToString());
            }

            MKH.Items.Add("");

            con1.Close();
        }*/
        
        string stt_xuat(){
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string str1 = "select  convert(varchar, getdate(), 12),count(STT_hd)+1 from hoadon where LEFT(STT_hd,6)=convert(varchar, getdate(), 12)";
                SqlDataAdapter dl = new SqlDataAdapter(str1, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);
                string str = b1.Rows[0][0].ToString();
                string a = b1.Rows[0][1].ToString();
                if (a.Length == 1) str = str + "00" + a;
                if (a.Length == 2) str = str + "0" + a;
                if (a.Length == 3) str = str + a;
                con1.Close();
                return str;
            }
            catch{
                return "0";
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            //them_ban();
            load_data();
            load_mkh();
            load_mhh();
            
            MPX.Text=stt_xuat();
            load_tong();
            nv.Text = "NV001";
            
            
        }

        private void MKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MKH.Text == "") TKH.Text = "";
                else
                {
                    conn con = new conn();
                    SqlConnection con1 = con.con();
                    string str = "select MA_KH,TEN_KH from KHACH_HANG where MA_KH like('" + MKH.Text + "')";
                    con1.Open();
                    SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                    DataTable b1 = new DataTable();
                    dl.Fill(b1);

                    TKH.Text = b1.Rows[0][1].ToString();


                    con1.Close();
                }
            }
            catch{
            
            }
        }
        void load() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select TEN_HH,giamoi,THUE,ma_vach from HANGHOA,luocsu_gia where HANGHOA.MA_HH like('%"+MHH.Text+"%') AND HANGHOA.MA_HH=LUOCSU_GIA.MA_HH and NGAYTHAYDOI=(select MAX(NGAYTHAYDOI) from LUOCSU_GIA where MA_HH like('%"+MHH.Text+"%'))";
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1);
            
            THH.Text = b1.Rows[0][0].ToString();
            gia.Text = b1.Rows[0][1].ToString();
            thue.Text = b1.Rows[0][2].ToString();
            mv.Text = b1.Rows[0][3].ToString();
            con1.Close();
        }  
        
        void load_data()
        {
            try
            {
                int a;
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string str = "select BAN.MA_HH,TEN_HH,BAN.SL_BAN,GIAMOI,THUE,convert(int,BAN.SL_BAN*GIAMOI*(100+THUE)/100) from ban,hanghoa,LUOCSU_GIA where hanghoa.ma_hh=ban.ma_hh and ban.STT_HD ='" + MPX.Text + "' and  BAN.MA_HH=LUOCSU_GIA.MA_HH AND NGAYTHAYDOI in (SELECT MAX(NGAYTHAYDOI) FROM LUOCSU_GIA,BAN where LUOCSU_GIA.MA_HH=ban.MA_HH and ban.STT_HD='" + MPX.Text + "' group by ban.MA_HH )";
                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataTable table = new DataTable();
                table.Columns.Add("STT", typeof(object));
                table.Columns.Add("Mã hàng", typeof(object));
                table.Columns.Add("Tên hàng", typeof(object));
                table.Columns.Add("Số lượng", typeof(object));
                table.Columns.Add("Đơn giá", typeof(object));
                table.Columns.Add("Thuế", typeof(object));
                table.Columns.Add("Thành tiền", typeof(object));
                for (a = 0; a < dt.Rows.Count; a++)
                {
                    table.Rows.Add(a + 1, dt.Rows[a][0], dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][3], dt.Rows[a][4], con.cachso(dt.Rows[a][5].ToString()));
                }
                DATA.DataSource = table;
                /*DATA.Columns[0].HeaderText = "Mã hàng";
                DATA.Columns[1].HeaderText = "Tên hàng";
                DATA.Columns[2].HeaderText = "Số lượng";
                DATA.Columns[3].HeaderText = "Đơn giá";
                DATA.Columns[4].HeaderText = "Thuế";
                DATA.Columns[5].HeaderText = "Thành tiền";*/
                con1.Close();
            }
            catch { }
        }
        
        void them_ban() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            string str1 = "select COUNT(*) from ban where STT_hd='" + MPX.Text + "' and ma_hh='" + MHH.Text + "'";
            string str = "insert into ban values('" + MHH.Text + "','" + MPX.Text + "'," + sl.Text + "," + gia.Text + ")";
            string str2 = "update ban set sl_ban=sl_ban+" + sl.Text + " where ma_hh='" + MHH.Text + "' and stt_hd='" + MPX.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str1, con1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            int a = Convert.ToInt32(dt.Rows[0][0].ToString());
            if (a == 0)
            {
                

                SqlCommand c1 = new SqlCommand(str, con1); c1.ExecuteNonQuery();
                kho kh = new kho();

                kh.giam(MHH.Text, Convert.ToInt32(sl.Text));
            }
            else
            {
                

                SqlCommand c1 = new SqlCommand(str2, con1); c1.ExecuteNonQuery();
                kho kh = new kho();

                kh.giam(MHH.Text, Convert.ToInt32(sl.Text));
            }
            con1.Close();
        }
        void them_hd() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                kho k = new kho();
                if (k.ton(MHH.Text, Convert.ToInt32(sl.Text)))
                {
                    string str2 = "";
                    string str1 = "select COUNT(stt_hd) from HOADON where STT_hd='" + MPX.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(str1, con1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //DATA.DataSource = dt;
                    str2 = "insert into hoadon values('" + MPX.Text + "','" + nv.Text + "',getdate())";
                    int a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    if (a == 0)
                    {


                        //sl.Text = str2;
                        SqlCommand c1 = new SqlCommand(str2, con1); c1.ExecuteNonQuery();
                        them_cua();
                        them_ban();

                    }
                    //sl.Text = str2;
                    else them_ban();
                }
                else
                {
                    MessageBox.Show("Hết hàng hoặc số lượng tồn kho ít hơn số lượng bán!", "Thông báo");
                }
                con1.Close();
                load_data();
            }
            catch { }
        }
        void them_cua()
        {
            try
            {
                if (MKH.Text != "")
                {
                    conn con = new conn();
                    SqlConnection con1 = con.con();
                    con1.Open();


                    string str2 = "insert into cua values('" + MKH.Text + "','" + MPX.Text + "')";
                    SqlCommand c1 = new SqlCommand(str2, con1); c1.ExecuteNonQuery();
                    //sl.Text = str2;
                    con1.Close();
                }
            }
            catch { }
        }
        string cat_tong(string a) {
            string b="";
            int c;

            for (c = 0; c < a.Length; c++) {
                if (Convert.ToString(a[c]) == ",") break;
                b = b + a[c];
            }
            /*c = b.Length;
            int d=c;
            string e="";
            for (; d > 2;) {
                e =" "+ b[d - 3] + b[d - 2] + b[d - 1] + e;
                d = d - 3;
            }
            if (d == 2) e = b[0] + b[1] + e;
            if (d == 1) e = b[0] + e;*/
            return b;

        }
        public string chuyen()
        {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
            string so;

            string str1 = "select COUNT(*) from ban where STT_hd='" + MPX.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int a = Convert.ToInt32(dt1.Rows[0][0].ToString());
            if (a > 0)
            {
                string str = "select convert(int,sum(BAN.SL_BAN*GIAMOI*(100+THUE)/100)) from ban,hanghoa,LUOCSU_GIA where hanghoa.ma_hh=ban.ma_hh and ban.STT_HD ='" + MPX.Text + "' and  BAN.MA_HH=LUOCSU_GIA.MA_HH AND NGAYTHAYDOI in (SELECT MAX(NGAYTHAYDOI) FROM LUOCSU_GIA,BAN where LUOCSU_GIA.MA_HH=ban.MA_HH and ban.STT_HD='" + MPX.Text + "' group by ban.MA_HH )";


                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                so = dt.Rows[0][0].ToString();
                
            }
            else so = "0";
            con1.Close();
            return so;

        }
        void load_tong() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            con1.Open();
           
            string str1 = "select COUNT(*) from ban where STT_hd='"+MPX.Text+"'";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int a = Convert.ToInt32(dt1.Rows[0][0].ToString());
            if (a > 0)
            {
                string str = "select convert(int,sum(BAN.SL_BAN*GIAMOI*(100+THUE)/100)) from ban,hanghoa,LUOCSU_GIA where hanghoa.ma_hh=ban.ma_hh and ban.STT_HD ='" + MPX.Text + "' and  BAN.MA_HH=LUOCSU_GIA.MA_HH AND NGAYTHAYDOI in (SELECT MAX(NGAYTHAYDOI) FROM LUOCSU_GIA,BAN where LUOCSU_GIA.MA_HH=ban.MA_HH and ban.STT_HD='" + MPX.Text + "' group by ban.MA_HH )";

                
                SqlDataAdapter da = new SqlDataAdapter(str, con1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tong.Text = con.cachso(dt.Rows[0][0].ToString());
                
            }
            else tong.Text = "0";
            con1.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            class1.stt_px = MPX.Text;
            
            them_hd();
           
            string chu1 = chuyen();
            string tmp;
            decimal i = Convert.ToDecimal(chu1);
            tmp = ToString(i);
            chu.Text = tmp;
            
            load_tong();
            set();
        }
        void set(){
            MHH.Text = "";
            THH.Text = "";
            gia.Text = "";
            sl.Text = "";
            thue.Text = "";
            mv.Text="";
        }
        void xoa_ban() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                con1.Open();
                string str = "delete from BAN where STT_hd='" + MPX.Text + "' AND MA_HH='" + MHH.Text + "' ";
                //sl.Text = str;
                SqlCommand c1 = new SqlCommand(str, con1); c1.ExecuteNonQuery();
                kho kh = new kho();
                kh.tang(MHH.Text, Convert.ToInt32(sl.Text));
                con1.Close();
            }
            catch { }
        }

        void xoa_hd() {
            conn con = new conn();
            SqlConnection con1 = con.con();
            string str = "select COUNT(*) from BAN where STT_hd='"+MPX.Text+"' ";
            con1.Open();
            SqlDataAdapter dl = new SqlDataAdapter(str, con1);
            DataTable b1 = new DataTable();
            dl.Fill(b1); 
            if (b1.Rows.Count == 1)
            {   
                xoa_ban();
                xoa_cua();
                string str1 = "delete from hoadon where STT_hd='" + MPX.Text + "' ";
                SqlCommand c1 = new SqlCommand(str1, con1); c1.ExecuteNonQuery();
                
            }
            //else xoa_ban();
            //con1.Open();
            
            con1.Close();
            //set();
        }
        void xoa_cua() {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con(); con1.Open();
                string str = "delete from cua where STT_hd='" + MPX.Text + "'";
                //sl.Text = str;
                SqlCommand c1 = new SqlCommand(str, con1); c1.ExecuteNonQuery();

                con1.Close();
            }
            catch { }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            xoa_hd();
            load_data();
            load_tong();
            set();
        }

        void lay_dl() {
            MHH.Text = DATA.CurrentRow.Cells[1].Value.ToString();
            THH.Text = DATA.CurrentRow.Cells[2].Value.ToString();
            sl.Text = DATA.CurrentRow.Cells[3].Value.ToString();
            gia.Text = DATA.CurrentRow.Cells[4].Value.ToString();
            thue.Text = DATA.CurrentRow.Cells[5].Value.ToString();
            //tong.Text = DATA.CurrentRow.Cells[5].Value.ToString(); 
            load();

        }

        private void DATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lay_dl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void tab() { 
            //if(th)
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Escape):
                    button4_Click(null, null);
                    break;
                case (Keys.Delete):
                    button5_Click(null, null);
                    break;
                case (Keys.Enter):
                    button3_Click_1(null, null);
                    break;
                case (Keys.F2):
                    button6_Click(null, null);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPX fpx = new FormPX();
            fpx.ShowDialog();

        }

        private void MHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select TEN_HH,giamoi,THUE,ma_vach from HANGHOA,luocsu_gia where HANGHOA.MA_HH like('%" + MHH.Text + "%') AND HANGHOA.MA_HH=LUOCSU_GIA.MA_HH and NGAYTHAYDOI=(select MAX(NGAYTHAYDOI) from LUOCSU_GIA where MA_HH like('%" + MHH.Text + "%'))";
                con1.Open();
                SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);

                THH.Text = b1.Rows[0][0].ToString();
                gia.Text = b1.Rows[0][1].ToString();
                thue.Text = b1.Rows[0][2].ToString();
                mv.Text = b1.Rows[0][3].ToString();
                con1.Close();
            }
            catch { }
        }
        void load_vach(string a){
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select TEN_HH,giamoi,THUE from HANGHOA,luocsu_gia where HANGHOA.MA_HH like('"+a+"%') AND HANGHOA.MA_HH=LUOCSU_GIA.MA_HH and NGAYTHAYDOI=(select MAX(NGAYTHAYDOI) from LUOCSU_GIA where MA_HH='"+a+"')";
                con1.Open();
                SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);

                THH.Text = b1.Rows[0][0].ToString();
                gia.Text = b1.Rows[0][1].ToString();
                thue.Text = b1.Rows[0][2].ToString();
                //mv.Text = b1.Rows[0][3].ToString();
                con1.Close();
                //sl.Text = str;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void MHH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select TEN_HH,giamoi,THUE,ma_vach from HANGHOA,luocsu_gia where HANGHOA.MA_HH like('%" + MHH.Text + "%') AND HANGHOA.MA_HH=LUOCSU_GIA.MA_HH and NGAYTHAYDOI=(select MAX(NGAYTHAYDOI) from LUOCSU_GIA where MA_HH like('%" + MHH.Text + "%'))";
                con1.Open();
                SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);

                THH.Text = b1.Rows[0][0].ToString();
                gia.Text = b1.Rows[0][1].ToString();
                thue.Text = b1.Rows[0][2].ToString();
                mv.Text = b1.Rows[0][3].ToString();
                con1.Close();
            }
            catch { }
        }

        private void mv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn con = new conn();
                SqlConnection con1 = con.con();
                string str = "select ma_hh from HANGHOA where HANGHOA.ma_vach='"+mv.Text+"'";
                con1.Open();
                SqlDataAdapter dl = new SqlDataAdapter(str, con1);
                DataTable b1 = new DataTable();
                dl.Fill(b1);
                MHH.Text = b1.Rows[0][0].ToString();
                load_vach(MHH.Text);
                tong.Text="qwe";
                con1.Close();
            }
            catch { }
        }
        

        

      

        
    }
}
