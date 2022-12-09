using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_094
{
    class Stack
    {
        private int[] elmnt;
        private int top;
        private int max;
        public Stack(int size)
        {
            elmnt = new int[size];
            top = -1;
            max = size;
        }
    }
}
