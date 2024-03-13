
Console.WriteLine("Informe a quantidade de suco que deseja fazer!");
double quantidadeTotal = double.Parse(Console.ReadLine());

double quantidadeAgua = quantidadeTotal * 0.8;
double quantidadeSuco = quantidadeTotal * 0.2;

Console.WriteLine($"Serao necessarios {quantidadeAgua} Lt de agua");
Console.WriteLine($"Serao necessarios {quantidadeSuco} Lt de suco");
