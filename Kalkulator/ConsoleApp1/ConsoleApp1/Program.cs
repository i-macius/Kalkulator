using System;

public class Program
{
    public static void Main()
    {
        int n = 5;  // Liczba wylosowanych liczb
        int max_liczba = 0;  // Zmienna przechowująca aktualnie największą liczbę
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int liczba = random.Next(1000, 10000);  // Wylosowanie czterocyfrowej liczby
            Console.WriteLine(liczba);  // Wypisanie wylosowanej liczby

            if (liczba > max_liczba)
            {
                max_liczba = liczba;
            }
        }

        Console.WriteLine("Największa liczba to: " + max_liczba);
    }
}
