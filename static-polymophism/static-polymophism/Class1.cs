using System;
using System.Collections.Generic;
using System.Text;

namespace static_polymophism
{
    class Class1
    {
        public void hello()
        {
            Console.WriteLine("hello");
        }
        public void hello(int a)
        {
            Console.WriteLine("hello" + a);
        }
    }
}
