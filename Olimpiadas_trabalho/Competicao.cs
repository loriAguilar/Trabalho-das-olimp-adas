using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    class Competicao
    {
        public string nomeCompeticao;
        private double[] notas = new double[2];

        #region Getters e Setters
        public string NomeCompeticao
        {
            get { return NomeCompeticao; }
            set { nomeCompeticao = value; }
        }
        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        #endregion

        #region Construtor
        public Competicao(string nome)
        {
            NomeCompeticao = nome;
        }
        #endregion

        public void cadastrarNota(int fase, double nota)
        {
            notas[fase - 1] = nota;
        }
    }
}
