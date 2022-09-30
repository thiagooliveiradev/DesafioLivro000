Console.Write("Digite o nome do aluno para consultar a presença dele na aula de hoje: ");
var aluno = Console.ReadLine();

switch (aluno) 
{
    case "Marcelo": Console.WriteLine("Presente!"); break;
    case "Renato": Console.WriteLine("Presente!"); break;
    case "Thiago": Console.WriteLine("Presete!"); break;
    case "Paulo": Console.WriteLine("Atestado médico"); break;
    case "Flavio": Console.WriteLine("Faltou");break;
    default: Console.WriteLine("Aluno não encontrado"); break;        
      
}

