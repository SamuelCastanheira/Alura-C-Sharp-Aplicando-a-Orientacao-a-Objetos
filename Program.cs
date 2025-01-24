Banda Queen = new Banda("Queen");

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
albumDoQueen.ExibirFaixas();