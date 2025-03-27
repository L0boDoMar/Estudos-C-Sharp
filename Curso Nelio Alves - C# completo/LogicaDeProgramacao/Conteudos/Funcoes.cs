namespace LogicaDeProgramacao.Conteudos;

public class Funcoes
{
    //vantagens: modularização, delegação e reaproveitamento
    //funções em classes recebem o nome de métodos

    public void ExibirMaiorNumero(List<int> numeros)
    {
       Console.WriteLine("O maior número é: "  + numeros.Max());
    }
}
