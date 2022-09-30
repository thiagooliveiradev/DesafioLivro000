/* Faça um programa que receba o salário de um funcionário, calcule e mostre o novo salário, sabendo-se
que este sofreu um aumento de 25% */

Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

Console.Write("Digite o valor do salário atual do funcionário: ");
var salarioAtual = Console.ReadLine();
var novoSalario = decimal.Parse(salarioAtual);

var promocao = novoSalario + novoSalario * 25 / 100;

Console.WriteLine($"Parabéns pela promoção seu novo salario é: {promocao}, seu antigo salario era {novoSalario} e teve um aumento de 25%");