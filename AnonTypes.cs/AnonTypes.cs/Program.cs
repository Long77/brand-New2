using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTypes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonymousData = new
            {
                Movies = "The Grand Budapest Hotel, Moonrise Kingdom, Django Unchained, Pulp Fiction",
                Music = "Led Zeppelin, AWOLNATION, Metallica, NWA, Elton John",
                Books = "Harry Potter, Nine Stories, The Chronicles of Narnia, Fight Club",
                Cars = "Porsche 911(930 and Later), Nissan Skyline GT-R R32, Shelby Cobra 427 S/C"
            };
            Console.WriteLine("Movies : " + anonymousData.Movies);
            Console.WriteLine("Music : " + anonymousData.Music);
            Console.WriteLine("Books : " + anonymousData.Books);
            Console.WriteLine("Cars : " + anonymousData.Cars);


            Console.ReadLine();

        }
     class MyData
        {
        }
        static void Second(string[] args)
        {

            var anonymousData = new
            {
                FirstName = "Joshua",
                LastName = "Long",
                MiddleName = "T",
            };

            Console.WriteLine("Name : " + anonymousData.FirstName);
            Console.ReadLine();
        }
    }
}
