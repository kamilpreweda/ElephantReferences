using ElephantReferences;

Elephant lucek = new Elephant() { Name = "Lucek", earSize = 100 };
Elephant laura = new Elephant() { Name = "Laura", earSize = 80 };


Console.WriteLine("Wciśnij 1 (Lucek), 2 (Laura), 3(przestawienie)");

while (true)
{
    char userInput = Console.ReadKey(true).KeyChar;
    Console.WriteLine($"Wcisnąłeś {userInput}.");

    if (userInput == '1')
    {
        Console.WriteLine("Wywołanie lucek.WhoAmI().");
        lucek.WhoAmI();
        // lucek.HearMessage("Cześć", laura);

    }
    else if (userInput == '2')
    {
        Console.WriteLine("Wywołanie laura.WhoAmI().");
        laura.WhoAmI();

    }
    else if (userInput == '3')
    {
        Elephant holder;
        holder = lucek;
        lucek = laura;
        laura = holder;
        Console.WriteLine("Zmienne zostały przestawione");


    }else if (userInput == '4')
    {
        lucek = laura;
        lucek.earSize = 4321;
        lucek.WhoAmI();
    }else if ( userInput == '5')
    {
        laura.SpeakTo(lucek, "Cześć Lucku");
    }
    else return;
    Console.WriteLine();

    
}

    