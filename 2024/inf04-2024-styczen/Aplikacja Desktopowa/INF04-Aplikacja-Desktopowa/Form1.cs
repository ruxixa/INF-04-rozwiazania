/* Autor: ruxixa 
*  
*  Plik: Form1.cs
*  
*  Data: 12.05.2024
*  Egzamin: INF-04 Styczeń 2024 
*  Zadanie: 1
*
*  Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
*  Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

// g��wna przestrze� nazw aplikacji
namespace INF04_Aplikacja_Desktopowa
{
    // klasa Paszport dziedzicz�ca po Form
    public partial class Paszport : Form
    {
        // inicjalizacja zmiennych
        public Paszport()
        {
            InitializeComponent();
        }

        /*
        **********************************************
        nazwa funkcji: OkButtonClick
        opis funkcji: Funkcja wywo�ywana po naci�ni�ciu przycisku OK. 
                      Sprawdza czy wszystkie pola s� wype�nione i czy zaznaczono kolor oczu.
        parametry: sender - obiekt, kt�ry wywo�a� funkcj�
                   e - argumenty zdarzenia
        zwracany typ i opis: brak
        autor: ruxixa
        ***********************************************
        */

        private void OkButtonClick(object sender, EventArgs e)
        {
            RadioButton? selectedRadioButton = kolorOczuGroup.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selectedRadioButton == null)
            {
                // Nie zaznaczono �adnego RadioButton.
                MessageBox.Show("Wybierz kolor oczu!");
                return;
            }

            // pobranie warto�ci z p�l
            string imie = imieInput.Text;
            string nazwisko = nazwiskoInput.Text;
            string numer = numerInput.Text;

            // sprawdzenie czy wszystkie pola s� wype�nione
            if (string.IsNullOrEmpty(imie) || string.IsNullOrEmpty(nazwisko) || string.IsNullOrEmpty(numer))
            {
                // Nie wype�niono wszystkich p�l.
                MessageBox.Show("Wype�nij wszystkie pola!");
                return;
            }
        }

        /*
        **********************************************
        nazwa funkcji: NumerInputChangeValue
        opis funkcji: Funkcja wywo�ywana po zmianie warto�ci w polu numer. 
                      Wy�wietla zdj�cie cz�owieka i odcisk palca na podstawie numeru.
        parametry: sender - obiekt, kt�ry wywo�a� funkcj�
                   e - argumenty zdarzenia
        zwracany typ i opis: brak
        autor: ruxixa
        ***********************************************
        */

        private void NumerInputChangeValue(object sender, EventArgs e)
        {
            // tablica z numerami
            string[] numery = ["000", "111", "333"];

            // sprawdzenie czy numer znajduje si� w tablicy
            if (numery.Contains(numerInput.Text))
            {
                // wy�wietlenie zdj�cia cz�owieka i odcisku palca
                czlowiekImage.Image = Image.FromFile($"assets/{numerInput.Text}-zdjecie.jpg");
                odciskImage.Image = Image.FromFile($"assets/{numerInput.Text}-odcisk.jpg");
            }
        }
    }
}
