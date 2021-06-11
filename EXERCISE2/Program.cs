using System;

namespace EXERCISE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your arrays Length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter your arrays seperated by ' ' eg:1 2 3 4 5");
            String arrayValue = Console.ReadLine();
            String[] value = arrayValue.Split(' ');
            int[] finalInputArray = new int[value.Length];
            Console.WriteLine();
            if (value.Length > length|| value.Length < length) {
                Console.WriteLine("Warning:Input Arrays's size does not match the array set by user");
                Console.WriteLine("We will automatically update your array size");
            }
            Console.WriteLine("*******************************************");
            for (int i = 0; i < finalInputArray.Length; i++) {
                finalInputArray[i] = Convert.ToInt32(value[i]);
            }
            Solution mysolution = new Solution();
            int count;
            int res=mysolution.solution(finalInputArray,out count);
            Console.WriteLine($"Ans:{res} it appears {count} times");
        }
    }
}
