using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2_6
{
    public partial class XemForm : Form
    {
        string strCon = @"Data Source=THIENPHUCLAPTOP;Initial Catalog=SINHVIEN26;Integrated Security=True";
        SqlConnection sqlCon = null;
        public XemForm()
        {
            InitializeComponent();
        }

        private void XemTatCaButton_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM SINHVIEN26";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                string MSSV = reader.GetString(0);
                string HoTen = reader.GetString(1);
                string GioiTinh = reader.GetString(2);
                string NgaySinh = reader.GetDateTime(3).ToString();


                ListViewItem lvi = new ListViewItem(MSSV);
                lvi.SubItems.Add(HoTen);
                lvi.SubItems.Add(GioiTinh);
                lvi.SubItems.Add(NgaySinh);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }

        private void TimTheoMSSVButton_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string MSSV_Query = MSSVTextBox.Text;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM SINHVIEN26 WHERE MSSV='" + MSSV_Query + "'";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            if (reader.Read())
            {
                string MSSV = reader.GetString(0);
                string HoTen = reader.GetString(1);
                string GioiTinh = reader.GetString(2);
                string NgaySinh = reader.GetDateTime(3).ToString();

                ListViewItem lvi = new ListViewItem(MSSV);
                lvi.SubItems.Add(HoTen);
                lvi.SubItems.Add(GioiTinh);
                lvi.SubItems.Add(NgaySinh);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
