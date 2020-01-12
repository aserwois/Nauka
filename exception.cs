using System;

namespace except
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);    
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}