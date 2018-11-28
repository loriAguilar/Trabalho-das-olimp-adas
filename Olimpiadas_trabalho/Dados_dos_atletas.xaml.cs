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

            MessageBox.Show(".:Cadastro concluído com sucesso:. \nNome: " + textnome.Text + " \nPaís: " + texboxpais.Text + " \nComitê: " + texboxcomite.Text);
            Salvar_arquivo();
        }
        #region arquivo
        public void Salvar_arquivo()
        {
            try
            {
                string path = "atletassalvos.txt";
                StreamWriter arquivo = new StreamWriter(path);
                int index = 0;
                arquivo.WriteLine(".:ATLETAS CADASTRADOS:.");
                foreach (var item in Controle.atletas)
                {
                    index++;                    
                    arquivo.WriteLine("{0}º Atleta ", index);
                    arquivo.WriteLine("Nome: " + item.Nome);
                    arquivo.WriteLine("País: " + item.Pais);
                    arquivo.WriteLine("Comitê: " + item.Comite);
                    arquivo.WriteLine("Sexo: " + item.Sexo);
                    arquivo.WriteLine("---------------------------------------------------------------------------------------------------------------");
                }

                arquivo.Close();
                Arquivos.Salvar(Controle.atletas);
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

        private void texboxpais_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void texboxcomite_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

