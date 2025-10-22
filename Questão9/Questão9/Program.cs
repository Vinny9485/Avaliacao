using System;

class Program
{
    static void Main()
    {
        // Inicializa o vetor de nomes
        string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };

        // Solicita ao usuário que digite um nome para pesquisar
        Console.Write("Digite um nome para pesquisar: ");
        string nomeBusca = Console.ReadLine();

        bool encontrado = false;

        // Percorre o vetor para buscar o nome
        foreach (string nome in nomes)
        {
            if (nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break;
            }
        }

        // Exibe o resultado da busca
        if (encontrado)
        {
            Console.WriteLine($"O nome {nomeBusca} foi encontrado no vetor.");
        }
        else
        {
            Console.WriteLine($"O nome {nomeBusca} não está no vetor.");
        }
    }
}
