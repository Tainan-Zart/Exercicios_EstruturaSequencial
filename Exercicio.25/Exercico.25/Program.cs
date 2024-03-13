

Console.WriteLine("Informe o valor do Raio");
double raio = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor da Altura");
double altura = double.Parse(Console.ReadLine());

double volumeCaixa = 3.13 * (raio * raio) * altura;

Console.WriteLine($"Volume da caixa de agua cilindrica é {volumeCaixa} Cm³");

