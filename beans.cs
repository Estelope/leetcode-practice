// 14. Longest Common Prefix
// Easy
// 16.1K
// 4.3K
// Companies
// Write a function to find the longest common prefix string amongst an array of strings.

// If there is no common prefix, return an empty string "".

 

// Example 1:

// Input: strs = ["flower","flow","flight"]
// Output: "fl"
// Example 2:

// Input: strs = ["dog","racecar","car"]
// Output: ""
// Explanation: There is no common prefix among the input strings.
 
 

// Constraints:

// 1 <= strs.length <= 200
// 0 <= strs[i].length <= 200
// strs[i] consists of only lowercase English letters.

// for each char in strings

// if string a[0] == string b[0] == string c[0]

// then newstring.push[char]

// return newstring


public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {

      string prefixString = "";

      if (strs.length == 0) 
      {
        return "";
      }

      foreach (strings in strs)
      {
        
      }
.
      
    }
}


To find the longest common prefix among an array of strings, you can use the following C# function:

csharp
Copy code
public string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
    {
        return "";
    }
    
    string prefix = strs[0]; 

    for (int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);  
            if (string.IsNullOrEmpty(prefix))
            {
                return "";
            }
        }
    }

    return prefix;
}



using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "flow", "flower", "flight" };
        string commonPrefix = FindCommonPrefix(words);
        Console.WriteLine("Common Prefix: " + commonPrefix);
    }

    static string FindCommonPrefix(string[] words)
    {
        if (words.Length == 0)
            return string.Empty;

        string firstWord = words[0];
        int commonPrefixLength = 0;

        foreach (char c in firstWord)
        {
            bool allWordsHaveCharacter = words.All(word => word.Length > commonPrefixLength && word[commonPrefixLength] == c);

            if (allWordsHaveCharacter)
            {
                commonPrefixLength++;
            }
            else
            {
                break;
            }
        }

        return firstWord.Substring(0, commonPrefixLength);
    }
}


short solution 


public string LongestCommonPrefix(string[] ss)
{
    string shortest = ss.OrderBy(s => s.Length).First();

    for (int i = 0; i < shortest.Length; i++)
    {
        if (ss.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
    }

    return shortest;
}