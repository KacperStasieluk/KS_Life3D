// Deklaracja podstawowych klas geometrycznych,
// Głównym zadaniem tych klas jest skrócenie zapisu współrzędnych 3d.
// Andrzej Stasiewicz, 2020
//
//---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wektor;
using macierz;

namespace punkt
{
// Punkt 3d
    public class Punkt
    {
        public float x, y, z;                             //współrzędne
//---------------------------------------------------------------------------
//  Konstruktor punktu zerowego
        public Punkt()
        {
            x = y = z = 0.0f;
        }
//---------------------------------------------------------------------------
//  Konstruktor inicjujący wskazanymi współrzędnymi
        public Punkt(float Ax, float Ay, float Az)
        {
            x = Ax;
            y = Ay;
            z = Az;
        }
        //---------------------------------------------------------------------------
        // Translacja punktu o zadany wektor, ale odwrotna kolejność
        public static Punkt operator +(Punkt p, Wektor w)
        {
            return new Punkt(p.x + w.vx, p.y + w.vy, p.z + w.vz);
        }
//---------------------------------------------------------------------------
// Odległość 2 punktów
        public double odleglosc( Punkt pa, Punkt pb)
        {
            return Math.Sqrt((pa.x - pb.x) * (pa.x - pb.x) + (pa.y - pb.y) * (pa.y - pb.y) + (pa.z - pb.z) * (pa.z - pb.z));
        }
//---------------------------------------------------------------------------
// Odległość 2 punktów
        public double odleglosc( Punkt p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y) + (z - p.z) * (z - p.z));
        }
//---------------------------------------------------------------------------
// iloczyn macierzy i punktu (przekształcenie punktu)
// Zwróć uwagę, że nie istnieje "operator * (TPunkt, TMacierz)"
        public static Punkt operator *(Macierz A, Punkt p)
        {
            Punkt r = new Punkt();
            r.x = A.a11 * p.x + A.a12 * p.y + A.a13 * p.z;
            r.y = A.a21 * p.x + A.a22 * p.y + A.a23 * p.z;
            r.z = A.a31 * p.x + A.a32 * p.y + A.a33 * p.z;
            return r;
        }
//---------------------------------------------------------------------------
// konwersja współrzędnych sferycznych na kartezjańskie
        public static Punkt RFiTetaToXYZ( double r, double fi, double teta)
        {
            float a = (float)Math.PI / 180.0f;
            float b = (float)(r * Math.Sin(a * teta));
            Punkt xyz = new Punkt( b * (float)Math.Cos(a * fi), 
                                   b * (float)Math.Sin(a * fi),
                                   (float)(r * Math.Cos(a * teta)));
            return xyz;
        }
    }
}
