using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
        input:
            Console.WriteLine("Please the Size of your Array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[size, size];
            for (int i = 0; i < size; i++) {
                String[] rowValue = new string[0];
                while (rowValue.Length != size) {
                    Console.WriteLine($"please enter {i + 1} row seperated by ' ' eg:1 2 3 4");
                    String row = Console.ReadLine();
                    rowValue = row.Split(' ');
                    if (rowValue.Length != size) {
                        Console.WriteLine("illegal Input");
                    }
                }
                for (int j = 0; j < size; j++) {
                    array[i, j] = Convert.ToInt32(rowValue[j]);
                }
            }
            Console.Clear();
            Console.WriteLine("User input Array is:");
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            int[] left = new int[] { 0, -1 };
            int[] right = new int[] { 0, 1 };
            int[] down = new int[] { 1, 0 };
            int[] up = new int[] { -1, 0 };
            int[] curPos = new int[] { 0, 0 };
            Boolean flag = true;
            Boolean[,] checkMatrix = new Boolean[size, size];
            Console.WriteLine("result:");
            checkMatrix[0, 0] = true;
            Console.Write("{0} ", array[0, 0]);
            while (flag)
            {
                int[] nextPos;
                int[] initial = new int[] { curPos[0], curPos[1] };
                check(right, 1, ref curPos,ref checkMatrix, out nextPos, array);
                check(down, 0, ref curPos, ref checkMatrix, out nextPos, array);
                check(left, 1, ref curPos, ref checkMatrix, out nextPos, array);
                check(up, 0, ref curPos, ref checkMatrix, out nextPos, array);

                if (initial[0] == curPos[0] && initial[1] == curPos[1]) {
                    flag = false;
                }
            }
        }
        public static int[] NextPos(int[] dir, int[] curPos) {
            return new int[] { curPos[0] + dir[0], curPos[1] + dir[1] };
        }

        public static void check(int[]dir,int index, ref int[]curPos,ref Boolean[,]checkMatrix,out int[]nextPos,int[,]array){
            nextPos = NextPos(dir, curPos);
            int boundary = (dir[index] == 1 ? checkMatrix.GetLength(0) : 0);
            while ((boundary == 0 ? nextPos[index] >= boundary : nextPos[index] < boundary)&& checkMatrix[nextPos[0], nextPos[1]] == false) {
                checkMatrix[nextPos[0], nextPos[1]] = true;
                curPos = nextPos;
                Console.Write("{0} ", array[curPos[0], curPos[1]]);
                nextPos = NextPos(dir, curPos);
            }
        }
    }
}
