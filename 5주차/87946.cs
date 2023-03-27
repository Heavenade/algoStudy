using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(int k, int[,] dungeons)
    {
        int answer = 0;
        List<int[]> dungeonList = new List<int[]>();

        for (int i = 0; i < dungeons.GetLength(0); i++)// 던전 갯수
        {
            int[] stamina = new int[2];
            stamina[0] = dungeons[i, 0];
            stamina[1] = dungeons[i, 1];

            dungeonList.Add(stamina);
        }


        while (dungeonList.Count > 0)
        {
            foreach (var d in dungeonList.ToList())
            {
                if (d[0] > k)
                    dungeonList.Remove(d);
            }

            if (dungeonList.Count == 0 || k < 0)
                break;

            dungeonList.OrderBy(d => d[1]);

            k -= dungeonList[0][1];
            answer++;
            dungeonList.Remove(dungeonList[0]);
        }

        return answer + 1;
    }
}
