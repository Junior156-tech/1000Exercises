

using System.Linq.Expressions;

string[] str = new string[] { "flower", "flow", "flight" };
string[] str2 = new string[] { "", "" };
string[] str3= new string[] { "a", "ab" };
string[] str4 = new string[] { "flor","flor","flor","flor" };
string[] str5 = new string[] { "ab", "a"};
string[] str6 = new string[] { "a", "b"};




Solution solution = new Solution() ;

var result = solution.LongestCommonPrefix(str6);
Console.WriteLine(result);


public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = string.Empty;
        string prefixTrue = string.Empty;
        int count = 0;
        int countLittle = 0;
        int countEquals = 1;
        int performance = 0;
        int[] max = new int[strs.Length];
        int little = 0;

        if (strs.Length == 1)
            return strs[0];

        for (int i = 0; i < strs.Length; i++)
            max[i] = strs[i].Length;

        for (int i = 0; i < max.Length; i++)
        {
            if (countLittle == 0)
                little = max[i];
            if (countLittle > 0 && little > max[i])
                little = max[i];

            ++countLittle;
        }

        for (int x = 0; x < strs.Length; x++)
        {

            if (count == little)
                return prefix ?? prefixTrue;

            if (count > 0 && prefix[0 + performance] == strs[x][performance])
                ++countEquals;
            if (countEquals == strs.Length)
            {
                countEquals = 1;
                performance++;
                x = 0;
                count = 0;
            }
            if (performance == strs[0].Length)
            {
                return prefix;
            }
            if (count == 0)
            {
                prefixTrue = prefix;

                if (strs[x] == "")
                    return prefixTrue;
                else
                    prefix = prefix + strs[x][performance];
            }
            //if (strs.Length == x + 1)
                //return prefixTrue;

            ++count;


        }
        return prefixTrue;
    }
}