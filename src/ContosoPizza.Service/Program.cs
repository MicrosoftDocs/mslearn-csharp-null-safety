using ContosoPizza.Models;

var pizza = new Pizza()
{
    Name = "Pepperoni Special",
    Size = PizzaSize.Medium,
    Crust = PizzaCrust.DeepDish,
    Sauce = PizzaSauce.Marinara,
    Price = 17.99m,
};

pizza.Toppings.Add(PizzaTopping.Pepperoni);

Console.WriteLine(pizza.ToString());