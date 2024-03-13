
Console.WriteLine("Informe a termperatura em graus Celsius");
double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

double termperaturaFahrenheit = (temperaturaCelsius * 1.8) + 32;

Console.WriteLine($"Temperatura Celsius: {temperaturaCelsius}°C");
Console.WriteLine($"Temperatura Fahrenheit: {termperaturaFahrenheit}°F");

