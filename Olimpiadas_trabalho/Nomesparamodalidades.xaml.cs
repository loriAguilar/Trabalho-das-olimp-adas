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
    /// Lógica interna para Nomesparamodalidades.xaml
    /// </summary>
    public partial class Nomesparamodalidades : Window
    {
        public Nomesparamodalidades()
        {
            InitializeComponent();
            //toda vez que alguém for cadastrado, vai se adicionar um nome a combobox
            try
            {
                //for (int a = 0; a < (Controle.atletas.Count); a++)
                //{
                //    combonomes.Items.Add(Controle.atletas[(a)].Nome.ToString());
                //}
                Arquivos.Carregar(Controle.atletas);
                foreach (var item in Controle.atletas)
                {
                    combonomes.Items.Add(item.Nome.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selecionado = Convert.ToString(combonomes.SelectionBoxItem);
           
            try
            {
                for (int pos = 0; pos < Controle.atletas.Count; pos++)
                    if (Controle.atletas[pos].Nome == selecionado)
                    {
                        Controle.indiceAtleta = pos;
                        if (Controle.atletas[pos].Sexo == 'F') //mulher
                        {
                            ModalidadesFemininas modalidadesFemininas = new ModalidadesFemininas();
                            modalidadesFemininas.ShowDialog();
                        }
                        else //homem
                        {
                            ModalidadesMasculinas modalidadesMasculinas = new ModalidadesMasculinas();
                            modalidadesMasculinas.ShowDialog();                            
                        }
                    }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

