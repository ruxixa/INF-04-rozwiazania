/**
 * Autor: ruxixa
 * 
 * Plik: main.cpp
 * 
 * Data: 21.05.2024
 * Egzamin: INF-04 Czerwiec 2023
 * Zadanie: 1
 * 
 * Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
 * Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication
*/

#include <iostream>

/**
 * **********************************************
 * nazwa funkcji: nwd
 * opis funkcji: funkcja oblicza największy wspólny dzielnik dwóch liczb
 * parametry:
 *     a: int - pierwsza liczba
 *     b: int - druga liczba
 * zwracany typ i opis: int - największy wspólny dzielnik liczb a i b
 * autor: ruxixa
 * ***********************************************
*/
int nwd(int a, int b) {
    // dopóki liczby a i b są różne
    while (a != b) {
        // jeśli a jest większe od b to odejmujemy b od a
        if (a > b) {
            a -= b;
        }
        // w przeciwnym wypadku odejmujemy a od b
        else {
            b -= a;
        }
    }

    // zwracamy a lub b, ponieważ są równe
    return a;
}

// funkcja main
int main() {
    // deklarujemy dwie liczby całkowite
    int a, b;

    // pobieramy od użytkownika dwie liczby
    std::cout << "Wprowadz liczbe a: ";
    std::cin >> a;
    std::cout << "Wprowadz liczbe b: ";
    std::cin >> b;

    // wyświetlamy wynik
    std::cout << "NWD(" << a << ", " << b << ") = " << nwd(a, b) << std::endl;

    return 0;
}
