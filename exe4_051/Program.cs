using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_051
{
    class Stack
    {
        private String[] ele = new string[40];
        private int prim;
        private int max;

        public Stack()
        {
            prim = -1;
            max = ele.Length;
        }

        public void push()
        {
            if (prim == max - 1)
            {
                Console.WriteLine("stack overlow");
                return;
            }
            else
            {
                prim++;
                Console.WriteLine("Masukan Element: ");
                ele[prim] = Console.ReadLine();
            }
        }

        public int pop()
        {
            if (prim == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[prim]);
                prim--;
                return prim;
            }
        }

        public void display()
        {
            if (prim == -1)
            {
                Console.WriteLine("Stack is Empty");
                return ;
            }
            else
            {
                for (int i = 0; i <= prim; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n *Stack Menu*\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\n Enter your choice :");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        s.push();
                        break;

                    case '2':
                        s.pop();
                        break;

                    case '3':
                        s.display();
                        break;

                    case '4':
                        return;

                    default:
                        Console.WriteLine("\n invalid choice");
                        break;
                }
            }
        }
        
    }
}
