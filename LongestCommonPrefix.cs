public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        int prefixLen = 0; 
        string baseStr = strs[0];

        while(prefixLen < baseStr.Length)
        {
            foreach(string s in strs)
            {
                if(s.Length <= prefixLen || baseStr[prefixLen] != s[prefixLen])
                {
                    return baseStr.Substring(0, prefixLen);
                }
            }
            prefixLen++;
        }

        return baseStr;
    }
}