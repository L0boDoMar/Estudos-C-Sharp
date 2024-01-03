Album albumPinkFloyd = new Album();
albumPinkFloyd.Nome = "Wish You Were Here";

Musica musica1 = new Musica();
musica1.Nome = "Shine On You Crazy Diamond (Pts. 1-5)";
musica1.Duracao = 798;

Musica musica2 = new Musica();
musica2.Nome = "Welcome to the Machine";
musica1.Duracao = 438;

albumPinkFloyd.AddMusica(musica1);
albumPinkFloyd.AddMusica(musica2);

albumPinkFloyd.MostrarMusicas();


