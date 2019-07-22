using System;

namespace stifi1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Enter two numbers ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Encap1 en = new Encap1();
            en.setval(a , b);
            
            Console.WriteLine("" + en.getval());

        }
    }
}
