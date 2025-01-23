using System.Runtime.ExceptionServices;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public string Artista { get; set; }
    public Genero Genero { get; set; }
    public int DuraçãoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    { 
        musicas.Add(musica);
    }

    public void ExibirFaixas() {
        Console.WriteLine($"Album: {Nome}");
        Console.WriteLine($"Artista/banda: {Artista}");
        Console.WriteLine($"Genero: {Genero.Nome}");
        foreach (Musica musica in musicas) { 
        Console.WriteLine($"Musica: { musica.Nome}");
        }
        Console.WriteLine($"Duração total: {DuraçãoTotal}s");
        Console.WriteLine();
    }


}