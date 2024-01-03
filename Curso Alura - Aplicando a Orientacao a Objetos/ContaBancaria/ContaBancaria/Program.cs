Titular titular1 = new Titular
{
    Nome = "John Doe",
    Cpf = "123.456.789-10",
    Celular = "(11) 91234-5678"
};

Conta conta1 = new Conta
{
    NumeroConta = "12354654",
    Agencia = "0174",
    Saldo = 1300.64F,
    Limite = 4000.00F
};

conta1.ExibirInfomacoesConta(titular1);

