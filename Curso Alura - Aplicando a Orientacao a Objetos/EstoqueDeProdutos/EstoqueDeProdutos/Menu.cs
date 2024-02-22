using EstoqueDeProdutos.Enums;

class Menu
{
    Estoque estoqueProdutos = new Estoque();
    OpcaoMenu ExibirOpcoesMenu()
    {
        Console.WriteLine(@"
░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝");
        Console.WriteLine("Cadastrar Produto - Digite 1");
        Console.WriteLine("Listar Produtos - Digite 2");
        Console.WriteLine("Editar Produto - Digite 3");
        Console.WriteLine("Lançamento de Produto - Digite 4");
        Console.WriteLine("Sair - Digite 0");
        do
        {
            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                if (Enum.IsDefined(typeof(OpcaoMenu), opcao))
                {
                    OpcaoMenu opcaoSelecionadaMenu = (OpcaoMenu)opcao;
                    return opcaoSelecionadaMenu;
                }
                else
                {
                    Console.Write("Opção inválida. Digite novamente: ");
                }
            }
            else
            {
                Console.Write("Opção inválida. Digite novamente: ");
            }
        } while (true);
    }

    public void ExibirMenu()
    {
        OpcaoMenu opcao = ExibirOpcoesMenu();

        if (OpcaoMenu.CadastrarProduto == opcao)
        {
            estoqueProdutos.CadastrarProduto();
            ExibirMenu();
        }
        else if (OpcaoMenu.ListarProdutos == opcao)
        {
            estoqueProdutos.MostrarProdutos();
            ExibirMenu();
        }
        else if (OpcaoMenu.EditarProduto == opcao)
        {
            estoqueProdutos.EditarInformacoesDoProduto();
            ExibirMenu();
        }
        else if (OpcaoMenu.LancamentoProduto == opcao)
        {
            estoqueProdutos.LancamentoProduto();
            ExibirMenu();
        }
        else if (OpcaoMenu.EncerrarSistema == opcao)
        {
            Console.WriteLine("Até Logo!");
            Environment.Exit(0);
        }




    }
}