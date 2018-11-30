using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olimpiadas_trabalho
{
    class Controle
    {
        //Está cadastrando direitinho
        public static List<Atleta> atletas = new List<Atleta>();
        public static List<Competicao> competicoes = new List<Competicao>();

        public static int indiceAtleta = 0;
        public static int aux;
        public static int comfem = 6;
        public static int pistoladear = 0;
        public const int tam = 10;

        public static string nomedamodalidade;
        // public static int contador = 0;
        public static string nome = null;

        #region verifica se pode abrir as janelas
        public static double notaMinima = -1; //considerada nota não preenchida
        public static bool telaCadastroEstaDeativada = false, telaFaseEliminatoriaEstaDesativada = false, telaFaseFinalEstaDesativada = false;

        public static bool abrirFase(int fase)
        {
            ///verifica se todas as notas foram preenchidas
            for (int pos = 0; pos < competicoes.Count; pos++)
                if (competicoes[pos].Notas[fase - 1] == notaMinima)
                    return false;

            return true;
        }
        #endregion

        //utilizados nas partes de competição feminina

        public static void Cadastrar_Atleta_na_Olimpiada(char sexo, string nome, string pais, string comite)
        {
            aux++;
            Atleta x;
            x = new Atleta(nome, pais, comite, sexo);
            atletas.Add(x);
            indiceAtleta++;
        }

        public static void Relatorio_Atletas()
        {
            string path = "atletassalvos.txt";
            StreamWriter arquivo = new StreamWriter(path);
            int index = 0;
            arquivo.WriteLine(".:ATLETAS CADASTRADOS:.");

            foreach (var item in atletas)
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
            Arquivos.Salvar(atletas);

        }

        public static void OrdenarVetor(int fase)
        {

            #region ordenando certo
            try { 
                int quantidadeCompeticoes = 1;
                string modalidadeSeraOrdenada;

                for (int comp = 0; comp < quantidadeCompeticoes; comp++)
                {
                    if (comp == 0)
                        modalidadeSeraOrdenada = "pistoladear";
                    else if (comp == 1)
                        modalidadeSeraOrdenada = "carabinadear";
                    else if (comp == 2)
                        modalidadeSeraOrdenada = "pistola";
                    else if (comp == 3)
                        modalidadeSeraOrdenada = "carabinatrespos";
                    else if (comp == 4)
                        modalidadeSeraOrdenada = "skeet";
                    else if (comp == 5)
                        modalidadeSeraOrdenada = "fossa";
                    else if (comp == 6)
                        modalidadeSeraOrdenada = "pistola50m";
                    else if (comp == 7)
                        modalidadeSeraOrdenada = "carabinadeitado";
                    else
                        modalidadeSeraOrdenada = "fossaolimpicadupla";



                    int tamanhoVetorFiltrado = 0, posLista = 0, posVetor;

                    //descobrindo o tamanho do vetor
                    foreach (var item in competicoes)
                    {
                        if (competicoes[posLista].NomeCompeticao == modalidadeSeraOrdenada)
                            tamanhoVetorFiltrado++;

                        posLista++;
                    }

                    int[] vetorIndices = new int[tamanhoVetorFiltrado];


                    //atribuindo valores ao vetorIndices
                    posLista = 0; posVetor = 0;
                    foreach (var item in competicoes)
                    {
                        if (competicoes[posLista].NomeCompeticao == modalidadeSeraOrdenada)
                        {
                            vetorIndices[posVetor] = posLista;
                            posVetor++;
                            posLista++;
                        }

                    }

                    //ordenando a partir do vetorIndices
                    int posMaiorNota = vetorIndices[0]; //= vetorIndices[0];
                    Competicao auxiliar;
                    for (posVetor = 0; posVetor < vetorIndices.Length; posVetor++)
                    {                        
                        for (int i = posVetor + 1; i < vetorIndices.Length; i++)
                            if (competicoes[posMaiorNota].Notas[fase] > competicoes[posVetor].Notas[fase])
                                posMaiorNota = posVetor;

                        int auxiliarIndices = vetorIndices[posVetor];
                        vetorIndices[posVetor] = vetorIndices[posMaiorNota];
                        vetorIndices[posMaiorNota] = auxiliarIndices;

                        auxiliar = competicoes[posVetor];
                        competicoes[posVetor] = competicoes[posMaiorNota];
                        competicoes[posMaiorNota] = auxiliar;
                    }
                }

            }
            catch(Exception mistake)
            {
                System.Windows.MessageBox.Show(mistake.Message);
            }

            #endregion
        }
    }

}

