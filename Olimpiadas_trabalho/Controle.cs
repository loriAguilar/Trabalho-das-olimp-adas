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



        public static string nomedamodalidade;
        public const int tam = 10;
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

        public static void OrdenarVetorFem()
        {
            int aux1 = 0, aux2 = 0, aux3 = 0, aux4 = 0, aux5 = 0, aux6 = 0, aux7 = 0, aux8 = 0, aux9 = 0;
            
            try
            {


                for (int a = 0; a < competicoes.Count; a++)
                {
                    

                    if (competicoes[a].NomeCompeticao == "pistoladear") //pistoladear -feminino e masculino
                    {
                        aux1++;
                        int[] vet1 = new int[aux1];
                        int menorpos, aux;
                        for(int h=0;h<aux1;h++)
                        {
                            vet1[h] = competicoes[h].IdAtleta;
                        }

                        for(int posicao=0;posicao<aux1;posicao++)
                        {
                            menorpos = posicao;
                            for(int po=posicao+1;po<aux1;po++)
                            {
                                if(competicoes[menorpos].Notas[0]>competicoes[po].Notas[0])
                                {
                                    menorpos = po;
                                }
                            }

                            aux = vet1[posicao];
                            vet1[posicao] = competicoes[menorpos].IdAtleta;
                            
                        }


                        string ven = "Vencedor: " + Convert.ToString(vet1[0]);
                        System.Windows.MessageBox.Show(ven);


                    }
                    else if (competicoes[a].NomeCompeticao == "carabinadear") //carabinadear-feminino e masculino
                    {
                        aux2++;
                        int[] vet2 = new int[aux2];
                    }
                    else if (competicoes[a].NomeCompeticao == "pistola") // pistola-feminino e masculino
                    {
                        aux3++;
                        int[] vet3 = new int[aux3];
                    }

                    else if (competicoes[a].NomeCompeticao == "carabinatrespos") //carabinatrespos-feminino e masculino
                    {

                        aux4++;
                        int[] vet4= new int[aux4];
                    }

                    else if (competicoes[a].NomeCompeticao == "skeet") //skeet-feminino e masculino
                    {
                        aux5++;
                        int[] vet5 = new int[aux5];
                    }

                    else if(competicoes[a].NomeCompeticao=="fossa") //fossa- feminino e masculino
                    {
                        aux6++;
                        int[] vet6 = new int[aux6];
                    }

                    else if(competicoes[a].NomeCompeticao=="pistola50m") //pistola50m-masculino
                    {
                        aux7++;
                        int[] vet7 = new int[aux7];
                    }
                    else if(competicoes[a].NomeCompeticao=="carabinadeitado") //carabinadeitado - masculino
                    {
                        aux8++;
                        int[] vet8 = new int[aux8];
                    }
                    else //fossaolimpicadupla-masculino
                    {
                        aux9++;
                        int[] vet9 = new int[aux9];
                    }

                }

            }
            catch (Exception ç)
            {
                System.Windows.MessageBox.Show(ç.Message);
            }
    }


}
