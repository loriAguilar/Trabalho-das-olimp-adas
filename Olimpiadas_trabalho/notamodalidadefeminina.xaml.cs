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
    /// Lógica interna para notamodalidadefeminina.xaml
    /// </summary>
    public partial class notamodalidadefeminina : Window
    {
        public notamodalidadefeminina()
        {
            InitializeComponent();
        }

        #region cadastrar nota
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region sair
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
