using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        class StartPage
    {
        static void Main(string[] args)
        {
            bool töötab = true;

            while (töötab)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Kütuse kalkulaator");
                Console.WriteLine("2 - Isikukoodi analüüs");
                Console.WriteLine("3 - Täringumäng");
                Console.WriteLine("4 - Palgaarvestus");
                Console.WriteLine("0 - Välju");

                Console.Write("Sisesta valik: ");
                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Alamfunktsioonid.KytuseKalkulaator();
                        break;

                    case "2":
                        Alamfunktsioonid.HindaIsikukood();
                        break;

                    case "3":
                        Alamfunktsioonid.TaringuMang();
                        break;

                    case "4":
                        Alamfunktsioonid.KysiJaArvutaPalk();
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

