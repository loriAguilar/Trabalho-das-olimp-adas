using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    class Atleta
    {
        //teste
        private string nome;
        private string pais;
        private string comite;
        private char sexo;
        private int contaCompeticoes = 0;
        public List<Competicao> comp = new List<Competicao>(); //relção de composição com atleta, sem atleta, não tem competidores

        #region Construtores
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
        }
        #endregion

        #region Getters and Setters
        public int ContaCompetidores
        {
            get { return contaCompeticoes; }
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
        #endregion
        
        public void cadastrarCompeticao(string nome)
        {
            //cadastrar competição
            Competicao a = new Competicao(nome);
            
            comp.Add(a);
            contaCompeticoes++;
        }
    }
}

