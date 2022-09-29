/* Faça um programa que receba o salário de um funcionário, calcule e mostre o novo salário, sabendo-se
que este sofreu um aumento de 25% */

Console.Write("Digite o valor do salário atual do funcionário: ");
var salarioAtual = Console.ReadLine();
int novoSalario = int.Parse(salarioAtual);

var promocao = novoSalario + novoSalario * 25 / 100;

Console.WriteLine($"Parabéns pela promoção seu novo salario é: {promocao}, seu antigo salario era {novoSalario} e teve um aumento de 25%");