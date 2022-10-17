bool finished = false;

do {
    Console.WriteLine("Escolha um Instrumento:" + "\n" + "1 - Baixo" + "\n" + "2 - Violão" + "\n" + "3 - Guitarra");
    Console.Write("Escolha : ");
    int instrumento = int.Parse(Console.ReadLine());

    Console.WriteLine("\n" + "Escolha um Estilo:" + "\n" + "1 - Rock" + "\n" + "2 - Punk/Grunge/Indie" + "\n" + "3 - Metal");
    Console.Write("Escolha : ");
    int estilo = int.Parse(Console.ReadLine());

    Console.WriteLine("\n" + "Escolha um Nível: " + "\n" + "1 - Iniciante" + "\n" + "2 - Intermediario" + "\n" + "3 - Avançado");
    Console.Write("Escolha : ");
    int nivel = int.Parse(Console.ReadLine());

    if (instrumento == 1 && estilo == 1 && nivel == 1) {
        Console.WriteLine("\n" + "Queen - Another One Bites the Dust" + "\n" + "AC/DC - Highway To Hell" + "\n" + "Deep Purple - Perfect Strangers");
    }
    else if (instrumento == 1 && estilo == 1 && nivel == 2) {
        Console.WriteLine("\n" + "Kansas - Carry On Wayward Son" + "\n" + "Red Hot Chilli Peppers - Californication" + "\n" + "Mamonas Assassinas - 1406");
    }
    else if (instrumento == 1 && estilo == 1 && nivel == 3) {
        Console.WriteLine("\n" + "Iron Maiden - The Number Of The Beast" + "\n" + "Muse - Hysteria " + "\n" + "Red Hot Chili Peppers - Can't Stop");
    }
    else if (instrumento == 1 && estilo == 2 && nivel == 1) {
        Console.WriteLine("\n" + "Nirvana - Smells Like Teens Sprit" + "\n" + "Blink 182 - I Miss You" + "\n" + "Green Day - Back In The USA");
    }
    else if (instrumento == 1 && estilo == 2 && nivel == 2) {
        Console.WriteLine("\n" + "Plush - Stone Temple Pilots" + "\n" + "Alice in Chains - Man in the box " + "\n" + "Foo Fighters - The Pretender");
    }
    else if (instrumento == 1 && estilo == 2 && nivel == 3) {
        Console.WriteLine("\n" + "Alice In Chains - Would?" + "\n" + "");
    }
    Console.Write("\n" + "Reniciar? (y/n)");
    char restart = char.Parse(Console.ReadLine());

    if (restart == 'y') {
        Console.Clear();
        finished = false;
    }
    else {
        finished = true;
        Console.Clear();
        Console.WriteLine("Keep Playing!");
    }
} while (!finished);


