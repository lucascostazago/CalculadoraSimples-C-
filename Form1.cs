using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
       
        //lista de opcoes.
        enum Operacoes
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += " 0 ";
        }

        private void maismenos_Click(object sender, EventArgs e)
        {

        }
        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            // double é número real
            List<double> listaDeNumeros = new List<double>();
            switch (ultimaOperacao)
            {
                case Operacoes.Soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('×').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    try
                    {
                        listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }
                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;


            }
        }
        private void virgula_Click(object sender, EventArgs e)
        {
           
            

        }

        private void somar_Click(object sender, EventArgs e)
        {
           
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
        private void multiplicar_Click(object sender, EventArgs e)
        {

            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
        private void subitrair_Click(object sender, EventArgs e)
        {

            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
        private void dividir_Click(object sender, EventArgs e)
        {

            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void Enter_Click(object sender, EventArgs e)
        {

            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void apagar_Click(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void cancelaeapaga_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void restodivisao_Click(object sender, EventArgs e)
        {

        }

        private void apagar_Click_1(object sender, EventArgs e)
        {
          
            if(textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }
    }
}
