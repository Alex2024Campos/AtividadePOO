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

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double x, num, i;

            num = Convert.ToDouble(txt1.Text);
            i = num - 1;

            while (i<=num)
            {
                x = num * i;
                i--;
                txt2.Text = String.Concat(txt2,"\r\n",x.ToString());
            }
        }
    }
}
