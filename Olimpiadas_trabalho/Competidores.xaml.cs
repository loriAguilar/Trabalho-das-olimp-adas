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
    /// Lógica interna para Competidores.xaml
    /// </summary>
    public partial class Competidores : Window
    {
        public Competidores()
        {
            InitializeComponent();
        }

        //inscrever atleta para competição feminina //só os dados do atleta
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dados_dos_atletas dados = new Dados_dos_atletas();
            dados.ShowDialog();
            string nome, pais, comite;
            char sexo = 'F';
            nome = dados.textnome.Text;
            pais = dados.texboxpais.Text;
            comite = dados.texboxcomite.Text;
            Atleta x;
            x = new Atleta(nome, pais, comite, sexo);
            Controle.atletas.Add(x);
            Controle.indiceAtleta++;
            this.Close();
        }

        //inscrever atleta para competição masculina //só os dados do atleta
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dados_dos_atletas dados = new Dados_dos_atletas();
            dados.ShowDialog();
            string nome, pais, comite;
            char sexo = 'M';
            nome = dados.textnome.Text;
            pais = dados.texboxpais.Text;
            comite = dados.texboxcomite.Text;
            Atleta x;
            x = new Atleta(nome, pais, comite, sexo);
            Controle.atletas.Add(x);
            Controle.indiceAtleta++;
            this.Close();
        }

        //botão responsável por desencadear o evento "sair"
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();

            Nomesparamodalidades nomes = new Nomesparamodalidades();
            nomes.ShowDialog();
        }
    }
}

