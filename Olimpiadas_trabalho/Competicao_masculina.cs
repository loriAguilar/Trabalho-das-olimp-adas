using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas_trabalho
{
    class Competicao_masculina:Atleta
    {
        
            protected string[] competicao_disputada = new string[9]; //quantas competições? Definir um máximo?
                                                                     //protected readonly string[] tipos = new string[] { "Pistola de ar 10 m", "Carabina de ar 10 m", "Pistola 25 m", "Carabina três posições 50 m", "Skeet", "Fossa olímpica" };

            //construtor para inicializar todos os atributos como nulos ou 0
            public Competicao_masculina()
            {

                for (int c = 0; c < competicao_disputada.Length; c++)
                {
                    this.competicao_disputada[c] = null;
                }

            }

            //construtor para inicializar os atributos com os valores passados por parâmetro
            public Competicao_masculina(string name, string country, string com, char sexo) : base(name, country, com, sexo)
            {

            }

            //propriedades para agregar valor aos atributos

            public string[] Competicao_disputada
            {
                get { return competicao_disputada; }
                set { competicao_disputada = value; }
            }
        }

    }

