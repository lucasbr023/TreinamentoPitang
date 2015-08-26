using LocadoraCarros.Negocio;
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


namespace LocadoraCarros
{
    /// <summary>
    /// Interaction logic for CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {

        private static readonly LocadoraContext context = new LocadoraContext();

        public CadastroCliente()
        {
            InitializeComponent();

            using (var context = new LocadoraContext()) {
                context.Clientes.Add(new Cliente("Lucas", "123"));
            }


        } 


        Singleton singleton = Singleton.GetInstancia();
        
        //RepositorioCliente repositorio = new RepositorioCliente();



        private void button_salvarCliente_Click(object sender, RoutedEventArgs e) {

            ArquivoXMLCliente arquivo = ArquivoXMLCliente.GetInstancia();

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
            



            //if (!nome.ValidarBrankSpace() || !documento.ValidarBrankSpace() || !telefone.ValidarBrankSpace()
            //    || !dataNascimento.ValidarBrankSpace() || !estado.ValidarBrankSpace() || !logradouro.ValidarBrankSpace()||
            //    !numero.ValidarBrankSpace() || !bairro.ValidarBrankSpace() || !cep.ValidarBrankSpace() || !cidade.ValidarBrankSpace())
            //{
            //    MessageBox.Show("Não pode conter conteudo obrigatorio em branco!");
            //}
            //else if (!telefone.ValidarTelefone())
            //{
            //    MessageBox.Show("Telefone invalido");
            //}else if (radioButton.IsChecked == true) {
            //    if (!documento.ValidarCPF()) {

            //        MessageBox.Show("CPF invalido!");
            //    }
            //}else if (radioButton1.IsChecked == true) {
            //    if (!documento.ValidarCNPJ()) {
            //        MessageBox.Show("CNPJ invalido!");
            //    }
            //}else if (!dataNascimento.ValidarData()) {
            //    MessageBox.Show("Data invalida!");
            //}


            Cliente cliente = new Cliente(nome, documento);
            singleton.InserirCliente(cliente);
            arquivo.Gravar(nome, documento, dataNascimento, telefone);
           
            this.Close();


        }




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

      


        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void Window_Closed_1(object sender, EventArgs e) {
            context.Dispose();
        }
    }
}
