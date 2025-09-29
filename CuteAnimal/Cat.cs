using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        private const int maxenergy = 100;
        public string Name{ get;}
        private int energy;
        public int Energy
        {
            get
            {
                return energy;
            }
            private set
            {
                if (energy > 100) energy = 100;
                else if (energy < 0) energy = 0;
            }
        }
        private Random random;
        private Mood moodStatus;
        private Feed feedStatus;

        private Feed[] possibleFeedStatus;
        private Mood[] possibleMoodStatus;

        private Cat()
        {
            random = new Random();

            possibleFeedStatus = (Feed[])Enum.GetValues(typeof(Feed));
            possibleMoodStatus = (Mood[])Enum.GetValues(typeof(Mood));
        }
        public Cat(string name, Mood moodStatus, Feed feedStatus)
        {
            this.Name = name;
            this.moodStatus = moodStatus;
            this.feedStatus = feedStatus;
            this.energy = maxenergy;
        }
        public Cat(string name) : this()
        {
            this.Name = name;
            energy = random.Next(maxenergy + 1);
            feedStatus = possibleFeedStatus[random.Next(possibleFeedStatus.Length)];
            moodStatus = possibleMoodStatus[random.Next(possibleMoodStatus.Length)];
        }

        public string GetName() => Name;

        public int GetEnergy() => energy;

        public void Sleep()
        {
            energy += 20;
            if (energy > maxenergy) energy = 100;

            if (feedStatus > Feed.Starving) feedStatus--;
            moodStatus = Mood.Grumpy;
        }
        public void Eat()
        {
            if (feedStatus < Feed.AboutToExplode)
            {
                feedStatus++;
            }
        }

        public void Play()
        {
            energy -= 15;
            if (energy < 0) energy = 0;
            moodStatus = Mood.Happy;
        }

        public Feed GetFeedStatus() => feedStatus;
        public Mood GetMoodStatus() => moodStatus;
        public void CatNoise()
        {
            Console.WriteLine("Meow!");
            energy -= 5;
            if (energy < 0) energy = 0;
        }
    }
}