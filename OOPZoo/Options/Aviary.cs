using OOPZoo.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZoo.Options
{
    public class Aviary

    {
        public string Name { get; protected set; }
        public int Square { get; protected set; }
        public BiomType Biome { get; set; }
       

        public List<AbstractAnimal> Animals { get; protected set;}
        public Aviary(string name,BiomType biome,int square)
        {
            Name = name;
            biome = biome;
            Square = square;
            Animals = new List<AbstractAnimal>();

        }
        
       public string AddAnimal(AbstractAnimal animal)
        {
            Animals.Add(animal);
            return $"{animal.Name} poselilsa v {Name}";
        }

        

    }
}
