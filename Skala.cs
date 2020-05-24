//  Przeskalowanie (liniowe) obszaru metrycznego z Realu w obszar pikselowy na ekranie
using System.Drawing;

namespace skala
{
    class Skala
    {
       private float A, B, C, D;			//skaling z real na ekr
       private float E, F, G, H;            //skaling z ekr na real
        // Konstruktor skalowania powierzchniowego.
        // (xe0, ye0) - lewy górny róg obszaru ekranowego,
        // eszer, ewys - szerokość i wysokość obszaru ekranowego
        // (xr0, yr0) - środek obszaru rzeczywistego,
        // rszer, rwys - szerokość i wysokość obszaru rzeczywistego
        public Skala(int xe0, int ye0, int eszer, int ewys, float xr0, float yr0, float rszer, float rwys)
        {
            A = (float)eszer / rszer;	//z przestrzeni na ekran
            B = (float)xe0 - A * (xr0 - rszer / 2.0f);
            C = -(float)ewys / rwys;
            D = (float)ye0 - C * (yr0 + rwys / 2.0f);

            E = rszer / (float)eszer;		//z ekranu do przestrzeni
            F = xr0 - rszer / 2.0f - E * (float)xe0;
            G = -rwys / (float)ewys;
            H = yr0 + rwys / 2.0f - G * (float)ye0;
        }
        //To samo w wersji Rectangle
        public Skala( Rectangle e, RectangleF r)

       {
            A = (float)e.Width / r.Width;	//z przestrzeni na ekran
            B = (float) e.X - A * (r.X - r.Width / 2.0f);
            C = -(float)e.Height / r.Height;
            D = (float) e.Y - C * (r.Y + r.Height / 2.0f);

            E = r.Width / (float)e.Width;		//z ekranu do przestrzeni
            F = r.X - r.Width / 2.0f - E * (float)e.X;
            G = -r.Height / (float)e.Height;
            H = r.Y + r.Height / 2.0f - G * (float)e.Y;
       }
       // Wyliczenie współrzędnej ekranowej xe punktu,
       // gdy znana jest jego współrzędna rzeczywista x.
       public int daj_ekr_x( double x)
       {
           return (int)(A * x + B);
       }
       // Wyliczenie współrzędnej ekranowej ye punktu,
       // gdy znana jest jego współrzędna rzeczywista y.
       public int daj_ekr_y(double y)
       {
           return (int)(C * y + D);
       }
        //Wyliczenie pary współrzędnych ekranowych z pary współrzędnych rzeczywistych
        public Point daj_ekr_xy( PointF rp)
        {
            return new Point( (int)(A * rp.X + B), (int)(C * rp.Y + D));
        }
       //	Wyliczenie współrzędnej rzeczywistej x punktu,
       //	gdy znana jest jego współrzŕdna ekranowa xe.
       public double daj_real_x( int xe)
       {
            return E * xe + F;
       }
        //	Wyliczenie współrzędnej rzeczywistej y punktu,
        //	gdy znana jest jego współrzŕdna ekranowa ye.
        public double daj_real_y( int ye)
       {
             return G * ye + H;
       }
        //Wyliczenie pary współrzędnych rzeczywistych z pary współrzędnych ekranowych
        public PointF daj_real_xy( Point ep)
        {
            return new PointF( E * ep.X + F, G * ep.Y + H);
        }
    }
}
