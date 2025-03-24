namespace LogicaDeProgramacao.Conteudos;

public class TiposDeDados
{
    public static void AulaTiposDeDados()
    {
        bool completo = false;
        string nome = "Maria Green";
        char genero = 'F';
        char valorUnicode = '\u0041';
        byte n1 = 255;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 2147483648L;
        float n5 = 4.5f;
        double n6 = 4.5;
        object obj1 = "Alex Brown";
        object obj2 = 4.5f;

        Console.WriteLine(completo);
        Console.WriteLine(nome);
        Console.WriteLine(genero);
        Console.WriteLine(valorUnicode);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(obj1);
        Console.WriteLine(obj2);

        n2 = int.MinValue;
        n3 = int.MaxValue;
        decimal n7 = decimal.MaxValue;

        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n7);
    }
}
