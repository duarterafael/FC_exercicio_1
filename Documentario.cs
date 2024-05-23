using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FC_exercicio_1
{
    public class Documentario : ItemLocadora
    {
        public string Assunto { get; set; }

        public Documentario(int codigo, string titulo, int ano, string assunto) : base(codigo, titulo, ano)
        {
            Assunto = assunto;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Documentário: {Titulo}, Assunto: {Assunto}, Ano: {Ano}");
        }
    }
}