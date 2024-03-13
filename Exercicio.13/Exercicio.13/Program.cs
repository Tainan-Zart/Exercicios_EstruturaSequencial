Console.WriteLine("Digite um número inteiro de até três dígitos:");
int numero = Convert.ToInt32(Console.ReadLine());

int centena = numero / 100;
int restoCentena = numero % 100;
int dezena = restoCentena / 10;
int unidade = restoCentena % 10;


Console.WriteLine($"Centena: {centena}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Unidade: {unidade}");