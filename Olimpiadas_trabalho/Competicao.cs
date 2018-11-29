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
        private bool[] passou = new bool[2];
        private int idAtleta;

        #region Getters e Setters
        public bool[] Passou
        {
            get { return passou;}
            private set { passou = value; }
        }
        public int IdAtleta
        {
            get { return idAtleta; }
            private set { idAtleta = value; }
        }
        public string NomeCompeticao
        {
            get { return nomeCompeticao; }
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
            for (int pos = 0; pos < passou.Length; pos++)
                passou[pos] = false;
            for (int pos = 0; pos < notas.Length; pos++)
                notas[pos] = Controle.notaMinima;
           
        }
        #endregion

        public void cadastrarNota(int fase, double nota)
        {
            notas[fase - 1] = nota;
        }
    }
}
