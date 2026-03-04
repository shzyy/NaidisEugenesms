using System;
using System.Collections.Generic;

namespace Jareltöö1
{
    public class Alamfunktsioonid
    {
        // Ülesanne 1
        public static void Piletikalkulaator()
        {
            Console.Write("Sisesta täispileti hind: ");
            double hind = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sisesta täiskasvanute arv: ");
            int tais = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta laste arv: ");
            int lapsed = Convert.ToInt32(Console.ReadLine());

            double taisSumma = tais * hind;
            double lapseHind = hind * 0.5;
            double lapseSumma = lapsed * lapseHind;

            double koguSumma = taisSumma + lapseSumma;

            Console.WriteLine("\n--- Arve ---");
            Console.WriteLine($"Täiskasvanud: {taisSumma:F2} €");
            Console.WriteLine($"Lapsed: {lapseSumma:F2} €");
            Console.WriteLine($"Kokku: {koguSumma:F2} €");
        }

        // Ülesanne 2
        public static void HindaKuupaeva(string kuupaev)
        {
            if (kuupaev.Length != 10)
            {
                Console.WriteLine("Vigane formaat!");
                return;
            }

            string aasta = kuupaev.Substring(0, 4);
            string kuu = kuupaev.Substring(5, 2);
            string paev = kuupaev.Substring(8, 2);

            Console.WriteLine($"Sündisid {paev}. päeval, {kuu}. kuul aastal {aasta}.");
        }

        // Ülesanne 3
        public static void MundiMang()
        {
            Random rnd = new Random();
            List<int> visked = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int tulemus = rnd.Next(0, 2);
                visked.Add(tulemus);
            }

            Console.WriteLine("Visked:");
            foreach (int v in visked)
            {
                if (v == 0)
                    Console.Write("Kiri ");
                else
                    Console.Write("Kull ");
            }

            int kulliArv = 0;
            foreach (int v in visked)
            {
                if (v == 1)
                    kulliArv++;
            }

            Console.WriteLine($"\nKull tuli {kulliArv} korda.");
        }

        // Ülesanne 4
        public static Tuple<double, double> ArvutaRistkylik(double pikkus, double laius)
        {
            double pindala = pikkus * laius;
            double umbermoot = 2 * (pikkus + laius);

            return new Tuple<double, double>(pindala, umbermoot);
        }
    }
}
