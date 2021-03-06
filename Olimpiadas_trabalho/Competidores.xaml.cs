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
            
            Dados_das_atletas_Femininas dados = new Dados_das_atletas_Femininas();
            dados.ShowDialog();
            //Controle.Cadastrar_Atleta_na_Olimpiada('F');
        }

        //inscrever atleta para competição masculina //só os dados do atleta
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            Dados_dos_atletas dados = new Dados_dos_atletas();
            dados.ShowDialog();
            //Controle.Cadastrar_Atleta_na_Olimpiada('M');
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

