using OOPZoo.Animal;
using OOPZoo.Options;

Tiger tiger = new Tiger("Simba", 3,70);
tiger.ToEat("meat", 3);
tiger.ToSound();
Elephant elephant = new Elephant("Lili",2,300);
elephant.ToEat("grass", 2);
elephant.ToSound();
Rabbit rabbit = new Rabbit("Kruqlash",1,4);
rabbit.ToEat("carrot", 1);
rabbit.ToSound();      


Console.WriteLine(tiger.ToEat("meat", 3).Text);
Console.WriteLine(tiger.ToSound().Text);
Console.WriteLine(elephant.ToEat("grass", 2).Text);
Console.WriteLine(elephant.ToSound().Text);
Console.WriteLine(rabbit.ToEat("carrot", 1).Text);
Console.WriteLine(rabbit.ToSound().Text);


Tiger newTiger =new Tiger("Simba",3,70 );
Aviary jungle = new Aviary("Jungle", BiomType.Jungle, 70);
Console.WriteLine(jungle.AddAnimal(newTiger));

Elephant newElephant = new Elephant("Lili", 2, 300);
Aviary tropic = new Aviary("Tropic", BiomType.Tropic, 300);
Console.WriteLine(tropic.AddAnimal(newElephant));

Rabbit newRabbit = new Rabbit("Kruqlash", 1, 4);
Aviary forest = new Aviary("Forest", BiomType.Forest, 70);
Console.WriteLine(forest.AddAnimal(newRabbit));


