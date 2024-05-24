namespace FC_exercicio_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Helloooo, World!");
        Filme filme = new Filme(1, "Casa blanca", 1970, "Rafael", 120);
        Console.WriteLine(filme.Titulo);
        filme.ExibirDetalhes();
    }
}
