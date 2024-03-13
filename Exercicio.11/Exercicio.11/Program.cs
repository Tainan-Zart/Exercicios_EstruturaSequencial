Console.WriteLine("Informe a quantidade de dias sem acidentes");
int diasTrabalhados = Convert.ToInt32(Console.ReadLine());

int anos = diasTrabalhados / 365;
int meses = (diasTrabalhados % 365) / 30;
int dias = (diasTrabalhados % 365) % 30;

Console.WriteLine($"Tempo sem acidentes: {anos} anos, {meses} meses, {dias} dias.");
