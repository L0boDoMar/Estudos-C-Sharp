/*Crie uma lista de inteiros utilizando o List<int> e utilize o for e o 
foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição 
de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto 
o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada 
elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos 
da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente 
cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador 
de módulo (%) e, caso seja, o número é impresso no console.
*/

//Lista de números inteiros
List<int> numerosInteiros = new List<int> { };

void PreencherLista()
{
    //preenche a lista com números pares de 0 a 100
    for (int i = 0; i < 101; i++)
    {
        numerosInteiros.Add(i);
    }
}

void ImprimirListaDeNumerosPares()
{
    //Preenche a lista
    PreencherLista();

    //imprimir números pares com for
    Console.WriteLine($"Números Pares de 0 a 100 com For: ");
    for (int i = 0;i<numerosInteiros.Count;i++)
    {
        if (numerosInteiros[i]%2 == 0)
        {
            Console.WriteLine(numerosInteiros[i]);
        }
    }

    //imprimir números pares com foreach
    Console.WriteLine($"\n\nNúmeros Pares de 0 a 100 com Foreach: ");
    foreach(int numero in numerosInteiros)
    {
        if (numerosInteiros[numero]%2 == 0)
        {
            Console.WriteLine(numero);
        }
    }
}

ImprimirListaDeNumerosPares();

