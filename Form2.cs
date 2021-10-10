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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        class DuLieu
        {
            public string chuoi = "";
            public float[] a = new float[] { };
            public int n = 0;
        }

        class Xu_ly_chuoi
        {
            public static DuLieu TachChuoi(string chuoi)
            {
                DuLieu dl = new DuLieu();
                dl.chuoi = chuoi;
                if (string.IsNullOrEmpty(chuoi)) chuoi = "0";
                else
                {
                    try
                    {
                        string[] s = chuoi.Trim().Split(',');
                        s = s.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                        dl.a = Array.ConvertAll(s, x => float.Parse(x)); //int.Parse(x)
                        dl.n = Convert.ToInt32(dl.a.Length.ToString());
                    }
                    catch (Exception) { }
                }
                return dl;
            }
        }
        int n; float[] A = new float[100];
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DuLieu dl = Xu_ly_chuoi.TachChuoi(txtChuoi.Text);
            A = dl.a;
            n = dl.n;
        }


        private void btn_KetQua_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox2.Text);
            if (tknp(A, x, 0, n - 1) == 1)
                txtinra.Text = "Xuat hien trong day";
            else
                txtinra.Text = "Khong xuat hien";

        }
        int tknp(float[] a, float x, int l, int r)
        {
            int mid;
            if (l > r)
                return 0;
            mid = (l + r) / 2;
            if (x == a[mid])
                return 1;
            if (x > a[mid])
                return tknp(a, x, mid + 1, r);
            return tknp(a, x, l, mid - 1);
        }

        private void txtChuoi_TextChanged(object sender, EventArgs e)
        {
            DuLieu dl = Xu_ly_chuoi.TachChuoi(txtChuoi.Text);
            A = dl.a;
            n = dl.n;
        }

        private void txtinra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    //
}
    

