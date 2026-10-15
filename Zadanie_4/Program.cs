bool czyKlucz = true;
bool czyHaslo = true;
Console.WriteLine("Podaj punkty życia:");
string zycie1 = Console.ReadLine()!;
int zycie = int.Parse(zycie1);
Console.Clear();
if (zycie <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie żyje!");
    return;
}
int petla = 0;
while(petla == 0)
{
    Console.WriteLine("Czy ma klucz? tak/nie:");
    string czyKlucz1 = Console.ReadLine()!;
    if (czyKlucz1 == "nie")
    {
        czyKlucz = false;
        petla++;
        Console.Clear();
    }
    else if (czyKlucz1 == "tak")
    {
        czyKlucz = true;
        petla++;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Podaj prawdziwą informację");
    }
}
petla = 0;
while (petla == 0)
{
    Console.WriteLine("Czy zna hasło? tak/nie:");
    string czyHaslo1 = Console.ReadLine()!;
    if (czyHaslo1 == "nie")
    {
        czyHaslo = false;
        petla++;
        Console.Clear();
    }
    else if (czyHaslo1 == "tak")
    {
        czyHaslo = true;
        petla++;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Podaj prawdziwą informację");
    }
}

if (czyKlucz == true || czyHaslo == true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Bohater może wejść do lochu");
    return;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie może wejść do lochu");
    return;
}