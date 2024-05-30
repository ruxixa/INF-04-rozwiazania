namespace INF_04_Aplikacja_Desktopowa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            danePracownika = new GroupBox();
            stanowisko = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            naziwsko = new TextBox();
            imie = new TextBox();
            generowanieHasla = new GroupBox();
            generujHaslo = new Button();
            znakiSpecjalne = new CheckBox();
            cyfry = new CheckBox();
            litery = new CheckBox();
            label4 = new Label();
            ileZnakow = new TextBox();
            zatwierdz = new Button();
            danePracownika.SuspendLayout();
            generowanieHasla.SuspendLayout();
            SuspendLayout();
            // 
            // danePracownika
            // 
            danePracownika.Controls.Add(stanowisko);
            danePracownika.Controls.Add(label3);
            danePracownika.Controls.Add(label2);
            danePracownika.Controls.Add(label1);
            danePracownika.Controls.Add(naziwsko);
            danePracownika.Controls.Add(imie);
            danePracownika.Location = new Point(43, 43);
            danePracownika.Name = "danePracownika";
            danePracownika.Size = new Size(334, 252);
            danePracownika.TabIndex = 0;
            danePracownika.TabStop = false;
            danePracownika.Text = "Dane Pracownika";
            // 
            // stanowisko
            // 
            stanowisko.FormattingEnabled = true;
            stanowisko.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            stanowisko.Location = new Point(102, 184);
            stanowisko.Name = "stanowisko";
            stanowisko.Size = new Size(196, 23);
            stanowisko.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 192);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 118);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Imię";
            // 
            // naziwsko
            // 
            naziwsko.Location = new Point(102, 110);
            naziwsko.Name = "naziwsko";
            naziwsko.Size = new Size(196, 23);
            naziwsko.TabIndex = 1;
            // 
            // imie
            // 
            imie.Location = new Point(102, 39);
            imie.Name = "imie";
            imie.Size = new Size(196, 23);
            imie.TabIndex = 0;
            // 
            // generowanieHasla
            // 
            generowanieHasla.Controls.Add(generujHaslo);
            generowanieHasla.Controls.Add(znakiSpecjalne);
            generowanieHasla.Controls.Add(cyfry);
            generowanieHasla.Controls.Add(litery);
            generowanieHasla.Controls.Add(label4);
            generowanieHasla.Controls.Add(ileZnakow);
            generowanieHasla.Location = new Point(418, 53);
            generowanieHasla.Name = "generowanieHasla";
            generowanieHasla.Size = new Size(326, 242);
            generowanieHasla.TabIndex = 1;
            generowanieHasla.TabStop = false;
            generowanieHasla.Text = "Generowanie Hasla";
            // 
            // generujHaslo
            // 
            generujHaslo.BackColor = Color.SteelBlue;
            generujHaslo.Location = new Point(20, 182);
            generujHaslo.Name = "generujHaslo";
            generujHaslo.Size = new Size(152, 38);
            generujHaslo.TabIndex = 12;
            generujHaslo.Text = "Generuj haslo";
            generujHaslo.UseVisualStyleBackColor = false;
            generujHaslo.Click += GenerujHaslo;
            // 
            // znakiSpecjalne
            // 
            znakiSpecjalne.AutoSize = true;
            znakiSpecjalne.Location = new Point(20, 144);
            znakiSpecjalne.Name = "znakiSpecjalne";
            znakiSpecjalne.Size = new Size(107, 19);
            znakiSpecjalne.TabIndex = 11;
            znakiSpecjalne.Text = "Znaki specjalne";
            znakiSpecjalne.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            cyfry.AutoSize = true;
            cyfry.Location = new Point(20, 108);
            cyfry.Name = "cyfry";
            cyfry.Size = new Size(54, 19);
            cyfry.TabIndex = 10;
            cyfry.Text = "Cyfry";
            cyfry.UseVisualStyleBackColor = true;
            // 
            // litery
            // 
            litery.AutoSize = true;
            litery.Location = new Point(20, 73);
            litery.Name = "litery";
            litery.Size = new Size(126, 19);
            litery.TabIndex = 9;
            litery.Text = "Małe i wielkie litery";
            litery.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 37);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Ile znaków?";
            // 
            // ileZnakow
            // 
            ileZnakow.Location = new Point(145, 29);
            ileZnakow.Name = "ileZnakow";
            ileZnakow.Size = new Size(100, 23);
            ileZnakow.TabIndex = 7;
            // 
            // zatwierdz
            // 
            zatwierdz.BackColor = Color.SteelBlue;
            zatwierdz.Location = new Point(215, 310);
            zatwierdz.Name = "zatwierdz";
            zatwierdz.Size = new Size(349, 38);
            zatwierdz.TabIndex = 13;
            zatwierdz.Text = "Zatwierdź";
            zatwierdz.UseVisualStyleBackColor = false;
            zatwierdz.Click += Zatwierdz;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 360);
            Controls.Add(zatwierdz);
            Controls.Add(generowanieHasla);
            Controls.Add(danePracownika);
            Name = "Form1";
            Text = "Dodaj pracownika";
            danePracownika.ResumeLayout(false);
            danePracownika.PerformLayout();
            generowanieHasla.ResumeLayout(false);
            generowanieHasla.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox danePracownika;
        private ComboBox stanowisko;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox naziwsko;
        private TextBox imie;
        private GroupBox generowanieHasla;
        private Label label4;
        private TextBox ileZnakow;
        private Button generujHaslo;
        private CheckBox znakiSpecjalne;
        private CheckBox cyfry;
        private CheckBox litery;
        private Button zatwierdz;
    }
}
