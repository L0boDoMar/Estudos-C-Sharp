namespace LogicaDeProgramacao.Conteudos;

public class ConvercaoECasting
{
    public static void AulaConvercaoECasting()
    {
        //Conversão implicita de float para double
        float x = 4.5f;
        double y = x;
        Console.WriteLine(y);

        //Conversão explicita de double para float (o valor 'a' ocupa mais espaço na memoria do que o valor 'b' de modo que é necessario converter explicitamente a variavel para que a atribuição seja possivel
        double a = 5.1;
        float b = (float)a;
        Console.WriteLine(b);

        //O casting é realizado, porém os dados serão truncados no casting
        int c = (int)a;
        Console.WriteLine(c);

        //Nesse caso o compilador entende que esta é uma divisão inteira. Para que o resultado seja double, será necessário realizar um casting para double
        int d = 5;
        int e = 2;
        int resultado = d / e;
        Console.WriteLine(resultado);
    }
}
