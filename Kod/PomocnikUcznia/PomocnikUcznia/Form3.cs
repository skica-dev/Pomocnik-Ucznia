using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomocnikUcznia
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        // Te zmienne i stałe poniżej przydadzą nam się w dalszej części programu

        const int PLUS = 1;
        const int MINUS = 2;
        const int RAZY = 3;
        const int PODZIELIC = 4;

        double a = 0;
        double b = 0;
        int dzialanie = 0;
        bool kropka = false; // kropka dziesietna 
        int ilepoprzecinku = 0; // ilosc cyfr po przecinku gdy kropka jest wcisnieta 
        int znak = PLUS; // plus lub minus 

        bool czykasowacekran = false;

        // Metody pomocnicze

        // Dla przycisków działań oraz cmdWynik i cmdZnak ustawiamy właściwość Enabled na true
        public void pokazznaki()
        {
            cmdKropka.Enabled = true;
            cmdSuma.Enabled = true;
            cmdRoznica.Enabled = true;
            cmdIloczyn.Enabled = true;
            cmdIloraz.Enabled = true;
            if (dzialanie != 0) cmdWynik.Enabled = true;
            cmdZnak.Enabled = true;
        }

        // Dla przycisków działań oraz cmdWynik i cmdZnak ustawiamy właściwość Enabled na false
        public void ukryjznaki()
        {
            cmdKropka.Enabled = false;
            cmdSuma.Enabled = false;
            cmdRoznica.Enabled = false;
            cmdIloczyn.Enabled = false;
            cmdIloraz.Enabled = false;
            cmdWynik.Enabled = false;
            cmdZnak.Enabled = false;

        }

        /*
         * Kod będzie odpowiednio zwiększał zmienną, w której przechowywana jest aktualnie wpisywana liczba.
         */
        public void cyfry(int i)
        {
            pokazznaki();
            if (dzialanie != 0) // Czyli wcisnelismy cyfre po raz pierwszy po uruchomieniu programu 
            {
                if (!kropka) a = 10 * a + i; // np. 10 * 15 + 3 = 150 + 3 = 153 
                else
                {
                    if (i != 0) a = a + i / (Math.Pow(10, ilepoprzecinku++)); // Math.Pow - potega 
                    else ++ilepoprzecinku;
                }
            }
            else
            {
                if (!kropka) b = 10 * b + i;
                else
                {
                    if (i != 0) b = b + i / (Math.Pow(10, ilepoprzecinku++)); // np. 0.6 + 3 / 10^2 = 0.6 + 0.03 = 0.63 
                    else ++ilepoprzecinku;
                }
            }

            if (czykasowacekran)
            {
                txtWynik.Text = "";
                czykasowacekran = false;
                znak = PLUS;
            }
            txtWynik.Text += i.ToString();
        }
        /*
         * Najpierw wykonuje ona bieżące działanie (jeśli jakieś jest) na argumentach x i y, a następnie ustawia działanie na takie, jakie przesłano w argumencie dz. 
         */
        public double dzialaj(double x, double y, int dz)
        {
            ukryjznaki(); //wywołanie metody pomocniczej
            double wynik = 0;
            if (dzialanie != 0)
            {
                switch (dzialanie)
                {
                    case PLUS: wynik = y + x; break;
                    case MINUS: wynik = y - x; break;
                    case RAZY: wynik = y * x; break;
                    case PODZIELIC: wynik = y / x; break;
                }
                txtWynik.Text = wynik.ToString();
                a = 0;
            }
            else wynik = y; // jak wcisnelismy znak np. + po raz pierwszy 
            dzialanie = dz;
            czykasowacekran = true;
            cmdKropka.Enabled = true;
            ilepoprzecinku = 0;
            return wynik;
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 1
        private void cmd1_Click(object sender, EventArgs e)
        {
            cyfry(1);
        }
        
        // Obsługa zdarzenia po naciśnięciu klawisza 2
        private void cmd2_Click(object sender, EventArgs e)
        {
            cyfry(2);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 3
        private void cmd3_Click(object sender, EventArgs e)
        {
            cyfry(3);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 4
        private void cmd4_Click(object sender, EventArgs e)
        {
            cyfry(4);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 5
        private void cmd5_Click(object sender, EventArgs e)
        {
            cyfry(5);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 6
        private void cmd6_Click(object sender, EventArgs e)
        {
            cyfry(6);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 7
        private void cmd7_Click(object sender, EventArgs e)
        {
            cyfry(7);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 8
        private void cmd8_Click(object sender, EventArgs e)
        {
            cyfry(8);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 9
        private void cmd9_Click(object sender, EventArgs e)
        {
            cyfry(9);
        }

        // Obsługa zdarzenia po naciśnięciu klawisza 0
        private void cmd0_Click(object sender, EventArgs e)
        {
            cyfry(0);
        }

        // Teraz oprogramujemy kliknięcie kropki dziesiętnej
        private void cmdKropka_Click(object sender, EventArgs e)
        {
            if (czykasowacekran)
            {
                txtWynik.Text = "";
                czykasowacekran = false;
                znak = PLUS;
            }
            if (txtWynik.Text == "") txtWynik.Text = "0";
            txtWynik.Text += ",";
            cmdKropka.Enabled = false;
            kropka = true;
            ilepoprzecinku = 1;
        }

        // Działanie PLUS
        private void cmdSuma_Click(object sender, EventArgs e)
        {
            b = dzialaj(a, b, PLUS);
        }

        // Działanie MINUS
        private void cmdRoznica_Click(object sender, EventArgs e)
        {
            b = dzialaj(a, b, MINUS);
        }

        // Działanie RAZY
        private void cmdIloczyn_Click(object sender, EventArgs e)
        {
            b = dzialaj(a, b, RAZY);
        }

        // Działanie PODZIELIC
        private void cmdIloraz_Click(object sender, EventArgs e)
        {
            b = dzialaj(a, b, PODZIELIC);
        }

        // Zmina znaku (ustawienie zmiennej znak)
        private void cmdZnak_Click(object sender, EventArgs e)
        {
            if (znak == PLUS) znak = MINUS;
            else znak = PLUS;

            if (dzialanie != 0) { a = -a; txtWynik.Text = a.ToString(); }
            else { b = -b; txtWynik.Text = b.ToString(); }
        }

        // Działanie =
        private void cmdWynik_Click(object sender, EventArgs e)
        {
            b = dzialaj(a, b, dzialanie);
            txtWynik.Text = b.ToString();
            cmdKropka.Enabled = true;
            pokazznaki();
            cmdWynik.Enabled = false;
            cmdKropka.Enabled = false;
            dzialanie = PLUS;
            a = 0;
        }

        // Działanie Anuluj
        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            a = b = 0;
            dzialanie = 0;
            kropka = false;
            ilepoprzecinku = 0;
            txtWynik.Text = "";
            znak = PLUS;
            czykasowacekran = false;
            ukryjznaki();
        }

        // Wpisywanie z klawiatury
        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+': if (cmdSuma.Enabled) cmdSuma_Click(sender, e); return;
                case '-': if (cmdRoznica.Enabled) cmdRoznica_Click(sender, e); return;
                case '*': if (cmdIloczyn.Enabled) cmdIloczyn_Click(sender, e); return;
                case '/': if (cmdIloraz.Enabled) cmdIloraz_Click(sender, e); return;
                case (char)13: if (cmdWynik.Enabled) cmdWynik_Click(sender, e); return; // enter
                case (char)27: cmdAnuluj_Click(sender, e); return; // escape
                case '.':
                case ',': if (cmdKropka.Enabled) cmdKropka_Click(sender, e); return;
            }
            int n = (int)e.KeyChar;
            if (n < 48 || n > 57) return; // Jak nie nacisnelismy cyfry to wychodzimy z funkcji
            n = int.Parse(e.KeyChar.ToString());
            cyfry(n);
            return;
        }


    }
}
