using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            User:
            Console.WriteLine("Please Enter the range of input");
            Console.Write("A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A < -10000 || A >= 10000 || B < -10000 || B > 10000 || A > B) {
                Console.WriteLine("illegal Input Try again");
                goto User;
            }
            Solution mysolution = new Solution();
            Console.WriteLine("Ans:{0}",mysolution.solution(A, B));
        }
    }
}
