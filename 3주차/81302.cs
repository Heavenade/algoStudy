using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[] solution(string[,] places)
    {
        int[] answer = new int[] { };
        answer = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int falseCnt = 0;
            for (int j = 0; j < 5; j++)
            {
                char[] line = places[i, j].ToCharArray();
                for (int k = 0; k < 5; k++)
                {
                    // p 상하좌우에 p가 있는가?
                    if (line[k].Equals('P'))
                    {
                        if (k - 1 >= 0 && line[k - 1].Equals('P')) falseCnt++;
                        if (k + 1 < 5 && line[k + 1].Equals('P')) falseCnt++;
                        if (j - 1 >= 0)
                        {
                            char[] prevline = places[i, j - 1].ToCharArray();
                            if (prevline[k].Equals('P')) falseCnt++;
                        }
                        if (j + 1 < 5)
                        {
                            char[] nextline = places[i, j + 1].ToCharArray();
                            if (nextline[k].Equals('P')) falseCnt++;
                        }
                    }
                    // o 상하좌우에 p가 두개 이상 있는가?
                    else if (line[k].Equals('O'))
                    {
                        int pcnt = 0;
                        if (k - 1 >= 0 && line[k - 1].Equals('P')) pcnt++;
                        if (k + 1 < 5 && line[k + 1].Equals('P')) pcnt++;
                        if (j - 1 >= 0)
                        {
                            char[] prevline = places[i, j - 1].ToCharArray();
                            if (prevline[k].Equals('P')) pcnt++;
                        }
                        if (j + 1 < 5)
                        {
                            char[] nextline = places[i, j + 1].ToCharArray();
                            if (nextline[k].Equals('P')) pcnt++;
                        }

                        if (pcnt >= 2) falseCnt++;
                    }
                }
            }
            if (falseCnt > 0) answer[i] = 0;
            else answer[i] = 1;
        }
        return answer;
    }
}