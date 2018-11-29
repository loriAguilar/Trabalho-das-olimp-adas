using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Olimpiadas_trabalho
{
    /// <summary>
    /// Lógica interna para Dados_dos_atletas.xaml
    /// </summary>
    public partial class Dados_dos_atletas : Window
    {

        public Dados_dos_atletas()
        {
            InitializeComponent();
            

        }

        //gera o evento "cadastrar"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // cadastra o atleta
            Controle.Cadastrar_Atleta_na_Olimpiada('M', textnome.Text, comboBox_Paises.Text, comboBox_Comite.Text);
            // exibe confirmação de cadastro
            MessageBox.Show(".:Cadastro concluído com sucesso:. \nNome: " + textnome.Text + " \nPaís: " + comboBox_Paises.Text + " \nComitê: " + comboBox_Comite.Text);
            Salvar_arquivo();

            // limpa os elementos da janela
            textnome.Clear();
            comboBox_Comite.SelectedItem = null;
            comboBox_Paises.SelectedItem = null;
        }

        #region arquivo
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
        #endregion

        //gera o evento "sair"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textnome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

