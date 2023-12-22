class Conta
{
    public string numeroConta;
    public string titular;
    public float saldo;
    public string senha;

    public void ExibirInfomacoesConta()
    {
        Console.WriteLine("Informações da Conta");
        Console.WriteLine($"Número da conta: {numeroConta}");
        Console.WriteLine($"Titular da Conta: {titular}");
        Console.WriteLine($"Saldo da Conta: {saldo}");
        Console.WriteLine("Senha da Conta: ******");
    }
}