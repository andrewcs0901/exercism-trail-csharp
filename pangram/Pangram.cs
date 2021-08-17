using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> charSet = new HashSet<char>(25);
        int aInASCII = 97;
        int zInASCII = 122;
        foreach (var ch in input.ToLower())
        {
            if(ch >= aInASCII && ch <= zInASCII)
                charSet.Add(ch);
        }
        return charSet.Count == 26;
    }
}
