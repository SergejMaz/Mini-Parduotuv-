using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzd_MiniShop_Sergej
{
    public class Prekes
    {
        public int IDnumeris { get; set; }
        public string Pavadinimas { get; set; }
        public double Dydis { get; set; }
        public string Aprasymas { get; set; }
        public double Kaina { get; set; }
        public List<Prekes> PrekiuSarasas;


        public Prekes()
        {
            PrekiuSarasas = new List<Prekes>();

        }
        public Prekes(int idNumeris, string pavadinimas, double dydis, string aprasymas, double kaina)
        {
            IDnumeris = idNumeris;
            Pavadinimas = pavadinimas;
            Dydis = dydis;
            Aprasymas = aprasymas;
            Kaina = kaina;
        }

        public void PrekiuAtvaizdavimas()
        {
            Console.WriteLine("ID numeris: " + IDnumeris);
            Console.WriteLine("Prekės tipas (pavadinimas): " + Pavadinimas);
            Console.WriteLine("Svoris: " + Dydis);
            Console.WriteLine("Prekės aprašymas: " + Aprasymas);
            Console.WriteLine("Kaina: " + Kaina);
        }
        
    }
}
