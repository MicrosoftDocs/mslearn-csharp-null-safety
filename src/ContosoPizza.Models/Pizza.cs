﻿namespace ContosoPizza.Models;

public record class Pizza
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(0, 9999.99)]
    public decimal Price { get; set; }

    public PizzaSize Size { get; set; }
    public PizzaCrust Crust { get; set; }
    public PizzaSauce Sauce { get; set; }

    public ICollection<PizzaTopping> Toppings { get; set; }
}