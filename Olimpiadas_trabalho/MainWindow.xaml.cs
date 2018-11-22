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

namespace Olimpiadas_trabalho
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("\nTRABALHO FINAL INTEGRADO \nNomes: \nGustavo Ribeiro de Freitas Sena \nJoão Vitor Mendes Soares \nLorena Alves Aguilar \nNathan Ribeiro Ferreira Pinto ", "", MessageBoxButton.OK,MessageBoxImage.Information);
            
        }

        #region competidores
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!Controle.telaCadastroEstaDeativada)
            {
                //janela que será usada para cadastrar os dados dos atletas e  quais competições eles vão participar
                Competidores competidores = new Competidores();
                competidores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não é possível cadastrar atletas. A competição já começou.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region administrativo
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //esse botão vai desencadear a abertura de uma janela para que os organizadores do evento entrem (não sei se por meio de senha, seria o ideal)
            //e cadastrem a pontuação dos atletas que participaram da competição
            Area_administrativa adm = new Area_administrativa();
            adm.ShowDialog();
        }
        #endregion

        #region sair
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();            
        }

        #endregion
    }
}
