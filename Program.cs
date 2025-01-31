Podcast jovemNerd = new Podcast("Azagal", "JovemNerd");
Episodio ep1 = new Episodio("Senhor dos Aneis",1, 60);
jovemNerd.AdicionaEpisodio(ep1);

Episodio ep2 = new Episodio("D&D",2, 120);
jovemNerd.AdicionaEpisodio(ep2);
jovemNerd.ExibirDetalhes();

Podcast podPah = new Podcast ("Igão", "Podpah");
Episodio podPah300 = new Episodio("Podpah nº 300",podPah.TotalEpisodios+1,150);
podPah.AdicionaEpisodio(podPah300);
podPah.ExibirDetalhes();
podPah300.AdicionarConvidados("Felipe Franco");
podPah300.AdicionarConvidados("Ramon Dino");
Console.WriteLine(podPah300.Resumo);


/*Banda Queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera", "Queen");


Musica musica1 = new Musica("Love of my life", "Queen")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica("Bohemian Rhapsody", "Queen") 
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
Queen.AdicionaAlbum(albumDoQueen);

albumDoQueen.ExibirFaixas();

Queen.ExibirDiscografia();
musica1.ExibirFichaTecica();
musica2.ExibirFichaTecica();
albumDoQueen.ExibirFaixas();*/