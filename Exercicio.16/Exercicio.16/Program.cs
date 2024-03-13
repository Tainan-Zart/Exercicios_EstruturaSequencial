
Console.WriteLine("Informe a quanidade de Sanduiches que deseja fazer!");
double quantidadeSanduiches = Convert.ToDouble(Console.ReadLine());

double quantidadeQueijo = quantidadeSanduiches * 2 * 0.05;
double quantidadePresunto = quantidadeSanduiches * 0.05;
double quantidadeHamburguer = quantidadeSanduiches * 0.100;

Console.WriteLine($"A quantidade em kg de queijos: {quantidadeQueijo}kg");
Console.WriteLine($"A quantidade em kg de Presunto: {quantidadePresunto}kg");
Console.WriteLine($"A quantidade em kg de Carne: {quantidadeHamburguer}kg");




