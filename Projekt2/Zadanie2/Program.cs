// Zadanie 2 - Tabliczka mnożenia od 1 do 10

Console.Write("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(liczba + " x " + i + " = " + (liczba * i));
}
