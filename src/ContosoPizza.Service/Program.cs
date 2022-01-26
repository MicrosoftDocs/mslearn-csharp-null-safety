using ContosoPizza.Models;

// Create a pizza
Pizza pizza = new("Meat Lover's Special")
{
    Size = PizzaSize.Medium,
    Crust = PizzaCrust.DeepDish,
    Sauce = PizzaSauce.Marinara,
    Price = 17.99m,
};

// Add cheeses
pizza.Cheeses.Add(PizzaCheese.Mozzarella);
pizza.Cheeses.Add(PizzaCheese.Parmesan);

// Add toppings
pizza.Toppings ??= new List<PizzaTopping>();
pizza.Toppings.Add(PizzaTopping.Sausage);
pizza.Toppings.Add(PizzaTopping.Pepperoni);
pizza.Toppings.Add(PizzaTopping.Bacon);
pizza.Toppings.Add(PizzaTopping.Ham);
pizza.Toppings.Add(PizzaTopping.Meatballs);

Console.WriteLine(pizza);

/*
    Expected output:

    The "Meat Lover's Special" is a deep dish pizza with marinara sauce.
    It's covered with a blend of mozzarella and parmesan cheese.
    It's layered with sausage, pepperoni, bacon, ham and meatballs.
    This medium size is $17.99. Delivery is $2.50 more, bringing your total $20.49!
*/