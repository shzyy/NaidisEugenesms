using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alamfunktsioonid
{
    public static void KytuseKalkulaator()
    {
        Console.Write("Sisesta läbitud km: ");
        double km = double.Parse(Console.ReadLine());

        Console.Write("Sisesta kütusekulu 100km kohta: ");
        double kulu100 = double.Parse(Console.ReadLine());

        Console.Write("Sisesta kütuse hind (€): ");
        double hind = double.Parse(Console.ReadLine());

        double kogukulu = (km / 100) * kulu100;
        double maksumus = kogukulu * hind;

        Console.WriteLine($"Kütust kulus: {kogukulu:F2} liitrit");
        Console.WriteLine($"Reisi maksumus: {maksumus:F2} €");
    }

    public static void HindaIsikukood()
    {
        Console.Write("Sisesta isikukood: ");
        string isikukood = Console.ReadLine();

        if (isikukood.Length != 11)
        {
            Console.WriteLine("Viga: Isikukood peab olema 11-kohaline!");
            return;
        }

        char esimene = isikukood[0];
        string sugu;
        int sajand;

        if (esimene == '1' || esimene == '3' || esimene == '5')
            sugu = "Mees";
        else if (esimene == '2' || esimene == '4' || esimene == '6')
            sugu = "Naine";
        else
            sugu = "Tundmatu";

        if (esimene == '1' || esimene == '2')
            sajand = 1800;
        else if (esimene == '3' || esimene == '4')
            sajand = 1900;
        else if (esimene == '5' || esimene == '6')
            sajand = 2000;
        else
            sajand = 0;

        string aastaStr = isikukood.Substring(1, 2);
        string kuu = isikukood.Substring(3, 2);
        string paev = isikukood.Substring(5, 2);

        if (!int.TryParse(aastaStr, out int aasta))
        {
            Console.WriteLine("Vigane sünniaasta!");
            return;
        }

        aasta += sajand;

        Console.WriteLine($"Oled {sugu}, sündinud {paev}.{kuu}.{aasta}");
    }

    public static void TaringuMang()
    {
        Random rnd = new Random();
        List<int> summad = new List<int>();
        int duublid = 0;
        int kogusumma = 0;

        for (int i = 0; i < 10; i++)
        {
            int t1 = rnd.Next(1, 7);
            int t2 = rnd.Next(1, 7);

            if (t1 == t2)
                duublid++;

            int summa = t1 + t2;
            summad.Add(summa);
            kogusumma += summa;
        }

        Console.WriteLine("Visked:");
        foreach (int s in summad)
        {
            Console.Write(s + " ");
        }

        Console.WriteLine($"\nDuubleid tuli: {duublid}");
        Console.WriteLine($"Kõikide visete kogusumma: {kogusumma}");
    }

    public static void KysiJaArvutaPalk()
    {
        Console.Write("Sisesta brutopalk: ");
        double brutopalk = double.Parse(Console.ReadLine());

        var tulemus = ArvutaPalk(brutopalk);

        Console.WriteLine($"Maksuvaba tulu: {tulemus.Item1:F2} €");
        Console.WriteLine($"Netopalk: {tulemus.Item2:F2} €");
    }

    public static Tuple<double, double> ArvutaPalk(double brutopalk)
    {
        double maksuvaba = 0;

        if (brutopalk < 1200)
            maksuvaba = 654;

        double tulumaksuAlus = brutopalk - maksuvaba;
        if (tulumaksuAlus < 0)
            tulumaksuAlus = 0;

        double tulumaks = tulumaksuAlus * 0.20;
        double tootuskindlustus = brutopalk * 0.016;
        double pension = brutopalk * 0.02;

        double neto = brutopalk - tulumaks - tootuskindlustus - pension;

        return Tuple.Create(maksuvaba, neto);
    }
}
