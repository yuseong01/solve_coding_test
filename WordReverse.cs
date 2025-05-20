using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == '<')
            {
                while (stack.Count() != 0) sb.Append(stack.Pop());
                while (inputString[i] != '>')
                {
                    sb.Append(inputString[i]);
                    i++;
                }
                sb.Append(inputString[i]);
            }
            else if (inputString[i] == ' ')
            {
                while (stack.Count() != 0) sb.Append(stack.Pop());
                sb.Append(inputString[i]);
            }    
            else
            {
                stack.Push(inputString[i]);
            }
        }
        while (stack.Count() != 0) sb.Append(stack.Pop());

        Console.Write(sb);
    }
}