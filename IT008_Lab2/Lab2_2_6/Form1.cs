using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lab2_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void XemButton_Click(object sender, EventArgs e)
        {
            XemForm xemform = new XemForm();
            xemform.Show();
        }
        private void ThemSuaButton_Click(object sender, EventArgs e)
        {
            ThemSuaForm themsuaform = new ThemSuaForm();
            themsuaform.Show();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            XoaForm xoaform = new XoaForm();
            xoaform.Show();
        }
    }
}