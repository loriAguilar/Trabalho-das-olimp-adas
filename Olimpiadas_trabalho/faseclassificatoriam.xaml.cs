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
    /// Lógica interna para faseclassificatoriam.xaml
    /// </summary>
    public partial class faseclassificatoriam : Window
    {
        public faseclassificatoriam()
        {
            InitializeComponent();
        }

        #region pistola de ar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region carabina de ar
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }

        #endregion

        #region pistola deitado
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region pistola
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region carabina deitado
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region carabina três posições
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }

        #endregion

        #region skeet
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region fossa olímpica
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region fossa olímpica dupla
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            notamodalidademasculina notamodalidademasculina = new notamodalidademasculina(1);
            notamodalidademasculina.ShowDialog();
        }
        #endregion

        #region sair
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
