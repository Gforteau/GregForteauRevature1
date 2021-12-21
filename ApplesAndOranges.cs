using System;

namespace ApplesAndOranges
{
    class Solution
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int apple = 0;
            int orange = 0;

            foreach( int app in apples)
            {
                if (app + a >= s && app + a <= t)
                    apple++;
            }
            Console.WriteLine(apple);
            foreach (int org in apples)
            {
                if (org + b >= s && org + b <= t)
                    orange++;
            }
            Console.WriteLine(orange);
        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

        }
    }
}
