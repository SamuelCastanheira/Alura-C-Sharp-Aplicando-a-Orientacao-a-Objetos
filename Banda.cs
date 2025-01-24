using System.Security.Cryptography;

class Banda
{
    static public readonly Dictionary <string,Banda> bandas = new Dictionary<string,Banda>();
    private List<Album> albums = new List<Album>(); 
    public string Nome { get; set; }
    public string Descricao { get;}

    public Banda(string nome) 
    {
        if (bandas.ContainsKey(nome))
        {
            Console.WriteLine("Banda já existente");
            return;
        }
        else {
            Nome = nome;
            bandas.Add(nome, this);
            Descricao = AdicionarDescricao();
        }
    }

    public void AdicionaAlbum (Album album)
    {
        albums.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums) {
            Console.WriteLine($"Album: {album} ({album.DuraçãoTotal}s)");
        }
        Console.WriteLine();
    }

    private string AdicionarDescricao() {
        Console.Write("Adicione uma descrição a banda: ");
        string descricao = Console.ReadLine();
        return descricao;
    }

    public void toString() {
        Console.WriteLine(Nome);
    }
}
