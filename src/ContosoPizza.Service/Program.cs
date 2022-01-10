using ContosoPizza.Models;

var pizza = new Pizza("Pepperoni Special")
{
    Size = PizzaSize.Medium,
    Crust = PizzaCrust.DeepDish,
    Sauce = PizzaSauce.Marinara,
    Price = 17.99m,
};

pizza.Toppings.Add(PizzaTopping.Pepperoni);

Console.WriteLine(pizza.ToString());

/*
    Output:
    Pizza: Pepperoni Special
    Size: Medium
    Crust: DeepDish
    Sauce: Marinara
    Toppings: Pepperoni
    Price: $17.99
*/