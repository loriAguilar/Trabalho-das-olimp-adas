using System.Collections.Generic;
using System.IO;

namespace Olimpiadas_trabalho
{
    static class Arquivos
    {
        public static void Salvar(List<Atleta> atleta) //Salva no arquivo Atletas.txt, os atletas contidos na lista de atletas
        {
            Carregar(atleta);
            StreamWriter salvos = new StreamWriter("Atletas.txt", true); //Caso o arquivo já exista adiciona-se mais linhas

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

                    if (Cadastrado(atleta, item)) //Caso o atleta não esteja cadastrado adiciona-se à lista de atletas
                        atleta.Add(item);


                }
            }
        }

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
    }
}
