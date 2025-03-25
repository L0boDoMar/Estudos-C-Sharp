namespace LogicaDeProgramacao.Conteudos;

public class OperadoresLogicos
{
    public static void AulaOperadoresLogicos()
    {
        // ordem de interpretação: ! -> && -> ||

        bool c1 = 2 > 3 && 4 != 5;
        bool c2 = 2 > 3 || 4 != 5;
        bool c3 = !(2>3) && 4 != 5;

        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);

        bool c4 = 10 < 5;

        bool c5 = c1 || c2 && c3;

        Console.WriteLine(c5);
    }
}
