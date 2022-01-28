namespace ContosoPizza.Models;

public sealed record class Pizza([Required] string Name)
{
    private ICollection<PizzaCheese>? _cheeses;

    public int Id { get; set; }

    [Range(0, 9999.99)]
    public decimal Price { get; set; }

    public PizzaSize Size { get; set; }
    public PizzaCrust Crust { get; set; }
    public PizzaSauce Sauce { get; set; }

    public ICollection<PizzaCheese> Cheeses
    {
        get => (_cheeses ??= new List<PizzaCheese>());
        set => _cheeses = value ?? throw new ArgumentNullException(nameof(value));
    }

    public ICollection<PizzaTopping>? Toppings { get; set; }

    public override string ToString() => this.ToDescriptiveString();
}
