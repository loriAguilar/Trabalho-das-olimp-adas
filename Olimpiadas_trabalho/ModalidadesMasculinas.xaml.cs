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
    /// Lógica interna para ModalidadesMasculinas.xaml
    /// </summary>
    public partial class ModalidadesMasculinas : Window
    {
        public ModalidadesMasculinas()
        {
            InitializeComponent();
        }

        //evento cadastrar
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //evento sair
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
