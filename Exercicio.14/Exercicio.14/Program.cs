Console.WriteLine("Informe o raio da pizza");

double raio = Convert.ToDouble(Console.ReadLine());

double potenciaRaio = raio * raio;
double area = potenciaRaio * 3.14;

Console.WriteLine($"A area da pizza é {area}m²");
