using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int piece = 0;

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push('(');
            }
            else
            {
                stack.Pop();

                if (s[i-1] == '(')
                {
                    piece += stack.Count;
                }
                else
                {
                    piece += 1;
                }
            }
        }

        Console.WriteLine(piece);
    }
}