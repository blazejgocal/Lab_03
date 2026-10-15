Console.WriteLine("Imię bohatera: ");
string imie = Console.ReadLine()!;
Console.WriteLine("Wiek bohatera: ");
string wiek = Console.ReadLine()!;
Console.WriteLine("Płeć bohatera: ");
string plec = Console.ReadLine()!;
Console.WriteLine("Rasa bohatera: ");
string rasa = Console.ReadLine()!;
Console.WriteLine("Symbol bohatera: ");
string symbol = Console.ReadLine()!;
Console.WriteLine("Punkty życia bohatera: ");
string punktyZycia = Console.ReadLine()!;
int punktyZycia1 = int.Parse(punktyZycia);
Console.WriteLine("Punkty doświadczenia bohatera: ");
string punktyDoswiadczenia = Console.ReadLine()!;
int punktyDoswiadczenia1 = int.Parse(punktyDoswiadczenia);
Console.WriteLine("Siła bohatera: ");
string sila = Console.ReadLine()!;
int sila1 = int.Parse(sila);
Console.WriteLine("Zwykłe obrażenia: ");
string zwykleObrazenia = Console.ReadLine()!;
int zwykleObrazenia1 = int.Parse(zwykleObrazenia);
Console.WriteLine("Mnożnik obrażeń: ");
string mnoznikObrazen = Console.ReadLine()!;
double mnoznikObrazen1 = double.Parse(mnoznikObrazen);
double obrazeniaAtakuSpecjalnego = zwykleObrazenia1 * mnoznikObrazen1;

Console.WriteLine("Maksymalne miejsce w plecku: ");
string maksymalneMiejsceWplecku = Console.ReadLine()!;
int maksymalneMiejsceWplecku1 = int.Parse(maksymalneMiejsceWplecku);
Console.WriteLine("Wolne miejsca w plecaku: ");
string wolneMiejscaWplecaku = Console.ReadLine()!;
int wolneMiejscaWplecaku1 = int.Parse(wolneMiejscaWplecaku);
int zajeteMiejscaWplecaku = maksymalneMiejsceWplecku1 - wolneMiejscaWplecaku1;
Console.WriteLine("Zdobyte złoto: ");
string zloto = Console.ReadLine()!;
int zloto1 = int.Parse(zloto);
Console.WriteLine("Liczba członków drużyny: ");
string liczbaCzlonkowDruzyny = Console.ReadLine()!;
int liczbaCzlonkowDruzyny1 = int.Parse(liczbaCzlonkowDruzyny);
int zlotoNaCzlonkaDruzyny = zloto1 / liczbaCzlonkowDruzyny1;
int zlotoPozostale = zloto1 % liczbaCzlonkowDruzyny1;
Console.WriteLine("Czy ma mapę? (true/false): ");
string czyMaMape = Console.ReadLine()!;
bool czyMaMape1 = bool.Parse(czyMaMape);
string lewa = $"Bohater: {imie}";
string prawa = $"{symbol}";

Console.WriteLine("\n\n\n");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("+==========================================+");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("             KARTA BOHATERA               ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.WriteLine("+==========================================+");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {lewa,-30}{prawa,10} ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.WriteLine("+------------------------------------------+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Wiek: {wiek} lat",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Płeć: {plec}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Rasa: {rasa}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Zdrowie: {punktyZycia1}/100",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Punkty doświadczenia: {punktyDoswiadczenia1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Siła: {sila1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Zwykłe obrażenia: {zwykleObrazenia1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Mnożnik obrażeń: {mnoznikObrazen1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Obrażenia ataku specjalnego: {obrazeniaAtakuSpecjalnego:F2}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.WriteLine("+------------------------------------------+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Plecak:  {zajeteMiejscaWplecaku}/{maksymalneMiejsceWplecku1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Wolne miejsca w plecaku: {wolneMiejscaWplecaku1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Zdobyte złoto: {zloto1}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Złoto na członka drużyny: {zlotoNaCzlonkaDruzyny}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($" {$"Złoto pozostałe: {zlotoPozostale}",-41}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("|");
Console.WriteLine("+------------------------------------------+");
if (czyMaMape1)
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater posiada mapę.                    ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
else
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater nie posiada mapy.                ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
if(punktyZycia1 > 0)
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater żyje.                            ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
else
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater nie żyje.                        ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
if(punktyZycia1 == 100)
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater jest w pełni zdrowy.             ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
else if(punktyZycia1 >= 50)
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater jest ranny.                      ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
else
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater jest ciężko ranny.               ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
if(punktyZycia1>50 && czyMaMape1 && wolneMiejscaWplecaku1>0)
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater jest gotowy do wyprawy.          ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
else
{
    Console.Write("|");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(" Bohater nie jest gotowy do wyprawy.      ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("|");
}
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("+==========================================+");
Console.ResetColor();
Console.WriteLine("\n\n\n");

Console.WriteLine("Wybierz czynność: wyruszyć na misję/rozpalić ognisko/przygotować miksturę.");
string czynnosc = Console.ReadLine()!;
switch (czynnosc)
{
    case "wyruszyć na misję":
        Console.WriteLine("Bohater chce wyruszyć na misję!");
        break;
    case "rozpalić ognisko":
        Console.WriteLine("Bohater chce rozpalić ognisko");
        break;
    case "przygotować miksturę" :
        Console.WriteLine("Bohater chce przygotować miksturę");
        break;
}