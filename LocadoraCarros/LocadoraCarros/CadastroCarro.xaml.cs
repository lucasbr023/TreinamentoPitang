using LocadoraCarros.Repositorios;
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
using System.Windows.Shapes;
using System.Windows.Data;
using System.Data;
using LocadoraCarros.Negocio;

namespace LocadoraCarros {
    /// <summary>
    /// Interaction logic for CadastroCarro.xaml
    /// </summary>
    public partial class CadastroCarro : Window {
        public CadastroCarro() {
            InitializeComponent();
        }


        Singleton singleton = Singleton.GetInstancia();

        private void button_salvarCarro_Click(object sender, RoutedEventArgs e) {

            ArquivoXMLCarro arquivo = ArquivoXMLCarro.GetInstancia();

            string status = "Dispónivel";
            string ano = textBox_Ano.Text;
            string placa = textBox_Placa.Text;
            string cor = textBox_Cor.Text;
            int quilometragem = int.Parse(textBox_Quilometragem.Text);
            string chaci = textBox_Chaci.Text;
            int qtdPortas = int.Parse(textBox_qtdPortas.Text);
            string modelo = textBox_Modelo.Text;


            Carro carro = new Carro(modelo, placa, status);
            singleton.InserirCarro(carro);
            arquivo.Gravar(modelo,ano,placa,quilometragem.ToString(),cor,chaci,qtdPortas.ToString(),status);
            this.Close();
        }



        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void textBox_Modelo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Ano_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Placa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Quilometragem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Cor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Chaci_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_qtdPortas_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
