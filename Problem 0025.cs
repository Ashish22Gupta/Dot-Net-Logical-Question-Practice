//Armstrong Number:- Number equal to the sum of its own digits each raised to the power of the number of digits.
//Like:- 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474...
//for number = 153
//1^3 = 1
//5^3 = 125
//3^3 = 27
//1 + 125 + 27 = 153
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 10000, i, j, k, temp, newtemp, number, count;
         Console.Write("Armstrong Numbers:- ");
         for(i=1;i<=limit;i++){
             number = 0;
             count = 0;
             for(j=i;j!=0;j/=10){
                 count++;
             }
             
             for(j=i;j!=0;j/=10){
                 temp = j%10;
                 newtemp = 1;
                 for(k=1;k<=count;k++){
                     newtemp *= temp;
                 }
                 number += newtemp;
             }
             if(number == i){
               Console.Write(i+" ");
             }
         }
    }
}
