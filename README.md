## INF-04 - Zbiór arkuszy z rozwiązaniami dla kierunku Technik Programista

Arkusze dla kierunku Technik Programista wraz z przykładowymi rozwiązaniami
 
## O projekcie

Jest to zbiór rozwiązań egzaminu zawodowego INF-04 wraz z przykładowymi arkuszami.
Rozwiązania są dostępne w językach:

- python
- C++
- C#

## Błędy i inne problemy

Niestety każemu zdarza się popełniać błędy. Dlatego jeżeli zauważysz jakiekolwiek niedociągnięcia w rozwiązaniu zadania lub sposobie jego wykonania, popraw mnie poprzez zgłoszenie "issue" opisując błąd lub kontrybucje. Możesz również zasugerować dodanie konkretnego rozwiązania poprzez otwieranie "pull request"

## Kontrybucje

Jeżeli chcesz dodać nowe rozwiązanie lub poprawkę błędu, możesz to zrobić poprzez kontrybucje. Obowiązują jednak pewne zasady:

1. **Formatowanie kodu** - kod powinien być czytelny i dobrze zorganizowany. Pamiętajmy ze materiały w tym repozytorium mają służyć głównie jako materiał do nauki. Unikajmy niejasnych lub niezrozumiałych nazw. Poniżej przedstawiam przykład dobrego kodu:
```cpp
#include <iostream>

int main() {
    std::string liczba;

    std::cout << "Wprowadz liczbe";
    std::cin >> liczba;

    std::cout << "Wprowadzono: " << liczba << "\n";

    return 0;
}
```

2. **Komentarze i dokumentacja** - Aby ułatwić zrozumienie kodu innym, warto dodawać komentarze oraz dokumentację. Komentarze powinny wyjaśniać skomplikowane lub mniej zrozumiałe fragmenty kodu. Dokumentacja powinna zawierać opisy funkcji, klas oraz niektórych zmiennych. Przykład dobrej dokumentacji:

```cpp
/*
* Funkcja obliczSume
*
* @param pierwszaLiczba - pierwsza liczba podana przez użytkownika
* @param drugaLiczba - druga liczba podana przez użytkownika
*
* @return suma liczb przekazanych do funkcji
*/

int obliczSume(int pierwszaLiczba, int drugaLiczba)
{
    // ciało funkcji
}
```

3. **Zachowanie funkcjonalności** - Kod powinien być w 100% zgodne z treścią zadania egzaminacyjnego, dostarczony i kompatybilny ze wszystkimi materiałami dostarczonymi przez CKE (zdjęcia, bazy danych itp.). Wymagane jest również umieszczenie pliku .pdf z treścią egzaminu lub linku do niego.

## Najczęściej zadawane pytania:

> ### Dlaczego nie ma rozwiązań w javie?
Java jest używana BARDZO rzadko na egzaminach zawodowych, stąd taka decyzja.

> ### Jak zasugerować rozwiązanie arkusza?
Możesz stworzyć **[pull request](https://github.com/ruxixa/INF-04-rozwiazania/pulls)**, wysyłając link do arkusza

> ### Jak dodać własne rozwiązanie?
Stwórz kontrybucje. Opisałem to dokładnie w sekcji **Kontrybucje**

## Przykładowe rozwiązania:
