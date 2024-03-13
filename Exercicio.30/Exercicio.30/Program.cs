int pontosGrandePorte = 10;
int pontosMedioPorte = 5;
int pontosPequenoPorte = 2;
int pontosPorAno = 2;

int projetosGrandePorte, projetosMedioPorte, projetosPequenoPorte, tempoDeCasa;
      
Console.WriteLine("Digite a quantidade de participações em projetos de grande porte:");
projetosGrandePorte = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de participações em projetos de médio porte:");
projetosMedioPorte = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de participações em projetos de pequeno porte:");
projetosPequenoPorte = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o tempo de casa do funcionário (em anos):");
tempoDeCasa = int.Parse(Console.ReadLine());

int pontosProjetos = (projetosGrandePorte * pontosGrandePorte) + (projetosMedioPorte * pontosMedioPorte) + (projetosPequenoPorte * pontosPequenoPorte);
int pontosTempoDeCasa = tempoDeCasa * pontosPorAno;
int totalPontos = pontosProjetos + pontosTempoDeCasa;
     
Console.WriteLine($"Total de pontos acumulados: {totalPontos}");
    