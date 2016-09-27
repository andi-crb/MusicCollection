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

            Album[] albums = new Album[10];
            albums[0] = new Album();
            albums[0].Title = "The Holy Bible";
            albums[0].Artist = "Manic Street Preachers";
            albums[0].Year = 1994;
            albums[0].Genre = "terrifying";

            Console.WriteLine("Music Collection");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create a record");
            Console.WriteLine("2. View all records");
            Console.WriteLine("3. Update a record");
            Console.WriteLine("4. Delete a record");
            string userChoice = Console.ReadLine();

            if (userChoice == "2")
            {
                foreach (Album a in albums)
                {
                    if (a != null)
                    {
                        Console.WriteLine(a.Title);
                        Console.WriteLine(a.Artist, a.Year, a.Genre);
                        Console.ReadLine();
                    }
                }
            }



        }
    }
    class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
    }
}

