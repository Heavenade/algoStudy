using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    int answer = 0;

    public void DFS(int[] numbers, int result, int target, int idx)
    {
        if (numbers.Length == idx)
        {
            if (result == target)
                answer++;
            return;
        }

        int nowNum = numbers[idx];

        DFS(numbers, result + nowNum, target, idx + 1);
        DFS(numbers, result - nowNum, target, idx + 1);
    }

    public int solution(int[] numbers, int target)
    {
        DFS(numbers, 0, target, 0);
        return answer;
    }
}
