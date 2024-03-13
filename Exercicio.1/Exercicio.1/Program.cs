Console.WriteLine("Vamos calcular a area do seu terreno");
Console.WriteLine("Digite a largura do seu terreno");
double retangulo = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Digite o comprimento do seu terreno");
double comprimento = Convert.ToDouble (Console.ReadLine()); 

double area = retangulo * comprimento;
Console.WriteLine($"A area do seu terreno é {area}");
