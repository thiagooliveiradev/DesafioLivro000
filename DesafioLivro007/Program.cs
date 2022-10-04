/* O custo ao consumidor de um carro novo é a soma do preço de fábrica com o percentual de lucro do
distribuidor e dos impostos aplicados ao preço de fábrica. Faça um programa que receba o preço de fábrica de um veículo, o percentual de lucro do distribuidor e o percentual de impostos, calcule e mostre:
a) o valor correspondente ao lucro do distribuidor; 
b) o valor correspondente aos impostos; 
c) o preço final do veículo. */

Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;



Console.Write("Infomre o preço de fábrica do veiculo: ");
var valorBase = int.Parse(Console.ReadLine());

Console.Write("Informe percentual de lucro do distribuidor: ");
var entradaLucroDistribuidor = decimal.Parse(Console.ReadLine());

Console.Write("Informe a taxa de juros sobre o valor base do véiculo: ");
var taxaDeJuros = decimal.Parse(Console.ReadLine());

var lucroDistribuidor = valorBase * (entradaLucroDistribuidor / 100);
var jurosBase = valorBase * (taxaDeJuros / 100);
var totalValorVeiculo = valorBase + jurosBase + lucroDistribuidor;

Console.WriteLine($"O lucro do distribuidor será: {lucroDistribuidor}");
Console.WriteLine($"O valor dos impostos será: {jurosBase}");
Console.WriteLine($"O valor total do véiculo é de {totalValorVeiculo}");