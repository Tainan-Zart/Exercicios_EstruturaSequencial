
Console.WriteLine("digite o valor da conta a pagar");
double valorTotal = Convert.ToDouble(Console.ReadLine());

double valorPorAmigo = valorTotal / 3;
double valorCarlos = Math.Floor(valorPorAmigo); 
double valorAndre = Math.Floor(valorPorAmigo);  
double valorFelipe = valorTotal - valorCarlos - valorAndre;

Console.WriteLine($"Carlos deve pagar: R${valorCarlos:F2}");
Console.WriteLine($"André deve pagar: R${valorAndre:F2}");
Console.WriteLine($"Felipe deve pagar: R${valorFelipe:F2}");

