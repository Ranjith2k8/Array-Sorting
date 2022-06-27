using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkAndRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine() ?? string.Empty, out var t);

            while (t != 0)
            {
                t--;
                var s = Console.ReadLine();
                if (s == null)
                    continue;
                int.TryParse(s.Split(' ')[0], out var n);
                int.TryParse(s.Split(' ')[1], out var k);

                var arr = Console.ReadLine().Split(' ');

                if (n != arr.Length)
                    continue;

                var index = n - (k % n);

                for (int i = index; i < n; i++)
                {
                    Console.Write($"{arr[i]} ");
                }

                for (int i = 0; i < index; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
