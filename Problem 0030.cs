//Sunny Number:- Number N is sunny if N + 1 is a perfect square.
//Example: 80 = 80 + 1 = 81 (which is 9^2)
//Examples: 3, 8, 15, 24, 35, 48, 63, 80, 99
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
         int limit = 100, i, j, divnum, modnum;
         Console.Write("Sunny Numbers Till "+limit+":- ");
         for(i=1;i<=limit;i++){
             divnum = 0;
             modnum = 0;
             for(j=1;j<i;j++){
                 divnum = (i+1)/j;
                 modnum= (i+1)%j; 
                 if(divnum == j && modnum == 0){
                     Console.Write(i+" "); 
                     break;
                 }
             }
         }
         
         Console.WriteLine("\n\n*_*_OR_*_*\n");
         
         Console.Write("Sunny Numbers Till "+limit+":- ");
         for(i=1;i<=limit;i++){
             for(j=1;j<i;j++){
                 if (j*j == i+1){
                     Console.Write(i+" "); 
                     break;
                 }
             }
         }
    }
}
