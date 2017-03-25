using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {

        double Total;
        double UltimoNumero;
        String Operacao;
        
        private void Limpar()
        {
            Total = 0;
            UltimoNumero = 0;
            Operacao = "+";
            mtbResultado.Text = "0";
        }

        private void Calcular()
        {
            switch (Operacao)
            {
                case "+" : Total = Total + UltimoNumero;
                    break;

                case "-" : Total = Total - UltimoNumero;
                    break;

                case "x" : Total = Total * UltimoNumero;
                    break;

                case "/" : Total = Total / UltimoNumero;
                    break;
            }

            UltimoNumero = 0;
            mtbResultado.Text = Total.ToString();
        }

        public Form1()
        {
            InitializeComponent();

            Limpar();
        }

        private void btLimpar(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btNumero(object sender, EventArgs e)
        {
            if(UltimoNumero == 0)
            {
                mtbResultado.Text = (sender as Button).Text;
            }
            else
            {
                mtbResultado.Text = mtbResultado.Text + (sender as Button).Text;
            }

            

            UltimoNumero = Convert.ToDouble(mtbResultado.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btOperacao(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

            Calcular();

            Operacao = (sender as Button).Text;
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

            Calcular();

            Operacao = "+";

            Total = 0;

        }
    }
}
