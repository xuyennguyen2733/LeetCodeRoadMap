// SOLUTION 1: Sort and compare (easier, less efficient)
public class Solution
{
  public bool IsAnagram(string s, string t)
  {
    if (s.Length != t.Length) return false;
    string sortedS = String.Concat(s.OrderBy(c => c));
    string sortedT = String.Concat(t.OrderBy(c => c));

    return sortedS.Equals(sortedT);
  }
}

// SOLUTION 2: compare character frequency (a bit longer, more efficient)
public class Solution
{
  public bool IsAnagram(string s, string t)
  {
    if (s.Length != t.Length) return false;

    Dictionary<char, int> sDict = new Dictionary<char, int>();
    Dictionary<char, int> tDict = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
      if (sDict.ContainsKey(s[i]))
      {
        sDict[s[i]] += 1;
      }
      else
      {
        sDict[s[i]] = 1;
      }
      if (tDict.ContainsKey(t[i]))
      {
        tDict[t[i]] += 1;
      }
      else
      {
        tDict[t[i]] = 1;
      }
    }

    if (sDict.Count != tDict.Count) return false;

    foreach (char key in sDict.Keys)
    {
      if (!tDict.ContainsKey(key)) return false;
      if (sDict[key] != tDict[key]) return false;
    }

    return true;
  }
}