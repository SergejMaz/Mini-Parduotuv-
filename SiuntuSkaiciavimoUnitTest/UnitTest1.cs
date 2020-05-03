using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uzd_MiniShop_Sergej;

namespace MiniShopUnitTest
{
    [TestClass]
    public class SiuntosSkaiciavimuUnitTest
    {
        [TestMethod]
        public void SiuntimoPasirinkimas_siuntosNr4_TikimesGauti20()
        {
            SiuntosSkaiciavimas siuntosSkaiciavimas = new SiuntosSkaiciavimas();

            siuntosSkaiciavimas.Numero = 4;
            
            var rezult = siuntosSkaiciavimas.SiuntimoPasirinkimas();

            Assert.AreEqual(20, rezult);
        }


        [TestMethod]
        public void SiuntosDydzioKlasifikavimas_Svoris3_TikimesGauti_Jususiunta_yra_L_dydzio()
        {
            SiuntosSkaiciavimas klasifikavimas = new SiuntosSkaiciavimas();


            klasifikavimas.SiuntosDydzioKlasifikavimas(3);


            Assert.AreEqual("L", klasifikavimas.SiuntosDydzioKlase);

        }

        [TestMethod]
        public void SiuntosKainosSkaiciavimas_Kaina100_TarptautinisSiuntimas_DydisL_TikimesGauti150()
        {
            SiuntosSkaiciavimas skaiciavimas = new SiuntosSkaiciavimas();
            skaiciavimas.SiuntPasirinkimas = 20;
            skaiciavimas.SiuntosDydzioKlase = "L";
            var rezultatas = skaiciavimas.SiuntosKainosSkaiciavimas(100);

            Assert.AreEqual(150, rezultatas);

        }
    }
        
}
