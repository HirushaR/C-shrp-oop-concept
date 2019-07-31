using System;

namespace static_polymophism
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cs1 = new Class1();
            cs1.hello();
            cs1.hello(10);
        }
    }
}
