/* Faça um programa que receba o valor de um depósito e o valor da taxa de juros, calcule e mostre o
valor do rendimento e o valor total depois do rendimento.*/

Console.Write("Digite o valor a ser depositado: ");
var valorDepositado = Console.ReadLine();
int deposito = int.Parse(valorDepositado);

Console.Write("Digite o valor da taxa de juros mensal: ");
var taxaDeJuros = Console.ReadLine();
decimal jurosMensal = decimal.Parse(taxaDeJuros);

var valorDoRendimento = deposito * (jurosMensal / 100);

Console.WriteLine($"seu dinheiro vai render mensalmente: {valorDoRendimento}");
