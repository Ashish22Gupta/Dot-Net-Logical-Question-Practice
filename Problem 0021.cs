//Palindrome Number:- Number that reads the same backward as forward.
//Like:- 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, ...101, 111, 121...

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
       int limit = 150, i, j, temp, number;
       Console.Write("Palindrom Number from 1 to "+limit+":- ");
       for(i=1;i<=limit;i++){
          number = 0;
          for(j=i;j!=0;j/=10){
              temp = j%10;
              number = number*10+temp;
          }
          if(number==i){
             Console.Write(i+" ");
          }
        }
    }
}
