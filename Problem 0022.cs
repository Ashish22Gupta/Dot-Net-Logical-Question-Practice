//Strong Number:- Number whose sum of the factorials of its digits equals the number itself.
//Like:- 1, 2, 145, 40585
//1! = 1 = 1
//4! = 4 x 3 x 2 x 1 = 24
//5! = 5 x 4 x 3 x 2 x 1 = 120 
// 1 + 24 + 120 = 145
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 50000, i, j, k, temp, number, totalnumber;
         Console.Write("Strong Numbers:- ");
         for(i=1;i<=limit;i++){
             totalnumber = 0;
             for(j=i;j!=0;j/=10){
                 temp = j%10;
                 number=1;
                 for(k=1;k<=temp;k++){
                     number *= k;
                 }
                 totalnumber += number;
             }
             if(totalnumber == i){
                Console.Write(i+" ");
             }
         }
    }
}
