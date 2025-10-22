using System;

class Program
{
    static void Main(string[] args)
    {
        int candidatoA = 0, candidatoB = 0, candidatoC = 0, votosNulos = 0;
        int voto;

        Console.WriteLine("SISTEMA DE VOTAÇÃO");
        Console.WriteLine("1: Candidato A");
        Console.WriteLine("2: Candidato B");
        Console.WriteLine("3: Candidato C");
        Console.WriteLine("9: Voto Nulo");
        Console.WriteLine("0: Encerrar Votação");

        do
        {
            Console.Write("\nDigite o número do seu voto: ");
            voto = int.Parse(Console.ReadLine());

            switch (voto)
            {
                case 1:
                    candidatoA++;
                    Console.WriteLine("Voto registrado para Candidato A");
                    break;
                case 2:
                    candidatoB++;
                    Console.WriteLine("Voto registrado para Candidato B");
                    break;
                case 3:
                    candidatoC++;
                    Console.WriteLine("Voto registrado para Candidato C");
                    break;
                case 9:
                    votosNulos++;
                    Console.WriteLine("Voto Nulo registrado");
                    break;
                case 0:
                    Console.WriteLine("Encerrando votação...\n");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Use 1, 2, 3, 9 ou 0 para encerrar.");
                    break;
            }


        } while (voto != 0);

        Console.WriteLine("\nRESULTADO DA ELEIÇÃO");
        Console.WriteLine($"Candidato A: {candidatoA} votos");
        Console.WriteLine($"Candidato B: {candidatoB} votos");
        Console.WriteLine($"Candidato C: {candidatoC} votos");
        Console.WriteLine($"Votos Nulos: {votosNulos} votos");

        int totalVotos = candidatoA + candidatoB + candidatoC + votosNulos;
        Console.WriteLine($"Total de votos: {totalVotos}");
    }
}