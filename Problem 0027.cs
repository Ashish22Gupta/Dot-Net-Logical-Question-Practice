//Spy Number:- number where the sum of its digits equals the product of its digits.
//Example: 1124 = Sum: 1+1+2+4 = 8, Product: 1 x 1 x 2 x 4 = 8
//Examples: 1, 2, 3, 4, 5, 6, 7, 8, 9, 22, 123, 132, 213, 231, 312, 321, 1124, 1142, 1214, 1241, 1412, 1421, 2114, 2141, 2411, 4112, 4121, 4211
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 10000, i, j, numadd, nummul, temp;
         Console.Write("Spy Numbers Till "+limit+":- ");
         for(i=1;i<=limit;i++){
             numadd = 0;
             nummul = 1;
             temp = 0;
             for(j=i;j!=0;j/=10){
                 temp = j%10;
                 numadd += temp;
                 nummul *= temp;
             }
             
             if(numadd == nummul){
                 Console.Write(i+" ");
             }
         }
    }
}
