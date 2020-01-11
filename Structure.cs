using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine(cube(5));
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}       