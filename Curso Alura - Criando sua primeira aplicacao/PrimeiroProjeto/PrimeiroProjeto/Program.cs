//Screen Sound

//Criar uma lista com nomes de bandas
//List<string> ListaDeBandas = new List<string> {"Iron Maiden", "AC/DC", "Metallica", "Kiss", "Helloween", "Pink Floyd"};

//Criar um dicionário
using System;

Dictionary<string, List<int>> DicionarioDeBandas = new Dictionary<string, List<int>>();
DicionarioDeBandas.Add("Pink Floyd", new List<int> { 10, 10, 9 });
DicionarioDeBandas.Add("Iron Maiden", new List<int>());

//criando um função com C#
void ExibirLogo() //função: pascal case
{
    //variável: camel case
    string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";

    //dica de site https://fsymbols.com/pt
    // '@' exibe uma string literal
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirTituloDaOpcao(string tituloDaOpcao)
{
    int quantidadeDeCaracteres = tituloDaOpcao.Length;
    string estrelinhas = string.Empty.PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(estrelinhas);
    Console.WriteLine(tituloDaOpcao);
    Console.Write(estrelinhas + "\n");
}

void RegistrarBandas()
{
    string opcao;

    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; //'!' indica que o valor não pode ser nulo

    if (DicionarioDeBandas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"A banda {nomeDaBanda} já foi registrada anteriormente!");

        //Repetir
        Console.WriteLine("\nPara registrar outra banda, digite 1");
        Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            Console.Clear();
            RegistrarBandas();
        }
        else
        {
            Console.Clear();
            MostrarOpcoesDoMenu();
        }
    }
    else
    {
        //ListaDeBandas.Add(nomeDaBanda); //adicionar uma banda a lista
        DicionarioDeBandas.Add(nomeDaBanda, new List<int>()); //adiciona uma banda e uma lista de notas vazias
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    }
    

    //Repetir
    Console.WriteLine("\nPara registrar outra banda, digite 1");
    Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
    opcao = Console.ReadLine();
    if (opcao == "1")
    {
        Console.Clear();
        RegistrarBandas();
    }
    else
    {
        Console.Clear();
        MostrarOpcoesDoMenu();
    }
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de Bandas Registradas\n");
    /*
    for (int i = 0; i < ListaDeBandas.Count; i++)
    {
        Console.WriteLine(ListaDeBandas[i]);
    }
    */
    foreach (string banda in DicionarioDeBandas.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    MostrarOpcoesDoMenu();

}

void AvaliarBandas()
{
    //digitar banda
    //verificar se a banda existe no dicionário
    //Atribuir uma nota

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");

    //buscar banda
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if (DicionarioDeBandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual nota deseja atribuir a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine());
        DicionarioDeBandas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {nomeBanda}");

        //Repetir
        Console.WriteLine("\nPara outra nota, digite 1");
        Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
        string opcao = Console.ReadLine();
        if (opcao == "1")
        {
            Console.Clear();
            AvaliarBandas();
        }
        else
        {
            Console.Clear();
            MostrarOpcoesDoMenu();
        }

    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada");

        //Repetir
        Console.WriteLine("\nPara outra nota, digite 1");
        Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
        string opcao = Console.ReadLine();
        if (opcao == "1")
        {
            Console.Clear();
            AvaliarBandas();
        }
        else
        {
            Console.Clear();
            MostrarOpcoesDoMenu();
        }


    }
}

void NotaMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Nota Média");

    Console.Write("Digite o nome da banda para obter sua nota média: ");
    string nomeBanda = Console.ReadLine();

    //verifica que se a banda digitada existe no dicionário
    if (DicionarioDeBandas.ContainsKey(nomeBanda))
    {
        string opcao;

        //verifica se a banda digitada possui alguma nota atribuida
        if (DicionarioDeBandas[nomeBanda].Count != 0)
        {
            double notaMediaDaBanda = DicionarioDeBandas[nomeBanda].Average();
            Console.WriteLine($"A nota média da banda {nomeBanda} é: {notaMediaDaBanda}");

            //Repetir
            Console.WriteLine("\nPara buscar uma nova banda, digite 1");
            Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
            opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.Clear();
                NotaMediaDaBanda();
            }
            else
            {
                Console.Clear();
                MostrarOpcoesDoMenu();
            }
        }
        else
        {
            Console.WriteLine($"Nenhuma nota foi atribuída a banda {nomeBanda}");

            //Repetir
            Console.WriteLine("\nPara buscar uma nova banda, digite 1");
            Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
            opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.Clear();
                NotaMediaDaBanda();
            }
            else
            {
                Console.Clear();
                MostrarOpcoesDoMenu();
            }
        }
       
        

    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada");

        //Repetir
        Console.WriteLine("\nPara buscar uma nova banda, digite 1");
        Console.WriteLine("\nPara voltar ao menu principal, digite qualquer outro caractere");
        string opcao = Console.ReadLine();
        if (opcao == "1")
        {
            Console.Clear();
            NotaMediaDaBanda();
        }
        else
        {
            Console.Clear();
            MostrarOpcoesDoMenu();
        }

    }

}

void MostrarOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; //'!' indica que o valor não pode ser nulo
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            NotaMediaDaBanda();
            break;
        case 0:
            Console.WriteLine("Até Mais =D");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


MostrarOpcoesDoMenu();

