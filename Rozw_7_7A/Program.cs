using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_7_7A
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasazer p1 = new Pasazer("Jan");
            Pasazer p2 = new Pasazer("Anna");
            Pociag pociag = new Pociag();
            pociag.DodajPasazera(p1);
            pociag.DodajPasazera(p2);
        }
    }

    class Pasazer
    {
        private string imie;

        public Pasazer(string imie)
        {
            this.imie = imie;
        }
    }

    class Pociag
    {
        private List<Pasazer> pasazerowie = new List<Pasazer>();

        public Pociag()
        {

        }

        public void DodajPasazera(Pasazer p)
        {
            pasazerowie.Add(p);
        }


    }
}
