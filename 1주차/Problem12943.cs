using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1주차
{
    public class Solution
    {
        public int solution(int num)
        {
            int collatz = 0;
            long lnum = (long)num;

            while (lnum != 1)
            {
                if (lnum % 2 == 0)
                    lnum /= 2;
                else
                    lnum = lnum * 3 + 1;
                collatz++;

                if (collatz > 500)
                    return -1;
            }
            return collatz;
        }
    }
}
