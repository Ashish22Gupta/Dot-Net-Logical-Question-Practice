// * Expected Output*
// 1 2 3 
// 4 5 6 
// 7 8 9 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i, j, k=1;
        for(i=1;i<=3;i++){
            for(j=1;j<=3;j++){
               Console.Write(k+" ");
               k++;
            }
            Console.WriteLine();
        }
    }
}