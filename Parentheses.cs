using System.Linq.Expressions;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        int num;
        num=int.Parse(Console.ReadLine());
        StringBuilder stringBuilder = new StringBuilder();
        
        for(int i=0; i<num; i++)
        {
            char[] inputString = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            
            foreach(char input in inputString)
            {
                if(input=='(')
                    stack.Push(input);
                else if(input==')')
                {
                    if(stack.Count>0&&stack.Peek()=='(')
                        stack.Pop();
                    else
                        stack.Push(input);
                }
            }
            if(stack.Count==0)
                stringBuilder.AppendLine("YES");
            else
                stringBuilder.AppendLine("NO");
        }
        Console.WriteLine(stringBuilder);
    }
}