using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(Width);
            int y = random.Next(Height);
            using (Graphics g = CreateGraphics())
            {
                g.DrawString("Paint Event", Font, Brushes.Black, x, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Graphics g = CreateGraphics()) 
            {
                SolidBrush brush = new SolidBrush(SystemColors.Control);
                g.FillRectangle(brush, ClientRectangle);
            }
        }
    }
}
