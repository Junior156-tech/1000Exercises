Solution solution = new Solution();
var response = solution.IsValid("()");
Console.WriteLine(response);


public class Solution
{

    public bool IsValid(string s)
    {
        if(s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
        {
            return true;
        }

        return false;
    }
}