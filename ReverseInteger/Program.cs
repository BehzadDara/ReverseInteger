// https://leetcode.com/problems/reverse-integer/description/

/*
Given a signed 32-bit integer x, 
return x with its digits reversed. 
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Example: 123 -> 321
Example: -123 -> -321
Example: 120 -> 21
Example: -2147483648 -> 0 (overflow)
*/

var x = -2147483648;
var result = Reverse(x);

Console.WriteLine(result);
Console.ReadKey();

static int Reverse(int x)
{
    var factor = x > 0 ? 1 : -1;
    var stringValue = x.ToString().Replace('-',' ');

    try
    {
        var charArray = stringValue.ToCharArray();
        Array.Reverse(charArray);
        var reverse = new string(charArray);
        var integerValue = int.Parse(reverse);

        return integerValue * factor;
    }
    catch
    {
        return 0;
    }
}