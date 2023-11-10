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
    public partial class XoaForm : Form
    {
        string strCon = @"Data Source=THIENPHUCLAPTOP;Initial Catalog=SINHVIEN26;Integrated Security=True";
        SqlConnection sqlCon = null;
        public XoaForm()
        {
            InitializeComponent();
        }

        private void XoaButton_Click(object sender, EventArgs e)
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

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM SINHVIEN26 WHERE MSSV='" + MSSV + "'";

            sqlCmd.Connection = sqlCon;
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
                MessageBox.Show("Xoa thanh cong!");
            else
                MessageBox.Show("Xoa that bai!");
        }
    }
}
