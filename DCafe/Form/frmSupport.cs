﻿using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DCafe
{
    public partial class frmSupport : Form
    {
        public SqlConnection sqlCon;
        public frmSupport()
        {
            InitializeComponent();
            //Load_Khuvuc("");
        }

        private void Load_Khuvuc(string where)
        {
            string mk = "SELECT ma_kv, RTRIM(ten_kv) AS ten_kv FROM T_Khuvuc";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsKhuvuc.DataSource = dt;
            sqlCon.Close();
        }

        private void Save_Khuvuc()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (checkExistKhuvuc(txtMa_kv.Text))
            {
                //Edit
                cmd.CommandText = "UPDATE T_Khuvuc SET ten_kv = @ten_kv WHERE ma_kv = @ma_kv";
                cmd.Parameters.AddWithValue("@ten_kv", txtTen_kv.Text);
                cmd.Parameters.AddWithValue("@ma_kv", txtMa_kv.Text);               
                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Khuvuc (ma_kv, ten_kv) VALUES (@ma_kv, @ten_kv)";
                cmd.Parameters.AddWithValue("@ten_kv", txtTen_kv.Text);
                cmd.Parameters.AddWithValue("@ma_kv", txtMa_kv.Text);
                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
        }

        public bool checkExistKhuvuc(string ma_kv)
        {
            string sql = "SELECT ma_kv FROM T_Khuvuc WHERE (ma_kv =@ma_kv)";
            bool isExist = false;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_kv", ma_kv);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isExist = true;
            }
            dr.Close();
            return isExist;
        }
        public void Delete_Khuvuc()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            cmd.CommandText = "DELETE T_Khuvuc WHERE (ma_kv =@ma_kv)";
            cmd.Parameters.AddWithValue("@ma_kv", txtMa_kv.Text);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void btn_them_Click(object sender, System.EventArgs e)
        {
            Save_Khuvuc();
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            Delete_Khuvuc();
        }

        private void grdDsKhuvuc_SelectionChanged(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in grdDsKhuvuc.SelectedRows)
            {
                txtTen_kv.Text = row.Cells[0].Value.ToString();
                txtMa_kv.Text = row.Cells[1].Value.ToString();              
            }
        }

        private void Load_DSBan(string where)
        {
            string mk = "SELECT maban, RTRIM(tenban) AS tenban, T_Ban.ma_kv, ten_kv FROM T_Ban, T_Khuvuc WHERE T_Ban.ma_kv=T_Khuvuc.ma_kv";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            grdDsBan.DataSource = dt;
            sqlCon.Close();
        }

        private void Load_CBKhuvuc(string where)
        {
            string mk = "SELECT ma_kv, RTRIM(ten_kv) AS ten_kv FROM T_Khuvuc";
            SqlDataAdapter ada = new SqlDataAdapter(mk, sqlCon);
            sqlCon.Open();
            DataTable dt = new DataTable();
            ada.Fill(dt);

            cbKhuvuc.DataSource = dt;
            cbKhuvuc.DisplayMember = "ten_kv";
            cbKhuvuc.ValueMember = "ma_kv";
            sqlCon.Close();
        }

        private void Save_Ban()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            if (checkExistBan(txtMaban.Text))
            {
                //Edit
                cmd.CommandText = "UPDATE T_Ban SET ten_ban = @ten_ban, ma_kv = @ma_kv WHERE ma_ban = @ma_ban";
                cmd.Parameters.AddWithValue("@ten_ban", txtTenban.Text);
                cmd.Parameters.AddWithValue("@ma_kv", cbKhuvuc.SelectedValue);
                cmd.Parameters.AddWithValue("@ma_ban", txtMaban.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                //Add
                cmd.CommandText = "INSERT INTO T_Ban (ma_ban, ten_ban, ma_kv) VALUES (@ma_ban, @ten_ban, @ma_kv)";
                cmd.Parameters.AddWithValue("@ten_ban", txtTenban.Text);
                cmd.Parameters.AddWithValue("@ma_kv", cbKhuvuc.SelectedValue);
                cmd.Parameters.AddWithValue("@ma_ban", txtMaban.Text);
                cmd.ExecuteNonQuery();
            }
            sqlCon.Close();
        }

        public bool checkExistBan(string ma_ban)
        {
            string sql = "SELECT ma_ban FROM T_Ban WHERE (ma_ban =@ma_ban)";
            bool isExist = false;
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.AddWithValue("ma_ban", ma_ban);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                isExist = true;
            }
            dr.Close();
            return isExist;
        }

        public void Delete_Ban()
        {
            SqlCommand cmd = sqlCon.CreateCommand();
            sqlCon.Open();
            cmd.CommandText = "DELETE T_Ban WHERE (ma_ban =@ma_ban)";
            cmd.Parameters.AddWithValue("@ma_ban", txtMaban.Text);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void grdDsBan_SelectionChanged(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in grdDsKhuvuc.SelectedRows)
            {
                txtMaban.Text = row.Cells[0].Value.ToString();
                txtTenban.Text = row.Cells[1].Value.ToString();
                cbKhuvuc.SelectedValue = row.Cells[2].Value.ToString();  
            }
        }

        private void btnThemban_Click(object sender, System.EventArgs e)
        {
            Save_Ban();
        }

        private void btnXoaban_Click(object sender, System.EventArgs e)
        {
            Delete_Ban();
        }



        

    }
}
