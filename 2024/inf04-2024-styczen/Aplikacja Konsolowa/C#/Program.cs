/* Autor: ruxixa 
*  
*  Plik: main.cpp
*  
*  Data: 12.05.2024
*  Egzamin: INF-04 Styczeń 2024 
*  Zadanie: 1
*
*  Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
*  Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

// importowanie przestrzeni nazw
using System;
using System.Collections.Generic;

// przestrzeń nazw dla zadania
namespace INF_04_Styczen_2024_Konsola
{
    // klasa programu
    class Program
    {
        /*
        **********************************************
        nazwa funkcji: sprawdzPlec
        opis funkcji: funkcja sprawdzająca płeć na podstawie numeru PESEL
        parametry: pesel - numer PESEL
        zwracany typ i opis: char - znak reprezentujący płeć (K - kobieta, M - mężczyzna)
        autor: ruxixa
        ***********************************************
        */

        // deklaracja funkcji sprawdzPlec
        static char SprawdzPlec(string pesel)
        {
            // jeśli przed ostatnia cyfra numeru PESEL jest parzysta
            if (pesel[9] % 2 == 0)
            {
                // zwracamy kobieta (K)
                return 'K';
            }
            // w przeciwnym wypadku zwracamy mężczyzna (M)
            return 'M';
        }

        static bool SprawdzSumeKontrolna(string pesel)
        {
            // nazwy zmiennych powinny być bardziej opisowe,
            // ale CKE wymaga, aby zmienne się w ten sposób 

            int m;     // reszta z dzielenia 10 - m
            int r;     // suma kontrolna

            int s = 0; // obliczona suma kontrolna

            // slownik z wagami cyfr numeru PESEL
            Dictionary<int, int> waga = new Dictionary<int, int>
            {
                {1, 1},
                {2, 3},
                {3, 7},
                {4, 9},
                {5, 1},
                {6, 3},
                {7, 7},
                {8, 9},
                {9, 1},
                {10, 3}
            };

            // pętla for
            // iterujemy od 1 do 10
            for (int i = 1; i < 11; i++)
            {
                // zamiana znaku na liczbę
                int cyfra = pesel[i - 1] - '0';

                // obliczenie wartości
                int wartosc = cyfra * waga[i];

                // dodanie wartości do sumy
                s += wartosc;
            }

            // obliczenie reszty z dzielenia sumy przez 10
            m = s % 10;

            // obliczenie r
            if (m == 0)
            {
                // jeśli m jest równe 0, to r jest równe 0
                r = 0;
            }
            // w przeciwnym wypadku
            else
            {
                // r jest równe 10 - m
                r = 10 - m;
            }

            // sprawdzenie sumy kontrolnej
            if (pesel[10] - '0' == r)
            {
                // jeśli suma kontrolna jest poprawna
                // zwracamy wartość true
                return true;
            }

            // w przeciwnym wypadku
            // zwracamy wartość false

            // ponownie nie musimy używać else, bo zwracamy wartość 
            // w poprzednim warunku, a więc kod nie dojdzie do tego miejsca
            return false;
        }

        /*
        **********************************************
        nazwa funkcji: main
        opis funkcji: funkcja główna programu
        zwracany typ i opis: nie zwraca żadnej wartości
        autor: ruxixa
        ***********************************************
        */

        static void Main(string[] args)
        {
            // deklaracja zmiennej pesel
            Console.Write("Wprowadz swoj pesel: ");
            string pesel = Console.ReadLine();

            if (pesel != null)
            {
                string plec = SprawdzPlec(pesel).ToString(); // Obsługa wartości null przed wywołaniem ToString()

                if (plec == "K")
                {
                    Console.WriteLine("Jestes KOBIETA");
                }
                else
                {
                    Console.WriteLine("Jestes MEZCZYZNA");
                }

                // sprawdzenie sumy kontrolnej tylko jeśli pesel nie jest null
                if (SprawdzSumeKontrolna(pesel))
                {
                    // jeśli suma kontrolna jest poprawna
                    // wyświetlamy komunikat
                    Console.WriteLine("Pesel jest POPRAWNY");
                }
                else
                {
                    // w przeciwnym wypadku
                    // wyświetlamy komunikat
                    Console.WriteLine("Pesel jest NIEPOPRAWNY");
                }
            }
            else
            {
                // jeśli pesel jest null
                Console.WriteLine("Podano pusty pesel.");
            }
        }
    }
}
