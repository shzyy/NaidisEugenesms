using System;
using System.Collections.Generic;

public class Alamfunktsioonid
{
  
    public static void KytuseKalkulaator()
    {
        Console.Write("Sisesta läbitud vahemaa (km): ");
        double km = Convert.ToDouble(Console.ReadLine());

        Console.Write("Sisesta kütusekulu 100km kohta (L): ");
        double kulu100 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Sisesta kütuse hind (€): ");
        double hind = Convert.ToDouble(Console.ReadLine());

        double kulunudKytus = (km / 100) * kulu100;
        double maksumus = kulunudKytus * hind;

        Console.WriteLine($"\nKulunud kütus: {kulunudKytus:F2} L");
        Console.WriteLine($"Reisi maksumus: {maksumus:F2} €\n");
    }

  
    public static string HindaIsikukood(string isikukood)
    {
        if (isikukood.Length != 11)
            return "Viga: Isikukood peab olema 11-kohaline!";

        char esimene = isikukood[0];

        string sugu;
        int sajand;

        if (esimene == '1' || esimene == '3' || esimene == '5')
            sugu = "Mees";
        else if (esimene == '2' || esimene == '4' || esimene == '6')
            sugu = "Naine";
        else
            sugu = "Tundmatu";

        if (esimene == '1' || esimene == '2') sajand = 1800;
        else if (esimene == '3' || esimene == '4') sajand = 1900;
        else if (esimene == '5' || esimene == '6') sajand = 2000;
        else sajand = 0;

        string aastaStr = isikukood.Substring(1, 2);
        string kuu = isikukood.Substring(3, 2);
        string paev = isikukood.Substring(5, 2);

        int aasta;
        if (!int.TryParse(aastaStr, out aasta))
            return "Viga: Vigane sünniaasta!";

        aasta += sajand;

        return $"Oled {sugu}, sündinud {paev}.{kuu}.{aasta}";
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

        Console.WriteLine("\nVisked:");
        foreach (int s in summad)
            Console.Write(s + " ");

        Console.WriteLine($"\nDuubleid visati: {duublid} korda");
        Console.WriteLine($"Kõikide visete kogusumma: {kogusumma}\n");
    }

    public static Tuple<double, double> ArvutaPalk(double brutopalk)
    {
        double maksuvaba = 0;

        if (brutopalk < 1200)
            maksuvaba = 654;

        double tootuskindlustus = brutopalk * 0.016;
        double kogumispension = brutopalk * 0.02;

        double tulumaksuAlus = brutopalk - maksuvaba;
        if (tulumaksuAlus < 0)
            tulumaksuAlus = 0;

        double tulumaks = tulumaksuAlus * 0.20;

        double neto = brutopalk - tulumaks - tootuskindlustus - kogumispension;

        return Tuple.Create(maksuvaba, neto);
    }
}