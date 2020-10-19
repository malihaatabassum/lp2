using System;
namespace lab2
{
    //task1
    class numbers
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 24; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

//task7

using System;

namespace Shape
{
    class makingdesign
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        class makingdesign2
        {
            static void Main(string[] args)
            {
                {
                    int x, y;
                    for (x = 4; x >= 1; x--)
                    {
                        for (y = 1; y <= x; y++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}

   
 