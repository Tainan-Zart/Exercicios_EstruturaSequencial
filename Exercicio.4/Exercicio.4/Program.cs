Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

int idadeDia = idade * 365; 

Console.WriteLine($"{nome} tem {idade} anos, e {idadeDia} dias.");
