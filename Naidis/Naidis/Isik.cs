using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis
{
    internal class Isik
    {
        public string Nimi;
        public int Vanus;
        public Isik(string nimi, int vanus)
        {
            this.Nimi = nimi;
            this.Vanus = vanus;
            Tervita();

        }
        public Isik()
        {

        }
        public void Tervita()
        {
            System.Console.WriteLine($"Tere, minu nimi on {Nimi}, ja ma olen {Vanus} aastat vana");
        }
}
}