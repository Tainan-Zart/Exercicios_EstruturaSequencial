

double  compra1, compra2, compra3, compra4, valorCompra, quantidadePontos;

Console.WriteLine("Digite o valor da primeira comprar");
compra1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da segunda comprar");
compra2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da terceira comprar");
compra3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da quarta comprar");
compra4 = double.Parse(Console.ReadLine());


valorCompra = compra1 + compra2 + compra3 + compra4;

quantidadePontos = valorCompra / 5;

 Console.WriteLine($"Total de pontos acumulados: {quantidadePontos:F2}");








