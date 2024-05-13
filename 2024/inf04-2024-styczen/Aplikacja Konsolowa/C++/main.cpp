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

// dodajemy bibliotekę iostream 
// (biblioteka standardowa C++ do obsługi strumieni wejścia/wyjścia)
#include <iostream>

// inne biblioteki
#include <iostream>
#include <string>
#include <map>

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
char sprawdzPlec(std::string pesel) {
    // jeśli przed ostatnia cyfra numeru PESEL jest parzysta
	if (pesel[9] % 2 == 0)
	{
        // zwracamy kobieta (K)
		return 'K';
	}

    // nie musimy używać else, bo zwracamy wartość w poprzednim warunku,
    // więc funkcja nigdy dojdzie do tego miejsca
    
    // w przeciwnym wypadku
    // zwracamy mężczyzna (M)
	return 'M';
}

/*
**********************************************
nazwa funkcji: sprawdzSumeKontrolna
opis funkcji: funkcja sprawdzająca sumę kontrolną numeru PESEL
parametry: pesel - numer PESEL
zwracany typ i opis: bool - wartość logiczna 
(true - poprawna suma kontrolna, false - niepoprawna suma kontrolna)
autor: ruxixa
***********************************************
*/

// deklaracja funkcji sprawdzSumeKontrolna
bool sprawdzSumeKontrolna(std::string pesel) {
    // nazwy zmiennych powinny być bardziej opisowe,
    // ale CKE wymaga, aby zmienne się w ten sposób 

    int m,     // reszta z dzielenia 10 - m
    int r,     // suma kontrolna
	int s = 0; // obliczona suma kontrolna

    // mapa z wagami cyfr numeru PESEL
	std::map<int, int> waga;

    // wypełnienie mapy
	waga = {
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
	for (int i = 1; i < 11; i++) {
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
	if (m == 0) {
        // jeśli m jest równe 0, to r jest równe 0
		r = 0;
	}
    // w przeciwnym wypadku
	else {
        // r jest równe 10 - m
		r = 10 - m;
	}

    // sprawdzenie sumy kontrolnej
	if (pesel[10] - '0' == r) {
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
// parametry: bra
zwracany typ i opis: int - wartość logiczna (0 - brak błędów, 1 - błąd)
autor: ruxixa
***********************************************
*/

// deklaracja funkcji main
int main() {
    // zmienna przechowująca numer PESEL
	std::string pesel;

    // wprowadzenie numeru PESEL
	std::cout << "Wprowadz swoj pesel: ";
	std::cin >> pesel;

    // sprawdzenie płci
	char plec = sprawdzPlec(pesel);

    // wyświetlenie płci
	if (plec == 'K') {
        // jeśli plec jest K, to jesteś kobietą
		std::cout << "Jestes KOBIETA" << "\n";
	}
    // w przeciwnym wypadku
	else {
        // w przeciwnym wypadku jesteś mężczyzną
		std::cout << "Jestes MEZCZYZNA" << "\n";
	}

    // sprawdzenie sumy kontrolnej
	if (sprawdzSumeKontrolna(pesel)) {
        // jeśli suma kontrolna jest poprawna
		std::cout << "Pesel jest POPRAWNY" << "\n";
		return 0;
	}

    // w przeciwnym wypadku
	std::cout << "Pesel jest NIEPOPRAWNY" << "\n";

    // zwracamy wartość 1, co oznacza błąd
    //
    // zwracamy błąd, ponieważ pesel jest niepoprawny
	return 1;
}
