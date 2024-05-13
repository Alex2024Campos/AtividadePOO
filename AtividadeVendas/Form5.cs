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
    }
}
