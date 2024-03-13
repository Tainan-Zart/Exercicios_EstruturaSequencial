Console.Write("Informe a quantidade de camisetas pequenas: ");
int camisetasPequena = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade de camisetas medias: ");
int camisetasMedias = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade de camisetas grandes: ");
int camisetasGrandes = Convert.ToInt32(Console.ReadLine());

double valorCamisetaPequena = camisetasPequena * 10;
double valorCamisetaMedia = camisetasMedias * 12;
double valorCamisetaGrande = camisetasGrandes * 15;
double valorTotal = valorCamisetaPequena + valorCamisetaMedia + valorCamisetaGrande;

Console.WriteLine($"O valor total das camisetas é {valorTotal}");
