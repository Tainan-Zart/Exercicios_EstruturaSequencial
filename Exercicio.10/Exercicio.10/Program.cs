Console.Write("Informa Ya do plano cartesiano: ");
double pontoYa = Convert.ToDouble(Console.ReadLine());

Console.Write("Informa Yb do plano cartesiano: ");
double pontoYb = Convert.ToDouble(Console.ReadLine());

Console.Write("Informa Xa do plano cartesiano: ");
double pontoXa = Convert.ToDouble(Console.ReadLine());

Console.Write("Informa Xb do plano cartesiano: ");
double pontoXb = Convert.ToDouble(Console.ReadLine());

double valorY = pontoYa - pontoYb;
double valorX=  pontoXa - pontoXb;

double valorPotenciaY = valorY * valorY;
double valorPotenciaX = valorX * valorX;

double calculoNumeros = valorPotenciaY + valorPotenciaX;

double valorFinal = Math.Sqrt(calculoNumeros);

Console.WriteLine(valorFinal);  