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
        public override string ToString()
        {
            return base.ToString();
        }
    }
    // The colon : indicates inheritance from another class
    // You can only inherit from one class (in c#)
    public class Human : HeroBase
    {
        public override string ToString()
        {
            return "Human";
        }
    }

    public class Alien : HeroBase
    {

        public override string ToString()
        {
            return $"Alien";
        }
    }

    public class HumanAugmented : Human
    {
        public override string ToString()
        {
            return $"HumanAugmented: {Name} : {Alias}";
        }
    }

    public class AlienPlant : Alien
    {
        public override string ToString()
        {
            return $"AlienPlant: : {Name} : {Alias}";
        }


    }

}
