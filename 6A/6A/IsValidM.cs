using System;
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


            var help = new List<char>();

            Dictionary<char, char> MyDictionary = new Dictionary<char, char>();


            //key , value
            MyDictionary.Add(')', '(');
            MyDictionary.Add('}', '{');
            MyDictionary.Add(']', '[');
            MyDictionary.Add('>', '<');



            if (stack.Count % 2 == 1)
            {
                answer = false;
            }
            else
            {
                int i = 0;
                while (i < stack.Count / 2)
                {
                    modalVariable = stack.Pop();
                    if (MyDictionary.ContainsKey(modalVariable))
                    {
                        foreach (var item in stack)
                        {
                            if (item == MyDictionary[modalVariable])
                            {
                                counter++;



                                help = stack.ToArray().ToList();
                                help.Remove(item);
                            }
                            else
                            {
                                help = stack.ToArray().ToList();
                            }
                            stack.Clear();
                            for (int j = 0; j < help.Count; j++)
                            {
                                stack.Push(help[j]);
                            }


                        }
                    }
                    else
                    {
                        answer = false;
                    }

                    i++;
                }




                if (counter != stack.Count / 2 || counter == 0)
                {
                    answer = false;
                }
            }






            return answer;
        }

        //public static Dictionary<char, char> MyDictionary = new Dictionary<char, char>();

        //    MyDictionary.Add('(', ')');
        //    MyDictionary.Add('{', '}');
        //    MyDictionary.Add('[', ']');
        //    MyDictionary.Add('<', '>');


    }
}
