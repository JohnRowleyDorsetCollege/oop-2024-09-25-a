using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_09_25_a.models
{
    public abstract class HeroBase
    {
        public string Name { get; set; }
        public string Alias { get; set; }

        protected HeroBase()
        {
            
        }

        protected HeroBase(string _name, string _alias) { 
            Name = _name;
            Alias = _alias;
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    // The colon : indicates inheritance from another class
    // You can only inherit from one class (in c#)
    public class Human : HeroBase
    {
        public Human()
        {
            
        }

        public Human(string _name, string _alias) : base(_name, _alias) 
        {
            
        }
        public override string ToString()
        {
            return "Human";
        }
    }

    public class Alien : HeroBase
    {
        public Alien()
        {
            
        }
        // Inherit and pass the parameters up to the base class
        public Alien(string _name, string _alias) :    base(_name, _alias)
        {
           
            
            
        }
        public override string ToString()
        {
            return $"Alien";
        }
    }

    public class HumanAugmented : Human
    {
        // Constructor - code is run when the class is created 
        public HumanAugmented()
        {
            Console.WriteLine("Creating a Human Augmented Class");
        }

        public HumanAugmented(string _name, string _alias) : base(_name, _alias) 
        {
           
        }




        public override string ToString()
        {
            return $"HumanAugmented: {Name} : {Alias}";
        }
    }

    public class AlienPlant : Alien
    {
        public AlienPlant()
        {
            
        }

        public AlienPlant(string _name, string _alias) : base(_name, _alias) 
        {
            
        }
        public override string ToString()
        {
            return $"AlienPlant: : {Name} : {Alias}";
        }


    }

}
