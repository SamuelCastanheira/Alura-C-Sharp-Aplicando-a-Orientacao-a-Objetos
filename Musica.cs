class Musica {
    public string Nome { get;}
    public Banda banda { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {banda}";

    public Musica(string nome, string banda) 
    { 
        Nome = nome;

        if (!Banda.bandas.ContainsKey(banda))
        {
            this.banda = new Banda(banda);
        }
        else 
        {
            this.banda = Banda.bandas[banda] ;
        }
    }


    public void ExibirFichaTecica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {banda.Nome}");
        Console.WriteLine($"Dração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine();
    }

    public void ExibirInfos()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {banda}");
        Console.WriteLine();
    }

    public void toString() {
        Console.WriteLine(Nome);
    }
}