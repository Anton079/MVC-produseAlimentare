using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_produseAlimentare
{
    public class ProduseAlimentare
    {
        public string _produs;
        public int _pret;
        public int _cantitate;

        public string produs
        {
            get { return _produs; }
            set { _produs = value; }
        }

        public int pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        public int cantitate
        {
            get { return _cantitate; }
            set { _cantitate = value; }
        }

        public string InfoAlimente()
        {
            string text = " ";
            text += "Nume produs " + produs + " \n";
            text += "Pretul " + pret + "\n";
            text += "Cantiatea " + cantitate + "\n";
            return text;
        }
    }
}
