using System;

public class AnagramChecks
{

    public static bool AnagramCheck(char[] a, char[] b)
	{
        /*
		 
		// Check length: First, compare the lengths of the two strings. If they are not the same, they cannot be anagrams.
		// Sort strings: Convert both strings into character arrays and sort them alphabetically.
		// Compare sorted strings: If the two sorted strings are identical, the original strings are anagrams. 

		 */
        if (a.Length != b.Length)
            return false;

        Array.Sort(a);
        Array.Sort(b);

        return a.SequenceEqual(b);

    }
}
