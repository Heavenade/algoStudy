using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;

        for (int target = left; target <= right; target++)
        {
            int count = 0;
            for (int i = 1; i * i <= target; i++)
            {
                if (i * i == target)
                    count++;
                else if (target % i == 0)
                    count += 2;
            }

            if (count % 2 == 0)
                answer += target;
            else
                answer -= target;
        }

        return answer;
    }
}