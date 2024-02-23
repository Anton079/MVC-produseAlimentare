using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_produseAlimentare
{
    public class ProduseAlimentareService
    {
        public List <ProduseAlimentare> ProduseAlimentareList = new List<ProduseAlimentare>();

        public void LoadData()
        {
            ProduseAlimentare Produs1 = new ProduseAlimentare();
            Produs1.produs = "Zahar alb";
            Produs1.pret = 6;
            Produs1.cantitate = 1;

            ProduseAlimentare Produs2 = new ProduseAlimentare();
            Produs2.produs = "Ovaz Romania";
            Produs2.pret = 7;
            Produs2.cantitate = 2;

            ProduseAlimentare Produs3 = new ProduseAlimentare();
            Produs3.produs = "Sare alb";
            Produs3.pret = 8;
            Produs3.cantitate = 1;

            ProduseAlimentare Produs4 = new ProduseAlimentare();
            Produs4.pret = 14;
            Produs4.cantitate = 1;
            Produs4.produs = "Sibiu salam";

            ProduseAlimentare Produs5 = new ProduseAlimentare();
            Produs5.pret = 15;
            Produs5.cantitate = 2;
            Produs5.produs = "Malai Romanesc";

            this.ProduseAlimentareList.Add(Produs1);
            this.ProduseAlimentareList.Add(Produs2);
            this.ProduseAlimentareList.Add(Produs3);
            this.ProduseAlimentareList.Add(Produs4);
            this.ProduseAlimentareList.Add(Produs5);

        }

        public void AfisareProduseAlimentare()
        {
            foreach(ProduseAlimentare x in ProduseAlimentareList)
            {
                Console.WriteLine(x.InfoAlimente());
            }
        }
    }
}
