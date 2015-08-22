using LocadoraCarros.Negocio;
using LocadoraCarros.Repositorios;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace LocadoraCarros {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        Singleton singleton = Singleton.GetInstancia();
        

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e) {

        }

        private void ComboBox_SelectionChanged_3(object sender, SelectionChangedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            CadastroCliente cadastro = new CadastroCliente();
            cadastro.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

            var itens = singleton.BuscarTodosCarros().OrderBy(x => x.Placa);
            foreach (var item in singleton.BuscarTodosCarros()) {
                listView.Items.Add(item.ToString());

            }



        }

        private void Button_Click_cadastroCarro(object sender, RoutedEventArgs e) {
            CadastroCarro cadastro = new CadastroCarro();
            cadastro.Show();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e) {


        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {


            
            listView.Items.Clear();
            var itens = singleton.BuscarTodosClientes().OrderByDescending(x=>x.Nome);
            foreach (Cliente cliente in itens) {
                listView.Items.Add(cliente.ToString());
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var pesquisa = singleton.BuscarTodosClientes().Where(x => x.Documento.Equals("10758480407"));
            foreach (var item in singleton.BuscarTodosClientes()) {
                MessageBox.Show(item.ToString());
            }
            //MessageBox.Show(singleton.ProcurarCliente("10758480407").Nome);
            


        }

        
    }
}
