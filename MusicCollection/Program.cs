using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Music Collection");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create a record");
            Console.WriteLine("2. View all records");
            Console.WriteLine("3. Update a record");
            Console.WriteLine("4. Delete a record");
            string userChoice = Console.ReadLine();
        }
    }
    class Albun
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
    }
}

