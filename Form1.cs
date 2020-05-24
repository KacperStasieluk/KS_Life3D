using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using t3d;
using punkt;

namespace KS_Life3D
{
    public partial class Form1 : Form
    {
//----------DEKLARACJE POMOCNYCH OBIEKTÓW I ZMIENNYCH----------//
        private Kostka[,,] kostki; // <-- Tablica 3D kostek
        private byte[,,] tab; // <-- Główna tablica komórek
        private byte[,,] _tab; // <-- Pomocnicza tablica komórek
        private int rozmiar = 50; // <-- Obszar roboczy
        private double r = 500, fi = 45, teta = 60;
        private Pen p = new Pen(Color.Green);
        private SolidBrush sb = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

        Point myszPoprzedniaPoz = new Point();
        Point myszRoznica = new Point();
        int myszPoprzedniaPozZoom;
        int myszRoznicaZoom;

        Random rnd = new Random();

        private int losowanie = 5;
        private int przezywaOd = 2, przezywaDo = 3;
        private int ozywaOd = 3, ozywaDo = 3;

//----------INICJALIZACJA----------//

        public Form1()
        {
            InitializeComponent();
            tab = new byte[rozmiar, rozmiar, rozmiar];
            _tab = new byte[rozmiar, rozmiar, rozmiar];
            kostki = new Kostka[rozmiar, rozmiar, rozmiar];

            for (int i = 1; i < rozmiar-1; i++)
            {
                for (int j = 1; j < rozmiar-1; j++)
                {
                    for (int k = 1; k < rozmiar-1; k++)
                    {
                        if (rnd.Next(losowanie) == 0) tab[i, j, k] = 1;
                        else tab[i, j, k] = 0;

                        kostki[i, j, k] = new Kostka(i - rozmiar/2, j - rozmiar / 2, k - rozmiar / 2);
                    }
                }
            }

            timer1.Start();
        }

//----------ODŚWIEŻANIE I WYKONYWANIE KROKU----------//

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(buttonAnimacja.Text == "Wstrzymaj") krok();
            nowyPanel1.Invalidate();
        }

