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
            for(int g=0;g<Controle.contador;g++)
            {
                notas.Items.Add(Controle.competidores[g].Nome.ToString());
            }
        }

        #region cadastrar nota
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string clicked = Convert.ToString(notas.SelectionBoxItem);
            double nota = double.Parse(notatexto.Text);
            try
            {
                for(int r=0;r<Controle.contador;r++)
                {
                    if(Controle.competidores[r].Nome==clicked)
                    {
                        
                    }
                }
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

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
