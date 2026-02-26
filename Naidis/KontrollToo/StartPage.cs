using System;

class StartPage
{
    static void Main(string[] args)
    {
        bool tootab = true;

        while (tootab)
        {
            Console.WriteLine("Vali tegevus:");
            Console.WriteLine("1 - Kütuse kalkulaator");
            Console.WriteLine("2 - Isikukoodi analüüs");
            Console.WriteLine("3 - Täringumäng");
            Console.WriteLine("4 - Palgaarvestus");
            Console.WriteLine("0 - Välju");
            Console.Write("Sinu valik: ");

            string valik = Console.ReadLine();
            Console.WriteLine();

            switch (valik)
            {
                case "1":
                    Alamfunktsioonid.KytuseKalkulaator();
                    break;

                case "2":
                    Console.Write("Sisesta isikukood: ");
                    string ik = Console.ReadLine();
                    string tulemus = Alamfunktsioonid.HindaIsikukood(ik);
                    Console.WriteLine(tulemus + "\n");
                    break;

                case "3":
                    Alamfunktsioonid.TaringuMang();
                    break;

                case "4":
                    Console.Write("Sisesta brutopalk: ");
                    double bruto = Convert.ToDouble(Console.ReadLine());
                    var palk = Alamfunktsioonid.ArvutaPalk(bruto);

                    Console.WriteLine($"Maksuvaba tulu: {palk.Item1:F2} €");
                    Console.WriteLine($"Netopalk: {palk.Item2:F2} €\n");
                    break;

                case "0":
                    tootab = false;
                    Console.WriteLine("Programm lõpetatud.");
                    break;

                default:
                    Console.WriteLine("Vigane valik!\n");
                    break;
            }
        }
    }
}
