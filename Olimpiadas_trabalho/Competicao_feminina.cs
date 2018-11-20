using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    class Competicao_feminina:Atleta
    {
        protected bool[] competicao_disputada = new bool[5];
        // protected readonly string[] tipos = new string[] { "Pistola de ar 10 m", "Carabina de ar 10 m", "Pistola 25 m", "Carabina três posições 50 m", "Skeet", "Fossa olímpica" };

        public Competicao_feminina() //construtor para inicializar tudo como nulo ou 0
        {

            for (int a = 0; a < competicao_disputada.Length; a++)
            {
                this.competicao_disputada[a] = false;
            }
        }

        //construtor para incializar tudo com valores recebidos por parâmetro
        public Competicao_feminina(string name, string country, string com, char sexo) : base(name, country, com, sexo)
        {

        }


        public bool[] Competicao_disputada
        {
            get { return competicao_disputada; }
            set { competicao_disputada = value; }
        }
    }

}
