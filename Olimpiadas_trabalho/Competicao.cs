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
        private double[] notas = new double[3];
        private int idAtleta;

        #region Getters e Setters
        public int IdAtleta
        {
            get { return idAtleta; }
            set { idAtleta = value; }
        }
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
