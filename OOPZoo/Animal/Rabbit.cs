using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZoo.Animal
{
    public class Rabbit:AbstractAnimal
    {
        public Rabbit(string name, int age, int weight) : base(name, age, weight)
        {
            Eat = new string[] { "Carrot" };
            Biome = Options.BiomType.Forest;
            _sound = "brbrbr";
        }
    }
}
