Banda banda1 = new Banda("Pink Floyd");

Album album1 = new Album("Wish You Were Here");

Musica musica1 = new Musica(banda1, "Shine On You Crazy Diamond (Pts. 1-5)")
{
    Duracao = 798,
    Disponivel = true
};


Musica musica2 = new Musica(banda1, "Welcome to the Machine") 
{
    Duracao = 438,
    Disponivel = false
};


album1.AddMusica(musica1);
album1.AddMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

album1.MostrarMusicas();


banda1.AddAlbum(album1);
banda1.ExibirDiscografia();

Console.WriteLine("\nPodcasts:");

Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AddConvidados("Maria");
ep1.AddConvidados("Marcio");


Episodio ep2 = new(2, "Técnicas de aprendizado", 63);
ep2.AddConvidados("João");
ep2.AddConvidados("Joana");
ep2.AddConvidados("José");
ep2.AddConvidados("Júlia");

Podcast podcast = new("Podcast DIFF", "Lucas");
podcast.AddEp(ep1);
podcast.AddEp(ep2);
podcast.ExibirDetalhes();

