const double valorPremio = 500000.00;
string nome1, nome2, nome3;
int pontos1, pontos2, pontos3;
int totalPontos = 0;
     
Console.Write("Digite o nome do 1º participante: ");
nome1 = Console.ReadLine();
Console.Write($"Digite a pontuação de {nome1}: ");
pontos1 = int.Parse(Console.ReadLine());
totalPontos += pontos1;
      
Console.Write("Digite o nome do 2º participante: ");
nome2 = Console.ReadLine();
Console.Write($"Digite a pontuação de {nome2}: ");
pontos2 = int.Parse(Console.ReadLine());
totalPontos += pontos2;

Console.Write("Digite o nome do 3º participante: ");
nome3 = Console.ReadLine();
Console.Write($"Digite a pontuação de {nome3}: ");
pontos3 = int.Parse(Console.ReadLine());
totalPontos += pontos3;
    
double partePremio1 = pontos1 * valorPremio / totalPontos;
double partePremio2 = pontos2 * valorPremio / totalPontos;
double partePremio3 = pontos3 * valorPremio / totalPontos;

Console.WriteLine("\n--- Distribuição do Prêmio ---");
Console.WriteLine($"{nome1} receberá R${partePremio1:F2}");
Console.WriteLine($"{nome2} receberá R${partePremio2:F2}");
Console.WriteLine($"{nome3} receberá R${partePremio3:F2}");





