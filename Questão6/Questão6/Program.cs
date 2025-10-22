double nota1, nota2, nota3, mediaP;
int peso1 = 1, peso2  = 2, peso3 = 3;

Console.WriteLine("Qual foi a sua 1ª nota?");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual foi a sua 2ª nota?");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Qual foi a sua 3ª nota?");
nota3 = double.Parse(Console.ReadLine());

mediaP = ((nota1 + peso1) + (nota2 + peso2) + (nota3 + peso3))/(peso1 + peso2 + peso3);

if (mediaP < 5.0)
{
    Console.WriteLine($"Sua media foi {mediaP}, então você está REPROVADO");

}
else if (mediaP <= 7.0)
{
    Console.WriteLine($"Sua media foi {mediaP}, então você está de RECUPERAÇÂO");

}
else
{
    Console.WriteLine($"Sua media foi {mediaP}, então você está APROVADO");
}