Console.WriteLine("Digite o dia");
int dia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o mes");
int mes = Convert.ToInt32(Console.ReadLine());

int diasPassados = mes *  30 + dia - 30 ;

Console.WriteLine($"já se passaram {diasPassados}");