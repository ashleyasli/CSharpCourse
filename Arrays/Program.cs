using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Ashley", "Mike", "Johsep" };
            students = new string[4] { "", "", "", "" };
            string[] students2 = { "Ashley", "Mike", "Johsep" };
            //students2[3] = "Michael";

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"New York","Texas","Canada" },
                {"Nevada","Alabama","Florida" },
                {"Hawai","Seattle","Minnesota" },
                {"Georgia","Connecticut","Washington" },
                {"Colorado","Oregon","New Jersey" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********");
            }

            Console.ReadLine();

        }
    }
}
