class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public Banda Banda { get; }
    public Genero Genero { get; set; }
    public int DuraçãoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome, string banda)
    {
        Nome = nome;
        if (!Banda.bandas.ContainsKey(banda))
        {
            this.Banda = new Banda(banda);
        }
        else
        {
            this.Banda = Banda.bandas[banda];
        }
    }


    public void AdicionarMusica(Musica musica)
    { 
        musicas.Add(musica);
    }

    public void ExibirFaixas() {
        Console.WriteLine($"Album: {Nome}");
        Console.WriteLine($"Artista/banda: {Banda.Nome}");
        foreach (Musica musica in musicas) { 
        Console.WriteLine($"Musica: { musica.Nome}");
        }
        Console.WriteLine($"Duração total: {DuraçãoTotal}s");
        Console.WriteLine();
    }

    public void toString() {
        Console.WriteLine(Nome);
    }

}