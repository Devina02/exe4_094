﻿using System;
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
        Boolean push(int item)
        {
            int val;
            if (top == max - 1)
            {

                Console.WriteLine("\n Overflow");
                return false;
            }
            else
            {
                Console.WriteLine("Enter the value?");
                val = Convert.ToInt32(Console.ReadLine());
                top = top + 1;
                elmnt[top] = val;
                return true;
            }
        }
        Boolean pop()
        {
            if (top == -1)
            {
                Console.WriteLine(" Underflow ");
                return false;
            }

            else

            {
                top = top - 1;
                Console.WriteLine(" Item popped ");
                return true;
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine(" Stack is Empty ");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item [" + (i + 1) + "] : " + elmnt[i]);
                }
            }
        }

    }
}
