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
    /// Lógica interna para Area_administrativa.xaml
    /// </summary>
    public partial class Area_administrativa : Window
    {
        public Area_administrativa()
        {
            InitializeComponent();
        }

        #region fase classificatória
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Botão que mostra todas as pessoas que se cadastraram 
            //Botão para cadastrar a nota que cada pessoa tirou em diferentes competições
            //posso fazer um botão para cada competição e colocar isso acima dentro deles
            if(feminino.IsChecked==true)
            {
                faseclassificatoriaf faseclassificatoriaf = new faseclassificatoriaf();
                faseclassificatoriaf.Show();
            }
            else
            {
                faseclassificatoriam faseclassificatoriam = new faseclassificatoriam();
                faseclassificatoriam.Show();
            }
        }
        #endregion

        #region fase final
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(feminino.IsChecked==true)
            {
                fasefinalf fasefinalf = new fasefinalf();
                fasefinalf.Show();
            }
            else
            {
                fasefinalm fasefinalm = new fasefinalm();
                fasefinalm.Show();
            }
        }
        #endregion

        #region entrega de medalhas
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //janela que vai ter os resultados finais (medalhas de ouro, prata e bronze de cada uma das modalidades
            if (feminino.IsChecked == true)
            {
                entregademedalhasf entregademedalhasf = new entregademedalhasf();
                entregademedalhasf.Show();
            }
            else
            {
                entregademedalhasm entregademedalhasm = new entregademedalhasm();
                entregademedalhasm.Show();
            }
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //tem que ter o botão para cadastrar os resultados dos três eventos
        //administrativo não vai cadastrar os eventos (feito automaticamente)
        //administrativo não vai cadastrar pessoas (feito pelo próprio atleta)
    }
}


