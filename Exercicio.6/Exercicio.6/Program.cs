Console.Write("Digite o valor do prato em kilos: ");
double pesoPrato = Convert.ToDouble(Console.ReadLine());

double valorPagar = pesoPrato * 12;

Console.WriteLine($"O valor a pagar é {valorPagar}");