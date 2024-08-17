namespace Practice5.Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            animals.Add(new Dog("Шарик", 5));
            animals.Add(new Cat("Мурзик", 3));
            animals.Add(new Parrot("Кеша", 1));

            foreach (Animal animal in animals)
            {
                switch(animal) {
                    case Dog dog:
                        dog.MakeSound();
                        break;
                    case Cat cat:
                        cat.MakeSound();
                        break;
                    case Parrot parrot:
                        parrot.MakeSound();
                        parrot.MakeSound("Привет, я Кеша!");
                        break;
                    default:
                        animal.MakeSound();
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            List<IFlyable> flyableCreatures = new List<IFlyable>();
            flyableCreatures.Add(new Parrot("Кега", 3));
            flyableCreatures.Add(new Eagle());

            foreach (IFlyable flyableCreature in flyableCreatures)
            {
                flyableCreature.Fly();
            }
        }
    }
}