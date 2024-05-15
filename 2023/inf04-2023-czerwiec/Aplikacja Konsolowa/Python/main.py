""" 
Autor: ruxixa 

Plik: main.py

Data: 12.06.2024
Egzamin: INF-04 Czerwiec 2023 
Zadanie: 1

Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
"""

"""
****************************************************
nazwa funkcji: wypelnij_tablice
parametry wejściowe: A : list[bool] - tablica z wartościami logicznymi
wartość zwracana: list[int] - lista liczb pierwszych
informacje: Funkcja wypełnia tablicę wartościami logicznymi, a następnie zwraca listę liczb pierwszych
autor: ruxixa
****************************************************
"""
def wypelnij_tablice(A : list[bool]) -> list[int]:
    # n - liczba elementów w tablicy
    n = len(A) - 1

    # Algorytm Eratostenesa
    for i in range(2, int(n ** 0.5) + 1):
        if A[i] == True:
            for j in range(2 * i, n + 1, i):
                A[j] = False

    # Zwracanie liczb pierwszych
    for i, pierwsza in enumerate(A): 
        if pierwsza:
            yield i

"""
****************************************************
nazwa funkcji: algorytm_eratostenesa
parametry wejściowe: n : int - liczba naturalna
wartość zwracana: None
informacje: Funkcja zwraca listę liczb pierwszych
autor: ruxixa
****************************************************
"""
def algorytm_eratostenesa(n : int) -> list[int]:
    # A - tablica z wartościami logicznymi
    A = [True] * (n + 1)

    # Pierwsze dwie liczby nie są pierwsze
    A[0] = A[1] = False

    # Wypisanie liczb pierwszych
    for liczba in wypelnij_tablice(A):
        print(liczba)

# Wywołanie funkcji
if __name__ == "__main__":
    # Przykładowe wywołanie funkcji z n = 100
    algorytm_eratostenesa(100)