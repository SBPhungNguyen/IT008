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
    public partial class ThemSuaForm : Form
    {
        string strCon = @"Data Source=THIENPHUCLAPTOP;Initial Catalog=SINHVIEN26;Integrated Security=True";
        SqlConnection sqlCon = null;
        public ThemSuaForm()
        {
            InitializeComponent();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string MSSV = MSSVTextBox.Text;
            string HoTen = HoTenTextBox.Text;
            string GioiTinh = GioiTinhTextBox.Text;
            string NgaySinh = NgaySinhTextBox.Text;

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO SINHVIEN26 VALUES('" + MSSV + "', '" + HoTen + "', '" + GioiTinh + "', '" + NgaySinh + "')";

            sqlCmd.Connection = sqlCon;
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
                MessageBox.Show("Them thanh cong!");
            else
                MessageBox.Show("Them that bai!");
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string MSSV = MSSVTextBox.Text;
            string HoTen = HoTenTextBox.Text;
            string GioiTinh = GioiTinhTextBox.Text;
            string NgaySinh = NgaySinhTextBox.Text;

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE SINHVIEN26 SET HOTEN='" + HoTen + "', GIOITINH='" + GioiTinh + "', NGAYSINH='" + NgaySinh + "' WHERE MSSV='" + MSSV + "'";

            sqlCmd.Connection = sqlCon;
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
                MessageBox.Show("Sua thanh cong!");
            else
                MessageBox.Show("Sua that bai!");
        }
    }
}
