using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Lesson_05_DSA
{
    public class Articles
    {
        public static void FindArticles()
        {
            Console.Clear();

            OrderedMultiDictionary<int, string> article = new OrderedMultiDictionary<int, string>(true);            
            article.Add(15, "Vendor = Jean, " + "Barcode = 0 12345 68901, " + "Title = Banana");
            article.Add(8, "Vendor = Jean, " + "Barcode = 0 12345 68666, " + "Title = Avocado");
            article.Add(9, "Vendor = Jane, " + "Barcode = 1 12225 68901, " + "Title = Strawberry");
            article.Add(15, "Vendor = Luca, " + "Barcode = 3 12345 68901, " + "Title = Cherry");
            article.Add(26, "Vendor = Jane, " + "Barcode = 0 12345 12345, " + "Title = Apple");
            article.Add(2, "Vendor = Jean, " + "Barcode = 3 33345 38901, " + "Title = Spinach");

            Console.WriteLine("You're going to give a range of price.");
            Console.Write("Range start > ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Range end > ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write(article.Range(start, true, end, true));

            Console.ReadLine();


        }        
    }
}
