

Solution Solution = new Solution();

var response = Solution.IsPalindrome(1000021);

Console.WriteLine(response);


public class Solution
{
    public bool IsPalindrome(int x)
    {
        var xString = x.ToString();
        bool validateOnce = true;
        string reverseNum = string.Empty;

        for (int i = 0; i < xString.Length; i++)
        {
            if (int.IsNegative(x))
                return false;

            for (int j = xString.Length - 1; j >= 0; j--)
            {
                if (validateOnce)
                    reverseNum = xString[j].ToString();
                else
                    reverseNum += xString[j];

                validateOnce = false;
            }

            if (reverseNum != xString)
                return false;
            else
                return true;
        }

        return false;
    }
}