using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeVendas
{
    public partial class Frm5 : Form
    {
        public Frm5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, num, i, f;
            x = Convert.ToDouble(txt1.Text);

            num = 1;
            i = 1;
            do
            {
                i = num * 1;
                f = x * 1;
                num++;
                txt2.Text = String.Concat(txt2.Text, "\r\n", x, "x", i, "=", f.ToString());
            } while ( x > num);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm2 tela1 = new Frm2();
            tela1.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double x, num, i, f;

            x = Convert.ToDouble(txt1.Text);

            num = 1;
            i = 1;

            while (num < x)
            { 
                i = num * i;
                f = x * i;
                num++;
                txt2.Text = String.Concat(txt2.Text, "\r\n", x,"x", i, "=", f.ToString());
            }


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double x, f, i, num;
            x = Convert.ToDouble(txt1.Text);
            for (i= 1, num = 1; num < x; num++)
            {
                i = num * i;
                f = x * i;
                txt2.Text = String.Concat(txt2.Text, "\r\n", x, "x", i, "=", f.ToString());
            }
        }
    }
}
