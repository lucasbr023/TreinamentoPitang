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

        List<Cliente> clientes = new List<Cliente>();

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


            Cliente cliente = new Cliente(nome, documento);

            clientes.Add(cliente);
            MessageBox.Show("Cliente adicionado com sucesso!!");
            this.Close();
            


        }
    }
}
