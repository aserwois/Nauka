using System;

namespace power
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPow(4,5));
        }

        static int getPow (int basNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum;i++)
            {
                result = result * basNum;
            }

            return result;
        }
    }
}