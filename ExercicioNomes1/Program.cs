string nome1, nome2; 
double idade1, idade2, idadeMedia;


Console.WriteLine("Nome 1: ");
nome1 = Console.ReadLine();
Console.WriteLine("Idade: ");
idade1 = double.Parse(Console.ReadLine());

Console.WriteLine("Nome 2: ");
nome2 = Console.ReadLine();
Console.WriteLine("Idade: ");
idade2 = double.Parse(Console.ReadLine());

idadeMedia = (idade1 + idade2) / 2;
Console.WriteLine("A media de idade é: " + idadeMedia.ToString("F1"));