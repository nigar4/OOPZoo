using OOPZoo.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPZoo.Options
{
    public class Aviaries

    {
        public string Name { get; set; }    
        public string Square { get; set; }  
        public string Biom { get; set; }

        public List<AbstractAnimal> Animals { get; set; }

    }
}
