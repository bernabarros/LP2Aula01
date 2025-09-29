using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        private const int maxenergy = 100;
        private string name;
        private int energy;
        private Mood moodStatus;
        private Feed feedStatus;

        public Cat(string name, Mood moodStatus, Feed feedStatus)
        {
            this.name = name;
            this.moodStatus = moodStatus;
            this.feedStatus = feedStatus;
            this.energy = maxenergy;
        }

        public string GetName()
        {
            return name;
        }

        public int GetEnergy()
        {
            return energy;
        }

        public int Sleep()
        {
            energy = maxenergy;
            return energy;
        }

        public Feed GetFeedStatus()
        {
            return feedStatus;
        }

        public Mood GetMoodStatus()
        {
            return moodStatus;
        }
        public void CatNoise()
        {
            Console.WriteLine("Meow!");
            this.energy--;
        }
    }
}