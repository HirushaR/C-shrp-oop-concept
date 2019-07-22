using System;
using System.Collections.Generic;
using System.Text;

namespace stifi1
{
    class Encap1
    {
        private int val1, val2 ,sum;
        public void setval(int x , int y)
        {
            val1 = x;
            val2 = y;
           
        }
        
        public int getval()
        {
            sum = val1 + val2;
            return sum;
        }
    }
}
