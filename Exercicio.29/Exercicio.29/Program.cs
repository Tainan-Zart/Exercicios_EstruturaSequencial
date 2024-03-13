double a, b;
 
Console.WriteLine("Digite o coeficiente 'a' da reta:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o coeficiente 'b' da reta:");
b = double.Parse(Console.ReadLine());

double x = -b / a;

Console.WriteLine($"A reta toca o eixo x no ponto ({x}).");
