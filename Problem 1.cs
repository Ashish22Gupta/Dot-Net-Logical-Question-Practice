// * Expected Output*
// 1 2 3 
// 2 4 6 
// 3 6 9 

using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i, j;
        for(i=1;i<=3;i++){
            for(j=1;j<=3;j++){
               Console.Write(i*j+" "); 
            }
            Console.WriteLine();
        }
    }
}