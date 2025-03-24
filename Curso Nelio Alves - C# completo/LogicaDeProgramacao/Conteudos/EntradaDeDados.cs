namespace LogicaDeProgramacao.Conteudos;

public class EntradaDeDados
{
    public void LerUmDado() { 
        string frase = Console.ReadLine();
        Console.WriteLine($"Você digitou:  {frase}");
    }

    public void LerDados() { 
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();

        Console.WriteLine($"Você digitou: {x}, {y} e {z}");
        
    }   

    public void LerDadosComEspaço()
    {
        string[] palavras = Console.ReadLine().Split(' ');

        foreach(var palavra in palavras)
        {
           Console.WriteLine(palavra);
        }
    }

    public void LerNumeroInteiro()
    {
        int n1 = int.Parse(Console.ReadLine());
    }

    public void LerChar()
    {
        char ch = char.Parse(Console.ReadLine());
    }

    public void LerDouble()
    {
        double n1 = double.Parse(Console.ReadLine());
    }

}
