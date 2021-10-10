using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtK.Focus();            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int k, n;
            k = int.Parse(txtK.Text);
            n = int.Parse(txtN.Text);
            if (k > n)
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn nhập lại không ?", "Vui lòng nhập lại K>=N", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                    Application.Exit();
                else
                {
                    txtK.Clear();
                    txtN.Clear();
                    txtK.Focus();
                }

            }
            else
            {
                int a = C(k, n);
                txtKQ.Text = Convert.ToString(a);
            }
        }
        int C(int k, int n)
        {
            if (k == 0 || k == n) return 1;
            if (k == 1) return n;
            return C(k - 1, n - 1) + C(k, n - 1);
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
