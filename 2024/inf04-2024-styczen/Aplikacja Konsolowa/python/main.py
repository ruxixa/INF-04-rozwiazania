""" 
Autor: ruxixa 

Plik: main.cpp

Data: 12.05.2024
Egzamin: INF-04 Styczeń 2024 
Zadanie: 1

Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
"""

"""
**********************************************
nazwa funkcji: sprawdz_plec
opis funkcji: funkcja sprawdzająca płeć na podstawie numeru PESEL
parametry: pesel - numer PESEL
zwracany typ i opis: str - znak (K - kobieta, M - mężczyzna)
autor: ruxixa
***********************************************
"""

# deklaracja funkcji sprawdzPlec
def sprawdz_plec(pesel: str) -> str:
    # jeśli przed ostatnia cyfra numeru PESEL jest parzysta
	if int(pesel[9]) % 2 == 0:
		return "K"

    # nie musimy używać else, bo zwracamy wartość w poprzednim warunku,
    # więc funkcja nigdy dojdzie do tego miejsca
    
    # w przeciwnym wypadku
    # zwracamy mężczyzna (M)
	return "M"

"""
**********************************************
nazwa funkcji: sprawdz_sume_kontrolna
opis funkcji: funkcja sprawdzająca sumę kontrolną numeru PESEL
parametry: pesel - numer PESEL
zwracany typ i opis: bool - wartość logiczna (True - poprawny, False - niepoprawny)
autor: ruxixa
***********************************************
"""

# deklaracja funkcji sprawdzSumeKontrolna
def sprawdz_sume_kontrolna(pesel):
    # slownik z wagami cyfr numeru PESEL
    waga = {
        1: 1,
        2: 3,
        3: 7,
        4: 9,
        5: 1,
        6: 3,
        7: 7,
        8: 9,
        9: 1,
        10: 3
    }

    # obliczona suma kontrolna
    s = 0

    # pętla for
    # iterujemy od 1 do 10
    for i in range(1, 11):
        # zamiana znaku na liczbę
        cyfra = int(pesel[i - 1])

        # obliczenie wartości
        wartosc = cyfra * waga[i]

        # dodanie wartości do sumy
        s += wartosc

    # obliczenie reszty z dzielenia sumy przez 10
    m = s % 10

    # obliczenie r
    if m == 0:
        # jeśli m jest równe 0, to r jest równe 0
        r = 0
    else:
        # r jest równe 10 - m
        r = 10 - m

    # sprawdzenie sumy kontrolnej
    if int(pesel[10]) == r:
        # jeśli suma kontrolna jest poprawna
        # zwracamy wartość True
        return True

    # w przeciwnym wypadku
    # zwracamy wartość False
    return False

"""
**********************************************
nazwa funkcji: main
opis funkcji: funkcja główna
parametry: brak
zwracany typ i opis: brak
autor: ruxixa
***********************************************
"""

def main():
    # zmienna przechowująca numer PESEL
    pesel = input("Wprowadz swoj pesel: ")

    # sprawdzenie płci
    plec = sprawdz_plec(pesel)

    # wyświetlenie płci
    if plec == 'K':
        # jeśli plec jest K, to jesteś kobietą
        print("Jestes KOBIETA")
    else:
        # w przeciwnym wypadku jesteś mężczyzną
        print("Jestes MEZCZYZNA")

    # sprawdzenie sumy kontrolnej
    if sprawdz_sume_kontrolna(pesel):
        # jeśli suma kontrolna jest poprawna
        print("Pesel jest POPRAWNY")
        return 

    # w przeciwnym wypadku
    print("Pesel jest NIEPOPRAWNY")

# wywołanie funkcji main
if __name__ == "__main__":
    main()
