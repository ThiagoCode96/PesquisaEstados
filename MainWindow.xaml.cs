using PesquisaEstados.Database;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace PesquisaEstados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dt=new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            StartSql();
        }
        private void StartSql()
        {
            dt = Telephone.StartList(true);
            DGVLista.ItemsSource = dt.DefaultView;

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            dt = Telephone.GetList(cidadeBox.Text, estadoBox.Text, siglaBox.Text, dddBox.Text);
            DGVLista.ItemsSource = dt.DefaultView;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
