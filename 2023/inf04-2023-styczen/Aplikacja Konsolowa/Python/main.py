""" 
Autor: ruxixa 

Plik: main.py

Data: 21.05.2024
Egzamin: INF-04 Czerwiec 2023 
Zadanie: 1

Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
"""

"""
**********************************************
nazwa funkcji: nwd
opis funkcji: funkcja oblicza największy wspólny dzielnik dwóch liczb
parametry: 
    a: int - pierwsza liczba
    b: int - druga liczba
zwracany typ i opis: int - największy wspólny dzielnik liczb a i b
autor: ruxixa
***********************************************
"""
def nwd(a: int, b: int) -> int:
    # dopóki liczby a i b są różne
    while a != b:
        # jeśli a jest większe od b to odejmujemy b od a
        if a > b:
            a -= b
        # w przeciwnym wypadku odejmujemy a od b
        else:
            b -= a

    # zwracamy a lub b, ponieważ są równe
    return a

# funkcja main
def main():
    # pobieramy od użytkownika dwie liczby
    a = int(input("Wprowadz liczbe a: "))
    b = int(input("Wprowadz liczbe b: "))

    # wyświetlamy wynik
    print(f"NWD({a}, {b}) = {nwd(a, b)}")
      
if __name__ == '__main__':
    main()