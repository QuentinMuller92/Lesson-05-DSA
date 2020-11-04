using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_DSA
{
    public class StudentsTester
    {
        public static void RunTest()
        {
            Console.Clear();

            Students.ReadStudents();

            Students.DisplayStudents();

            Console.ReadLine();
        }
    }
}
