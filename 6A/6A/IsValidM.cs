using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6A
{
    public static class IsValidM
    {
        public static bool IsValid(char[] array)
        {
            bool answer = true;

            //Array.Reverse(array);

            //considering that array can contain alphabetical chars.

            Stack<char> stack = new Stack<char>();
            foreach (char c in array)
            {
                if (c == '(' || c == ')' || c == '{' || c == '}'
                    || c == '[' || c == ']' || c == '<' || c == '>')
                {
                    stack.Push(c);
                }
            }


            int counter = 0;
            char modalVariable = ' ';



            Dictionary<char, char> MyDictionary = new Dictionary<char, char>();


            //key , value
            MyDictionary.Add(')', '(');
            MyDictionary.Add('}', '{');
            MyDictionary.Add(']', '[');
            MyDictionary.Add('>', '<');

            var stack_1 = new Stack<char>();
            int Length = stack.Count;

            if (stack.Count % 2 == 1)
            {
                answer = false;
            }
            else
            {

                int j = 0;
                while (j < Length/2)
                {
                    int i = 1;
                    modalVariable = stack.Pop();
                    foreach (var item in stack)
                    {
                        if(item == MyDictionary[modalVariable])
                        {

                        }

                    }
                    j++;

                }
            }




            if (counter != Length / 2 || counter == 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }

            return answer;
            
        }




        


    }
}
