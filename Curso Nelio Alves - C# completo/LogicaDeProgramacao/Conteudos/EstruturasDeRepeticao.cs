

using System.Globalization;

namespace LogicaDeProgramacao.Conteudos;

public class EstruturasDeRepeticao
{
    public void ExemploComWhile()
    {
        Console.Write("Digite um número: ");
        double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //true = executa e volta
        //false = não executa
        while (num >= 0)
        {
            double raiz = Math.Sqrt(num);
            Console.WriteLine($"A raíz do número {num} é {raiz.ToString("F3", CultureInfo.InvariantCulture)}");

            Console.Write("Digite outro número: ");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Número negativo =/");
    }

    public void ExemploComFor()
    {
        Console.Write("Quantos números inteiros você vai digitar? ");
        int numeroRepeticoes = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int soma = 0;
        for (int i = 0; i < numeroRepeticoes; i++)
        {
            Console.Write("Digite um número: ");
            int valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma += valor;
        }

        Console.WriteLine($"O valor da soma é {soma}");
    }
}
