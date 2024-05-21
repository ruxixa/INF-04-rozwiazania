/*
* Autor: ruxixa 
* 
* Plik: main.cpp
* 
* Data: 15.06.2024
* Egzamin: INF-04 Czerwiec 2023 
* Zadanie: 1
* 
* Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
* Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

#include <iostream>
#include <vector>
#include <cmath>

/*
****************************************************
nazwa funkcji: wypelnij_tablice
parametry wejściowe: A : list[bool] - tablica z wartościami logicznymi
wartość zwracana: list[int] - lista liczb pierwszych
informacje: Funkcja wypełnia tablicę wartościami logicznymi, a następnie zwraca listę liczb pierwszych
autor: ruxixa
****************************************************
*/

std::vector<int> wypelnij_tablice(std::vector<bool>& A) {
    // n - liczba elementów w tablicy
    int n = A.size() - 1;

    // Algorytm Eratostenesa

    // Funkcja sqrt zwraca pierwiastek kwadratowy z n
    // Równie dobrze można użyć n ** 0.5
    //
    // Wtedy będzie to wyglądać tak:
    // for (int i = 2; i <= n ** 0.5; ++i) { ... }

    for (int i = 2; i <= std::sqrt(n); ++i) {
        if (A[i] == true) {
            for (int j = 2 * i; j <= n; j += i) {
                A[j] = false;
            }
        }
    }

    // Tworzenie listy liczb pierwszych
    std::vector<int> liczby_pierwsze;
    for (int i = 2; i <= n; ++i) {
        if (A[i] == true) {
            liczby_pierwsze.push_back(i);
        }
    }

    return liczby_pierwsze;
}

/*
****************************************************
nazwa funkcji: algorytm_eratostenesa
parametry wejściowe: n : int - liczba naturalna
wartość zwracana: None
informacje: Funkcja zwraca listę liczb pierwszych
autor: ruxixa
***************************************************
*/

void algorytm_eratostenesa(int n) {
    // A - tablica z wartościami logicznymi
    std::vector<bool> A(n + 1, true);

    // Pierwsze dwie liczby nie są pierwsze
    A[0] = A[1] = false;

    // Wypisanie liczb pierwszych
    std::vector<int> wynik = wypelnij_tablice(A);

    // Wypisanie wyniku
    for (int liczba : wynik) {
        std::cout << liczba << std::endl;
    }
}

int main() {
    // Przykładowe wywołanie funkcji z n = 100
    algorytm_eratostenesa(100);

    return 0;
}
