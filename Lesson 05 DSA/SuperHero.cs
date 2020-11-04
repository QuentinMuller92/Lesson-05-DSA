using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_DSA
{
    public class SuperHero : IPrioritizable
    {
        public SuperHero(double priority, string name, string superPower)
        {
            Priority = priority;
            Name = name;
            SuperPower = superPower;
        }

        public string SuperPower;

        public string Name;

        public double Priority { get; set; }
    }
}
