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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int[] b = new int[100];
        int[] X = new int[100];
        
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
            for (int j = 1; j <= n ; j++)
            {
                if (b[j] == 0)
                {
                    X[i] = j;
                    b[j] = 1;
                    if (i == n)
                        Xuat_x();
                    else
                        Try(i + 1);
                    b[j] = 0;
                }
            }
        }
        private void Form4_Load(object sender, EventArgs e)
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

        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
