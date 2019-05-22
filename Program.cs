using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            int width = 6;
            int height = width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                width--;
            }
        }
    }
}
