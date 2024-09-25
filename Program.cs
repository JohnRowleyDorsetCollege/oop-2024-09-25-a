

using oop_2024_09_25_a.models;

Console.WriteLine("Week 2: Inheritance");
/// var hb = new HeroBase(); Abstract class, cannot use it directly
var ap = new AlienPlant();

ap.Name = "Plant";
ap.Alias = "Groot";

var ah = new HumanAugmented();

ah.Name = "Peter Parker";
ah.Alias = "SpiderMan";

// INSTANTIATE (create) the object and initialise it using {prop=value,prop=value}
var wolverine = new HumanAugmented()
{
    Name = "Logan",
    Alias = "Wolverine"
};


var TheHulk = new HumanAugmented("David Banner", "The Hulk");

Console.WriteLine(ap);
Console.WriteLine(ah);
Console.WriteLine(wolverine);
Console.WriteLine(TheHulk);