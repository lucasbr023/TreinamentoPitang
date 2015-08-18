using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }


        Operacoes o = new Operacoes();

        string operacao = "";
        double acumula = 0;


        private void ISomar(object sender, RoutedEventArgs e) {
            try {

                double valor_1;

                if (operacao == "*" || operacao == "-" || operacao == "/") {
                    operacao = "+";
                }
                else if (double.TryParse(txtPrimeiro.Text.ToString(), out valor_1)) {
                    acumula += valor_1;
                    txtPrimeiro.Text = "";
                    operacao = "+";
                }
                else {
                    MessageBox.Show("Digite apenas valores numericos");
                }


            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Erro");
            }


        }

        private void ISubtrair(object sender, RoutedEventArgs e) {

            try {

                double valor_1;

                if (operacao == "*" || operacao == "+" || operacao == "/") {
                    operacao = "-";
                }
                else if (double.TryParse(txtPrimeiro.Text.ToString(), out valor_1)) {
                    acumula += valor_1;
                    txtPrimeiro.Text = "";
                    operacao = "-";
                }
                else {
                    MessageBox.Show("Digite apenas valores numericos");
                }
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void IMultiplicar(object sender, RoutedEventArgs e) {

            try {

                double valor_1;

                if (operacao == "+" || operacao == "-" || operacao == "/") {
                    operacao = "*";
                }
                else if (double.TryParse(txtPrimeiro.Text.ToString(), out valor_1)) {
                    acumula += valor_1;
                    txtPrimeiro.Text = "";
                    operacao = "*";
                }
                else {
                    MessageBox.Show("Digite apenas valores numericos");
                }
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Erro");
            }

        }

        private void IDividir(object sender, RoutedEventArgs e) {

            try {
                double valor_1;

                if (operacao == "*" || operacao == "-" || operacao == "+") {
                    operacao = "/";
                }
                else if (double.TryParse(txtPrimeiro.Text.ToString(), out valor_1)) {
                    acumula += valor_1;
                    txtPrimeiro.Text = "";
                    operacao = "/";
                }
                else {
                    MessageBox.Show("Digite apenas valores numericos");
                }
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Erro");

            }

        }

        private void IElevar(object sender, RoutedEventArgs e) {
            try {
                double valor1;

                if (double.TryParse(txtPrimeiro.Text.ToString(), out valor1)) {
                    valor1 = double.Parse(txtPrimeiro.Text);
                }
                else {
                    MessageBox.Show("Digite apenas valores numericos");
                }

                Double resultado = o.ElevarQuadrado(valor1);
                
                txtResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Erro");

            }

        }

        private void IRaiz(object sender, RoutedEventArgs e) {
            try {
                double valor1;

                if (double.TryParse(txtPrimeiro.Text.ToString(), out valor1)) {
                    valor1 = double.Parse(txtPrimeiro.Text);
                }
                else {
                    MessageBox.Show("Digite apenas valores numericos");
                }

                Double resultado = o.Raiz(valor1);
               
                txtResultado.Text = Convert.ToString(resultado);
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Erro");

            }

        }

        private void IResultado(object sender, TextChangedEventArgs e) {
        }

        private void TextPrimeiro(object sender, TextChangedEventArgs e) {
        }

        private void TextBoxSegundo(object sender, TextChangedEventArgs e) {
        }

        private void button_igual_Click(object sender, RoutedEventArgs e) {

            switch (operacao) {
                case "+":
                    acumula += double.Parse(txtPrimeiro.Text);
                    txtResultado.Text = acumula.ToString();
                    break;
                case "-":
                    acumula -= double.Parse(txtPrimeiro.Text);
                    txtResultado.Text = acumula.ToString();
                    break;
                case "/":
                    if (double.Parse(txtPrimeiro.Text) != 0) {
                        acumula /= double.Parse(txtPrimeiro.Text);
                        txtResultado.Text = acumula.ToString();
                    }
                    else {
                        MessageBox.Show("Não pode dividir por 0");
                    }
                    break;
                case "*":
                    acumula *= double.Parse(txtPrimeiro.Text);
                    txtResultado.Text = acumula.ToString();
                    break;
                    }



        }

        private void button_Click(object sender, RoutedEventArgs e) {
            acumula = 0;
            operacao = "";
            txtResultado.Text = "";
        }
    }
}
