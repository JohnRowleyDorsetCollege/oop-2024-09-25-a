// See https://aka.ms/new-console-template for more information
using oop_2024_09_25_a.models;

Console.WriteLine("Inheritance");

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




Console.WriteLine(ap);
Console.WriteLine(ah);
Console.WriteLine(wolverine);