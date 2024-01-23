int[] numsArray = new int[] { 2, 7, 11, 15 };

Solution Solution = new Solution();

var Response = Solution.TwoSum(numsArray, 9);

foreach (var item in Response)
{
    Console.WriteLine(item);
}


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int overcharge = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int y = 0; y < nums.Length; y++)
            {

                if (nums[i] + nums[y] == target)
                {

                    if (overcharge == 1 && nums[i] == nums[y])
                    {
                        return new int[] { i, y };
                    }
                    if (nums[i] == nums[y])
                    {
                        ++overcharge;
                        continue;
                    }

                    return new int[] { i, y };
                }

            }
        }

        return new int[0];
    }
}