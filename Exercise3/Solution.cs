using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B) {
            int res = 0;
            for (int i = A; i <= B; i++) {
                if (i < 0) {
                    continue;
                }
                int temp = (int)Math.Sqrt(i);
                if (temp * temp == i) {
                    res++;
                }
            }
            return res;
        }
    }
}
