//Neon Number:- Sum of the digits of its square equals the original number itself.
//Like:- 9^2 = 81
// 8 + 1 = 9
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int limit = 100, i, j, temp, number;
        Console.Write("Neon Numbers:- ");
        for(i=1;i<=limit;i++){
            number = 0;
            for(j=(i*i);j!=0;j/=10){
               temp = j%10;
               number += temp;
            }
            if(number == i){
               Console.Write(i+" ");
            }
        }
    }
}
