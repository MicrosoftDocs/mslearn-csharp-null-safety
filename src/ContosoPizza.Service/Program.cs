using ContosoPizza.Models;

var pizza = new Pizza("Meat Lover's Special")
{
    Size = PizzaSize.Medium,
    Crust = PizzaCrust.DeepDish,
    Sauce = PizzaSauce.Marinara,
    Price = 17.99m,
};

pizza.Cheeses = new List<PizzaCheese>();
pizza.Cheeses.Add(PizzaCheese.Mozzarella);
pizza.Cheeses.Add(PizzaCheese.Parmesan);

pizza.Toppings = new List<PizzaTopping>();
pizza.Toppings.Add(PizzaTopping.Sausage);
pizza.Toppings.Add(PizzaTopping.Pepperoni);
pizza.Toppings.Add(PizzaTopping.Bacon);
pizza.Toppings.Add(PizzaTopping.Ham);
pizza.Toppings.Add(PizzaTopping.Meatball);

Console.WriteLine(pizza);