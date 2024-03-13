Console.Write("Digite quantos o valor que deseja colocar de gasolina: ");
double valorDinheiro = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da Gasolina: ");
double valorGasolina = Convert.ToDouble(Console.ReadLine());

double litrosGasolina = valorDinheiro / valorGasolina;

Console.WriteLine($"Voce vai abastecer em seu carro {litrosGasolina} de Gasolina");