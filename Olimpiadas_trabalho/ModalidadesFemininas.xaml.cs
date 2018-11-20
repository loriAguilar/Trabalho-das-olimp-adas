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
            for(int d=0;d<Controle.contador;d++)
            {
                Controle.competidores[d] = new Competicao_feminina();
            }
        }

        //evento cadastrar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Competicao_feminina comp = new Competicao_feminina();

            try
            {
                string nome = Controle.auxf;
                for (int c = 0; c < Controle.contador; c++)
                {
                    if (Controle.competidores[c].Nome == nome)
                    {
                        if (pistoladear.IsChecked == true)
                        {
                            Controle.competidores[c].Competidora.Competicao_disputada[0] = "pistoladear";
                        }

                        if (carabinadear.IsChecked == true)
                        {
                            Controle.competidores[c].Competidora.Competicao_disputada[1] = "carabinadear";
                        }

                        if (pistola.IsChecked == true)
                        {
                            Controle.competidores[c].Competidora.Competicao_disputada[2] = "pistola";
                        }

                        if (carabinatrespos.IsChecked == true)
                        {
                            Controle.competidores[c].Competidora.Competicao_disputada[3] = "carabinatrespos";
                        }

                        if (skeet.IsChecked == true)
                        {
                            Controle.competidores[c].Competidora.Competicao_disputada[4] = "skeet";
                        }

                        if (fossa.IsChecked == true)
                        {
                            Controle.competidores[c].Competidora.Competicao_disputada[5] = "fossa";
                        }
                    }
                }
            }
            catch(Exception k)
            {
                MessageBox.Show("Erro: " + k.Message);
            }
            
        }

        //evento sair
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
