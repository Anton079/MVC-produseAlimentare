using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_produseAlimentare
{
    public class ProduseAlimentareService
    {
        private List <ProduseAlimentare> _ProduseAlimentareList;

        public ProduseAlimentareService()
        {
            _ProduseAlimentareList = new List<ProduseAlimentare>();
            this.LoadData();
        }

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

            this._ProduseAlimentareList.Add(Produs1);
            this._ProduseAlimentareList.Add(Produs2);
            this._ProduseAlimentareList.Add(Produs3);
            this._ProduseAlimentareList.Add(Produs4);
            this._ProduseAlimentareList.Add(Produs5);

        }

        //Crud
        public void AfisareProduseAlimentare()
        {
            foreach(ProduseAlimentare x in _ProduseAlimentareList)
            {
                Console.WriteLine(x.InfoAlimente());
            }
        }

        public int FindProdusAlimentarByName(string numeProdus)
        {
            for (int i = 0; i < _ProduseAlimentareList.Count; i++)
            {
                if (_ProduseAlimentareList[i].produs == numeProdus)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddProdusAlimentarInList(ProduseAlimentare ProdusNou)
        {
            if (FindProdusAlimentarByName(ProdusNou.produs) == -1)
            {
                this._ProduseAlimentareList.Add(ProdusNou);
                return true;
            }
            return false;
        }

        public bool RemoveProdusAlimentarByName(string ProdusCautat)
        {
            int ProdusulCautatIndex = FindProdusAlimentarByName(ProdusCautat);
            if (ProdusulCautatIndex != -1)
            {
                _ProduseAlimentareList.RemoveAt(ProdusulCautatIndex);
                return true;
            }
            return false;
        }

        //View

        public bool BuyProdusAli(string ProdusDorit)
        {
            for (int i = 0; i < _ProduseAlimentareList.Count; i++)
            {
                if (_ProduseAlimentareList[i].produs == ProdusDorit)
                {
                    _ProduseAlimentareList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool AddProdusInList(ProduseAlimentare ProdusNou)
        {
            if (FindProdusAlimentarByName(ProdusNou.produs) != -1)
            {
                this._ProduseAlimentareList.Add(ProdusNou);
                return true;
            }
            return false;
        }

        //EDIT
        public bool EditProdusALimentaPret(string produsDorit, int pret)
        {
            foreach (ProduseAlimentare x in _ProduseAlimentareList)
            {
                if (x.produs == produsDorit)
                {
                    x.pret = pret;
                    return true;
                }
            }
            return false;
        }

        public bool EditProdusALimentaDenumire(string produsDorit, string denumire)
        {
            foreach (ProduseAlimentare x in _ProduseAlimentareList)
            {
                if (x.produs == produsDorit)
                {
                    x.produs = denumire;
                    return true;
                }
            }
            return false;
        }

        public bool EditProdusALimentaCantitate(string produsDorit, int cantitate)
        {
            foreach (ProduseAlimentare x in _ProduseAlimentareList)
            {
                if (x.produs == produsDorit)
                {
                    x.cantitate = cantitate;
                    return true;
                }
            }
            return false;
        }
    }
}
