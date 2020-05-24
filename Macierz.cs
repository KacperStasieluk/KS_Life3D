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

namespace macierz
{
    // Definicja macierzy 3x3 o następującym układzie elementów:
    //  a11  a12  a13
    //  a21  a22  a23
    //  a31  a32  a33
    public class Macierz
    {
         public float a11, a12, a13, a21, a22, a23, a31, a32, a33;
//---------------------------------------------------------------------------
// konstruktor domyślny tworzy macierz zerową
         public Macierz()
         {
             a11 = a12 = a13 = a21 = a22 = a23 = a31 = a32 = a33 = 0;
         }
//---------------------------------------------------------------------------
//  Konstruktor merytoryczny wprost tworzy zadaną macierz
        public Macierz( float Aa11, float Aa12, float Aa13,
                        float Aa21, float Aa22, float Aa23,
                        float Aa31, float Aa32, float Aa33)
         {
             a11 = Aa11; a12 = Aa12; a13 = Aa13;
             a21 = Aa21; a22 = Aa22; a23 = Aa23;
             a31 = Aa31; a32 = Aa32; a33 = Aa33;
         }
//---------------------------------------------------------------------------
// Inny konstruktor merytoryczny z podanych wektorów tworzy wiersze macierzy
         public Macierz(Wektor a, Wektor b, Wektor c)
         {
             a11 = a.vx; a12 = a.vy; a13 = a.vz;
             a21 = b.vx; a22 = b.vy; a23 = b.vz;
             a31 = c.vx; a32 = c.vy; a33 = c.vz;
         }
//---------------------------------------------------------------------------
// Iloczyn macierzy i liczby
         public static Macierz operator *(Macierz A, float a)
         {
             return new Macierz(a * A.a11, a * A.a12, a * A.a13, a * A.a21, a * A.a22, a * A.a23, a * A.a31, a * A.a32, a * A.a33);
         }
//---------------------------------------------------------------------------
// j. w., tylko w odwrotnej kolejności
         public static Macierz operator *(float a, Macierz A)
         {
             return new Macierz(a * A.a11, a * A.a12, a * A.a13, a * A.a21, a * A.a22, a * A.a23, a * A.a31, a * A.a32, a * A.a33);
         }
//---------------------------------------------------------------------------
// Iloczyn (złożenie) macierzy
         public static Macierz operator *(Macierz A, Macierz B)
         {
             Macierz r = new Macierz();
             r.a11 = A.a11 * B.a11 + A.a12 * B.a21 + A.a13 * B.a31;
             r.a12 = A.a11 * B.a12 + A.a12 * B.a22 + A.a13 * B.a32;
             r.a13 = A.a11 * B.a13 + A.a12 * B.a23 + A.a13 * B.a33;

             r.a21 = A.a21 * B.a11 + A.a22 * B.a21 + A.a23 * B.a31;
             r.a22 = A.a21 * B.a12 + A.a22 * B.a22 + A.a23 * B.a32;
             r.a23 = A.a21 * B.a13 + A.a22 * B.a23 + A.a23 * B.a33;

             r.a31 = A.a31 * B.a11 + A.a32 * B.a21 + A.a33 * B.a31;
             r.a32 = A.a31 * B.a12 + A.a32 * B.a22 + A.a33 * B.a32;
             r.a33 = A.a31 * B.a13 + A.a32 * B.a23 + A.a33 * B.a33;
             return r;
         }
    }
}
