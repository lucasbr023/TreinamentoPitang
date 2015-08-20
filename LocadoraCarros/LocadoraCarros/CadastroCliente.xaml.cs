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

namespace LocadoraCarros {
    /// <summary>
    /// Interaction logic for CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window {
        public CadastroCliente() {
            InitializeComponent();
          

        }
        RepositorioCliente repositorio = new RepositorioCliente();




        private void textBox_nome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_Documento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_DataNascimento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_telefone_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_logradouro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_numero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_cep_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_bairro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_estado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_cidade_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_complemento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_salvarCliente_Click(object sender, RoutedEventArgs e)
        {

            string nome = textBox_nome.Text;
            
            string documento = textBox_Documento.Text;
            string telefone = textBox_telefone.Text;
            string dataNascimento = textBox_DataNascimento.Text;
            string estado = textBox_estado.Text;
            string logradouro = textBox_logradouro.Text;
            string numero = textBox_numero.Text;
            string bairro = textBox_bairro.Text;
            string cep = textBox_cep.Text;
            string cidade = textBox_cidade.Text;
            string complemento = textBox_complemento.Text;

            if (!nome.ValidarBrankSpace() || !documento.ValidarBrankSpace() || !telefone.ValidarBrankSpace()) {
                MessageBox.Show("Não pode conter conteudo obrigatorio em branco!");
            }
            else if (!telefone.ValidarTelefone()) {
                MessageBox.Show("Telefone invalido");
            }
            else {
                Cliente cliente = new Cliente(nome, documento);
                repositorio.Inserir(cliente);
                this.Close();
            }
           
            


           

           
            
            


        }
    }
}