        private void krok()
        {
            //WYLICZANIE NOWEGO WYGLĄDU TABLICY NA TABLICY POMOCNICZEJ:
            for (int i = 1; i < rozmiar - 1; i++)
            {
                for (int j = 1; j < rozmiar - 1; j++)
                {
                    for (int k = 1; k < rozmiar - 1; k++)
                    {
                        //Policzenie liczby sąsiadów według sąsiedztwa Moore'a:
                        int sasiedzi = znajdzSasiadow(i, j, k);

                        //Jeśli komórka żyje:
                        if (tab[i, j, k] == 1)
                        {
                            //...i NIE MA od "przezywaOd" do "przezywaDo" sąsiadów, uśmierć ją.
                            //W przedziwnym wypadku - pozostaw żywą.
                            if (!(sasiedzi >= przezywaOd && sasiedzi <= przezywaDo)) _tab[i, j, k] = 0;
                            else _tab[i, j, k] = 1;
                        }
                        //Jeśli komórka nie żyje:
                        else
                        {
                            //...i ma od "umieraOd" do "umieraDo" sąsiadów, ożyw ją.
                            //W przeciwnym wypadku - pozostaw martwą.
                            if ((sasiedzi >= ozywaOd && sasiedzi <= ozywaDo)) _tab[i, j, k] = 1;
                            else _tab[i, j, k] = 0;
                        }
                    }
                }
            }

            //PRZEPISYWANIE TABLICY POMOCNICZEJ DO TABLICY GŁÓWNEJ:
            for (int i = 1; i < rozmiar - 1; i++)
            {
                for (int j = 1; j < rozmiar - 1; j++)
                {
                    for (int k = 1; k < rozmiar - 1; k++)
                    {
                        tab[i, j, k] = _tab[i, j, k];
                    }
                }
            }
        }

//----------RYSOWANIE----------//
        public void nowyPanel1_Paint(object sender, PaintEventArgs e)
        {
            //PODSTAWOWE DEKLARACJE:
            Graphics g = e.Graphics;
            Punkt obserwator = Punkt.RFiTetaToXYZ(r, fi, teta);
            T3d projektor = new T3d(obserwator, nowyPanel1.ClientRectangle);

            //WYRYSOWYWANIE GRANIC OBSZARU ROBOCZEGO:
            Punkt[] obszar = new Punkt[8];
            Point[] _obszar = new Point[8];

            obszar[0] = new Punkt(-25, -25, -25);
            obszar[1] = new Punkt(25, -25, -25);
            obszar[2] = new Punkt(25, 25, -25);
            obszar[3] = new Punkt(-25, 25, -25);
            obszar[4] = new Punkt(-25, -25, 25);
            obszar[5] = new Punkt(25, -25, 25);
            obszar[6] = new Punkt(25, 25, 25);
            obszar[7] = new Punkt(-25, 25, 25);

            for (int i = 0; i < 8; i++)
            {
                projektor.punkt_3d(out _obszar[i], obszar[i]);
            }

            g.DrawLine(p, _obszar[0], _obszar[1]);
            g.DrawLine(p, _obszar[1], _obszar[2]);
            g.DrawLine(p, _obszar[2], _obszar[3]);
            g.DrawLine(p, _obszar[3], _obszar[0]);

            g.DrawLine(p, _obszar[4], _obszar[5]);
            g.DrawLine(p, _obszar[5], _obszar[6]);
            g.DrawLine(p, _obszar[6], _obszar[7]);
            g.DrawLine(p, _obszar[7], _obszar[4]);

            g.DrawLine(p, _obszar[0], _obszar[4]);
            g.DrawLine(p, _obszar[1], _obszar[5]);
            g.DrawLine(p, _obszar[2], _obszar[6]);
            g.DrawLine(p, _obszar[3], _obszar[7]);

            //RYSOWANIE KOSTEK:
            for (int i = 1; i < rozmiar - 1; i++)
            {
                for (int j = 1; j < rozmiar - 1; j++)
                {
                    for (int k = 1; k < rozmiar - 1; k++)
                    {
                        if (tab[i, j, k] == 1)
                        {
                            for (int l = 0; l < kostki[i, j, k].granice.Length; l++)
                            {
                                projektor.punkt_3d(out kostki[i, j, k]._granice[l], kostki[i, j, k].granice[l]);
                            }
                            sb.Color = Color.FromArgb(255, 255 - i, 255 - 2 * j, 255 - 3 * k);
                            kostki[i, j, k].rysuj(sb, g, obserwator);
                        }
                    }
                }
            }
        }

//----------ZNAJDOWANIE SĄSIADÓW----------//
        private int znajdzSasiadow(int i, int j, int k)
        {
            //Liczenie sąsiadów odbywa się na obszarze 3x3x3,
            //gdzie punktem centralnym jest komórka, dla której
            //tych sąsiadów liczymy - ona nie jest brana pod uwagę:
            int sasiedzi = 0;
            for (int a = i - 1; a < i + 2; a++)
            {
                for (int b = j - 1; b < j + 2; b++)
                {
                    for (int c = k - 1; c < k + 2; c++)
                    {
                        if ((a != i && b != j && c != k) && tab[a, b, c] == 1) sasiedzi++;
                    }
                }
            }
            return sasiedzi;
        }

//----------PONOWNE ROZSTAWIANIE----------//
        private void buttonRozstaw_Click(object sender, EventArgs e)
        {
            //ZEROWANIE TABLICY:
            for (int i = 1; i < rozmiar - 1; i++)
            {
                for (int j = 1; j < rozmiar - 1; j++)
                {
                    for (int k = 1; k < rozmiar - 1; k++)
                    {
                        tab[i, j, k] = 0;
                    }
                }
            }

            //GENEROWANIE NOWYCH WARTOŚCI TABLICY NA ZADANYM OBSZARZE, LICZĄC OD ŚRODKA OBSZARU ROBOCZEGO:
            for (int i = (rozmiar / 2) - (int)numericUpDownX.Value / 2; i < (rozmiar / 2) + (int)numericUpDownX.Value / 2; i++)
            {
                for (int j = (rozmiar / 2) - (int)numericUpDownY.Value / 2; j < (rozmiar / 2) + (int)numericUpDownY.Value / 2; j++)
                {
                    for (int k = (rozmiar / 2) - (int)numericUpDownZ.Value / 2; k < (rozmiar / 2) + (int)numericUpDownZ.Value / 2; k++)
                    {
                        if (rnd.Next(losowanie) == 0) tab[i, j, k] = 1;
                        else tab[i, j, k] = 0;
                    }
                }
            }
        }

//----------STEROWANIE MYSZĄ----------//

