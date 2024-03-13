
Console.WriteLine("Digite a quantidade de latas de 350ml que deseja!");
double lata350ml = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade de garrafas de 600ml que deseja!");
double garrafa600ml = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a quantidade de garrafas de 2Lt que deseja!");
double garrafa2lt = Convert.ToDouble(Console.ReadLine());

double quantidadeLata350ml = lata350ml * 0.350;
double quantidadeGarrafa600ml = garrafa600ml * 0.600;
double quantidadeGarrafa2Lt = garrafa2lt * 2;

double quantidadeTotal = quantidadeLata350ml + quantidadeGarrafa600ml + quantidadeGarrafa2Lt;

Console.WriteLine($"Voce irá comprar {quantidadeTotal}Lt de refrigerante. ");






