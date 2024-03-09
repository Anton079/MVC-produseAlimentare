using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_produseAlimentare
{
    public class View
    {
        ProduseAlimentareService produseAlimentareService = new ProduseAlimentareService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate Produsele");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate Produsele de un anumit pret");
            Console.WriteLine("Apasati tasta 3 si introduceti produsul pe care o doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un produs nou");
        }

        public void play()
        {
            bool running = true;

            produseAlimentareService.LoadData();

            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        produseAlimentareService.AfisareProduseAlimentare();
                        break;
                }
            }
        }
    }
}
