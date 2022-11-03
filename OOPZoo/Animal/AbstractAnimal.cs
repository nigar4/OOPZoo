using OOPZoo.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZoo.Animal
{
   public abstract class AbstractAnimal
    {
        public string Name { get;protected set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public BiomType Biome { get; protected set; }
        public string[] Eat { get; set; }
        public int Square { get; set; }
        public bool IsPredator { get; set; }

        public string _sound;
        public AbstractAnimal(string name, int age,int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            
        }

       public void ToEat(string eat,int kg)
        {
            Console.WriteLine($"{Name} kushaet  {kg} kg {eat} za den ");
        }
    }
}
