/* Um trabalhador recebeu seu salário e o depositou em sua conta bancária. Esse trabalhador emitiu dois 
cheques e agora deseja saber seu saldo atual. Sabe-se que cada operação bancária de retirada paga 
CPMF de 0,38% e o saldo inicial da conta está zerado */

Console.Write("Digite o valor a ser depositado: ");
var salarioRecebido = decimal.Parse(Console.ReadLine());

Console.Write("Qual o valor do primeiro cheque?");