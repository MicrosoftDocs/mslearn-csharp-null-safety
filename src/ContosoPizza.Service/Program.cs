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

pizza.Toppings ??= new
{
    PizzaTopping.Sausage,
    PizzaTopping.Pepperoni,
    PizzaTopping.Bacon,
    PizzaTopping.Ham,
    PizzaTopping.Meatballs
};

Console.WriteLine(pizza);

/*
    Output:

    The "Meat Lover's Special" is a medium crust deep dish pizza with marinara sauce.
    It's covered with mozzarella and parmesan cheese.
    It comes with sausage, pepperoni, bacon, ham, and meatballs.
    The medium size is $17.99. Delivery is $2.50 more, bringing your total $19.49!
*/