using System;

namespace CuteAnimal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Cat cat1 = new Cat("kitty", Mood.Happy, Feed.Satisfied);
            Cat cat2 = new Cat("kitcat");

            Console.WriteLine(cat1.GetName());
            Console.WriteLine(cat2.GetName());

            Console.WriteLine(cat1.GetMoodStatus());
            Console.WriteLine(cat2.GetMoodStatus());

            Console.WriteLine(cat1.GetFeedStatus());
            Console.WriteLine(cat2.GetFeedStatus());

            Console.WriteLine(cat1.GetEnergy());
            Console.WriteLine(cat2.GetEnergy());

            cat1.CatNoise();
            cat2.CatNoise();

            Console.WriteLine(cat1.GetEnergy());
            Console.WriteLine(cat2.GetEnergy());

            cat1.Sleep();
            cat2.Sleep();

            Console.WriteLine(cat1.GetEnergy());
            Console.WriteLine(cat2.GetEnergy());
        }
    }
}
