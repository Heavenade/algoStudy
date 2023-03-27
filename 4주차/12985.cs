using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        while (a != b)
        {
            answer++;
            a = GetNextNumber(a);
            b = GetNextNumber(b);
        }
        return answer;
    }

    public int GetNextNumber(int x)
    {
        if (x % 2 == 0)
            return x / 2;
        else
            return (x + 1) / 2;
    }
}