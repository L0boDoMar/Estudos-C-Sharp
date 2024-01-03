
class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);  //soma a duração das músicas presentes na lista Musica

    public void AddMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void MostrarMusicas()
    {
        Console.WriteLine($"Músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"Duração do Álbum: {DuracaoTotal} s");
    }
}