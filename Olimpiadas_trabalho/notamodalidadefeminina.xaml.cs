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

namespace Olimpiadas_trabalho
{
    /// <summary>
    /// Lógica interna para notamodalidadefeminina.xaml
    /// </summary>
    public partial class notamodalidadefeminina : Window
    {
        public int fase;

        public notamodalidadefeminina(int fase)
        {
            InitializeComponent();
            this.fase = fase;
            labelNomeModalidade.Content = Controle.nomedamodalidade;

            try
            {
                for (int a = 0; a < (Controle.competicoes.Count); a++)
                {
                    if (Controle.competicoes[a].NomeCompeticao == Controle.nomedamodalidade)
                    {
                        if (Controle.atletas[a].Sexo == 'F')
                        {
                            Controle.indiceAtleta = Controle.competicoes[a].IdAtleta;
                            notas.Items.Add(Controle.atletas[Controle.indiceAtleta].Nome.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }

        #region cadastrar nota
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double nota = Convert.ToDouble(notatexto.Text);
                Controle.competicoes[Controle.indiceAtleta].cadastrarNota(fase, nota);
                MessageBox.Show("Cadastro efetuado com sucesso!");
                notatexto.Clear();
            }
            catch(FormatException)
            {
                MessageBox.Show("Digite um valor válido", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                notatexto.Clear();
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

        }
        #endregion

        #region sair
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();
            
        }
        #endregion

        #region avançar
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Controle.OrdenarVetor(fase);
        }
        #endregion
    }
}
