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
using System.IO;

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
           // Salvar_arquivo();


        }
        #region arquivo
        public void Salvar_arquivo()
        {
            try
            {
                string path = "atletassalvos.txt";
                if (!File.Exists(path))
                {
                    StreamWriter criararquivo = new StreamWriter(path);
                    criararquivo.Close();
                }
                
                StreamWriter arquivo = new StreamWriter(path);
                for (int i = 0; i < Controle.aux; i++)
                {
                    arquivo.WriteLine(".:ATLETAS CADASTRADOS:.");
                    arquivo.WriteLine("{0}º Atleta ", Controle.atletas[i]);
                    arquivo.WriteLine("Nome: " + Controle.atletas[i].Nome);
                    arquivo.WriteLine("País: " + Controle.atletas[i].Pais);
                    arquivo.WriteLine("Comitê: " + Controle.atletas[i].Comite);
                    arquivo.WriteLine("Sexo: " + Controle.atletas[i].Sexo);
                    arquivo.WriteLine("---------------------------------------------------------------------------------------------------------------");
                }
                arquivo.Close();
            }
            catch(Exception pl)
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

