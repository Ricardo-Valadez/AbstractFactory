namespace FactoryPizza{
      public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            if (item == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (item == "veggie")
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            else if (item == "clam")
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (item == "pepperoni")
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            return pizza;
        }
    }
}