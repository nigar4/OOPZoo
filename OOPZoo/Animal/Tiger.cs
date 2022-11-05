namespace OOPZoo.Animal
{
    public class Tiger : AbstractAnimal
    {
       public Tiger(string name, int age,int weight) : base (name, age,weight)
        {
           
            Eat = new string[] { "Meat" };
            Biome=Options.BiomType.Jungle;
            _sound = "rrrrr";
        }


    }
}
