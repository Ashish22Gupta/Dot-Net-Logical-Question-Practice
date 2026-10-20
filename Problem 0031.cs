//Magic number:- Number where recursively adding its digits until a single digit remains yields 1.
//Example: 1729 = 1+7+2+9 = 19 = 1+9 = 10 = 1 + 0 = 1
//Examples: 1, 10, 19, 28, 37, 46, 55, 1729

using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int limit = 1000, i, j, temp, addnum, number;
        Console.Write("Magic Numbers Till " + limit + " :- ");
        for (i = 1; i <= limit; i++)
        {
            number = i;
            while (number > 9)
            {
                addnum = 0;
                for (j = number; j != 0; j /= 10)
                {
                    temp = j % 10;
                    addnum += temp;
                }
                number = addnum;
            }
            
            if (number == 1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
