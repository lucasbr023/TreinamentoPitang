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

namespace LocadoraCarros {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e) {

        }

        private void ComboBox_SelectionChanged_3(object sender, SelectionChangedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente cadastro = new CadastroCliente();
            cadastro.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_cadastroCarro(object sender, RoutedEventArgs e)
        {
            CadastroCarro cadastro = new CadastroCarro();
            cadastro.Show();
        }
    }
}
