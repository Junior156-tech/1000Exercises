






Solution solution = new Solution();
var response = solution.IsValid("(){}}{");
Console.WriteLine(response);


public class Solution
{
    public bool IsValid(string s)
    {
        var value = string.Empty;
        int count = 0;

        if (s.Length == 1)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            ++count;

            if ((s[i] == '{' || s[i] == '[' || s[i] == '(') || count > 1)
            {

                if (count == 2 && (s[i] == '{' || s[i] == '[' || s[i] == '('))
                {
                    return false;
                }
                else if ((s[i] == '}' && s[i - 1] == '{') || (s[i] == ')' && s[i - 1] == '(') || (s[i] == ']' && s[i - 1] == '['))
                {
                    value = value + s[i];
                }

                if (count == 1)
                {
                    value = value + s[i];
                }

            }
            else
            {
                return false;
            }
        }


        return true;
        //if (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
        //{
        //    return true;
        //}

        //return false;
    }
}