using EstoqueDeProdutos.Enums;
using System.Drawing;
using System.Security.Cryptography;

class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    void LimparConsole()
    {
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void CadastrarProduto()
    {

        Produto p = new Produto();

        // a quantidade inicial deve ser 0
        p.Quantidade = 0;

        //valida a entrada do nome
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.WriteLine("Cadastrar Produto");
            Console.Write("Digite o nome do produto: ");
            string nomeP = Console.ReadLine();
            if (string.IsNullOrEmpty(nomeP))
            {
                Console.WriteLine($"O nome do produto não pode ser vazio.");
            }
            else
            {
                p.NomeProduto = nomeP;
                entradaValida = true;
            }
        }

        //preço
        //enquanto o valor digitado não for do tipo float, retorna mensagem de erro e solicita um novo valor
        bool precoValido = false;
        do
        {
            Console.Write("Digite o preço do produto: R$ ");

            if (float.TryParse(Console.ReadLine(), out float preco))
            {
                // Validar outras condições
                if (preco >= 0)
                {
                    p.Preco = preco;
                    precoValido = true;
                }
                else
                {
                    Console.WriteLine("O preço não pode ser negativo. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
            }
        } while (!precoValido);

        //fornecedor
        entradaValida = false;
        while (!entradaValida)
        {
            Console.Write("Digite o nome do fornecedor: ");
            string fornecedor = Console.ReadLine();
            if (string.IsNullOrEmpty(fornecedor))
            {
                Console.WriteLine($"O nome do fornecedor não pode ser vazio.");
            }
            else
            {
                p.Fornecedor = fornecedor;
                entradaValida = true;
            }
        }

        //código do produto
        string codigoProduto = "";
        entradaValida = false;
        while (!entradaValida)
        {
            Console.Write("Digite o código do produto: ");
            codigoProduto = Console.ReadLine()!;

            if (string.IsNullOrEmpty(codigoProduto))
            {
                Console.WriteLine($"O nome do fornecedor não pode ser vazio.");
            }
            else
            {
                //verificar se o produto está cadastrado no sistema com base no código
                bool produtoExiste = produtos.Any(p => p.CodigoProduto == codigoProduto);

                //se um produto ja cadastrado for digitado, retorna uma mensagem de erro
                if (produtoExiste)
                {
                    Console.WriteLine($"O produto {p.NomeProduto} já está cadastrado no sistema.");
                }
                else
                {
                    p.CodigoProduto = codigoProduto;
                    produtos.Add(p);
                    Console.Write("Produto Cadastrado com sucesso");
                    LimparConsole();
                    entradaValida = true;
                }
            }
        }
    }

    public void MostrarProdutos()
    {
        if (produtos.Count == 0) 
        { 
            Console.WriteLine("Nenhum produto foi cadastrado no sistema!");
            LimparConsole();

        }
        else
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome produto: {produto.NomeProduto} | Quantidade: {produto.Quantidade} | Preço: R${produto.Preco} | Fornecedor:{produto.Fornecedor} | Código: {produto.CodigoProduto}");
            }
            LimparConsole();
        } 
    }

    public void EntradaProduto()
    {
        Console.Write("Informe o Código do Produto para Lançamento: ");
        string codigoProduto = Console.ReadLine()!;

        Produto produtoSelecionado = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

        if (produtoSelecionado != null)
        {
            Console.Write("Digite a quantidade para entrada: ");

            if (int.TryParse(Console.ReadLine(), out int qtd))
            {
                if (qtd >= 0)
                {
                    produtoSelecionado.Quantidade += qtd;
                    Console.WriteLine($"Saldo de Estoque: {produtoSelecionado.Quantidade}");
                    LimparConsole();

                }
                else
                {
                    Console.WriteLine("A quantidade não pode ser negativa");
                    EntradaProduto();
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                EntradaProduto();
            }
        }
        else
            Console.WriteLine("Produto não encontrado");

    }

    public void SaidaProduto()
    {
        Console.Write("Informe o Código do Produto para Lançamento: ");
        string codigoProduto = Console.ReadLine()!;

        Produto produtoSelecionado = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

        if (produtoSelecionado != null)
        {
            Console.Write("Digite a quantidade para saída: ");

            if (int.TryParse(Console.ReadLine(), out int qtd))
            {
                if (qtd >= 0)
                {
                    produtoSelecionado.Quantidade -= qtd;
                    Console.WriteLine($"Saldo de Estoque: {produtoSelecionado.Quantidade}");
                    LimparConsole();
                }
                else
                {
                    Console.WriteLine("A quantidade não pode ser negativa. Tente novamente.");
                    SaidaProduto();
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                SaidaProduto();
            }
        }
        else
            Console.WriteLine("Produto não encontrado");

    }

    public void InventarioProduto()
    {
        Console.Write("Informe o Código do Produto para Lançamento: ");
        string codigoProduto = Console.ReadLine()!;

        Produto produtoSelecionado = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

        if (produtoSelecionado != null)
        {
            Console.Write("Digite a quantidade para entrada de inventario: ");

            if (int.TryParse(Console.ReadLine(), out int qtd))
            {
                if (qtd >= 0)
                {
                    produtoSelecionado.Quantidade = qtd;
                    Console.WriteLine($"Saldo de Estoque: {produtoSelecionado.Quantidade}");
                    LimparConsole();
                }
                else
                {
                    Console.WriteLine("A quantidade não pode ser negativa. Tente novamente.");
                    InventarioProduto();
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                InventarioProduto();
            }
        }
        else
            Console.WriteLine("Produto não encontrado");
    }

    public void EditarInformacoesDoProduto()
    {
        Console.Write("Informe o Código do Produto que Deseja Alterar: ");
        string codigoProduto = Console.ReadLine()!;

        Produto produtoSelecionado = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

        if (produtoSelecionado != null)
        {
            Console.WriteLine("Alterar Informações do Produto\n");

            Console.WriteLine($"Nome produto: {produtoSelecionado.NomeProduto} | Quantidade: {produtoSelecionado.Quantidade} | Preço: R${produtoSelecionado.Preco} | Fornecedor:{produtoSelecionado.Fornecedor} | Código: {produtoSelecionado.CodigoProduto}");

            //criar enum - future
            Console.WriteLine("Nome do Produto - Digite 1");
            Console.WriteLine("Fornecedor - Digite 2");
            Console.WriteLine("Preço - Digite 3");
            Console.WriteLine("Excluir Produto - Digite 4");

            Console.Write("Qual atributo deseja alterar? ");

            do
            {
                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    if (Enum.IsDefined(typeof(OpcaoEdicao), opcao))
                    {
                        OpcaoEdicao opcaoSelecionada = (OpcaoEdicao)opcao;
                        AlterarProduto(opcaoSelecionada, produtoSelecionado);
                        break;
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
        else
            Console.WriteLine("Produto não encontrado");

    }

    private Produto AlterarProduto(OpcaoEdicao opcao, Produto produtoSelecionado)
    {
        if (OpcaoEdicao.NomeProduto == opcao)
        {
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write($"Digite um novo nome para o produto {produtoSelecionado.NomeProduto}:");
                string novoNome = Console.ReadLine();

                if (string.IsNullOrEmpty(novoNome))
                {
                    Console.WriteLine($"O nome do produto {produtoSelecionado.NomeProduto} não pode ser vazio.");
                }
                else
                {
                    produtoSelecionado.NomeProduto = novoNome;
                    Console.WriteLine($"O nome do produto foi alterado com sucesso!");
                    LimparConsole();
                    entradaValida = true;
                }
            }
        }
        else if (OpcaoEdicao.NomeFornecedor == opcao)
        {
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write($"Digite um novo fornecedor para o produto {produtoSelecionado.NomeProduto}:");
                string novoFornecedor = Console.ReadLine();
                if (string.IsNullOrEmpty(novoFornecedor))
                {
                    Console.WriteLine($"O nome do fornecedor {produtoSelecionado.Fornecedor} não pode ser vazio.");
                }
                else
                {
                    produtoSelecionado.Fornecedor = novoFornecedor;
                    Console.WriteLine($"O nome do fornecedor foi alterado com sucesso!");
                    LimparConsole();
                    entradaValida = true;
                }
            }

        }
        else if (OpcaoEdicao.Preco == opcao)
        {
            bool precoValido = false;
            do
            {
                Console.Write($"Digite um novo preço para o produto {produtoSelecionado.NomeProduto}: ");

                if (float.TryParse(Console.ReadLine(), out float preco))
                {
                    // Validar outras condições
                    if (preco >= 0)
                    {
                        produtoSelecionado.Preco = preco;
                        Console.WriteLine($"O preço do produto foi alterado com sucesso!");
                        LimparConsole();
                        precoValido = true;
                    }
                    else
                        Console.WriteLine("O preço não pode ser negativo. Tente novamente.");
                }
                else
                    Console.WriteLine("Entrada inválida. Por favor, tente novamente.");

            } while (!precoValido);
        }
        else if (OpcaoEdicao.Excluir == opcao)
        {
            bool entradaValida = false;
            while (!entradaValida)
            {
                Console.Write($"Tem certeza? S/N ");
                string opcaoExclusao = Console.ReadLine();
                if (opcaoExclusao == "S" || opcaoExclusao == "s")
                {
                    Console.WriteLine("Produto excluído com sucesso!");
                    produtos.RemoveAll(p => p.CodigoProduto == produtoSelecionado.CodigoProduto);
                    LimparConsole();
                    entradaValida = true;
                }
                else if (opcaoExclusao == "N" || opcaoExclusao == "n")
                {
                    Console.WriteLine("Exclusão cancelada com sucesso!");
                    LimparConsole();
                    EditarInformacoesDoProduto();
                }
                else
                    Console.WriteLine("Opção inválida. Digite novamente");

            }

        }

        else
            Console.WriteLine("Opção Inválida");

        return produtoSelecionado;
    }

    public void LancamentoProduto()
    {
        Console.WriteLine("Entrada - Digite 1");
        Console.WriteLine("Saída - Digite 2");
        Console.WriteLine("Inventário - Digite 3");

        bool opcaoValida = false; // Variável de controle para saída do loop

        do
        {
            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                if (Enum.IsDefined(typeof(OpcaoLancamento), opcao))
                {
                    if (opcao == (int)OpcaoLancamento.EntradaProduto)
                    {
                        EntradaProduto();
                    }
                    else if (opcao == (int)OpcaoLancamento.SaidaProduto)
                    {
                        SaidaProduto();
                    }
                    else if (opcao == (int)OpcaoLancamento.InventarioProduto)
                    {
                        InventarioProduto();
                    }
                    
                    opcaoValida = true;
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
        } while (!opcaoValida); // Condição de saída do loop
    }
}
