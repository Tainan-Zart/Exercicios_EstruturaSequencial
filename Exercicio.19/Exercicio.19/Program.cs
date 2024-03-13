
Console.WriteLine("Digite a quantidade de frangos da fazenda");
double quantidadeFrangos = Convert.ToDouble(Console.ReadLine());

double valorAnelIdentificao = quantidadeFrangos * 4;
double valorAnelAlimento = quantidadeFrangos  * 2 * 3.50;

double valorTotalAneis = valorAnelIdentificao + valorAnelAlimento;

Console.WriteLine($"Valor total para marcas todos os frangos é {valorTotalAneis}R$");

