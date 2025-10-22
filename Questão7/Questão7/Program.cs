using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita os números ao usuário
        Console.Write("Digite o número inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Digite o número final: ");
        int fim = int.Parse(Console.ReadLine());

        Console.WriteLine("\n=== TABUADA COMPLETA ===");

        // Loop externo para cada número do intervalo
        for (int i = inicio; i <= fim; i++)
        {
            Console.WriteLine($"\nTabuada do {i}:");

            // Loop interno para multiplicar de 1 a 10
            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j;
                Console.WriteLine($"{i} x {j} = {resultado}");
            }
        }
    }
}