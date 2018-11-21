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
    /// Lógica interna para ModalidadesFemininas.xaml
    /// </summary>
    public partial class ModalidadesFemininas : Window
    {
        public ModalidadesFemininas()
        {
            InitializeComponent();
        }
        
        private void buttonCadastrarCompeticao(object sender, RoutedEventArgs e)
        {
            //evento cadastrar
            int indiceParaCadastrar = Controle.indiceCompetidores;

            if (pistoladear.IsChecked == true)
                Controle.competidores[indiceParaCadastrar].cadastrarCompeticao("pistoladear");
            
            if (carabinadear.IsChecked == true)
                Controle.competidores[indiceParaCadastrar].cadastrarCompeticao("carabinadear");

            if (pistola.IsChecked == true)
                Controle.competidores[indiceParaCadastrar].cadastrarCompeticao("pistola");

            if (carabinatrespos.IsChecked == true)
                Controle.competidores[indiceParaCadastrar].cadastrarCompeticao("carabinatrespos");

            if (skeet.IsChecked == true)
                Controle.competidores[indiceParaCadastrar].cadastrarCompeticao("skeet");

            if (fossa.IsChecked == true)
                Controle.competidores[indiceParaCadastrar].cadastrarCompeticao("fossa");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //evento sair
            this.Close();
        }
    }
}
