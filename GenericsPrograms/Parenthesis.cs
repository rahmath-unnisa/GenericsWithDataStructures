﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWithDataStructures.GenericsPrograms
{
    public class Parenthesis<T>
    {
        public void ParenthesesChecking<T>()
        {
            int top = -1;
            int[] str = new int[17] { '(', '5', '+', '6', ')', '*', '(', '7', '+', '8', ')', '/', '(', '4', '+', '3', ')' };
            int n = str.Length;
            char[] stack = new char[17];
            for (int i = 0; i < n; i++)
            {
                if (str[i] == '(')
                {
                    top = top + 1;
                    stack[top] = '(';
                }
                if (str[i] == ')' && stack[top] == '(')
                {
                    top = top - 1;
                }
            }
            if (top == -1)
            {
                Console.WriteLine("Balanced Parenthesis");
            }
            else
            {
                Console.WriteLine("Unbalanced Parenthesis");
            }
        }
    }
}
