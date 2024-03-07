
Solution Solution = new Solution();

int result = Solution.RomanToInt("III");
Console.WriteLine(result);


public class Solution
{
    public int RomanToInt(string s)
    {
        int I = 1;
        int V = 5;
        int X = 10;
        int L = 50;
        int C = 100;
        int D = 500;
        int M = 1000;
        int CM = 900;
        int XC = 90;
        int IV = 4;
        int IX = 9;
        int II = 0;
        int VV = 0;
        int XX = 0;
        int LL = 0;
        int CC = 0;
        int DD = 0;
        int MM = 0;

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                    ++II;
                    break;  
                case 'V':
                    ++VV;
                    break;
                case 'X':
                    ++XX;
                    break;
                case 'L':
                    ++LL;
                    break;
                case 'C':
                    ++CC;
                    break;
                case 'D':
                    ++DD;
                    break;
                case 'M':
                    ++MM;
                    break;
            }

        }

        if(MM > 0)
            M = MM * M;
        else M = 0;
        if (DD > 0)
            D = DD * D;
        else D = 0;
        if (CC > 0)
            C = CC * C;
        else C = 0; 
        if (LL > 0)
            L = LL * L;
        else L = 0;
        if (XX > 0)
            X = XX * X;
        else X = 0;
        if (VV > 0)
            V = VV * V;
        else V = 0;
        if (II > 0)
            I = II * I;
        else I = 0;

        int result = M + D + C + L + X + V + I;
        return result;
    }
}

