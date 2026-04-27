using System;
using System.Collections.Generic;

public class Solution
{
    public string MakeLargestSpecial(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        int count = 0, i = 0;
        List<string> res = new List<string>();


        for (int j = 0; j < s.Length; ++j)
        {
            if (s[j] == '1') count++;
            else count--;

            if (count == 0)
            {

                res.Add("1" + MakeLargestSpecial(s.Substring(i + 1, j - i - 1)) + "0");
                i = j + 1;
            }
        }


        res.Sort((a, b) => b.CompareTo(a));

        return string.Join("", res);
    }
}