// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

class Program{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 999)
        {
            Console.WriteLine("out of ability");
            return;
        }

        if (number == 0)
        {
            Console.WriteLine("zero");
            return;
        }
        if (number < 10)
        {
            Console.WriteLine(ReadOneDigit(number));
        }else if (number < 20)
        {
            Console.WriteLine(ReadTeen(number));
        }else if (number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;
            string result = ReadTens(tens);
            if(ones != 0)
            {
                result += " " + ReadOneDigit(ones);
            }
            Console.WriteLine(result);
        }
        else
        {
            int hundreds = number / 100;
            int remainder = number % 100;
            string result = ReadOneDigit(hundreds) + " hundreds";
            if (remainder != 0)
            {
                result += " and ";
                if (remainder < 10)
                {
                    result += ReadOneDigit(remainder);
                }else if (remainder < 20)
                {
                    result += ReadTeen(remainder);
                }
                else
                {
                    int tens = remainder / 10;
                    int ones = remainder % 10;

                    result += ReadTens(tens);
                    if (ones != 0)
                    {
                        result += " " + ReadOneDigit(ones);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
    
    // Đọc 1 chữ số
    static string ReadOneDigit(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }
    
    // Đọc 10–19
    static string ReadTeen(int number)
    {
        switch (number)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }
    // Đọc hàng chục
    static string ReadTens(int number)
    {
        switch (number)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
    
}