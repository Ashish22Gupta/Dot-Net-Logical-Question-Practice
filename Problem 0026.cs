//Automorphic Number:- number whose square ends in the same digits as the number itself.
//Example: 25 = 25^2 = 6225 (Ends in 25)
//Examples: 0, 1, 5, 6, 25, 76, 376, 625
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 1000, i, j, multiplyvalue, temp, count, divisor;
         Console.Write("Automorphic Numbers Till "+limit+":- ");
         for(i=1;i<=limit;i++){
             temp = 0;
             count = 0;
             multiplyvalue = i*i;
             for(j=i;j!=0;j/=10){
                 count++;
             }
             
             divisor = 1;
             for(j=1;j<=count;j++){
                 divisor *= 10;
             }
             
             temp = multiplyvalue % divisor;
             if (temp == i){
                 Console.Write(i+" ");
             }
         }
    }
}
