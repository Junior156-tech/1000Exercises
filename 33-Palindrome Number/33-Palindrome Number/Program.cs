
Solution Solution = new Solution();

var response = Solution.IsPalindrome(11);

Console.WriteLine(response);


public class Solution
{
    public bool IsPalindrome(int x)
    {
        var xString = x.ToString();

        for (int i = 0; i < xString.Length; i++)
        {
            if (int.IsNegative(x))
                return false;

            if (xString.Length == 2 && xString[i] != xString[i + 1])
                return false;

            if (xString[i] == xString[xString.Length - 1])
                return true;
        }

        return false;
    }
}