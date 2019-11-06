using System;

namespace BaseClassDerivedClassMod6
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit raspberry = new Fruit();
            raspberry.Name = "Raspberry";
            raspberry.Edible = true;
            raspberry.PlantType = "Vine";
        }
    }

    public abstract class Plant
    {
        public string Name { get; set; }
        public string PlantType { get; set; }
        public bool Edible { get; set; }
        

    }

    public class Veggies : Plant   
    {
        // gord, tubor, leaf, etc.
        public string VeggiType { get; set; }
    }

    class Fruit : Plant
    {
        // berry, stone fruit, tree fruit, etc
        public string FruitType { get; set; }
    }

    class Fungi : Plant
    {

    }
}
