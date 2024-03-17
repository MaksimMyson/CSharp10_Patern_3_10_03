using static System.Net.Mime.MediaTypeNames;

namespace CSharp10_Patern_3_10_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            OrderFacade orderFacade = new OrderFacade();
            orderFacade.PlaceOrder(123, 2, 100.50, "вул. Поштова, 1, м. Київ");

            
            ICar car = new EconomyCar();
            Console.WriteLine($"Опис: {car.GetDescription()}, Ціна: {car.GetCost()}");

            car = new LuxuryCarDecorator(car);
            Console.WriteLine($"Опис: {car.GetDescription()}, Ціна: {car.GetCost()}");

            
            IImage image1 = new ProxyImage("photo1.jpg");
            IImage image2 = new ProxyImage("photo2.jpg");

            image1.Display(); 
            image1.Display(); 

            image2.Display(); 
        }
    }
}
