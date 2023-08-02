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
        public static bool IsValid(string str)
        {
            bool answer = true;
            char modalVariable = ' ';

            str = str.Replace(" ", "");

            char[] array = str.ToCharArray();
            Stack<char> stack = new Stack<char>();


            Dictionary<char, char> MyD = new Dictionary<char, char>();

            MyD.Add(')', '(');
            MyD.Add('}', '}');
            MyD.Add(']', '[');
            MyD.Add('>', '<');




            //Array.Reverse(array);


            foreach (char c in array)
            {
                if (c == '(' || c == ')' || c == '{' || c == '}'
                    || c == '[' || c == ']' || c == '<' || c == '>')
                {
                    stack.Push(c);
                }
            }
            int length = stack.Count;


            List<int> list = new List<int>();
            list.Add(0);
            list.Add(0);
            list.Add(0);
            list.Add(0);

            if (length % 2 == 0)
            {

                for (int i = 0; i < length; i++)
                {
                    modalVariable = stack.Pop();
                    switch (modalVariable)
                    {
                        case ')':
                            list[0]++;
                            break;

                        case '(':
                            list[0]--;
                            break;

                        case '}':
                            list[1]++;
                            break;

                        case '{':
                            list[1]--;
                            break;

                        case ']':
                            list[2]++;
                            break;

                        case '[':
                            list[2]--;
                            break;

                        case '>':
                            list[3]++;
                            break;

                        case '<':
                            list[3]--;
                            break;

                    }

                    foreach (var item in list)
                    {
                        if (item < 0)
                        {
                            answer = false;
                        }
                        else if (i == length - 1 && item > 0)
                        {
                            answer = false;
                        }
                    }

                    if (!answer)
                        break;
                }


            }
            else
            {
                answer = false;
            }

            return answer;



        }

    }
}
