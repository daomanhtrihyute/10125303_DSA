using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bai1_C5
    {
        static bool KiemTraBieuThuc(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0) return false;
                    char mo = stack.Pop();
                    if ((c == ')' && mo != '(') || (c == ']' && mo != '[') || (c == '}' && mo != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        public static void Run()
        {
            string expr = "{[()]}";
            Console.WriteLine($"BIỂU THỨC {expr} HỢP LỆ: {KiemTraBieuThuc(expr)}");
        }
    }
}

