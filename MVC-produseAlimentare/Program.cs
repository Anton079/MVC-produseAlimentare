using MVC_produseAlimentare;

internal class Program
{
    public static void Main(string[] args)
    {
        ProduseAlimentareService service = new ProduseAlimentareService();

        service.LoadData();

        ProduseAlimentare produsNou = new ProduseAlimentare();
        produsNou.produs = "Ulei de masline";
        produsNou.pret = 20;
        produsNou.cantitate = 1;


        service.AfisareProduseAlimentare();
    }
}