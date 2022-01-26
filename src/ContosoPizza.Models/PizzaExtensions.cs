namespace ContosoPizza.Models;

static class PizzaExtensions
{
    internal static string ToDescriptiveString(this Pizza pizza)
    {
        StringBuilder builder = new();
        builder.AppendFormat("The \"{0}\" is a ", pizza.Name);
        builder.AppendFormat("{0}", pizza.Crust switch
        {
            PizzaCrust.Thin => "thin crust",
            PizzaCrust.DeepDish => "deep dish",
            PizzaCrust.Stuffed => "stuffed crust",
            _ => "hand tossed",
        });
        builder.AppendFormat(" pizza with {0}.", pizza.Sauce switch
        {
            PizzaSauce.Marinara => "marinara sauce",
            PizzaSauce.Alfredo => "alfredo sauce",
            PizzaSauce.Barbecue => "barbecue sauce",
            _ => "tomato sauce",
        });
        builder.AppendLine();

        var cheeses = pizza.Cheeses switch
        {
            { Count: 0 } => "",
            { Count: 1 } => "It's covered with ",
            { Count: _ } => "It's covered with a blend of "
        };
        builder.Append(cheeses);
        builder.AppendCollection(pizza.Cheeses, c => c.ToString().ToLower());
        builder.AppendLine(" cheese.");

        var toppings = pizza.Toppings switch
        {
            { Count: 0 } => "",
            { Count: 1 } => "It comes with ",
            { Count: _ } => "It's layered with "
        };
        builder.Append(toppings);
        builder.AppendCollection(pizza.Toppings, t => t.ToString().ToLower());
        builder.AppendLine(".");

        const decimal deliveryCharge = 2.50m;
        builder.AppendFormat(
            "This {0} size is {1:c}. Delivery is {2:c} more, bringing your total {3:c}!",
            pizza.Size switch 
            {
                PizzaSize.Personal => "personal",
                PizzaSize.Small => "small",
                PizzaSize.Medium => "medium",
                PizzaSize.Large => "large",
                _ => "extra large",
            },
            pizza.Price, deliveryCharge, pizza.Price + deliveryCharge);

        return builder.ToString();
    }

    private static StringBuilder AppendCollection<T>(
        this StringBuilder builder,
        ICollection<T> source,
        Func<T, string> format)
    {
        var array = source.ToArray();
        for (int i = 0; i < array.Length; ++ i)
        {
            var (isLast, isSecondToLast) = (i == array.Length - 1, i == array.Length - 2);
            var text = (isLast, isSecondToLast) switch
            {
                (true, _) => $"and {format(array[i])}",
                (_, true) => $"{format(array[i])} ",
                _ => $"{format(array[i])}, ",
            };

            builder.Append(text);
        }

        return builder;
    }
}