using System;
using System.ComponentModel;

public class RomanNumerals
{
	public string RomanNumeral(int number)
	{
        if (number <= 0)
        {
            throw new ArgumentException("number should be positive");
        }

        Dictionary<int, string> dics = new Dictionary<int, string>();

        dics.Add(1000, "M");
        dics.Add(900, "CM");
        dics.Add(500, "D");
        dics.Add(400, "CD");
        dics.Add(100, "C");
        dics.Add(90, "XC");
        dics.Add(50, "L");
        dics.Add(40, "XL");
        dics.Add(10, "X");
        dics.Add(9, "IX");
        dics.Add(5, "V");
        dics.Add(4, "IV");
        dics.Add(1, "I");

        string result = "";

        foreach (var dic in dics)
        {
            while(number >= dic.Key)
            {
                result = result + dic.Value;
                number = number - dic.Key;
            }
        }


        return result;

    }
}
