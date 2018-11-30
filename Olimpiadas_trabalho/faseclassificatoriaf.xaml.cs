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

namespace Olimpiadas_trabalho
{
    /// <summary>
    /// Lógica interna para faseclassificatoriaf.xaml
    /// </summary>
    public partial class faseclassificatoriaf : Window
    {
        public faseclassificatoriaf()
        {
            InitializeComponent();
        }

        #region pistola de ar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Controle.nomedamodalidade = "pistoladear";
            notamodalidadefeminina notamodalidadefeminina = new notamodalidadefeminina(1);
            notamodalidadefeminina.ShowDialog();
        }
        #endregion

        #region carabina de ar
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Controle.nomedamodalidade = "carabinadear";
            MessageBox.Show(Controle.nomedamodalidade);
            notamodalidadefeminina notamodalidadefeminina = new notamodalidadefeminina(1);
            notamodalidadefeminina.ShowDialog();
        }

        #endregion

        #region pistola
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Controle.nomedamodalidade = "pistola";
            notamodalidadefeminina notamodalidadefeminina = new notamodalidadefeminina(1);
            notamodalidadefeminina.ShowDialog();
        }
        #endregion

        #region carabina de três posições
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Controle.nomedamodalidade = "carabinatrespos";
            notamodalidadefeminina notamodalidadefeminina = new notamodalidadefeminina(1);
            notamodalidadefeminina.ShowDialog();
        }
        #endregion

        #region skeet
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Controle.nomedamodalidade = "skeet";
            notamodalidadefeminina notamodalidadefeminina = new notamodalidadefeminina(1);
            notamodalidadefeminina.ShowDialog();
        }
        #endregion

        #region fossa olímpica
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Controle.nomedamodalidade = "fossa";
            notamodalidadefeminina notamodalidadefeminina = new notamodalidadefeminina(1);
            notamodalidadefeminina.ShowDialog();
        }
        #endregion

        #region sair
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Arquivos.escreverRelatorioResultado(0);
        }
    }
}
