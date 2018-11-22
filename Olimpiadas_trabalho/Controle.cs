using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    class Controle
    {
        //Está cadastrando direitinho
        public static List<Atleta> atletas = new List<Atleta>();
        public static List<Competicao> competicoes = new List<Competicao>();
        public static int indiceAtleta=0;
        public static int aux ;

        
        public static string nomedamodalidade;
        public const int tam = 10;
        public static int contador = 0;
        public static string nome = null;


        #region verifica se pode abrir as janelas
        public static double notaMinima = -1; //considerada nota não preenchida
        public static bool telaCadastroEstaDeativada = false, telaFaseEliminatoriaEstaDesativada = false, telaFaseFinalEstaDesativada = false;

        public static bool abrirFase(int fase)
        {
            ///verifica se todas as notas foram preenchidas
            for(int pos = 0; pos < competicoes.Count; pos++)
                if (competicoes[pos].Notas[fase - 1] == notaMinima)
                    return false;
            
            return true;
        }
        #endregion
    }


}
