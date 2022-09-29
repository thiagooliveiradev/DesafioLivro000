/* Faça um programa que receba o salário base de um funcionário, calcule e mostre o salário a receber,
sabendo-se que o funcionário tem gratificação de 5% sobre o salário base e paga imposto de 7% também sobre o salário base */


Console.Write("Digite o salário base do funcionaro para o calculo de gratificação e impostos: ");
var salarioBase = Console.ReadLine();
int salarioBruto = int.Parse(salarioBase);

var gratificacao = salarioBruto * 5 / 100;
var impostos = salarioBruto * 7 / 100;

var salarioLiquido = salarioBruto + gratificacao - impostos;

Console.WriteLine($"O salário a receber do funcionário é {salarioLiquido}, sua gratificação total foi {gratificacao} e o total de impostos retidos na fonte foram {impostos}");

