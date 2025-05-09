using System.Linq.Expressions;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        int testCaseCount = int.Parse(Console.ReadLine());
        int wordLength;
        StringBuilder stringBuilder = new StringBuilder();
        
        for(int i=0; i<testCaseCount; i++)
        {
            string inputString=Console.ReadLine();
            string[] words = inputString.Split(" ");

            foreach(string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);
                stringBuilder.Append(reversed+" ");
            }
            stringBuilder.Append("\n");
        }

        Console.WriteLine(stringBuilder);
    }
}
