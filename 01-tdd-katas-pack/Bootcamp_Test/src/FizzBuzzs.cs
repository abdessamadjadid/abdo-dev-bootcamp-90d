using System;

public class FizzBuzzs
{
	public string FizzBuzz(int n)
	{
        //"Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers divisible by both 3 and 5

        if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz";
        if (n % 3 == 0) return "Fizz";
        if (n % 5 == 0) return "Buzz";
        return n.ToString();

    }

}
