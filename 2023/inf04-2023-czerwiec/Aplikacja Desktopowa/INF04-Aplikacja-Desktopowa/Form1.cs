/* Autor: ruxixa 
*  
*  Plik: Form1.cs
*  
*  Data: 12.06.2024
*  Egzamin: INF-04 Styczeń 2024 
*  Zadanie: 2
*
*  Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
*  Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

// główna przestrze� nazw aplikacji
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
        *******************************************************
        nazwa funkcji: czySameCyfry
        parametry wejściowe: string input - ciąg znaków do sprawdzenia
        wartość zwracana: bool - czy wszystkie znaki w ciągu są cyframi
        informacje: Funkcja sprawdza, czy wszystkie znaki w ciągu są cyframi
        autor: ruxixa
        ****************************************************
        */

        static bool czySameCyfry(string input)
        {
            foreach (char znak in input)
            {
                if (!Char.IsDigit(znak))
                {
                    return false;
                }
            }
            return true;
        }

        /*
        *******************************************************
        nazwa funkcji: sprawdzCeneButtonClicked
        parametry wejściowe: object sender, EventArgs e - parametry zdarzenia
        wartość zwracana: brak 
        informacje: Funkcja wywoływana po kliknięciu przycisku sprawdzCeneButton. 
                    Sprawdza cenę przesyłki i wyświetla ją w labelu cenaLabel
        autor: ruxixa
        ****************************************************
        */

        private void sprawdzCeneButtonClicked(object sender, EventArgs e)
        {
            // słownik z cenami przesylek
            Dictionary<string, float> cenyPrzesylek = new Dictionary<string, float>
            {
                { "Paczka", 1f },
                { "List", 1.5f },
                { "Pocztówka", 10f }
            };

            // pobranie zaznaczonego rodzaju przesyłki
            RadioButton? selectedRadioButton = rodzajPrzesylkiGroup.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            // sprawdzenie czy wybrano rodzaj przesyłki
            if (selectedRadioButton == null)
            {
                // wyświetlenie komunikatu o błędzie
                MessageBox.Show("Nie wybrano rodzaju przesyłki!");

                // przerwanie funkcji
                return;
            }

            // wyświetlenie ceny przesyłki
            cenaLabel.Text = $"Cena: {cenyPrzesylek[selectedRadioButton.Text]} zł";
        }

        /*
        *******************************************************
        nazwa funkcji: zatwierdzButtonClicked
        parametry wejściowe: object sender, EventArgs e - parametry zdarzenia
        wartość zwracana: brak 
        informacje: Funkcja wywoływana po kliknięciu przycisku zatwierdzButton. 
                    Sprawdza poprawność kodu pocztowego
        autor: ruxixa
        ****************************************************
        */

        private void zatwierdzButtonClicked(object sender, EventArgs e)
        {
            // sprawdzenie czy kod pocztowy ma 5 znaków
            if (kodPocztowyInput.Text.Length != 5)
            {
                // wyświetlenie komunikatu o błędzie
                MessageBox.Show("Kod pocztowy musi mieć 5 znaków!");
                return;
            }
            //  sprawdzenie czy kod pocztowy zawiera tylko cyfry
            else if (czySameCyfry(kodPocztowyInput.Text))
            {
                // wyświetlenie komunikatu o poprawności kodu pocztowego
                MessageBox.Show("Kod pocztowy zawiera tylko cyfry!");
            }
        }
    }
}
