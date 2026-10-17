//Harshad Number (Niven Number):- number that is divisible by the sum of its digits.
//Example: 18 = sum: 1 + 8 = 9 = 18 % 9 == 0
//Examples: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 18, 20, 21, 24, 27, 30, 36, 40, 42, 45, 48, 50, 54, 60, 63, 70, 72, 80, 81, 84, 90, 100
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 100, i, j, temp, addnum;
         Console.Write("Harshad Numbers Till "+limit+":- ");
         for(i=1;i<=limit;i++){
             temp = 0;
             addnum = 0;
             for(j=i;j!=0;j/=10){
                 temp = j%10;
                 addnum += temp;
             }
             
             if(i%addnum==0){
                 Console.Write(i+" ");
             }
         }
    }
}
