//  Klasa wyznaczająca ekranowe położenie punktu z przestrzeni 3d,
//  postrzeganego z dowolnego miejsca, zadanego położeniem obserwatora.
//  Obserwator spogląda w kierunku centrum (0, 0, 0),
//  dlatego obserwowana rzeczywistość powinna być zdefiniowana wokół środka.
//
using macierz;
using wektor;
using skala;
using punkt;
using System.Drawing;

namespace t3d
{
    class T3d
    {
        private Macierz M;                               //macierz przejścia do układu obserwatora
        private Skala s;                                 //przeskalowanie ekranu metrycznego w pikselowy
        private double fodl_ekr;
        private Wektor fR;                               //wektor przesunięcia układu obserwatora;
                                                         //---------------------------------------------------------------------------
                                                         //	Konstruktor główny, inicjujący wszystkie parametry przekształcenia 3d
                                                         //  Trzy ostatnie paramtry (metryczny opis ekranu) nie są wymagane -
                                                         //  zostaną obliczone ze wymiarów pikselowych i  standardowej pozycji
                                                         //  komputerowca przed monitorem .
        public T3d(Punkt obs,                           //pozycja obserwatora
            int xe0, int ye0, int eszer, int ewys,       //okno ekranowe w pikselach
            float odl_ekr = 0,                          //typowa odległość oczu od monitora
            float szer_ekr = 0, float wys_ekr = 0)      //fizyczny opis ekranu w metrach
        {
            Punkt centrum = new Punkt(0, 0, 0);            //tam patrzy obserwator
            Wektor pion = new Wektor(0, 0, 1);             //pomocniczy wektor, orientujący obserwatora w 3d
            if (odl_ekr <= 0)
                odl_ekr = 0.5f;
            if (szer_ekr <= 0)                                //gdy nie określono rozmiarów ekranu
                szer_ekr = (float)eszer * 0.0257f / 96.0f;    //0.0257 m = 1 cal. Ekran ma 96 pikseli/cal
            if (wys_ekr <= 0)
                wys_ekr = (float)ewys * 0.0257f / 96.0f;

            s = new Skala(xe0, ye0, eszer, ewys, 0, 0, szer_ekr, wys_ekr);

            Wektor w3 = new Wektor(obs, centrum);          //lokalny wektor z obserwatora (wkazujący środek układu)
            w3.unormuj();

            Wektor w1 = new Wektor();
            w1 = (pion ^ w3);                               //lokalny wektor osi x' obserwatora
            w1.unormuj();

            Wektor w2 = new Wektor();
            w2 = (w3 ^ w1);                                //lokalny wektor osi y' obserwatora
            w1 = -w1;                                       //lewoskrętność układu obserwatora

            M = new Macierz(w1, w2, w3);                   //macierz przekształcenia

            fodl_ekr = odl_ekr;                             //parametry potrzebne innym funkcjom
            fR = new Wektor(obs, new Punkt());             //tyle dystansu dzieli układy odniesienia
        }
        //---------------------------------------------------------------------------
        //Techniczny konstruktor o innym kształcie
        public T3d(Punkt obs,                           //pozycja obserwatora
            Rectangle e,                                //okno ekranowe w pikselach
            float odl_ekr = 0,                          //typowa odległość oczu od monitora
            float szer_ekr = 0, float wys_ekr = 0)      //rozmiary ekranu w metrzach
            : this (obs, e.X, e.Y, e.Width, e.Height, odl_ekr, szer_ekr, wys_ekr)
        {
        }
        //---------------------------------------------------------------------------
        //	Wylicz współrzędne punktu z przestrzeni 3d,
        //  najpierw transformując go do układu obserwatora,
        //  potem znajdując jego obraz na ekranie rzeczywistym (metrycznym)
        //  i w końcu przeskalowując ów obraz metryczny w pikselowy
        public bool punkt_3d( out int xe, out int ye, Punkt p) 
        {
         Punkt nowy = new Punkt();                       //punkt w układzie obserwatora
         nowy = p + fR;                                  //przesunięcie współrzędnych do ukł. obserwatora
         nowy = M * nowy;                                //obrót

         if (nowy.z == 0)
         {
             xe = ye = 0;                               //out: musi byc wpisanie
             return false;
         }

         xe = s.daj_ekr_x( nowy.x * fodl_ekr / nowy.z);
         ye = s.daj_ekr_y( nowy.y * fodl_ekr / nowy.z);
        // xe = s -> daj_ekr_x( atan( nowy.x / nowy.z) * fodl_ekr); //sferyczny ekran (np. siatkówka oka)
        // ye = s -> daj_ekr_y( atan( nowy.y / nowy.z) * fodl_ekr);
         return true;
        }
        //-----------------------------------------------------------------------------
        //To samo w wersji kompaktowej
        public bool punkt_3d( out Point e, Punkt p)
        {
            int xe, ye;
            bool ret = punkt_3d(out xe, out ye, p);
            e = new Point(xe, ye);
            return ret;
        }
    }
}
