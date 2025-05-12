using System.Linq.Expressions;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        //List를 안쓰고 계산공식찾기 
        List<int> numList = new();
        StringBuilder sb = new();
        int N, K;
        int j=0;

        string[] input = Console.ReadLine().Split(" ");
        N = int.Parse(input[0]);
        K = int.Parse(input[1]);

        for (int i = 1; i <= N; i++) numList.Add(i);
        
        sb.Append("<");
        while(numList.Count>1)
        {
            j+=K-1;
            if(j>=numList.Count) j%=numList.Count;
            sb.Append(numList[j]+", ");
            numList.RemoveAt(j);
        }
        sb.Append(numList[0]);
        sb.Append(">");

        Console.WriteLine(sb);
    }
}