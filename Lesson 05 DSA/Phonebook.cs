using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_05_DSA
{
    public static class Phonebook
    {
        public static void ReadPhoneBook()
        {
            // Read the file and build the phone book
            SortedDictionary<string, SortedDictionary<string, string>> phonesByTown = new SortedDictionary<string, SortedDictionary<string, string>>();

            StreamReader reader = new StreamReader("Phonebook.txt");

            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    string[] entry = line.Split(new char[] { '|' });
                    string name = entry[0].Trim();
                    string town = entry[1].Trim();
                    string phone = entry[2].Trim();

                    SortedDictionary<string, string> phoneBook;

                    if (!phonesByTown.TryGetValue(town, out phoneBook))
                    {
                        // This town is new. Create a phone book for it
                        phoneBook = new SortedDictionary<string, string>();
                        phonesByTown.Add(town, phoneBook);
                    }

                    phoneBook.Add(name, phone);
                }
            }

            // Print the phone book by towns
            foreach (string town in phonesByTown.Keys)
            {
                Console.WriteLine("Town " + town + ":");

                SortedDictionary<string, string> phoneBook = phonesByTown[town];

                foreach (var entry in phoneBook)
                {
                    string name = entry.Key;
                    string phone = entry.Value;
                    Console.WriteLine("\t{0} - {1}", name, phone);
                }
            }
        }
    }
}
