
using System.Threading.Tasks.Dataflow;

class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public string Host { get;}
    public string Nome { get;}
    public int TotalEpisodios  => episodios.Count;

    public Podcast(string host, string nome) 
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionaEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void  ExibirDetalhes() {
        Console.WriteLine($"{Nome} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e=>e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Esse podcast possui {TotalEpisodios} episódios");
        Console.WriteLine();
        Console.WriteLine();
    }
}

