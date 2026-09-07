using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsOverridingTester
{
    internal class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public string Description { get { return $"A {Size:0.0}cm {Color} egg"; } }

        public Egg(double size, string color)
        {
            Size = size;
            Color = color;
        }
    }

    class BrokenEgg : Egg
    {
        public BrokenEgg(double size, string color) : base(size, color)
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
