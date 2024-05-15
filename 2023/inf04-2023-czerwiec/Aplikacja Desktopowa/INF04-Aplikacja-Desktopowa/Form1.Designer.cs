/* Autor: ruxixa 
*  
*  Plik: Form1.Designer.cs
*  
*  Data: 12.05.2024
*  Egzamin: INF-04 Styczeń 2024 
*  Zadanie: 1
*
*  Repozytorium: https://github.com/ruxixa/INF-04-rozwiazania
*  Licencja: CC0 1.0 Universal (CC0 1.0) Public Domain Dedication 
*/

namespace INF04_Aplikacja_Desktopowa
{
    partial class Paszport
    {
        private System.ComponentModel.IContainer components = null;

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
            rodzajPrzesylkiGroup = new GroupBox();
            PaczkaRadio = new RadioButton();
            ListRadio = new RadioButton();
            pocztowkaRadio = new RadioButton();
            sprawdzCeneButton = new Button();
            zatwierdzButton = new Button();
            daneAdresoweGroup = new GroupBox();
            miastoInput = new TextBox();
            miastoLabel = new Label();
            kodPocztowyInput = new TextBox();
            listLabel = new Label();
            ulicaInput = new TextBox();
            ulicaLabel = new Label();
            pictureBox1 = new PictureBox();
            cenaLabel = new Label();
            rodzajPrzesylkiGroup.SuspendLayout();
            daneAdresoweGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rodzajPrzesylkiGroup
            // 
            rodzajPrzesylkiGroup.Controls.Add(PaczkaRadio);
            rodzajPrzesylkiGroup.Controls.Add(ListRadio);
            rodzajPrzesylkiGroup.Controls.Add(pocztowkaRadio);
            rodzajPrzesylkiGroup.Location = new Point(28, 33);
            rodzajPrzesylkiGroup.Name = "rodzajPrzesylkiGroup";
            rodzajPrzesylkiGroup.Size = new Size(267, 167);
            rodzajPrzesylkiGroup.TabIndex = 0;
            rodzajPrzesylkiGroup.TabStop = false;
            rodzajPrzesylkiGroup.Text = "Rodzaj Przesyłki";
            // 
            // PaczkaRadio
            // 
            PaczkaRadio.AutoSize = true;
            PaczkaRadio.Location = new Point(22, 117);
            PaczkaRadio.Name = "PaczkaRadio";
            PaczkaRadio.Size = new Size(61, 19);
            PaczkaRadio.TabIndex = 2;
            PaczkaRadio.TabStop = true;
            PaczkaRadio.Text = "Paczka";
            PaczkaRadio.UseVisualStyleBackColor = true;
            // 
            // ListRadio
            // 
            ListRadio.AutoSize = true;
            ListRadio.Location = new Point(22, 76);
            ListRadio.Name = "ListRadio";
            ListRadio.Size = new Size(43, 19);
            ListRadio.TabIndex = 1;
            ListRadio.TabStop = true;
            ListRadio.Text = "List";
            ListRadio.UseVisualStyleBackColor = true;
            // 
            // pocztowkaRadio
            // 
            pocztowkaRadio.AutoSize = true;
            pocztowkaRadio.Location = new Point(22, 36);
            pocztowkaRadio.Name = "pocztowkaRadio";
            pocztowkaRadio.Size = new Size(82, 19);
            pocztowkaRadio.TabIndex = 0;
            pocztowkaRadio.TabStop = true;
            pocztowkaRadio.Text = "Pocztówka";
            pocztowkaRadio.UseVisualStyleBackColor = true;
            // 
            // sprawdzCeneButton
            // 
            sprawdzCeneButton.Location = new Point(28, 206);
            sprawdzCeneButton.Name = "sprawdzCeneButton";
            sprawdzCeneButton.Size = new Size(267, 32);
            sprawdzCeneButton.TabIndex = 1;
            sprawdzCeneButton.Text = "Sprawdź Cenę";
            sprawdzCeneButton.UseVisualStyleBackColor = true;
            sprawdzCeneButton.Click += sprawdzCeneButtonClicked;
            // 
            // zatwierdzButton
            // 
            zatwierdzButton.Location = new Point(28, 349);
            zatwierdzButton.Name = "ZatwierdzButton";
            zatwierdzButton.Size = new Size(665, 32);
            zatwierdzButton.TabIndex = 2;
            zatwierdzButton.Text = "Zatwierdź";
            zatwierdzButton.UseVisualStyleBackColor = true;
            zatwierdzButton.Click += zatwierdzButtonClicked;
            // 
            // daneAdresoweGroup
            // 
            daneAdresoweGroup.Controls.Add(miastoInput);
            daneAdresoweGroup.Controls.Add(miastoLabel);
            daneAdresoweGroup.Controls.Add(kodPocztowyInput);
            daneAdresoweGroup.Controls.Add(listLabel);
            daneAdresoweGroup.Controls.Add(ulicaInput);
            daneAdresoweGroup.Controls.Add(ulicaLabel);
            daneAdresoweGroup.Location = new Point(377, 33);
            daneAdresoweGroup.Name = "daneAdresoweGroup";
            daneAdresoweGroup.Size = new Size(316, 275);
            daneAdresoweGroup.TabIndex = 3;
            daneAdresoweGroup.TabStop = false;
            daneAdresoweGroup.Text = "Dane Adresowe";
            // 
            // miastoInput
            // 
            miastoInput.Location = new Point(19, 223);
            miastoInput.Name = "miastoInput";
            miastoInput.Size = new Size(285, 23);
            miastoInput.TabIndex = 7;
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Location = new Point(17, 202);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new Size(43, 15);
            miastoLabel.TabIndex = 6;
            miastoLabel.Text = "Miasto";
            // 
            // kodPocztowyInput
            // 
            kodPocztowyInput.Location = new Point(17, 142);
            kodPocztowyInput.Name = "kodPocztowyInput";
            kodPocztowyInput.Size = new Size(285, 23);
            kodPocztowyInput.TabIndex = 5;
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Location = new Point(15, 121);
            listLabel.Name = "listLabel";
            listLabel.Size = new Size(82, 15);
            listLabel.TabIndex = 4;
            listLabel.Text = "Kod Pocztowy";
            // 
            // ulicaInput
            // 
            ulicaInput.Location = new Point(17, 58);
            ulicaInput.Name = "ulicaInput";
            ulicaInput.Size = new Size(285, 23);
            ulicaInput.TabIndex = 3;
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Location = new Point(15, 37);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new Size(96, 15);
            ulicaLabel.TabIndex = 0;
            ulicaLabel.Text = "Ulica z numerem";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.list;
            pictureBox1.Location = new Point(29, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new Font("Segoe UI", 20F);
            cenaLabel.Location = new Point(165, 275);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new Size(90, 37);
            cenaLabel.TabIndex = 5;
            cenaLabel.Text = "Cena: ";
            // 
            // Paszport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 410);
            Controls.Add(cenaLabel);
            Controls.Add(pictureBox1);
            Controls.Add(daneAdresoweGroup);
            Controls.Add(zatwierdzButton);
            Controls.Add(sprawdzCeneButton);
            Controls.Add(rodzajPrzesylkiGroup);
            Name = "Paszport";
            Text = "Wprowadzenie danych do paszportu. Wykonał: ruxixa";
            rodzajPrzesylkiGroup.ResumeLayout(false);
            rodzajPrzesylkiGroup.PerformLayout();
            daneAdresoweGroup.ResumeLayout(false);
            daneAdresoweGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox rodzajPrzesylkiGroup;
        private RadioButton PaczkaRadio;
        private RadioButton ListRadio;
        private RadioButton pocztowkaRadio;
        private Button sprawdzCeneButton;
        private Button zatwierdzButton;
        private GroupBox daneAdresoweGroup;
        private Label ulicaLabel;
        private TextBox ulicaInput;
        private TextBox miastoInput;
        private Label miastoLabel;
        private TextBox kodPocztowyInput;
        private Label listLabel;
        private PictureBox pictureBox1;
        private Label cenaLabel;
    }
}
