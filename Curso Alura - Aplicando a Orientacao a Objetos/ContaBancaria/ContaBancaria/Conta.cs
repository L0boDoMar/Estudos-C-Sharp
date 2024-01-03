public class Conta
{
    public Titular Titular { get; set; }
    public string NumeroConta { get; set; }
    public string Agencia { get; set; }
    public float Saldo { get; set; }
    public float Limite { get; set; }
    public float LimiteTotal => Saldo + Limite;



    public void ExibirInfomacoesConta(Titular titular)
    {
        Console.WriteLine("Informações da Conta\n");
        Console.WriteLine("Dados do Titular");
        Console.WriteLine($"Nome: {titular.Nome}");
        Console.WriteLine($"CPF: {titular.Cpf}");
        Console.WriteLine($"Celular: {titular.Celular}");

        Console.WriteLine("\nDados da Conta");
        Console.WriteLine($"Número da conta: {NumeroConta}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Saldo: R$ {Saldo}");
        Console.WriteLine($"Limite: R$ {Limite}");
        Console.WriteLine($"Limite Total (Saldo + Limite): R$ {LimiteTotal}");

    }
}