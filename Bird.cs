using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsOverridingTester
{
    internal class Bird
    {
        public static Random Randomizer = new Random();

        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called");
            return new Egg[0];
        }
    }

    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                if (Bird.Randomizer.Next(4) == 0) eggs[i] = new BrokenEgg("white");
                else eggs[i] = new Egg(Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }

    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Randomizer.NextDouble() + 12, "speckled");
            }
            return eggs;
        }
    }
}
