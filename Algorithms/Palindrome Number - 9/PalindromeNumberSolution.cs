namespace Algorithms.Palindrome_Number___9;

/*
    Given an integer x, return true if x is a palindrome, and false otherwise.
 */

public class PalindromeNumberSolution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x == 0) return true;

        char[] xStr = x.ToString().ToCharArray();
        char[] xStrReverse = xStr.Reverse().ToArray();

        for (int i = 0; i < xStr.Length; i++)
        {
            if (xStr[i] != xStrReverse[i]) return false;
        }

        return true;
    }
}