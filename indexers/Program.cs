using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void indexdemo()
        {
            stdetails[0] = new Student
            {
                id = 444,
                stdname = "aarya",
                course = "c#"

            };


            stdetails[1] = new Student
            {
                id = 415,
                stdname = "shakespeare",
                course = "dotnet"

            };

            Console.WriteLine("{0}\t{1}\t{2}", stdetails[0].id, stdetails[0].stdname, stdetails[0].course);
            Console.WriteLine("{0}\t{1}\t{2}", stdetails[1].id, stdetails[1].stdname, stdetails[1].course);
            

        }
    }
}
