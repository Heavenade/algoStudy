using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cloth
{
    public string parts;
    public int count;

    public Cloth(string parts)
    {
        this.parts = parts;
        count = 1;
    }
}

public class Solution
{
    public int solution(string[,] clothes)
    {
        int answer = 1;
        List<Cloth> clothesList = new List<Cloth>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (clothesList.Exists(_ => _.parts == clothes[i, 1]))
            {
                Cloth cloth = clothesList.Find(_ => _.parts == clothes[i, 1]);
                cloth.count++;
            }
            else
            {
                Cloth cloth = new Cloth(clothes[i, 1]);
                clothesList.Add(cloth);
            }
        }

        foreach (Cloth cloth in clothesList)
            answer *= (cloth.count + 1);

        return answer-1;
    }
}