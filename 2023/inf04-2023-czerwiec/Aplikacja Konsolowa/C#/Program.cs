/* Autor: ruxixa 
*  
*  Plik: Program.cs
*  
*  Data: 15.05.2024
*  Egzamin: INF-04 Styczeń 2023
*  Zadanie: 1
*
*  Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
*  Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

// importowanie przestrzeni nazw
using System;
using System.Collections.Generic;

// przestrzeń nazw dla zadania
namespace INF_04_Styczen_2023_Konsola
{
    public static List<int> WypelnijTablice(List<bool> A)
    {
        // n - liczba elementów w tablicy
        int n = A.Count - 1;

        // Algorytm Eratostenesa
        for (int i = 2; i <= Math.Sqrt(n); ++i)
        {
            if (A[i] == true)
            {
                for (int j = 2 * i; j <= n; j += i)
                {
                    A[j] = false;
                }
            }
        }

        // Tworzenie listy liczb pierwszych
        List<int> liczbyPierwsze = new List<int>();
        for (int i = 2; i <= n; ++i)
        {
            if (A[i] == true)
            {
                liczbyPierwsze.Add(i);
            }
        }

        return liczbyPierwsze;
    }

    /*
    ****************************************************
    nazwa funkcji: AlgorytmEratostenesa
    parametry wejściowe: n : int - liczba naturalna
    wartość zwracana: None
    informacje: Funkcja zwraca listę liczb pierwszych
    autor: ruxixa
    ***************************************************
    */

    public static void AlgorytmEratostenesa(int n)
    {
        // A - tablica z wartościami logicznymi
        List<bool> A = new List<bool>(new bool[n + 1]);

        // Pierwsze dwie liczby nie są pierwsze
        A[0] = A[1] = false;

        // Wypisanie liczb pierwszych
        List<int> wynik = WypelnijTablice(A);

        // Wypisanie wyniku
        foreach (int liczba in wynik)
        {
            Console.WriteLine(liczba);
        }
    }

    public static void Main(string[] args)
    {
        // Przykładowe wywołanie funkcji z n = 100
        AlgorytmEratostenesa(100);
    }
}