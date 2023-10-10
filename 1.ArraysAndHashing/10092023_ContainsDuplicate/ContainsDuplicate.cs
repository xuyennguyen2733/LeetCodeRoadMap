public class Solution
{
  public bool ContainsDuplicate(int[] nums)
  {
    HashSet<int> counts = new HashSet<int>();
    for (int i = 0; i < nums.Length; i++)
    {
      if (counts.Contains(nums[i])) return true;
      counts.Add(nums[i]);
    }
    return false;
  }
}