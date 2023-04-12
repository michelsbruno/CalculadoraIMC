using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class CalcIMC : Form
    {
        public CalcIMC()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double ldc_peso, ldc_altura, ldc_IMC;

            ldc_peso = Convert.ToDouble(txt_peso.Text);
            ldc_altura = Convert.ToDouble(txt_altura.Text);

            ldc_IMC = ldc_peso / (ldc_altura * ldc_altura);

            if (ldc_IMC < 16)
            {
                lb_observacao.Text = "Você está abaixo do seu peso ideal. Magreza Grau III";
                gb_resultado.BackColor = Color.IndianRed;
            }
            else if (ldc_IMC >= 16 && ldc_IMC <= 16.9)
            {
                lb_observacao.Text = "Você está abaixo do seu peso ideal. Magreza Grau II";
                gb_resultado.BackColor = Color.BurlyWood;
            }
            else if (ldc_IMC >= 17 && ldc_IMC <= 18.4)
            {
                lb_observacao.Text = "Você está abaixo do seu peso ideal. Magreza Grau I";
                gb_resultado.BackColor = Color.BurlyWood;
            }
            else if (ldc_IMC >= 18.5 && ldc_IMC <= 24.9)
            {
                lb_observacao.Text = "Você está no seu peso adequado!";
                gb_resultado.BackColor = Color.Green;
            }
            else if (ldc_IMC >= 25 && ldc_IMC <= 29.9)
            {
                lb_observacao.Text = "Você está acima do seu peso ideal. Pré-obeso";
                gb_resultado.BackColor = Color.Yellow;
            }
            else if (ldc_IMC >= 30 && ldc_IMC <= 34.9)
            {
                lb_observacao.Text = "Você está acima do seu peso ideal. Obesidade Grau I";
                gb_resultado.BackColor = Color.BurlyWood;
            }
            else if (ldc_IMC >= 35 && ldc_IMC <= 39.9)
            {
                lb_observacao.Text = "Você está acima do seu peso ideal. Obesidade Grau II";
                gb_resultado.BackColor = Color.BurlyWood;
            }
            else if (ldc_IMC >= 40)
            {
                lb_observacao.Text = "Você está acima do seu peso ideal. Obesidade Grau III";
                gb_resultado.BackColor = Color.IndianRed;
            }


            lb_resultado.Text = "Seu IMC: " + ldc_IMC.ToString("0.00");

            lb_resultado.Visible = true;
            lb_observacao.Visible = true;
            gb_resultado.Visible = true;
            btn_recalcular.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CalcIMC tela = new CalcIMC();
            tela.Show();
        }
    }
}
