using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    class Competicao
    {
        private string nomeCompeticao;
        private double[] notas = new double[3];
        private int idAtleta;

        #region Getters e Setters
        public int IdAtleta
        {
            get { return idAtleta; }
            private set { idAtleta = value; }
        }
        public string NomeCompeticao
        {
            get { return NomeCompeticao; }
            private set { nomeCompeticao = value; }
        }
        public double[] Notas
        {
            get { return notas; }
            private set { notas = value; }
        }

        #endregion

        #region Construtor
        public Competicao(string nome, int idAtleta)
        {
            NomeCompeticao = nome;
            this.IdAtleta = idAtleta;
        }
        #endregion

        public void cadastrarNota(int fase, double nota)
        {
            notas[fase - 1] = nota;
        }
    }
}
