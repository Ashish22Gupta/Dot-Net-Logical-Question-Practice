/* Expected Output */
//1
//2 3
//4 5 6
//7 8 9 10
//11 12 13 14 15

using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        int limit = 5, i, j, k, number=1;
        for(i=1; i<=limit; i++){
            for(j=1; j<=i; j++){
                Console.Write(number);
                number++;
            }
            for(k=limit-i;k>0;k--){
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        int numberlimit = 21;
        int looplimit, startnumber = 1;
        if(numberlimit%2==0){
            looplimit = numberlimit/2;
        }
        else{
            looplimit = numberlimit/3;
        }
        for(i=1;startnumber<=numberlimit; i++){
            for(j=1;j<=i;j++){
                Console.Write(startnumber);
                startnumber++;
            }
            Console.WriteLine();
        }

    }
}
