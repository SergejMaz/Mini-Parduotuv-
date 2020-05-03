using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzd_MiniShop_Sergej
{
    public class SiuntosSkaiciavimas 
    {
        
        List<double> IkainiaiSiuntimas;
        public string SiuntosDydzioKlase { get; set; }

        public double SiuntPasirinkimas { get; set; }

        public double SiuntosNr { get; set; }

        public double Numero { get; set; }

        public double NuskaitimasIsConsol()
        {
            Console.WriteLine("Siuntimai");
            Console.WriteLine("\n1. Siuntimas per Lietuvos Pasta \n2. Siuntimas per Kurjerius \n3. Siuntimas i Pastomata \n4.Tarptautinis siuntimas");
            Console.WriteLine("Iveskite norimo siuntimo budo numeri ir paspauskite Enter");
            double numer = Convert.ToDouble(Console.ReadLine());
            return Numero = numer;
        }

        public double SiuntimoPasirinkimas()
        {
            
            SiuntosNr = Numero;

            switch (SiuntosNr)
            {
                case 1:
                    SiuntosNr = IkainiaiSiuntimas[0];
                    Console.WriteLine($"Siuntimo kaina yra: {SiuntosNr} Eur");
                    break;
                case 2:
                    SiuntosNr = IkainiaiSiuntimas[1];
                    Console.WriteLine($"Siuntimo kaina yra: {SiuntosNr} Eur");
                    break;
                case 3:
                    SiuntosNr = IkainiaiSiuntimas[2];
                    Console.WriteLine($"Siuntimo kaina yra: {SiuntosNr} Eur");
                    break;
                case 4:
                    SiuntosNr = IkainiaiSiuntimas[3];
                    Console.WriteLine($"Siuntimo kaina yra: {SiuntosNr} Eur");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }
            return SiuntPasirinkimas = SiuntosNr;
        }

        public SiuntosSkaiciavimas()
        {
            IkainiaiSiuntimas = new List<double>() { 4, 5, 3, 20 };

        }

        public void SiuntosDydzioKlasifikavimas(double svoris)
        {
            if (svoris <= 0.5)
            {
                SiuntosDydzioKlase = "S";
            }
            else if (svoris > 0.5 && svoris <= 2)
            {
                SiuntosDydzioKlase = "M";
            }
            else if (svoris > 1 && svoris <= 5)
            {
                SiuntosDydzioKlase = "L";
            }
            else
            {
                Console.WriteLine("Tokio Dydžio siuntu nėra"); 
            }

            Console.WriteLine($"Jusu siunta yra {SiuntosDydzioKlase} dydžio");

            SiuntosDydzioKlase = SiuntosDydzioKlase;
            
        }

       

        public double SiuntosKainosSkaiciavimas(double kaina)
        {
            switch (SiuntosDydzioKlase)
            {
                case "S":
                    kaina += 10 + SiuntPasirinkimas;
                    break;
                case "M":
                    kaina += 20 + SiuntPasirinkimas;
                    break;
                case "L":
                    kaina += 30 + SiuntPasirinkimas;
                    break;
                default:
                    kaina = double.MaxValue;
                    break;

            }
            Console.WriteLine("Jusu uzsakimo kaina viso yra: " + kaina + "Eur");
            return kaina;
        }

       
    }
    
}
