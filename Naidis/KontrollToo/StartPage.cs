using System;

namespace Jareltöö1
{
    class StartPage
    {
        static void Main(string[] args)
        {
            bool töötab = true;

            while (töötab)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Kinopiletite kalkulaator");
                Console.WriteLine("2 - Kuupäeva eraldaja");
                Console.WriteLine("3 - Mündimäng");
                Console.WriteLine("4 - Ristküliku arvutused");
                Console.WriteLine("0 - Välju");
                Console.Write("Sisesta valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Alamfunktsioonid.Piletikalkulaator();
                        break;

                    case "2":
                        Console.Write("Sisesta kuupäev (YYYY-MM-DD): ");
                        string kuup = Console.ReadLine();
                        Alamfunktsioonid.HindaKuupaeva(kuup);
                        break;

                    case "3":
                        Alamfunktsioonid.MundiMang();
                        break;

                    case "4":
                        Console.Write("Sisesta pikkus: ");
                        double pikkus = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Sisesta laius: ");
                        double laius = Convert.ToDouble(Console.ReadLine());

                        var tulemus = Alamfunktsioonid.ArvutaRistkylik(pikkus, laius);

                        Console.WriteLine($"Pindala: {tulemus.Item1:F2}");
                        Console.WriteLine($"Ümbermõõt: {tulemus.Item2:F2}");
                        break;

                    case "0":
                        töötab = false;
                        break;

                    default:
                        Console.WriteLine("Vale valik!");
                        break;
                }
            }
        }
    }
}

