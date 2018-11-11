using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] matrix = new string[3][];

            matrix[0] = new string[3] { "main", "up", "sub" };
            matrix[1] = new string[3] { "down", "center", "up" };
            matrix[2] = new string[3] { "sub", "down", "main" };

            foreach (string[] matrixItem in matrix)
            {

                foreach (string arritem in matrixItem)
                {
                    Console.Write("\t" + arritem);

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n");
        }
    }
}
