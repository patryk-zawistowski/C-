// Zadanie 1 - Suma liczb od 1 do N (liczona pętlą, bez wzoru)

Console.Write("Podaj liczbę: ");
int n = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = 1; i <= n; i++)
{
    suma = suma + i;
}

Console.WriteLine("Suma liczb od 1 do " + n + " wynosi: " + suma);
