using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        string answerString = new string(new char[] { });
        string tmpString = new string(new char[] { });

        for (int i = 0; i < s.Length; i++)
        {
            if ('0' <= s[i] && s[i] <= '9')
                answerString += s[i];
            else
                tmpString += s[i];

            if (tmpString.Length > 0)
            {
                if (tmpString.Equals("zero"))
                { answerString += '0'; tmpString = ""; }
                else if (tmpString.Equals("one"))
                { answerString += '1'; tmpString = ""; }
                else if (tmpString.Equals("two"))
                { answerString += '2'; tmpString = ""; }
                else if (tmpString.Equals("three"))
                { answerString += '3'; tmpString = ""; }
                else if (tmpString.Equals("four"))
                { answerString += '4'; tmpString = ""; }
                else if (tmpString.Equals("five"))
                { answerString += '5'; tmpString = ""; }
                else if (tmpString.Equals("six"))
                { answerString += '6'; tmpString = ""; }
                else if (tmpString.Equals("seven"))
                { answerString += '7'; tmpString = ""; }
                else if (tmpString.Equals("eight"))
                { answerString += '8'; tmpString = ""; }
                else if (tmpString.Equals("nine"))
                { answerString += '9'; tmpString = ""; }
            }
        }
        answer = Int32.Parse(answerString);
        return answer;
    }
}