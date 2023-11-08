using System;
using System.Collections;

namespace FactoryPizza
{
    public class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");            

        }
    }
}
