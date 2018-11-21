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
            MessageBox.Show(Convert.ToString(Controle.contador));
            try
            {
                for (int a = 0; a < (Controle.contador); a++)
                {
                    combonomes.Items.Add(Controle.competidores[(a)].Nome.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ModalidadesFemininas modalidadesFemininas = new ModalidadesFemininas();
            ModalidadesMasculinas modalidadesMasculinas = new ModalidadesMasculinas();
            string selecionado = Convert.ToString(combonomes.SelectionBoxItem);
           
            try
            {

                for (int b = 0; b < Controle.contador; b++)
                {
                    if (Controle.competidores[b].Nome == selecionado)
                    {
                        if (Controle.competidores[b].Sexo == 'F')
                        {
                            Controle.indiceCompetidores = b;
                            Controle.nome = selecionado;
                            modalidadesFemininas.ShowDialog();
                        }
                        else {Controle.indiceCompetidores=b; modalidadesMasculinas.ShowDialog(); }
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

