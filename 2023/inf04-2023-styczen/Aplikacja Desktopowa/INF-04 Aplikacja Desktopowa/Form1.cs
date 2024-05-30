using System;
using System.Security.AccessControl;

namespace INF_04_Aplikacja_Desktopowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        **********************************************
        nazwa funkcji: stworzKombinacje
        opis funkcji: Funkcja generuje kombinacje znak�w 
                      na podstawie wybranych opcji
        parametry: 
            - bool czyLitery - czy wygenerowa� litery
            - bool czyCyfry - czy wygenerowa� cyfry
            - bool czyZnakiSpecjalne - czy wygenerowa� znaki specjalne
        zwracany typ i opis: wygenerowane haslo o typie string
        autor: ruxixa
        ***********************************************
        */
        string stworzKombinacje(bool czyLitery, bool czyCyfry, bool czyZnakiSpecjalne)
        {
            string kombinacja = "";

            if (czyLitery)
            {
                kombinacja += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (czyCyfry)
            {
                kombinacja += "0123456789";
            }

            if (czyZnakiSpecjalne)
            {
                kombinacja += "!@#$%^&*()_+-=";
            }

            return kombinacja;
        }   


        /*
        **********************************************
        nazwa funkcji: wygenerujHaslo
        opis funkcji: Funkcja generuje has�o o zadanej d�ugo�ci
        parametry: brak
        zwracany typ i opis: wygenerowane haslo o typie string
        autor: ruxixa
        ***********************************************
        */
        string wygenerujHaslo()
        {
            int iloscZnakow = int.Parse(ileZnakow.Text);

            bool czyLitery = litery.Checked;
            bool czyCyfry = cyfry.Checked;
            bool czyZnakiSpecjalne = znakiSpecjalne.Checked;

            Random random = new Random();

            string kombinacja = stworzKombinacje(czyLitery, czyCyfry, czyZnakiSpecjalne);
            string haslo = "";

            for (int i = 0; i < iloscZnakow; i++)
            {
                haslo += kombinacja[random.Next(0, kombinacja.Length)];
            }

            return haslo;
        }

        /*
        **********************************************
        nazwa funkcji: GenerujHaslo
        opis funkcji: Funkcja wywo�uje generowanie has�a
        parametry: dane zdarzenia, kt�re s� przekazywane do funkcji
        zwracany brak
        autor: ruxixa
        ***********************************************
        */
        private void GenerujHaslo(object sender, EventArgs e)
        {
            MessageBox.Show(wygenerujHaslo());
        }

        /*
        **********************************************
        nazwa funkcji: Zatwierdz
        opis funkcji: Funkcja wyswietla dane pracownika i jego has�o
        parametry: dane zdarzenia, kt�re s� przekazywane do funkcji
        zwracany typ i opis: brak
        autor: ruxixa
        ***********************************************
        */
        private void Zatwierdz(object sender, EventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {imie.Text} {naziwsko.Text} {stanowisko.Text} Has�o: {wygenerujHaslo()}");
        }
    }
}
