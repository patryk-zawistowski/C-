// Zadanie 5 - Trójkąt z gwiazdek

Console.Write("Podaj wysokość trójkąta: ");
int wysokosc = int.Parse(Console.ReadLine());

for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
{
    for (int j = 1; j <= wiersz; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
