
// g��wna przestrze� nazw aplikacji
namespace INF04_Aplikacja_Desktopowa
{
    // klasa Paszport dziedzicz�ca po Form
    internal static class Program
    {
        [STAThread]

        // inicjalizacja zmiennych
        static void Main()
        {
            // inicjalicacja konfiguracji aplikacji
            ApplicationConfiguration.Initialize();
            // uruchomienie aplikacji
            Application.Run(new Paszport());
        }
    }
}