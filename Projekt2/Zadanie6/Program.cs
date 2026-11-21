// Zadanie 6 - Sprawdzanie, czy liczba jest pierwsza

Console.Write("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine());

bool czyPierwsza = true;

if (liczba < 2)
{
    czyPierwsza = false;
}

for (int i = 2; i < liczba; i++)
{
    if (liczba % i == 0)
    {
        czyPierwsza = false;
        break;
    }
}

if (czyPierwsza)
{
    Console.WriteLine(liczba + " jest liczbą pierwszą.");
}
else
{
    Console.WriteLine(liczba + " nie jest liczbą pierwszą.");
}
