namespace myApp.Semana5.ECommerce;

public class ProductCentral
{
    public static void Main()
    {
        IDownloadable downloadable = new DigitalProduct();
        downloadable.Download();

        IShippable shippable = new PhysicalProduct();
        shippable.Ship();
    }
}