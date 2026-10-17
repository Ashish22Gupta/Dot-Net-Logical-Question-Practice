//Perfect Number:- Positive integer that is equal to the sum of its proper positive divisors (excluding the number itself).
//Example: 28  Divisors: 1, 2, 4, 7, 14 = 1 + 2 + 4 + 7 + 14 = 28
//Examples: 6, 28, 496, 8128
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 10000, i, j, temp;
         Console.Write("Perfect Numbers Till "+limit+":- ");
         for(i=1;i<=limit;i++){
             temp = 0;
             for(j=1;j<i;j++){
                 if(i%j==0){
                     temp+=j;
                 }
             }
             
             if(temp==i){
                 Console.Write(i+" ");
             }
         }
    }
}
