using System;

namespace Beschleunigen_C_Sharp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                char x;
                //Konsolen-Menu
                Console.WriteLine("\n\tCopyright \u00A9 2009 Nicolas Sauter ");
                Console.WriteLine("\n\tSimulation             Taste: <1>");
                Console.WriteLine("\tEndgeschwindigkeit (V2)Taste: <2>");
                Console.WriteLine("\tStrecke            (s) Taste: <3>");
                Console.WriteLine("\tBeschleunigung     (a) Taste: <4>");
                Console.WriteLine("\tZeit               (t) Taste: <5>");
                Console.WriteLine("\tHangabtriebskraft  (FH)Taste: <6>");
                Console.WriteLine("\tKinetische Energie (WK)Taste: <7>");
                Console.WriteLine("\tUmrechnung KW-PS-KW    Taste: <8>");
                Console.WriteLine("\tGravitations-Kraft     Taste: <9>");
                Console.Write("\tBeenden!               Taste: <b>\t");

                try
                {
                    x = Convert.ToChar(Console.ReadLine());

                    switch (x)
                    {
                        case '1':
                            CFunktionen.Simulation();
                            break;
                        //Untermenu
                        case '2':
                            Console.WriteLine("\n\n Bekannt: Beschleunigung(a) und Strecke(s) <1>");
                            Console.Write(" Bekannt: Beschleunigung(a) und Zeit(t)    <2>  ");
                            x = Convert.ToChar(Console.ReadLine());
                            if (x == '1') CFunktionen.EndgeschwindigkeitV2a();
                            if (x == '2') CFunktionen.EndgeschwindigkeitV2b(); else continue;
                            break;
                        //Untermenu
                        case '3':
                            Console.WriteLine("\n\n Bekannt: Beschleunigung(a) und Zeit(t)                <1>");
                            Console.WriteLine(" Bekannt: Beschleunigung(a) und Endgeschwindigkeit(V2) <2>");
                            Console.Write(" Bekannt: Zeit(t) und Endgeschwindigkeit(V2)           <3>  ");
                            x = Convert.ToChar(Console.ReadLine());
                            if (x == '1') CFunktionen.Strecke_s1();
                            if (x == '2') CFunktionen.Strecke_s2();
                            if (x == '3') CFunktionen.Strecke_s3(); else continue;
                            break;
                        case '4':
                            Console.WriteLine("\n\n Bekannt: Strecke(s) und Zeit(t)                         <1>");
                            Console.WriteLine(" Bekannt: Strecke(s) und Endgeschwindigkeit(V2)          <2>");
                            Console.WriteLine(" Bekannt: Zeit(t) und Endgeschwindigkeit(V2)             <3>");
                            Console.WriteLine(" Bekannt: Masse(m) und Kraft(N) die auf m Wirkt!         <4>");
                            Console.Write(" Beschleunigung(a) auf einer Kreisbahn (Zentrifugalkraft <5>  ");
                            x = Convert.ToChar(Console.ReadLine());
                            if (x == '1') CFunktionen.Beschleunigung1();
                            if (x == '2') CFunktionen.Beschleunigung2();
                            if (x == '3') CFunktionen.Beschleunigung3();
                            if (x == '4') CFunktionen.Beschleunigung4();
                            if (x == '5') CFunktionen.Beschleunigung5(); else continue;
                            break;
                        case '5':
                            Console.WriteLine("\n\n Bekannt: Beschleunigung(a) und Strecke(s)             <1>");
                            Console.WriteLine(" Bekannt: Beschleunigung(a) und Endgeschwindigkeit(V2) <2>");
                            Console.Write(" Bekannt: Strecke(s) und Endgeschwindigkeit(V2)        <3>  ");
                            x = Convert.ToChar(Console.ReadLine());
                            if (x == '1') CFunktionen.Zeit1();
                            if (x == '2') CFunktionen.Zeit2();
                            if (x == '3') CFunktionen.Zeit3(); else continue;
                            break;
                        case '6':
                            CFunktionen.Hangabtriebskraft();
                            break;
                        case '7':
                            CFunktionen.Energie_Kinetisch();
                            break;
                        case '8':
                            Console.WriteLine("\n\n Umrechnen KW in PS <1>");
                            Console.Write(" Umrechnen PS in KW <2>  ");
                            x = Convert.ToChar(Console.ReadLine());
                            if (x == '1') CFunktionen.KW_PS();
                            if (x == '2') CFunktionen.Ps_KW(); else continue;
                            break;
                        case '9':
                            CFunktionen.Gravitation();
                            break;
                        case 'b': return;
                        default: Console.Write("\n\n"); continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\n\tFehler!!!\n\n");
                }


            }//Ende While Schleife!            
        }
    }
}
