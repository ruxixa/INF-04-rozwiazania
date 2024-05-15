/* Autor: ruxixa 
*  
*  Plik: Program.cs
*  
*  Data: 12.05.2024
*  Egzamin: INF-04 Styczeń 2024 
*  Zadanie: 1
*
*  Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
*  Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

// główna przestrzeń nazw aplikacji
namespace INF04_Aplikacja_Desktopowa
{
    // klasa Paszport dziedzicząca po Form
    internal static class Program 
    {
        // metoda główna aplikacji
        [STAThread]
        static void Main()
        {
            // inicjalicacja konfiguracji aplikacji
            ApplicationConfiguration.Initialize();
            
            // uruchomienie aplikacji
            Application.Run(new Paszport());
        }
    }
}