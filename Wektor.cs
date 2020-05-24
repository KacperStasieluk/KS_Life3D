// Deklaracja podstawowych klas geometrycznych,
// Głównym zadaniem tych klas jest skrócenie zapisu współrzędnych 3d.
// Andrzej Stasiewicz, 2020
//
//---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using punkt;

namespace wektor
{
// Wektor 3d (a wlasciciwie tylko jego współrzędne, bez punktu zaczepienia).
    public class Wektor
    {
         public float vx, vy, vz;                      //długości współrzędnych
//---------------------------------------------------------------------------
//  Konstruktor wektora zerowego
         public Wektor( )
         {
             vx = vy = vz = 0.0f;
         }
//---------------------------------------------------------------------------
//  Konstruktor wektora o wskazanym kierunku
         public Wektor(float Avx, float Avy, float Avz)
         {
              vx = Avx;
              vy = Avy;
              vz = Avz;
         }
//---------------------------------------------------------------------------
//  Konstruktor wektora rozpiętego między dwoma punktami
         public Wektor( Punkt Ap, Punkt Ak)
         {
             vx = Ak.x - Ap.x;
             vy = Ak.y - Ap.y;
             vz = Ak.z - Ap.z;
         }
//---------------------------------------------------------------------------
// Translacja punktu o zadany wektor
        public static Punkt operator +(Wektor w, Punkt p)
        {
            return new Punkt(p.x + w.vx, p.y + w.vy, p.z + w.vz);
        }
//---------------------------------------------------------------------------
// suma 2 wektorów. Początkiem jest początek pierwszego składnika.
//  Drugi składnik nie musi mieć początku w miejscu końca pierwszego.
        public static Wektor operator +( Wektor w1, Wektor w2)
        {
            return new Wektor(w1.vx + w2.vx, w1.vy + w2.vy, w1.vz + w2.vz);
        }
//---------------------------------------------------------------------------
// Iloczyn liczby i wektora (wydłużanie / skracanie wektora)
public static Wektor operator *( Wektor w, float a)
{
    return new Wektor(w.vx * a, w.vy * a, w.vz * a);
}
//---------------------------------------------------------------------------
// Powyższy iloczyn zapisany w innej kolejności
        public static Wektor operator *( float a, Wektor w)
        {
            return new Wektor(w.vx * a, w.vy * a, w.vz * a);
        }
//---------------------------------------------------------------------------
// Operator zmiany zwrotu (tzw. unarny "-")
         public static Wektor operator - (Wektor w)
         {
             w.vx = -w.vx;
             w.vy = -w.vy;
             w.vz = -w.vz;
             return w;
         }
//---------------------------------------------------------------------------
// Iloczyn skalarny 2 wektorów. Na ogół służy do wyznaczania zgodności kierunków wektorów w1 i w2
         public static double operator *(Wektor w1, Wektor w2)
         {
             return (w1.vx * w2.vx + w1.vy * w2.vy + w1.vz * w2.vz);
         }
//---------------------------------------------------------------------------
// Iloczyn wektorowy 2 wektorów. Na ogół służy do wyznaczania kierunku prostopadłego do powierzchni rozpiętej na w1 i w2
         public static Wektor operator ^(Wektor w1, Wektor w2)
         {
             return new Wektor(w1.vy * w2.vz - w1.vz * w2.vy,
                               w1.vz * w2.vx - w1.vx * w2.vz,
                               w1.vx * w2.vy - w1.vy * w2.vx);
         }
//---------------------------------------------------------------------------
// Uczyń długość wektora = 1
         public void unormuj()
         {
            float dlg = dlugosc();
             if (dlg > 0)                               //na wszelki wypadek ...
             {
                 vx /= dlg;
                 vy /= dlg;
                 vz /= dlg;
             }
         }
//---------------------------------------------------------------------------
// Oblicz długość
         public float dlugosc()
         {
             return (float)Math.Sqrt( vx * vx + vy * vy + vz * vz);
         }
    }
}
