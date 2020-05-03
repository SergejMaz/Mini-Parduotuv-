using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzd_MiniShop_Sergej
{
    class Program
    {

        static void Main(string[] args)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("MiniShop.txt");
            string line = null;
            List<Prekes> prsarasas = new List<Prekes>();
            while ((line = reader.ReadLine()) != null)
            {
                var eilute = line.Split(';');
                Prekes krepselis = new Prekes();

                foreach (var item in eilute)
                {
                    var duomenys = item.Split('|');

                    Prekes prekes = new Prekes(int.Parse(duomenys[0]), duomenys[1], double.Parse(duomenys[2]), duomenys[3], double.Parse(duomenys[4]));
                    prekes.PrekiuAtvaizdavimas();

                    krepselis.PrekiuSarasas.Add(prekes);
                    break;
                }
                prsarasas.Add(krepselis);
            }
            reader.Close();
            reader.Dispose();

            double sveria = 0;
            double kainuSuma = 0;

            string form = "";

            while (form != "OK")
            {

                Console.WriteLine("Iveskite norimos prekes ID numeri: ");
                int nuskaitomasID = Convert.ToInt32(Console.ReadLine());

                foreach (var item in prsarasas)
                {
                    foreach (var itemas in item.PrekiuSarasas)
                    {

                        if (nuskaitomasID == itemas.IDnumeris)
                        {
                            sveria += itemas.Dydis;
                            kainuSuma += itemas.Kaina;

                            Console.WriteLine($"Jusu pirkiniu krepselis:  svoris yra: {sveria} kaina: {kainuSuma}");
                            Console.WriteLine("Jeigu norite testi apsipirkima spauskite Enter jei norite baigti parasykite OK");
                            form = Console.ReadLine();
                        }
                       

                    }
                }


                sveria = sveria;
                kainuSuma = kainuSuma;
            }

            Console.WriteLine($"Jusu Prekiu Krepselio Svoris: { sveria} kg. ir Kaina: {kainuSuma} Eur");

            SiuntosSkaiciavimas siuntosSkaiciavimas = new SiuntosSkaiciavimas();
            siuntosSkaiciavimas.NuskaitimasIsConsol();
            siuntosSkaiciavimas.SiuntimoPasirinkimas();
            siuntosSkaiciavimas.SiuntosDydzioKlasifikavimas(sveria);
            siuntosSkaiciavimas.SiuntosKainosSkaiciavimas(kainuSuma);


        }


    }
}
