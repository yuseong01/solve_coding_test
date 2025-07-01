using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N= int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            String inputString = Console.ReadLine();

            List<int> value = new List<int>();

            for(int i=0; i<N; i++)
            {
                value.Add(int.Parse(Console.ReadLine()));
            }

            Stack<double> stack = new Stack<double>();

            for(int i=0; i<inputString.Length; i++)
            {
                if(inputString[i]>='A'&&inputString[i]<='Z')
                {
                    int index = inputString[i] - 'A';
                    stack.Push(value[index]);
                }
                else
                {
                    double right = stack.Pop();
                    double left = stack.Pop();
                    double result = 0;

                    switch(inputString[i])
                    {
                        case '+':
                            result = left + right;
                            break;
                        case '-':
                            result = left - right;
                            break;
                        case '*':
                            result = left * right;
                            break;
                        case '/':
                            result = left / right;
                            break;
                    }

                    stack.Push(result);
                }
            }

            double finalResult = stack.Pop();

            sb.Append(finalResult.ToString("F2"));
            Console.WriteLine(sb);
        }
    }
}
