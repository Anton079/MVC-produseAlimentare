using MVC_produseAlimentare;

internal class Program
{
    public static void Main(string[] args)
    {
        ProduseAlimentareService service = new ProduseAlimentareService();

        service.LoadData();

        service.AfisareProduseAlimentare();
    }
}