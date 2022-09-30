// Faça um programa que receba três notas, calcule e mostre a média aritmética


Console.Write("Digite a nota da primeira avaliação do aluno: ");
var notaPrimeiraAvaliacao = Console.ReadLine();
int resultadoDaAvaliacao1 = int.Parse(notaPrimeiraAvaliacao);

Console.Write("Digite a nota da segunda avaliação do aluno: ");
var notaSegundaAvalicao = Console.ReadLine();
int resultadoDaAvaliacao2 = int.Parse(notaSegundaAvalicao);

Console.Write("Digite a nota da terceira avaliação do aluno: ");
var notaTerceiraAvaliacao = Console.ReadLine();
var resultadoDaAvaliacao3 = int.Parse(notaTerceiraAvaliacao);

var media = (resultadoDaAvaliacao1 + resultadoDaAvaliacao2 + resultadoDaAvaliacao3) / 3;

if (media < 6)
{
    Console.WriteLine($"O resultado da média do aluno é {media}, REPROVADO!");
}
else 
{
    Console.WriteLine($"O resultado da média do aluno é {media}, APROVADO!");
}

