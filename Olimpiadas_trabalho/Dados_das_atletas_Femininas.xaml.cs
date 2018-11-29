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
    /// Lógica interna para Dados_das_atletas_Femininas.xaml
    /// </summary>
    public partial class Dados_das_atletas_Femininas : Window
    {
        public Dados_das_atletas_Femininas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // cadastra o atleta
            Controle.Cadastrar_Atleta_na_Olimpiada('F', textnome.Text, comboBox_Paises.Text, comboBox_Comite.Text);            

            // exibe confirmação de cadastro
            MessageBox.Show(".:Cadastro concluído com sucesso:. \nNome: " + textnome.Text + " \nPaís: " + comboBox_Paises.Text + " \nComitê: " + comboBox_Comite.Text);
            Salvar_arquivo();

            // limpa os elementos da janela
            textnome.Clear();
            comboBox_Comite.SelectedItem = null;
            comboBox_Paises.SelectedItem = null;
        }

        public void Salvar_arquivo()
        {
            try
            {
                Controle.Relatorio_Atletas();
            }
            catch (Exception pl)
            {
                MessageBox.Show(pl.Message);
            }
        }

        // evento associado ao botão sair
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
