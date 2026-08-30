// * Expected Output*
//  *  *  *  *  * 
//  *  *     *  * 
//  *     *     * 
//  *  *     *  * 
//  *  *  *  *  * 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i, j, limit=5;
        for(i=1;i<=limit;i++){
            for(j=1;j<=limit;j++){
               if(i==j || limit+1 == (i+j) || (i>=1 && j==1) || (j==limit && i>=1) || (i==1 && j>=1) || (i==limit && j>=1)){
                Console.Write(" * ");
               }else{
                  Console.Write("   ");
               }
            }
            Console.WriteLine();
        }
    }
}
