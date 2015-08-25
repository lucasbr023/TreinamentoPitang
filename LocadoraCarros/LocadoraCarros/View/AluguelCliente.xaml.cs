using LocadoraCarros.Negocio;
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
    /// Interaction logic for AluguelCliente.xaml
    /// </summary>
    public partial class AluguelCliente : Window {
        public AluguelCliente() {
            InitializeComponent();
        }

        Singleton singleton = Singleton.GetInstancia();
        ArquivoXMLAlugueis arquivo = ArquivoXMLAlugueis.GetInstancia();

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void button_salvarAluguel_Click(object sender, RoutedEventArgs e) {


            string documentoCliente = textBox.Text;
            string placaCarro = textBox1.Text;
            string codigo = textBox2.Text;

            var clientes = singleton.BuscarTodosClientes();
            var carros = singleton.BuscarTodosCarros();
            var pesquisaCliente = from c in clientes
                                  where c.Documento == documentoCliente
                                  select c;

            var pesquisaCarro = from c in carros
                                where c.Placa == placaCarro
                                select c;

            foreach (Carro carro in pesquisaCarro) {
                if (carro.Status == false) {
                    carro.CodigoAluguel = codigo;
                }
                else {
                    MessageBox.Show("Carro Indisponivel!");
                    this.Close();
                }
            }


            foreach (Cliente item in clientes) {

                if (item.CodigoAluguel == null) {
                    item.CodigoAluguel = codigo;
                }
                else {
                    MessageBox.Show("Cliente já apresenta um aluguel");
                    this.Close();
                }

            }

            var query = from carro in pesquisaCarro
                        join cliente in pesquisaCliente
                        on carro.CodigoAluguel equals cliente.CodigoAluguel
                        where carro.Status == false
                        select new Aluguel(cliente, carro, codigo);



            foreach (Aluguel item in query) {
                item.Carro.Status = true;
                singleton.InserirAluguel(item);
                arquivo.Gravar(item);

            }

            this.Close();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void button_Click(object sender, RoutedEventArgs e) {


            string documentoCliente = textBox.Text;
            string placaCarro = textBox1.Text;
            string codigo = textBox2.Text;

            var clientes = singleton.BuscarTodosClientes();
            var carros = singleton.BuscarTodosCarros();
            var pesquisaCliente = from c in clientes
                                  where c.Documento == documentoCliente
                                  select c;

            var pesquisaCarro = from c in carros
                                where c.Placa == placaCarro
                                select c;

            foreach (Carro carro in pesquisaCarro) {
                if (carro.Status == true) {
                    carro.CodigoAluguel = null;
                    carro.Status = false;
                }
                else {
                    MessageBox.Show("Carro Indisponivel!");
                }
            }


            foreach (Cliente item in clientes) {
                item.CodigoAluguel = null;
            }

            var query = from carro in pesquisaCarro
                        join cliente in pesquisaCliente
                        on carro.CodigoAluguel equals cliente.CodigoAluguel
                        select new Aluguel(cliente, carro, codigo);

            foreach (Aluguel item in query) {
                singleton.RemoverAluguel(item);

            }

            this.Close();


        }
    }
}
