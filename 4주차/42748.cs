using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0];
            int end = commands[i, 1] + 1;
            int dest = commands[i, 2];
            int[] acsResult = new int[end - start];

            Array.Copy(array, start - 1, acsResult, 0, end - start);
            Array.Sort(acsResult);
            answer[i] = acsResult[dest - 1];
        }
        return answer;
    }
}