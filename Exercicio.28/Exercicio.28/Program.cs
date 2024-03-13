
Console.WriteLine("Digite o valor do cheque");
double valorCheque = double.Parse(Console.ReadLine());

double valorDesconto = valorCheque - valorCheque * 0.38;

Console.WriteLine($"Valor do cheque após o recolhimento de CPMF ficou: {valorDesconto}R$");
