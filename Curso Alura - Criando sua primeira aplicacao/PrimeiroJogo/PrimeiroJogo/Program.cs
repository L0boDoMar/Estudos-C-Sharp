/*
Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.
Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. 
O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o 
número gerado pelo programa.
O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas 
até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o 
jogo acabou.
 
 */

//Gerar um número inteiro aleatório entre 1 e 100
using static System.Net.Mime.MediaTypeNames;

int GerarNumero()
{
    Random numeroAleatorio = new Random();

    int numero = numeroAleatorio.Next(1,101);

    return numero;
}

void ExibirMensagemDeBoasVindas() 
{ 
//nome do programa
Console.WriteLine(@"
░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗███████╗  ░█████╗░
██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔════╝  ██╔══██╗
███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║█████╗░░  ██║░░██║
██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══╝░░  ██║░░██║
██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║███████╗  ╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ░╚════╝░

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░██╗
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗██║
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║╚═╝
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝██╗
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝");

Console.WriteLine("Bem vindo ao Adivinhe o Número");
Console.WriteLine("Nesse jogo, seu objetivo é adivinhar um número aleatório entre 1 e 100.\nTente o quanto quiser, porém, se quiser sair, digite '0'.");
}


void AdivinharNumero() 
{ 
Console.WriteLine("\nDigite um número entre 0 e 100");

    int numeroAleatorioGerado = GerarNumero();
    int numeroEscolhido;

    do
    {
        Console.Write("Digite um número: ");
        string inputUsuario = Console.ReadLine()!;
        numeroEscolhido = int.Parse(inputUsuario);

        if(numeroEscolhido < numeroAleatorioGerado && numeroEscolhido!= 0)
        {
            Console.WriteLine("O número sorteado é maior que "+numeroEscolhido+" tente outra vez!");
        }
        else if(numeroEscolhido > numeroAleatorioGerado && numeroEscolhido != 0)
        {
            Console.WriteLine("O número sorteado é menor que " + numeroEscolhido + " tente outra vez!");
        }
        else if (numeroEscolhido == 0)
        {
            Console.WriteLine("Até a próxima!");
        }
        else
        {
            Console.WriteLine("Você acertou, o número sorteado era " + numeroAleatorioGerado + "!");
        }
    
    } while (numeroAleatorioGerado != numeroEscolhido && numeroEscolhido != 0);


}

//Execução do programa
ExibirMensagemDeBoasVindas();
AdivinharNumero();