using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            // 사용자에게 입력 받아 3~5월은 봄, 6~8월은 여름, 9~11월은 가을, 12~2월은 겨울로 출력

            Console.Write("몇 월인지 입력하세요 >> ");
            String input = Console.ReadLine();

            if(input.Contains("3") || input.Contains("4") || input.Contains("5"))
            {
                Console.WriteLine("봄");
            } else if (input.Contains("6") || input.Contains("7") || input.Contains("8"))
            {
                Console.WriteLine("여름");
            } else if (input.Contains("9") || input.Contains("10") || input.Contains("11"))
            {
                Console.WriteLine("가을");
            } else if (input.Contains("12") || input.Contains("1") || input.Contains("2"))
            {
                Console.WriteLine("봄");
            } else
            {
                Console.WriteLine("잘못 입력하셨습니다");
            }
        }
    }
}
