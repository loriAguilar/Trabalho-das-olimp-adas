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
            labelNomeAtleta.Content = Controle.atletas[Controle.indiceAtleta].Nome;
        }

        #region cadastrar
        private void buttonCadastrarCompeticao(object sender, RoutedEventArgs e)
        {
            //evento cadastrar
            int indiceParaCadastrar = Controle.indiceAtleta;
            Competicao aux;
            
            if (pistoladear.IsChecked == true)
            {
                aux = new Competicao("pistoladear", Controle.indiceAtleta);
                Controle.competicoes.Add(aux);
            }
            
            if (carabinadear.IsChecked == true)
            {
                aux = new Competicao("carabinadear", Controle.indiceAtleta);
                Controle.competicoes.Add(aux);
            }

            if (pistola.IsChecked == true)
            {
                aux = new Competicao("pistola", Controle.indiceAtleta);
                Controle.competicoes.Add(aux);
            }

            if (carabinatrespos.IsChecked == true)
            {
                aux = new Competicao("carabinatrespos", Controle.indiceAtleta);
                Controle.competicoes.Add(aux);
            }
            
            if (skeet.IsChecked == true)
            {
                aux = new Competicao("skeet", Controle.indiceAtleta);
                Controle.competicoes.Add(aux);
            }

            if (fossa.IsChecked == true)
            {
                aux = new Competicao("fossa", Controle.indiceAtleta);
                Controle.competicoes.Add(aux);
            }

            //testar coiso cadastrados
            Console.WriteLine(Controle.atletas[indiceParaCadastrar].Nome);
            for (int pos = 0; pos < Controle.competicoes.Count; pos++)
            {
                Console.WriteLine("Cadastrado {0}: {1}", Controle.atletas[Controle.competicoes[pos].IdAtleta].Nome, Controle.competicoes[pos].NomeCompeticao);
            }

            MessageBox.Show("Cadastro conluído com sucesso", "", MessageBoxButton.OK);
        }
        #endregion

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //evento sair
            this.Close();
        }
    }
}
