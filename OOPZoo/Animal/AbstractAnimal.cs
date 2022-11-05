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

       public Message ToEat(string eat,int kg)
        {
            return new Message()
            {
                Text = $"{Name} poel {kg} kilogramm {eat}",
                Name = this.Name,
                MessageType = MessageType.Eat
            };
          
        }
        public Message ToSound()
        {
            return new Message()
            {
                Text =$"{ Name} izdaet zvuki { _sound}",
                Name =this.Name,
                MessageType = MessageType.Sound
            };
        }
           
    }
}
