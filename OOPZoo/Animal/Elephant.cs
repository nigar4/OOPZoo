using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPZoo.Options;
namespace OOPZoo.Animal
{
    public class Elephant:AbstractAnimal
    {
        public Elephant(string name,int age,int weight):base (name,age,weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Biome = BiomType.Tropic;
            Eat = new string[] { "Grass", "Fruit", "Watermelon" };
            Square = 100;
            IsPredator = false;
            _sound = "VUUU";
            
        }
    }
}
