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

        //gera evento "fase classificatória"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Botão que mostra todas as pessoas que se cadastraram 
            //Botão para cadastrar a nota que cada pessoa tirou em diferentes competições
            //posso fazer um botão para cada competição e colocar isso acima dentro deles
            Fase_classificatoria classificatoria = new Fase_classificatoria();
            classificatoria.ShowDialog();
        }

        //gera evento "fase final"
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //janela: um botão para mostrar as pessoas que estão classificadas e um botão para cadastrar as notas que cada uma das pessoas teve em cada modalidade
        }

        //gera evento "entrega de medalhas"
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //janela que vai ter os resultados finais (medalhas de ouro, prata e bronze de cada uma das modalidades
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //tem que ter o botão para cadastrar os resultados dos três eventos
        //administrativo não vai cadastrar os eventos (feito automaticamente)
        //administrativo não vai cadastrar pessoas (feito pelo próprio atleta)
    }
}


