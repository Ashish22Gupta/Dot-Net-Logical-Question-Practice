//A
//A B
//A B C
//A B C D
//A B C D E
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        char i, j, limit = ' ';
        bool flag = false;

        Console.Write("Enter the limit:- ");
        
        while (flag==false)
        {
            string Input = Console.ReadLine().Trim().ToUpper();
            if (!string.IsNullOrEmpty(Input) && Input.Length == 1)
            {
                limit = Convert.ToChar(Input);
                if (limit >= 'A' && limit <= 'Z')
                {
                    flag = true;
                    continue;
                }
            }
            Console.Write("Enter a character between A to Z:- ");
        }

        for (i = 'A'; i <= limit; i++)
        {
            for (j = 'A'; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
