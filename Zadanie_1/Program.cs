Console.WriteLine("Podaj liczbę całkowitą: ");
string liczba1 = Console.ReadLine()!;
int liczba = int.Parse(liczba1);
if (liczba % 2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Liczba jest parzysta");
    return;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Liczba jest nieparzysta");
    return;
}