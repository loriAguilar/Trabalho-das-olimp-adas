using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    //teste
    class Atleta
    {
        protected string nome;
        protected string pais;
        protected string comite;
        protected char sexo;
        // private Competicao_feminina competidora; //relção de composição com atleta, sem atleta, não tem competidores
        //private Competicao_masculina competidor;

        //construtores classe atleta
        public Atleta()
        {
            this.nome = null;
            this.pais = null;
            this.comite = null;
        }

        public Atleta(string nome, string pais, string comite, char sexo) //passado por parâmetro através das competições masculina e feminina
        {
            this.Nome = nome;
            this.Pais = pais;
            this.Comite = comite;
            this.Sexo = sexo;
            //this.Competidora = new Competicao_feminina();
            //this.Competidor = new Competicao_masculina();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }




        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Comite
        {
            get { return comite; }
            set { comite = value; }
        }

        /* public Competicao_feminina Competidora
         {
             get { return competidora; }
             set { competidora = value; }
         }

         public Competicao_masculina Competidor
         {
             get { return competidor; }
             set { competidor = value; }
         }*/
    }
}

