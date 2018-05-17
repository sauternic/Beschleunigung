using System;
using System.Threading;

namespace Beschleunigen_C_Sharp
{
    class CFunktionen
    {

        public static void Beschleunigung1()
        {
            double t;
            double a;
            double s;


            Console.Write("\n\n Strecke in Meter Eingeben: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Zeit in Sekunden Eingeben: ");
            t = Convert.ToDouble(Console.ReadLine());

            a = (2 * s) / (t * t);

            Console.WriteLine("\n Beschleunigung in m/s2: {0:#,0.#################}", a);
            Console.WriteLine("\n Beschleunigung in G's (9.81m/s2): {0:#,0.#################}", a / 9.81);
            Console.ReadLine();
        }

        public static void Beschleunigung2()
        {
            double V2;
            double a;
            double s;


            Console.Write("\n\n Strecke in Meter Eingeben: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Geschwindigkeit in km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            a = ((V2 / 3.6) * (V2 / 3.6)) / (2 * s);

            Console.WriteLine("\n Beschleunigung in m/s2: {0:#,0.#################}", a);
            Console.WriteLine("\n Beschleunigung in G's (9.81m/s2): {0:#,0.#################}", a / 9.81);

            Console.ReadLine();
        }

        public static void Beschleunigung3()
        {
            double V2;
            double a;
            double t;


            Console.Write("\n\n Zeit in sec Eingeben: ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Geschwindigkeit in km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            a = (V2 / 3.6) / t;

            Console.WriteLine("\n Beschleunigung in m/s2: {0:#,0.#################}", a);
            Console.WriteLine("\n Beschleunigung in G's (9.81m/s2): {0:#,0.#################}", a / 9.81);

            Console.ReadLine();
        }

        public static void Beschleunigung4()
        {
            double N;
            double a;
            double m;


            Console.Write("\n\n Masse in kg Eingeben: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Kraft(N), die Masse Angreift Eingeben: ");
            N = Convert.ToDouble(Console.ReadLine());

            a = N / m;

            Console.WriteLine("\n Beschleunigung in m/s2: {0:#,0.#################}", a);
            Console.WriteLine("\n Beschleunigung in G's (9.81m/s2): {0:#,0.#################}", a / 9.81);

            Console.ReadLine();
        }


        public static void Beschleunigung5()
        {
            double V2;
            double a;
            double r;


            Console.Write("\n\n Geschwindigkeit in Km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Radius in Meter Eingeben: ");
            r = Convert.ToDouble(Console.ReadLine());

            a = ((V2 / 3.6) * (V2 / 3.6)) / r;

            Console.WriteLine("\n Beschleunigung in m/s2: {0:#,0.#################}", a);
            Console.WriteLine("\n Beschleunigung in G's (9.81m/s2): {0:#,0.#################}", a / 9.81);

            Console.ReadLine();
        }

        public static void EndgeschwindigkeitV2a()
        {
            double V2;
            double a;
            double s;


            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Strecke in Meter Eingeben: ");
            s = Convert.ToDouble(Console.ReadLine());

            V2 = Math.Sqrt(2 * a * s);

            Console.WriteLine("\n Endgeschwindigkeit V2 in m/s: {0:#,0.#################}", V2);
            Console.WriteLine(" Endgeschwindigkeit V2 in km/h: {0:#,0.#################}", 3.6 * V2);



            Console.ReadLine();
        }


        public static void EndgeschwindigkeitV2b()
        {
            double V2;
            double a;
            double t;


            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Zeit in sec Eingeben: ");
            t = Convert.ToDouble(Console.ReadLine());

            V2 = a * t;

            Console.WriteLine("\n Endgeschwindigkeit V2 in m/s: {0:#,0.#################}", V2);
            Console.WriteLine(" Endgeschwindigkeit V2 in km/h: {0:#,0.#################}", 3.6 * V2);



            Console.ReadLine();
        }

        public static void Energie_Kinetisch()
        {
            double WK;
            double m;
            double V2;

            Console.Write("\n\n Masse in Kg Eingeben: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Geschwindigkeit in Km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            WK = m / 2 * (V2 / 3.6) * (V2 / 3.6);

            Console.WriteLine("\n Kinetische Energie in J: {0:#,0.#################}", WK);
            Console.WriteLine(" Kinetische Energie in kJ: {0:#,0.#################}", WK / 1000);

            Console.ReadLine();
        }

        public static void Gravitation()
        {
            double F;
            const double f = 6.67e-11;//Gravitationskonstante!
            double m1;
            double m2;
            double r;

            Console.Write("\n Masse 1 in kg Eingeben: ");
            m1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Masse 2 in kg Eingeben: ");
            m2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Abstand der Massenschwerpunkte in Meter Eingeben: ");
            r = Convert.ToDouble(Console.ReadLine());

            F = f * m1 * m2 / (r * r);

            Console.WriteLine("\n Gegenseitige Anziehungskraft in N: {0:#,0.#################}", F);
            Console.WriteLine("\n Beschleunigung von Masse 1 in m/s2: {0:#,0.#################}", F / m1);
            Console.WriteLine(" In G's wenn 1G = 9.81m/s2: {0:#,0.#################}", (F / m1) / 9.81);

            Console.WriteLine("\n Beschleunigung von Masse 2 in m/s2: {0:#,0.#################}", F / m2);
            Console.WriteLine(" In G's wenn 1G = 9.81m/s2: {0:#,0.#################}", (F / m2) / 9.81);






            Console.ReadLine();
        }

        public static void Hangabtriebskraft()
        {
            double FH;
            double FG;
            double h;

            Console.Write("\n\n Beschleunigung(a) oder Kraft(N) Eingeben: ");
            FG = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Promille Eingeben: ");
            h = Convert.ToDouble(Console.ReadLine());

            FH = FG * h / Math.Sqrt(1000000.0 + h * h);

            Console.WriteLine("\n Hangabtriebskraft bzw Beschleunigung: {0:#,0.#################}", FH);

            Console.ReadLine();
        }

        public static void KW_PS()
        {
            double KW;
            double PS;

            Console.Write("\n\n KW Eingeben: ");
            KW = Convert.ToDouble(Console.ReadLine());

            PS = KW / 0.736;

            Console.WriteLine("\n {0:#,0.#################}KW sind {1}PS", KW, PS);

            Console.ReadLine();
        }

        public static void Ps_KW()
        {
            double PS;
            double KW;

            Console.Write("\n\n PS Eingeben: ");
            PS = Convert.ToDouble(Console.ReadLine());

            KW = PS * 0.736;

            Console.WriteLine("\n {0:#,0.#################}PS sind {1}KW", PS, KW);

            Console.ReadLine();
        }

        public static void Simulation()
        {
            double a;
            double V2;
            double s;
            double Ges;
            double diff;

            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Geschwindigkeit Eingeben in Km/h: ");
            Ges = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\tBeschleunigt/Gebremst - bis/aus {0:#,0.#################} Km/h \n", Ges);
            for (double x = 0.2; x < 50000; x = x + 0.2)
            {
                Thread.Sleep(200);

                V2 = a * x; //Berechnung in m/s
                s = (a * x * x) / 2; //Berechnung von Strecke
                diff = Ges - (V2 * 3.6);
                if (diff < 0) { diff = 0; }
                Console.WriteLine(" Sek: {0:#,0.0}   Km/h: {1:#,0.00}   Km/h: {2:#,0.00}      Meter: {3:#,0.00}", x, V2 * 3.6, diff, s);
                if (diff == 0) break;
            }
            Console.ReadLine();
        }

        public static void Strecke_s1()
        {
            double t;
            double a;
            double s;


            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Zeit in Sekunden Eingeben: ");
            t = Convert.ToDouble(Console.ReadLine());

            s = (a * t * t) / 2;

            Console.WriteLine("\n Strecke in Meter: {0:#,0.#################}", s);

            Console.ReadLine();
        }

        public static void Strecke_s2()
        {
            double V2;
            double a;
            double s;


            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Endgeschwindigkeit in Km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            s = ((V2 / 3.6) * (V2 / 3.6)) / (2 * a);

            Console.WriteLine("\n Strecke in Meter: {0:#,0.#################}", s);

            Console.ReadLine();
        }

        public static void Strecke_s3()
        {
            double V2;
            double t;
            double s;


            Console.Write("\n\n Zeit in sec Eingeben: ");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Endgeschwindigkeit in Km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            s = ((V2 / 3.6) * t) / 2;

            Console.WriteLine("\n Strecke in Meter: {0:#,0.#################}", s);

            Console.ReadLine();
        }

        public static void Zeit1()
        {
            double t;
            double a;
            double s;


            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Strecke in Meter Eingeben: ");
            s = Convert.ToDouble(Console.ReadLine());

            t = Math.Sqrt((2 * s) / a);

            Console.WriteLine("\n Zeit in Sec: {0:#,0.#################}", t);

            Console.ReadLine();
        }

        public static void Zeit2()
        {
            double t;
            double a;
            double V2;


            Console.Write("\n\n Beschleunigung in m/s2 Eingeben: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Endgeschwindigkeit in Km/h: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            t = (V2 / 3.6) / a;

            Console.WriteLine("\n Zeit in Sec: {0:#,0.#################}", t);

            Console.ReadLine();
        }


        public static void Zeit3()
        {
            double t;
            double V2;
            double s;


            Console.Write("\n\n Endgeschwindigkeit in Km/h Eingeben: ");
            V2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n Strecke in Meter Eingeben: ");
            s = Convert.ToDouble(Console.ReadLine());

            t = 2 * s / (V2 / 3.6);

            Console.WriteLine("\n Zeit in Sec: {0:#,0.#################}", t);

            Console.ReadLine();
        }
    }
}
