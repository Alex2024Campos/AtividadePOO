﻿using System;
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
    public partial class Frm4 : Form
    {
        public Frm4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string sexo, nome;
            sexo = txt3.Text;
            nome = txt1.Text;

            double age, sal, result;
            age = Convert.ToDouble(txt2.Text);
            sal = Convert.ToDouble(txt4.Text);

            if (sexo == "Masculino" && age >= 30)
            {
                result = sal + 100;

                txt5.Text = result.ToString();
            }

            else if (sexo == "Masculino" && age < 30)
            {
                result = sal + 80;

                txt5.Text = result.ToString();
            }

            else if (sexo == "Feminino" && age >= 30)
            {
                result = sal + 200;

                txt5.Text = result.ToString();
            }

            else if (sexo == "Feminino" && age < 30)
            {
                result = sal + 50;

                txt5.Text = result.ToString();
            }

            txt6.Text = nome.ToString();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();

            txt1.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm2 tela1 = new Frm2();
            tela1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm4_Load(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
