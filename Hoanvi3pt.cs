using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cautrucdulieu
{
    public partial class Hoanvi3pt : Form
    {
       
        public Hoanvi3pt()
        {
            InitializeComponent();
        }
        int[] b = new int[100];
        char[] X = new char[100];
        void Xuat_x()
        {
            for (int k = 1; k <= 3; k++)
            {
                txtketqua.Text += X[k];
            }
            txtketqua.Text += "\t";
        }
        void Try(int i)
        {
            for (char j = 'A'; j <= 'C'; j++)
            {
                if (b[j] == 0)
                {
                    X[i] = j;
                    b[j] = 1;
                    if (i < 3)
                        Try(i + 1);
                    else
                        Xuat_x();
                    b[j] = 0;
                }
            }
        }
        private void Hoanvi_3pt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 100; j++)
                b[j] = 0;
            Try(1);
        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
