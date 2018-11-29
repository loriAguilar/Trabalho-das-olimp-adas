using System.Collections.Generic;
using System.IO;

namespace Olimpiadas_trabalho
{
    /// <summary>
    /// Salvamento e Carregamento de arquivos
    /// </summary>
    static class Arquivos
    {
        #region Leitura e Escrita (Atletas)

        #region Escrita (Atletas)
        /// <summary>
        /// Salva no arquivo Atletas.txt, os atletas contidos na lista de atletas
        /// </summary>
        /// <param name="atleta"></param>
        public static void Salvar(List<Atleta> atleta)
        {
            Carregar(atleta);
            StreamWriter salvos = new StreamWriter("Atletas.txt"); //Caso o arquivo já exista adiciona-se mais linhas

            foreach (var item in atleta)
            {
                //Escreve no arquivo na seguinte ordem: Nome; País; Comitê; Sexo
                if (item != null)
                {
                    salvos.WriteLine("{0};{1};{2};{3}", item.Nome, item.Pais, item.Comite, item.Sexo);
                }
            }
            salvos.Close();
        }
        #endregion

        #region Leitura (Atletas)
        /// <summary>
        /// Carrega para a lista de atletas os atletas salvos no arquivo de Atletas
        /// </summary>
        /// <param name="atleta"></param>
        public static void Carregar(List<Atleta> atleta) //Carrega para a lista de atletas os atletas salvos no arquivo de Atletas
        {
            if (File.Exists("Atletas.txt"))
            {
                StreamReader load = new StreamReader("Atletas.txt");

                string[] linha;

                while (!load.EndOfStream) //Lê até o final do arquivo
                {
                    linha = load.ReadLine().Split(';');
                    Atleta item = new Atleta(linha[0], linha[1], linha[2], char.Parse(linha[3])); //Cria um atleta com as informações da linha

                    if (!Cadastrado(atleta, item)) //Caso o atleta não esteja cadastrado adiciona-se à lista de atletas
                        atleta.Add(item);
                }
                load.Close();
            }
        }
        #endregion

        #endregion

        #region Leitura e Escrita (Competições)

        #region Escrita (Competições)
        public static void Salvar(List<Competicao> competicoes)
        {
            Carregar(competicoes);
            StreamWriter salvos = new StreamWriter("Atletas.txt"); //Caso o arquivo já exista adiciona-se mais linhas

            string[] passou;

            foreach (var item in competicoes)
            {                
                if (item != null)
                {
                    passou = new string[item.Passou.Length];
                    for (int i = 0; i < item.Passou.Length; i++)
                    {
                        if (item.Passou[i] == true)
                            passou[i] = "1";
                        else
                            passou[i] = "0";
                    }
                    //Escreve no arquivo na seguinte ordem: IdAtleta, NomeCompleto, Passou1, Passou2, Notas1, Nota2, Nota3
                    salvos.WriteLine("{0};{1};{2};{3};{4};{5};{6}", item.NomeCompeticao, item.IdAtleta, passou[0], passou[1], item.Notas[0], item.Notas[1], item.Notas[3]);

                }
            }
            salvos.Close();
        }
        #endregion

        #region Leitura (Competições)
        public static void Carregar(List<Competicao> competicoes)
        {
            if (File.Exists("Competicoes.txt"))
            {
                StreamReader load = new StreamReader("Competicoes.txt");

                string[] linha;

                while (!load.EndOfStream) //Lê até o final do arquivo
                {
                    linha = load.ReadLine().Split(';');
                    Competicao item = new Competicao(linha[0], int.Parse(linha[1])); //Cria uma competição com as informações da linha

                    if (linha[2] == "1")
                        item.Passou[0] = true;
                    else if (linha[3] == "0")
                        item.Passou[1] = false;

                    item.Notas[0] = int.Parse(linha[4]);
                    item.Notas[1] = int.Parse(linha[5]);
                    item.Notas[2] = int.Parse(linha[6]);

                    if (!Cadastrado(competicoes, item)) //Caso a competição não esteja cadastrado adiciona-se à lista de atletas
                        competicoes.Add(item);
                }
                load.Close();
            }


        }
        #endregion        

        #endregion

        #region Verificação de cadastros duplicados
        private static bool Cadastrado(List<Atleta> atletas, Atleta atleta) //Verifica se um atleta já está cadastrado na lista de atletas
        {
            bool Existe = false;

            foreach (var item in atletas)
            {
                if (atleta.Nome == item.Nome)
                    Existe = true;
            }

            return (Existe);
        }
        private static bool Cadastrado(List<Competicao> competicoes, Competicao competicao) //Verifica se um atleta já está cadastrado na lista de 
        {
            bool Existe = false;

            foreach (var item in competicoes)
            {
                if (competicao.IdAtleta == item.IdAtleta)
                    Existe = true;
            }

            return (Existe);
        }
        #endregion
    }
}
