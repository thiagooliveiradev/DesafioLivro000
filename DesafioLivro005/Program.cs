/* Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual, calcule e mostre: 
a) a idade dessa pessoa;
b) quantos anos ela terá em 2050.*/ 


Console.Write("Digite o ano que você nasceu, para saber quantos anos terá em 2050: ");
var dataNascimento = Console.ReadLine();
var anoNascimento = int.Parse(dataNascimento);

var dataEntrada = DateTime.Now.Year;
var Acrescentaridade = (2050 - dataEntrada);
var idadeFutura = dataEntrada - anoNascimento + Acrescentaridade;

Console.WriteLine($"Sua idade em 2050 será: {idadeFutura}");


