using System;

namespace BaseClassDerivedClassMod6
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit raspberry = new Fruit();
            Plant plant = new Plant();

            // instance of class Fruit created, but the props below are not found in Fruit, they are found in Plant
            raspberry.Name = "Raspberry";
            raspberry.Edible = true;
            raspberry.PlantType = "Vine";
            // the FruitType prop is not accessable from the base class but is from the Fruit class
            raspberry.FruitType = "Berry";
            // plant.FruitType = "Plant";  // causes a compiler error, derivation only goes from parent to child

            // presently calling the base class function EatMe
            raspberry.EatMe(raspberry.Name);

            // Example of overriding a base class method
            Fungi fungiMagic = new Fungi();
            fungiMagic.Name = "Magic Mushroom";
            fungiMagic.EatMe(fungiMagic.Name);

            Fungi fungi = new Fungi();
            fungi.Name = "Portabello";
            fungi.EatMe(fungi.Name); 

        }
    }

    public class Plant
    {
        public string Name { get; set; }
        public string PlantType { get; set; }
        public bool Edible { get; set; }
        
        public virtual void EatMe(string name)
        {
            Console.WriteLine("Congradulations, you have eaten a " + name);
        }
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
        public override void EatMe(string name)
        {
            if (this.Name == "Magic Mushroom")
            {
                Console.WriteLine("You done messed up now A-A-Ron");
                Console.WriteLine("You have eaten a " + name);
            }
            else
            {
                base.EatMe(name);
            }
        }
    }
}
