using OOPZoo.Animal;
using OOPZoo.Options;

Tiger tiger = new Tiger("Simba", 3,70);
tiger.ToEat("meat", 3);
tiger.ToSound();
Elephant elephant = new Elephant("Lili",2,300);
elephant.ToEat("grass", 2);
elephant.ToSound();

Console.WriteLine(tiger.ToEat("meat", 3).Text);
Console.WriteLine(tiger.ToSound().Text);
Console.WriteLine(elephant.ToEat("grass", 2).Text);
Console.WriteLine(elephant.ToSound().Text);
Aviary jungle = new Aviary("Simba", BiomType.Jungle, 70);
