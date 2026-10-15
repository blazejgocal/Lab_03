Console.WriteLine("Podaj aktualne punkty życia:");
int zycie = int.Parse(Console.ReadLine()!);
Console.Clear();
if (zycie == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie żyje");
    return;
}
Console.WriteLine("Podaj podstawowe obrażenia broni:");
int podObrazenia = int.Parse(Console.ReadLine()!);
Console.Clear();
int petla = 0;
bool czyMaMiksture = true;
while (petla == 0)
{
    Console.WriteLine("Czy bohater ma miksturę? tak/nie");
    string czyMaMiksture1 = Console.ReadLine()!;
    if (czyMaMiksture1 == "nie")
    {
        czyMaMiksture = false;
        petla++;
        Console.Clear();
    }
    else if (czyMaMiksture1 == "tak")
    {
        czyMaMiksture = true;
        petla++;
        Console.Clear();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podaj prawdziwą informację");
        Console.ResetColor();
    }
}
petla = 0;
string czynnosc = " ";
if (zycie <= 20)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("UWAGA - NISKI POZIOM ZDROWIA");
    Console.ResetColor();
}
while (petla == 0)
{
    Console.WriteLine("Wybierz czynność: atak/leczenie/ucieczka");
    czynnosc = Console.ReadLine()!;
    if (czynnosc == "atak" || czynnosc == "leczenie" || czynnosc == "ucieczka")
    {
        petla++;
        Console.Clear();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nieznana akcja.");
        Console.ResetColor();
    }
}
switch (czynnosc)
{
    case "atak":
        Console.WriteLine($"Zadane obrażenia: {podObrazenia}");
        break;
    case "leczenie":
        if (czyMaMiksture == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bohater się uleczył");
        }
        else
        {
            Console.WriteLine("Brak mikstury leczącej.");
        }
        break;
    case "ucieczka":
        Console.WriteLine("Bohater uciekł");
        break;
}