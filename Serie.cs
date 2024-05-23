using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC_exercicio_1
{
    public class Serie : ItemLocadora
    {
        public int Temporadas {get; set;}
        public int Episodios {get; set;}

        public Serie(int codigo, string titulo, int ano, int temporada, int episodios) : base(codigo, titulo,  ano)
        {
            Temporadas = temporada;
            Episodios = episodios;
        }
    }
}