using System;

namespace stifi3
{
    class Program
    {
        static void Main(string[] args)
        {
            poly py = new poly();
            py.get(3);
            py.get();
            py.get("sdf");

            Console.ReadLine();
        }
    }
}
