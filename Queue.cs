using System.Linq.Expressions;
using System.Text;

namespace CodingTest;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        int front=-1;
        StringBuilder sb = new StringBuilder();

        int N=int.Parse(Console.ReadLine());
    
        for(int i=0; i<N; i++)
        {
            string[] commend = Console.ReadLine().Split(" ");
            switch(commend[0])
            {
                case "push":
                    list.Add(commend[1]);
                    break;
                case "front":
                    sb.AppendLine(list.Count==0? "-1":list[0]);
                    break;
                case "back":
                    sb.AppendLine(list.Count==0? "-1": list[list.Count-1]);
                    break;
                case "pop":
                    sb.AppendLine(list.Count==0? "-1": list[0]);
                    if(list.Count!=0) list.RemoveAt(0);
                    break;
                case "size":
                    sb.AppendLine(list.Count==0? "0":list.Count().ToString());
                    break;
                case "empty":
                    sb.AppendLine(list.Count==0? "1":"0");
                    break;
            }

        }
        Console.WriteLine(sb);

    }
}

