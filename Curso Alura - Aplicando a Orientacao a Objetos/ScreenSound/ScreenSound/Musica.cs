//Caracteristicas comuns às músicas

class Musica
{
    /*
        - Usar 'prop' para criar os atributos
        - Atributos começam com maiúscula 
    */

    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    //Lambda - operação de somente leitura
    public string DescricaoResumida => $"A música {Nome} Pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Artista: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira no plano plus\n");
        }
    }

}