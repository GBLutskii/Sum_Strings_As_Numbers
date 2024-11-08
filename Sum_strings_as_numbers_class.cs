using System;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        int digit, dozen, count;
        dozen = count = 0;
        string[] sumArr = new string[Math.Max(a.Length, b.Length) + 1];

        // since given strings may represent giant numbers, my way is to sum digit after digit starting from the end and store values into the array
        while (count < a.Length && count < b.Length)
        {
            count++;
            digit = Convert.ToInt32(Convert.ToString(a[^count])) + Convert.ToInt32(Convert.ToString(b[^count])) + dozen;
            if (digit >= 10)
            {
                dozen = 1;
                digit -= 10;
            }
            else { dozen = 0; }
            sumArr[^count] = Convert.ToString(digit);
        }
        // given "numbers" may have different length
        while (count < a.Length)
        {
            count++;
            digit = Convert.ToInt32(Convert.ToString(a[^count])) + dozen;
            if (digit >= 10)
            {
                dozen = 1;
                digit -= 10;
            }
            else { dozen = 0; }
            sumArr[^count] = Convert.ToString(digit);
        }
        // given "numbers" may have different length
        while (count < b.Length)
        {
            count++;
            digit = Convert.ToInt32(Convert.ToString(b[^count])) + dozen;
            if (digit >= 10)
            {
                dozen = 1;
                digit -= 10;
            }
            else { dozen = 0; }
            sumArr[^count] = Convert.ToString(digit);
        }
        // since the rsult may be giant as well I return it as a string, checking the 1st digit cause it can be zero (but obviously it can not)
        sumArr[0] = Convert.ToString(dozen);
        string result = string.Join("", sumArr);
        if (result[0] != '0')
        {
            return result;
        }
        else if (result[0] == '0' && result[1] == '0')
        {
            return result[2..];
        }
        else { return result[1..]; }
    }
}