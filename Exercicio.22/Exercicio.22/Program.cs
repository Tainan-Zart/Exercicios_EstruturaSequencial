
Console.WriteLine("Digite a quantidade de moedas de 1 centavo ");
double umCentavo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 5 centavos ");
double cincoCentavo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 10 centavos");
double dezCentavo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 25 centavos");
double vinteCincoCentavo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 50 centavos ");
double cinquentaCentavo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 1 real ");
int umReal = int.Parse(Console.ReadLine());

double totalUmCentavo = umCentavo * 0.01;
double totalCincoCentavo = cincoCentavo * 0.05;
double totalDezCentavo = dezCentavo * 0.1;
double totalVinteCincoCentavo = vinteCincoCentavo * 0.25;
double totalCinquentaCentavo = cinquentaCentavo * 0.50;
int totalUmReal = umReal * 1;

double reaisTotais = totalUmCentavo + totalCincoCentavo + totalDezCentavo + totalVinteCincoCentavo + totalCinquentaCentavo + totalUmReal;

Console.WriteLine($"O total em reais é {reaisTotais}");

