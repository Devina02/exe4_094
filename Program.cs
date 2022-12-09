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
                Console.WriteLine("Masukan elemen");
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
        static void Main(string[] args)
        {
            Stack s = new Stack(33);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push. ");
                Console.WriteLine("2. Pop. ");
                Console.WriteLine("3. Display. ");
                Console.WriteLine("4. Exit. ");
                Console.WriteLine("\nEnter your choice: ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nMasukan Elemen: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                }
            }
        }

    }
}
