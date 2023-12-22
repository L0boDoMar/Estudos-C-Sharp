//Caracteristicas comuns às músicas

class Musica
{ 
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Artista: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira no plano plus\n");
        }
    }

}