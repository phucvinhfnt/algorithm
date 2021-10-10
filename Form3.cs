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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
        int SD(float[] A, float x, int csd, int csc)
        {//day còn 1 phần tử

            if (csd == csc)
            {
           /*     return Math.Abs(csd - x);*/

            }
            int csg = (csd + csc) / 2;
            int Min1 = SD(A, x, csd, csg);
            int Min2 = SD(A, x, csg + 1, csc);
            if (Min1 < Min2)
            {
                return Min1;
            }
            else return Min2;



        }
        int n; float[] A = new float[100];
        private void Form3_Load(object sender, EventArgs e)
        {
            DuLieu dl = Xu_ly_chuoi.TachChuoi(txtChuoi.Text);
            A = dl.a;
            n = dl.n;
        }

        private void txtChuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinra_TextChanged(object sender, EventArgs e)
        {
            float x = float.Parse(textBox2.Text);
            if (SD(A, x, 0, n - 1) == 1)
                txtinra.Text = "Xuat hien trong day";
            else
                txtinra.Text = "Khong xuat hien";

        }
    }
}
