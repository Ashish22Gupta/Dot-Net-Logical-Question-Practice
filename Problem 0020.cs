//Prime Number :- Number which is divisible by 1 and itself only
//Like:- 2, 3, 5, 7, 11, 13, 17,19...
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 20, i, j;
         Console.Write("Prime Numbers are:- ");
         for(i=2;i<=limit;i++){
             int temp=0;
             for(j=2;j<=i;j++){
                if(i%j==0){
                   temp++;
                }
             }
             if(temp==1){
                Console.Write(i+" ");
             }
         }
    }
}