        private void nowyPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myszPoprzedniaPoz = e.Location;
                Cursor.Current = Cursors.NoMove2D;
            }

            if (e.Button == MouseButtons.Right)
            {
                myszPoprzedniaPozZoom = e.Location.Y;
                Cursor.Current = Cursors.NoMoveVert;
            }
        }

        private void nowyPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myszRoznica = e.Location - (Size)myszPoprzedniaPoz;
                fi -= myszRoznica.X;
                teta += myszRoznica.Y;
                myszPoprzedniaPoz = e.Location;
            }

            if (e.Button == MouseButtons.Right)
            {
                myszRoznicaZoom = e.Location.Y - myszPoprzedniaPozZoom;
                if (r + myszRoznicaZoom > 1 && r + myszRoznicaZoom < 5000) r += myszRoznicaZoom;
                myszPoprzedniaPozZoom = e.Location.Y;
            }
        }

//----------PRZYBORNIK----------//

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            przezywaOd = (int)numericUpDownPrzezywaOd.Value;
            przezywaDo = (int)numericUpDownPrzezywaDo.Value;
            ozywaOd = (int)numericUpDownUmieraOd.Value;
            ozywaDo = (int)numericUpDownUmieraDo.Value;
        }

        private void numericUpDownLosowanie_ValueChanged(object sender, EventArgs e)
        {
            losowanie = (int)numericUpDownLosowanie.Value;
        }

        private void buttonAnimacja_Click(object sender, EventArgs e)
        {
            if (buttonAnimacja.Text == "Animuj") buttonAnimacja.Text = "Wstrzymaj";
            else buttonAnimacja.Text = "Animuj";
        }

        private void numericUpDownTimer_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDownTimer.Value;
        }

        private void buttonKrok_Click(object sender, EventArgs e)
        {
            krok();
        }   
    }

//----------PANEL Z PODWÓJNYM BUFOROWANIEM----------//

    class NowyPanel : Panel
    {
        public NowyPanel()
        {
            DoubleBuffered = true;
        }
    }

