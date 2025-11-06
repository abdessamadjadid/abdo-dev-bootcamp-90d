using System;
using System.Collections.Generic;

public class PrimeFactors
{
    public int[] PrimeFactor(int number)
    {
        if (number <= 1) return Array.Empty<int>();

        var factors = new List<int>();
        int i = 2;

        while (number > 1)
        {
            if (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
            else
            {
                i++;
            }
        }

        return factors.ToArray();
    }
}
