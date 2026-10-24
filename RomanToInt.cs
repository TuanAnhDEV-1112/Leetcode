using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>() {
            {'I' , 1},
            {'V' , 5},
            {'X' , 10},
            {'L' , 50},
            {'C' , 100},
            {'D' , 500},
            {'M' , 1000}
        };

        int preChar = 0;
        int result = 0;
        foreach(char c in s)
        {
            result += dict[c];
            if(preChar < dict[c])
            {
                result -= 2*preChar;
            }
            preChar = dict[c];
        }

        return result;
    }
}