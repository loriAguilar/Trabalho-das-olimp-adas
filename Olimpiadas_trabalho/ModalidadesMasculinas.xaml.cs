﻿using System;
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
    /// Lógica interna para ModalidadesMasculinas.xaml
    /// </summary>
    public partial class ModalidadesMasculinas : Window
    {
        public ModalidadesMasculinas()
        {
            InitializeComponent();
            
        }

        //evento cadastrar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int indiceParaCadastrar = Controle.indiceAtleta;
            Competicao ajd;

            if (pistoladear.IsChecked == true)
            {
                ajd = new Competicao("pistoladear", Controle.indiceAtleta);
                Controle.pistoladear++;
                Controle.competicoes.Add(ajd);
            }

            if (carabinadear.IsChecked == true)
            {
                ajd = new Competicao("carabinadear", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            if (pistolarapida25m.IsChecked == true)
            {
                ajd = new Competicao("pistola", Controle.indiceAtleta); //25 metros
                Controle.competicoes.Add(ajd);
            }

            if (pistola.IsChecked == true)
            {
                ajd = new Competicao("pistola50m", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            if (carabina.IsChecked == true)
            {
                ajd = new Competicao("carabinadeitado", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            if (carabinatrespos.IsChecked == true)
            {
                ajd = new Competicao("carabinatrespos", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            if (skeet.IsChecked == true)
            {
                ajd = new Competicao("skeet", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            if (fossaolimpica.IsChecked == true)
            {
                ajd = new Competicao("fossa", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            if (fossaolimpicadupla.IsChecked == true)
            {
                ajd = new Competicao("fossaolimpicadupla", Controle.indiceAtleta);
                Controle.competicoes.Add(ajd);
            }

            MessageBox.Show("Cadastro concluído com sucesso");
            SalvaarquivoM();
            Close();
        }

        //evento sair
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void SalvaarquivoM()
        {
            string path2 = "CompetidoresCompeticaoMasculina.txt";
            try
            {
                if (!File.Exists(path2))
                {
                    StreamWriter criar = new StreamWriter(path2);
                    criar.Close();
                }

                StreamWriter arquivo = new StreamWriter(path2);

                arquivo.WriteLine("Nome: " + Controle.atletas[Controle.indiceAtleta].Nome);
                for (int a = 0; a < Controle.competicoes.Count; a++)
                {
                    arquivo.WriteLine("Competição {0}: {1} ", (a + 1), Controle.competicoes[a].NomeCompeticao);
                }


                arquivo.Close();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }
    }
}
