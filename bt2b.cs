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
    public partial class bt2b : Form
    {
        public bt2b()
        {
            InitializeComponent();
        }
        int[] b = new int[100];
        char [] X = new char [100];

        void Xuat_x()
        {
            int n = int.Parse(TxtN.Text);
            for (int k = 1; k <= n; k++)
            {
                txtketqua.Text += X[k];
            }
            txtketqua.Text += "\t";
        }
        void Try(int i)
        {
            int n = int.Parse(TxtN.Text);
            for (char j = 'A'; j <= 'D'; j++)
            {
                if (!((j == 'A') && X[i - 1] == 'A'))
                {
                    X[i] = j;
                   
                    if (i < n)
                        Try(i + 1);
                    else Xuat_x();

                }

            }
        }
        private void bt2b_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 100; j++)
                b[j] = 0;
            Try(1);

        }
    }
}
