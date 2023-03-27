using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(int[] citations)
    {
        int answer = 1;

        //citations을 인용횟수로 내림차순한다.
        Array.Sort(citations);
        Array.Reverse(citations);

        // 해당 순위의 인용횟수(citations[i]) <= 순위(h) 가 되는 때를 찾아낸다.
        // 이때 i == h-1
        for (int i = 0; i < citations.Length; i++, answer++)
        {
            if (answer < citations[i])
                continue;
            else if (answer == citations[i])
                return answer;
            else if (answer > citations[i])
            {   answer--;
                return answer;
            }
        }
        return citations.Length;
    }
}
