using Bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Data;

public static class ModelBuilderExtensions
{
    public static ModelBuilder Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
        new Product
        {
            Id = 1,
            Name = "Carrot Cake",
            Description = "A scrumptious carrot cake encrusted with sliced almonds",
            Price = 8.99m,
            ImageName = "carrot-cake.jpg"
        },
        new Product
        {
            Id = 2,
            Name = "Lemon Tart",
            Description = "A delicious lemon tart smothered with juicy fresh fruit",
            Price = 9.99m,
            ImageName = "lemon-tart.jpg"
        },
        new Product
        {
            Id = 3,
            Name = "Cupcakes",
            Description = "Delectable vanilla and chocolate cupcakes",
            Price = 5.99m,
            ImageName = "cup-cakes.jpg"
        },
        new Product
        {
            Id = 4,
            Name = "Bread",
            Description = "Fresh baked French-style bread, bagettes and cobs",
            Price = 2.49m,
            ImageName = "bread.jpg"
        },
        new Product
        {
            Id = 5,
            Name = "Bagels",
            Description = "Deliciously chewy freshly made New York-style bagels.",
            Price = 5.99m,
            ImageName = "bagels.jpg"
        },
        new Product
        {
            Id = 6,
            Name = "Chocolate Cake",
            Description = "Rich chocolate frosting cover this chocolate lover's dream",
            Price = 8.99m,
            ImageName = "chocolate-cake.jpg"
        },
        new Product
        {
            Id = 7,
            Name = "Brownies",
            Description = "Fudgy, gooey and super chocolaty with a crispy top",
            Price = 5.99m,
            ImageName = "brownie.jpg"
        },
        new Product
        {
            Id = 8,
            Name = "Sweet Buns",
            Description = "Sweet, light, airy and perfect with your afternoon tea",
            Price = 3.49m,
            ImageName = "buns.jpg"
        }, 
        new Product
        {
            Id = 9,
            Name = "Cheesecake",
            Description = "Creamy and vibrant lemon cheesecake made with organic lemons",
            Price = 2.49m,
            ImageName = "cheesecake.jpg"
        },
        new Product
        {
            Id = 10,
            Name = "Chocolate Cookies",
            Description = "Crisp on the outside, soft on the inside and full of chocolate chips",
            Price = 3.49m,
            ImageName = "chocolate-chip.jpg"
        },
        new Product
        {
            Id = 11,
            Name = "Cinnamon Rolls",
            Description = "Big, fluffy, soft and delicious with warming cinnamon",
            Price = 3.99m,
            ImageName = "cinnamon-roll.jpg"
        },
        new Product
        {
            Id = 12,
            Name = "Croissants",
            Description = "Flaky and buttery, perfect for savoury or sweet",
            Price = 3.49m,
            ImageName = "croissant.jpg"
        },
        new Product
        {
            Id = 13,
            Name = "Doughnuts",
            Description = "Traditional ring doughnuts with a variety of toppings",
            Price = 5.49m,
            ImageName = "doughnuts.jpg"
        },
        new Product
        {
            Id = 14,
            Name = "Fruit Loaf",
            Description = "Packed full with only the juiciest, plumpest fruit",
            Price = 8.49m,
            ImageName = "fruit-loaf.jpg"
        },
        new Product
        {
            Id = 15,
            Name = "Fruit Tart",
            Description = "Light pastry with a selection of the freshest fruit",
            Price = 6.49m,
            ImageName = "fruit-tart.jpg"
        },
        new Product
        {
            Id = 16,
            Name = "Lemon Meringue",
            Description = "Zingy lemon on a light pastry covered with light clouds of meringue",
            Price = 10.99m,
            ImageName = "lemon-meringue.jpg"
        },
        new Product
        {
            Id = 17,
            Name = "Macaron",
            Description = "Tiny, delicate meringue pillows with a variety of fillings",
            Price = 9.99m,
            ImageName = "macaron.jpg"
        },
        new Product
        {
            Id = 18,
            Name = "Pain Au Chocolate",
            Description = "The lighest pastry shot through with top quality chocolate",
            Price = 4.49m,
            ImageName = "pain-au-chocolate.jpg"
        },
        new Product
        {
            Id = 19,
            Name = "Cornish Pasty",
            Description = "A meaty treat based on traditional Cornish recipes",
            Price = 5.99m,
            ImageName = "pasty.jpg"
        },
        new Product
        {
            Id = 20,
            Name = "Sliced Bread",
            Description = "Our top quality loaves sliced for your convenience",
            Price = 2.49m,
            ImageName = "sliced-bread.jpg"
        });
        return modelBuilder;
    }
}