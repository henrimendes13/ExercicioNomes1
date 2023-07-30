 string nome1, nome2;
        double idade1, idade2, idadeMedia;

        string[] vet;

        Console.WriteLine("Nome e idade: ");
        vet = Console.ReadLine().Split(' ');
        nome1 = vet[0];
        idade1 = int.Parse(vet[1]);


        string[] vet2;

        Console.WriteLine("Nome e idade: ");
        vet2 = Console.ReadLine().Split(' ');
        nome2 = vet2[0];
        idade2 = int.Parse(vet2[1]);


        idadeMedia = (idade1 + idade2) / 2;

        Console.WriteLine("A media de idade é: " + idadeMedia.ToString("F1"));