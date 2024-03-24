using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_produseAlimentare
{
    public class View
    {
        private ProduseAlimentareService _produseAlimentareService;

        public View()
        {
            _produseAlimentareService = new ProduseAlimentareService();
        }
        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate Produsele");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate Produsele de un anumit pret"); //Afisare filtru lista !!!!!!
            Console.WriteLine("Apasati tasta 3 si introduceti produsul pe care il doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un produs nou");
        }

        public void play()
        {
            bool running = true;

            _produseAlimentareService.LoadData();

            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        _produseAlimentareService.AfisareProduseAlimentare();
                        break;

                    case "2":
                        ShowProduseAtSamePrice();
                        break;

                    case "3":
                        ShowProduseAtSamePrice();
                        break;

                    case "4":
                        AddFlowers();
                        break;

                    case "5":
                        EditPretProdus();
                        break;

                    case "6":
                        EditProdusDenumire();
                        break;


                }
            }
        }

        public void ShowProduseAtSamePrice()
        {
            Console.WriteLine("La ce pret doriti un produs?");
            string produsPrice = Console.ReadLine();

            if (_produseAlimentareService.FindProdusAlimentarByName(produsPrice) != -1)
            {
                Console.WriteLine("Avem la acest pret!");
            }
            else
            {
                Console.WriteLine("Nu avem la acest pret");
            }


        }

        public void BuyProdusAlimentar()
        {
            Console.WriteLine("Ce produs doriti sa cumparati din lista de mai jos?");
            _produseAlimentareService.AfisareProduseAlimentare();
            string produsDorit = Console.ReadLine();

            if (_produseAlimentareService.BuyProdusAli(produsDorit) != false)
            {
                Console.WriteLine("Produsul a fost achizitionate cu succes!");
            }
            else
            {
                Console.WriteLine("Produsul nu a fost achizitionate");
            }
        }

        public void AddFlowers()
        {
            Console.WriteLine("Introduceți cantitatea produsului:");
            int cantiProdus = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți prețul total al produsului:");
            int pretProdus = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți numele produsului");
            string tipProdus = Console.ReadLine();

            ProduseAlimentare produs6 = new ProduseAlimentare();
            produs6.cantitate = cantiProdus;
            produs6.pret = pretProdus;
            produs6.produs = tipProdus;

            Console.WriteLine("Produsul a fost adaugat cu succes!");
        }

        public void EditPretProdus()
        {
            Console.WriteLine("La ce produs vrei sa modificati pretul?");
            string preodusAles = Console.ReadLine();

            Console.WriteLine("Cu ce pret vreti sa il modificati?");
            int newPrice = Int32.Parse(Console.ReadLine());

            if (_produseAlimentareService.EditProdusALimentaPret(preodusAles, newPrice))
            {
                Console.WriteLine("Pretul produsului a fost modificata cu succes!");
            }
            else
            {
                Console.WriteLine("Pretul produsului nu a putut fi modificata!");
            }
        }

        public void EditProdusDenumire()
        {
            Console.WriteLine("La ce produs doriti sa modificati denumirea?");
            string denumireaNew = Console.ReadLine();

            Console.WriteLine("Cu ce denumire vreti sa il modificati?");
            string newName = Console.ReadLine();

            if (_produseAlimentareService.EditProdusALimentaDenumire(denumireaNew, newName))
            {
                Console.WriteLine("Denumirea produsului a fost modificata cu succes!");
            }
            else
            {
                Console.WriteLine("Denumirea produsului nu a putut fi modificata!");
            }
        }

        public void EditCantitateProdus()
        {
            Console.WriteLine("La ce produs doriti sa modificati cantitatea?");
            string produsNewCant = Console.ReadLine();

            Console.WriteLine("Cu ce cantitate vreti sa il modificati?");
            int newCantitate = Int32.Parse(Console.ReadLine());

            if (_produseAlimentareService.EditProdusALimentaCantitate(produsNewCant, newCantitate))
            {
                Console.WriteLine("Cantitatea a fost modificata cu succes!");
            }
            else
            {
                Console.WriteLine("Cantitatea nu a putut fi modificata!");
            }
        }
    }
}
