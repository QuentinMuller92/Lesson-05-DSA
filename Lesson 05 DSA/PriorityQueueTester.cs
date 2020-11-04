using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_DSA
{
    public static class PriorityQueueTester
    {
        public static void RunTest()
        {
            Console.Clear();

            var queue = new PriorityQueue<SuperHero>();

            queue.Enqueue(new SuperHero(2, "Wolverine", "Adamantium"));
            queue.Enqueue(new SuperHero(10, "Captian Marvel", "*"));
            queue.Enqueue(new SuperHero(2, "Iron Man", "Billionaire Playboy"));
            queue.Enqueue(new SuperHero(1, "Dr. Strange", "Doctor"));

            while (queue.Count() > 0)
            {
                var hero = queue.Dequeue();
                Console.WriteLine($"Priority:{hero.Priority}, {hero.Name} : {hero.SuperPower}");
            }

            Console.ReadLine();
        }
    }
}
