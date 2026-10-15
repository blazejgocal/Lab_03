Console.WriteLine("Podaj swój wiek:");
string wiek1 = Console.ReadLine();
int wiek = int.Parse(wiek1);
if(wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (wiek >= 0 && wiek <= 12)
{
    Console.WriteLine("dziecko");
    return;
}
else if (wiek >= 13 && wiek <= 17)
{
    Console.WriteLine("nastolatek");
    return;
}
else if (wiek >= 18 && wiek <= 64)
{
    Console.WriteLine("osoba dorosła");
    return;
}
else if (wiek >= 65 && wiek <= 110)
{
    Console.WriteLine("senior");
    return;
}
else
{
    Console.WriteLine("Niepoprawny wiek");
}