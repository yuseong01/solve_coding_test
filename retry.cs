using System.Linq.Expressions;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int temp = 1;
        StringBuilder stringBuilder = new StringBuilder();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < num; i++)   
        {
            int inputNum = int.Parse(Console.ReadLine());

            if (stack.Count() != 0 && stack.Peek() == inputNum)
            {
                stringBuilder.AppendLine("-");
                stack.Pop();
            }
            else
            {
                if (temp > inputNum)
                {
                    stringBuilder.Clear();
                    stringBuilder.AppendLine("NO");
                    break;
                }
                for (int j = temp; j <= inputNum; j++)
                {
                    stringBuilder.AppendLine("+");
                    stack.Push(j);
                }
                temp = inputNum + 1;
                stringBuilder.AppendLine("-");
                stack.Pop();
            }
        }
        Console.WriteLine(stringBuilder);
    }
}

