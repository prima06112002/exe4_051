﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_051
{
    class Stack
    {
        private String[] ele = new string[40];
        private int top;
        private int max;

        public Stack()
        {
            top = -1;
            max = ele.Length;
        }

        public void push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("stack overlow");
                return;
            }
        }
        
    }
}
