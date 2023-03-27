using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[] solution(string[] genres, int[] plays)
    {
        List<int> answer = new List<int>();
        Dictionary<string, int> genreSumDic = new Dictionary<string, int>();
        for (int i = 0; i < genres.Length; i++)
        {
            if (genreSumDic.ContainsKey(genres[i]))
                genreSumDic[genres[i]] += plays[i];
            else
                genreSumDic.Add(genres[i], plays[i]);
        }

        Dictionary<string, List<int[]>> genrePlayDic = new Dictionary<string, List<int[]>>();
        for (int i = 0; i < genres.Length; i++)
        {
            if (genrePlayDic.ContainsKey(genres[i]))
            {
                int[] tmp = { i, plays[i] };
                genrePlayDic[genres[i]].Add(tmp);
            }
            else
            {
                int[] tmp = { i, plays[i] };
                List<int[]> tmpList = new List<int[]>();
                tmpList.Add(tmp);
                genrePlayDic.Add(genres[i], tmpList);
            }
        }

        var items = genreSumDic.OrderByDescending(x => x.Value);
        foreach (var dictionary in items)
        {
            string key = dictionary.Key; // genre string
            var sortList = genrePlayDic[key].OrderByDescending(x => x[1]).ToList();
            if (sortList.Count() <= 1)
                answer.Add(sortList[0][0]);
            else
                for (int i = 0; i < 2; i++)
                    answer.Add(sortList[i][0]);  
        }
        return answer.ToArray();
    }
}

// 해쉬 개념으로 푼다.

//dictionary 사용

//1. 재생 횟수 합계가 많은 장르를 찾아야함.
//장르별 총 재생횟수를 가진 dictionary를 만든다.

//장르sum dictionary에 키: 장르 value: 재생횟수로
//전체 song 에서 for을 돌려 장르를 추가하거나 재생횟수를 더한다.

//2. 장르별 각 곡과 재생횟수를 알아야한다.

//장르별 각 곡+재생횟수를 가진 dictionary를 만든다

//장르Play dictionary에 키:장르 value:  list[번호, 재생횟수] 를 저장한다.

//3. 장르sum dictionary를 value인 재생횟수로 내림차순 sort한다.

//4. sort 된 장르 순으로 list[번호, 재생횟수] 를 내림차순하여 최대 2개의 고유번호를 answer에 추가한다. 

//내림차순 시 플레이 횟수가 같으면 고유번호가 작은 게 먼저 오도록 예외처리한다.