using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_09_25_a.models
{
    public class HeroBase
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }
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
            return "Alien";
        }
    }

    public class HumanAugmented : Human
    {
        public override string ToString()
        {
            return "HumanAugmented";
        }
    }

    public class AlienPlant : Alien
    {
        public override string ToString()
        {
            return "AlienPlant";
        }
    }

}
