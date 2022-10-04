/* Faça um programa que receba o número de horas trabalhadas e o valor do salário mínimo, calcule e
mostre o salário a receber, seguindo estas regras:
a) a hora trabalhada vale a metade do salário mínimo. 
b) o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada. 
c) o imposto equivale a 3% do salário bruto. 
d) o salário a receber equivale ao salário bruto menos o imposto. */


Console.Write("Digite o sálario base: ");
var salarioBase = decimal.Parse(Console.ReadLine());

Console.Write("Digite o número de horas trabalhadas: ");
var horasTrabalhadas = decimal.Parse(Console.ReadLine());

Console.Write("Digite o valor do imposto a ser descontato do salario bruto ");
var impostoDesconto = decimal.Parse(Console.ReadLine());

var salarioHoras = salarioBase / 2;
var salarioBruto = salarioHoras * horasTrabalhadas;
var impostoSalario = salarioBruto * (impostoDesconto / 100);
var salarioLiquido = salarioBruto - impostoSalario;

Console.WriteLine($"O valor líquido que o funcionaro irá receber é de: {salarioLiquido} ");

