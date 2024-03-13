

Console.WriteLine("Digite sua altura!");
double alturaPessoa = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida de sua sombra!");
double  medidaSombraPessoa = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a medida da sombra do predio!");
double  medidaSombraPredio = double.Parse(Console.ReadLine());

double alturaPessoaSombraPredio = alturaPessoa * medidaSombraPredio;
double alturaPredio = alturaPessoaSombraPredio / medidaSombraPessoa;

Console.WriteLine($"A altura do predio é {alturaPredio:f2}");