//----------KOSTKA----------//

    //Klasa Kostka musi dziedziczyć po Punkcie,
    //żeby móc użyć funkcji odleglosc().
    public class Kostka : Punkt
    {
        public Punkt[] granice = new Punkt[8];
        public Point[] _granice = new Point[8];
        public Punkt najblizszy = new Punkt();

        public Kostka(int i, int j, int k)
        {
            obliczGranice(i, j, k);
        }

        public void rysuj(SolidBrush sb, Graphics g, Punkt obs)
        {
            Point[] punkty = new Point[4]; // <-- Tablica do rysowania Polygonów

            //WYLICZANIE NAJBLIŻSZEGO ROGU KOSTKI:
            
            //Wyliczanie to służy zapobiegnięciu rysowania wszystkich
            //ścianek kostki, skoro części z nich i tak nie widzimy.
            //W najgorszym wypadku jesteśmy w stanie, patrząc na sześcian,
            //zobaczyć maksymalnie 3 jego ściany. Dlatego w zależności od
            //tego, który wierzchołek znajduje się najbliżej obserwatora, to zostaną
            //narysowane tylko te 3 ściany, które jest w stanie zobaczyć
            //obserwator.

            double min = 999;
            for(int i = 0; i < 8; i++)
            {
                double nowa = odleglosc(granice[i], obs);
                if (nowa < min)
                {
                    min = nowa;
                    najblizszy = granice[i];
                }
            }
            
            //SPRAWDZANIE, KTÓRY WIERZCHOŁEK JEST NAJBLIŻSZY
            //I W ZALEŻNOŚCI OD NIEGO - RYSOWANIE:

            if (najblizszy == granice[4])
            {
                gorna();
                lewo_tyl();
                prawo_tyl();
            }
            else if (najblizszy == granice[5])
            {
                gorna();
                lewo_przod();
                lewo_tyl();
            }
            else if (najblizszy == granice[6])
            {
                gorna();
                lewo_przod();
                prawo_przod();
            }
            else if (najblizszy == granice[7])
            {
                gorna();
                prawo_przod();
                prawo_tyl();
            }
            else if (najblizszy == granice[0])
            {
                dolna();
                lewo_tyl();
                prawo_tyl();
            }
            else if (najblizszy == granice[1])
            {
                dolna();
                lewo_przod();
                lewo_tyl();
            }
            else if (najblizszy == granice[2])
            {
                dolna();
                lewo_przod();
                prawo_przod();
            }
            else if (najblizszy == granice[3])
            {
                dolna();
                prawo_przod();
                prawo_tyl();
            }

            //FUNKCJE RYSUJĄCE ŚCIANY:

            void dolna()
            {
                punkty[0] = _granice[0];
                punkty[1] = _granice[1];
                punkty[2] = _granice[2];
                punkty[3] = _granice[3];
                g.FillPolygon(sb, punkty);
            }

            void gorna()
            {
                punkty[0] = _granice[4];
                punkty[1] = _granice[5];
                punkty[2] = _granice[6];
                punkty[3] = _granice[7];
                g.FillPolygon(sb, punkty);
            }

            void lewo_tyl()
            {
                punkty[0] = _granice[0];
                punkty[1] = _granice[1];
                punkty[2] = _granice[5];
                punkty[3] = _granice[4];
                g.FillPolygon(sb, punkty);
            }

            void lewo_przod()
            {
                punkty[0] = _granice[1];
                punkty[1] = _granice[2];
                punkty[2] = _granice[6];
                punkty[3] = _granice[5];
                g.FillPolygon(sb, punkty);
            }

            void prawo_tyl()
            {
                punkty[0] = _granice[0];
                punkty[1] = _granice[3];
                punkty[2] = _granice[7];
                punkty[3] = _granice[4];
                g.FillPolygon(sb, punkty);
            }

            void prawo_przod()
            {
                punkty[0] = _granice[2];
                punkty[1] = _granice[3];
                punkty[2] = _granice[7];
                punkty[3] = _granice[6];
                g.FillPolygon(sb, punkty);
            }
        }

        public void obliczGranice(int i, int j, int k)
        {
            //WYLICZANIE WSZYSTKICH WIERZCHOŁKÓW KOSTKI:
            granice[0] = new Punkt(i, j, k);
            granice[1] = new Punkt(i + 1, j, k);
            granice[2] = new Punkt(i + 1, j + 1, k);
            granice[3] = new Punkt(i, j + 1, k);
            granice[4] = new Punkt(i, j, k + 1);
            granice[5] = new Punkt(i + 1, j, k + 1);
            granice[6] = new Punkt(i + 1, j + 1, k + 1);
            granice[7] = new Punkt(i, j + 1, k + 1);
        }
    }
}