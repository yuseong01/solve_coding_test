using System.Linq.Expressions;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        List<int> stack = new List<int>();
        int top = -1;

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string inputString = Console.ReadLine();
            string[] command = inputString.Split(" ");
            if (command[0] == "push")
            {
                stack.Add(int.Parse(command[1]));
                top++;
            }
            else if (command[0] == "pop")
            {
                if (top == -1)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine($"{stack[top]}");
                    stack.RemoveAt(top);
                    top--;
                }

            }
            else if (command[0] == "size")
            {
                Console.WriteLine($"{top + 1}");
            }
            else if (command[0] == "empty")
            {
                if (top == -1)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
            else if (command[0] == "top")
            {
                if (top == -1)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine($"{stack[top]}");
                }
            }


        }

    }
}