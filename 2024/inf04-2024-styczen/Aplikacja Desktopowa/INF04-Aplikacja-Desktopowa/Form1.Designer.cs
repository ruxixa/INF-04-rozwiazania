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
            numerLabel = new Label();
            ImieLabel = new Label();
            NazwiskoLabel = new Label();
            imieInput = new TextBox();
            nazwiskoInput = new TextBox();
            kolorOczuGroup = new GroupBox();
            piwneRadio = new RadioButton();
            zieloneRadio = new RadioButton();
            niebieskieRadio = new RadioButton();
            czlowiekImage = new PictureBox();
            odciskImage = new PictureBox();
            OkButton = new Button();
            numerInput = new TextBox();
            kolorOczuGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)czlowiekImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)odciskImage).BeginInit();
            SuspendLayout();
            // 
            // numerLabel
            // 
            numerLabel.AutoSize = true;
            numerLabel.Location = new Point(27, 29);
            numerLabel.Name = "numerLabel";
            numerLabel.Size = new Size(50, 15);
            numerLabel.TabIndex = 0;
            numerLabel.Text = "Numer: ";
            // 
            // ImieLabel
            // 
            ImieLabel.AutoSize = true;
            ImieLabel.Location = new Point(27, 73);
            ImieLabel.Name = "ImieLabel";
            ImieLabel.Size = new Size(33, 15);
            ImieLabel.TabIndex = 1;
            ImieLabel.Text = "Imię:";
            // 
            // NazwiskoLabel
            // 
            NazwiskoLabel.AutoSize = true;
            NazwiskoLabel.Location = new Point(27, 119);
            NazwiskoLabel.Name = "NazwiskoLabel";
            NazwiskoLabel.Size = new Size(60, 15);
            NazwiskoLabel.TabIndex = 2;
            NazwiskoLabel.Text = "Nazwisko:";
            // 
            // imieInput
            // 
            imieInput.BackColor = Color.Azure;
            imieInput.Location = new Point(126, 70);
            imieInput.Name = "imieInput";
            imieInput.Size = new Size(217, 23);
            imieInput.TabIndex = 4;
            // 
            // nazwiskoInput
            // 
            nazwiskoInput.BackColor = Color.Azure;
            nazwiskoInput.Location = new Point(126, 116);
            nazwiskoInput.Name = "nazwiskoInput";
            nazwiskoInput.Size = new Size(217, 23);
            nazwiskoInput.TabIndex = 5;
            // 
            // kolorOczuGroup
            // 
            kolorOczuGroup.Controls.Add(piwneRadio);
            kolorOczuGroup.Controls.Add(zieloneRadio);
            kolorOczuGroup.Controls.Add(niebieskieRadio);
            kolorOczuGroup.Location = new Point(27, 161);
            kolorOczuGroup.Name = "kolorOczuGroup";
            kolorOczuGroup.Size = new Size(316, 121);
            kolorOczuGroup.TabIndex = 6;
            kolorOczuGroup.TabStop = false;
            kolorOczuGroup.Text = "Kolor oczu";
            // 
            // piwneRadio
            // 
            piwneRadio.AutoSize = true;
            piwneRadio.Location = new Point(14, 88);
            piwneRadio.Name = "piwneRadio";
            piwneRadio.Size = new Size(57, 19);
            piwneRadio.TabIndex = 2;
            piwneRadio.TabStop = true;
            piwneRadio.Text = "piwne";
            piwneRadio.UseVisualStyleBackColor = true;
            // 
            // zieloneRadio
            // 
            zieloneRadio.AutoSize = true;
            zieloneRadio.Location = new Point(14, 55);
            zieloneRadio.Name = "zieloneRadio";
            zieloneRadio.Size = new Size(62, 19);
            zieloneRadio.TabIndex = 1;
            zieloneRadio.TabStop = true;
            zieloneRadio.Text = "zielone";
            zieloneRadio.UseVisualStyleBackColor = true;
            // 
            // niebieskieRadio
            // 
            niebieskieRadio.AutoSize = true;
            niebieskieRadio.Location = new Point(14, 24);
            niebieskieRadio.Name = "niebieskieRadio";
            niebieskieRadio.Size = new Size(77, 19);
            niebieskieRadio.TabIndex = 0;
            niebieskieRadio.TabStop = true;
            niebieskieRadio.Text = "niebieskie";
            niebieskieRadio.UseVisualStyleBackColor = true;
            // 
            // czlowiekImage
            // 
            czlowiekImage.Image = Properties.Resources._000_zdjecie;
            czlowiekImage.Location = new Point(382, 26);
            czlowiekImage.Name = "czlowiekImage";
            czlowiekImage.Size = new Size(226, 203);
            czlowiekImage.TabIndex = 7;
            czlowiekImage.TabStop = false;
            // 
            // odciskImage
            // 
            odciskImage.Image = Properties.Resources._000_odcisk;
            odciskImage.Location = new Point(591, 26);
            odciskImage.Name = "odciskImage";
            odciskImage.Size = new Size(185, 203);
            odciskImage.TabIndex = 8;
            odciskImage.TabStop = false;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.Azure;
            OkButton.Location = new Point(462, 242);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(246, 33);
            OkButton.TabIndex = 9;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButtonClick;
            // 
            // numerInput
            // 
            numerInput.BackColor = Color.Azure;
            numerInput.Location = new Point(126, 26);
            numerInput.Name = "numerInput";
            numerInput.Size = new Size(217, 23);
            numerInput.TabIndex = 10;
            numerInput.Validated += NumerInputChangeValue;
            // 
            // Paszport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 303);
            Controls.Add(numerInput);
            Controls.Add(OkButton);
            Controls.Add(odciskImage);
            Controls.Add(czlowiekImage);
            Controls.Add(kolorOczuGroup);
            Controls.Add(nazwiskoInput);
            Controls.Add(imieInput);
            Controls.Add(NazwiskoLabel);
            Controls.Add(ImieLabel);
            Controls.Add(numerLabel);
            Name = "Paszport";
            Text = "Wprowadzenie danych do paszportu. Wykonał: ruxixa";
            kolorOczuGroup.ResumeLayout(false);
            kolorOczuGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)czlowiekImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)odciskImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numerLabel;
        private Label ImieLabel;
        private Label NazwiskoLabel;
        private TextBox imieInput;
        private TextBox nazwiskoInput;
        private GroupBox kolorOczuGroup;
        private RadioButton piwneRadio;
        private RadioButton zieloneRadio;
        private RadioButton niebieskieRadio;
        private PictureBox czlowiekImage;
        private PictureBox odciskImage;
        private Button OkButton;
        private TextBox numerInput;
    }
}
