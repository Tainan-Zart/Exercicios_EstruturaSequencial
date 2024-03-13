Console.Write("Digite seu salario");
double salarioInicial = Convert.ToDouble(Console.ReadLine());

double salarioAumento = (salarioInicial * 0.15) + salarioInicial;

double salarioDesconto = salarioAumento -  (salarioAumento * 0.08);

Console.WriteLine($"O salario inicial é ${salarioInicial}, com 15% de aumento {salarioAumento}, com 8% de desconto {salarioDesconto}");