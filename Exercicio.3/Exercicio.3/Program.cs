﻿Console.WriteLine("Digite a quantidade de paes");
int quantidadePaes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quantidade de broas");
int quantidadeBroas = Convert.ToInt32(Console.ReadLine());

double valorPaes = quantidadePaes * 0.60;
double valorBroas = quantidadeBroas * 6.50;

double valorVendas = valorBroas + valorPaes;

double valorPoupanca = valorVendas * 0.10;


Console.WriteLine($"valor total dos produtos {valorVendas} ");
Console.WriteLine($"valor para colocar na poupança {valorPoupanca} ");