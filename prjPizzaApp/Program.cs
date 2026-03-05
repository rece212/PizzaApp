namespace prjPizzaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaconCheesePizzaBannanaPineapple test = 
                new BaconCheesePizzaBannanaPineapple();

            PlainPizza Plain = new PlainPizza();
            Console.WriteLine(test.ToString());


        }
    }
}
