using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_DSA
{
    public interface IPrioritizable
    {
        /// <summary>
        /// Priority of the item.
        /// </summary>
        double Priority { get; set; }
    }
}
