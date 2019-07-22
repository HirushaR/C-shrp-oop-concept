using System;

namespace stifi6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 0 ,c;
            try
            {
                c = 10 / a;
                Console.WriteLine("" + c);
            }
            catch(Exception es)
            {
                Console.WriteLine("" + es);
            }

        }
    }
}
