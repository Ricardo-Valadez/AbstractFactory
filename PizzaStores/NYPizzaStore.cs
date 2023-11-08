namespace FactoryPizza{
      public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            if (item == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (item == "veggie")
            {
                pizza = new NYStyleVeggiePizza();
            }
            else if (item == "clam")
            {
                pizza = new NYStyleClamPizza();
            }
            else if (item == "pepperoni")
            {
                pizza = new NYStylePepperoniPizza();
            }
            return pizza;
        }
    }
}