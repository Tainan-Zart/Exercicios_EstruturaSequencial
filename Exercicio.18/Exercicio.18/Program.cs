
Console.WriteLine("Informe a quantidades de horas normais trabalhadas!");
double horasNormaisTrabalhadas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quantidades de horas extras trabalhadas!");
double horasExtrasTrabalhadas = Convert.ToDouble(Console.ReadLine());

double valorHorasNormaisTrabalhadas = horasNormaisTrabalhadas * 10;
double valorExtrasNormaisTrabalhadas = horasExtrasTrabalhadas * 15;

double valorBruto = valorHorasNormaisTrabalhadas +  valorExtrasNormaisTrabalhadas;
double valorLiquido = valorBruto - valorBruto * 0.10;

Console.WriteLine($"Valor Bruto: {valorBruto}R$");
Console.WriteLine($"Valor Liquido: {valorLiquido}R$");





