using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE2
{
    class Solution
    {
        public int solution(int[] A, out int count)
        {
            int[] map = new int[10001];
            foreach (int i in A)
            {
                map[i]++;
            }
            int res = 0;
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] > map[res]) {
                    res = i;
                }
            }
            count = map[res];
            return res;
        }
    }
}
