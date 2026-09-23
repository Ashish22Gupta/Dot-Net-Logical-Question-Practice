//* Expected Output */
//1 8 9 16
//2 7 10 15
//3 6 11 14
//4 5 12 13

using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        int limit = 4;
        int even = limit - 1, odd = 0;
        for (int i = 0; i < limit; i++)
        {
            for (int j = 1; j <=limit; j++)
            {
                if(j%2==0){
                    Console.Write(limit*j - odd+" ");
                }else{
                    Console.Write(limit*j - even+" ");
                }
            }
            odd++;
            even--;
            Console.WriteLine();
        }
    }
}    
