using System;

string contacts = "";
int numberOfPeopleInList = 0;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"~: ADRESSBOKEN ({numberOfPeopleInList} personer, {contacts.Length} tecken) :~\n");
    Console.ResetColor();
    Console.WriteLine("1) Visa personer");
    Console.WriteLine("2) Lägg till person");
    Console.WriteLine("\nQ) Avsluta 3) Rensa adressboken");

    // Console.Write("\nVal: ");
    char choice = Console.ReadKey(true).KeyChar;

    if (choice == '1')
    {
        Console.Clear();
        Console.WriteLine(Environment.NewLine + contacts + Environment.NewLine + (contacts.Split("\n").Length - 1) + " personer totalt");
        Console.ReadKey();
    }
    else if (choice == '2')
    {
        Console.Clear();
        Console.Write("\nNamn: ");
        string newPerson = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newPerson))
        {
            contacts += contacts.Length >= 0 ? newPerson + Environment.NewLine : newPerson;
            numberOfPeopleInList++;
        }
    }
    else if (choice == '3')
    {
        Console.WriteLine("\nÄr du säker på att du vill rensa adressboken? Detta går inte att ångra! (j/n)");
        choice = Console.ReadKey(true).KeyChar;
        if (choice == 'j')
        {
            contacts = "";
            numberOfPeopleInList = 0;
        }
    }
    else if (choice == 'q') Environment.Exit(0);
}