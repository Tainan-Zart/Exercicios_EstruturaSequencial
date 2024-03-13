Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

double notaFinal = (nota1 * 1 + nota2 * 2 + nota3 * 3) / (1 + 2 + 3);

Console.WriteLine($"Nota final do aluno é {notaFinal}");