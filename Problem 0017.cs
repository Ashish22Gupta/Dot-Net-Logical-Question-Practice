/* Expected Output */
//*      *
//**    **
//***  ***
//********
//***  ***
//**    **
//*      *

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int limit = 4, i, j, k;
        for(i=1; i<=limit; i++){
            for(j=1; j<=i; j++){
                Console.Write("*");
            }
            
            for(k=1; k<=((limit-i)*2); k++){
                Console.Write(" ");
            }
            
            for(j=1; j<=i; j++){
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
        
        for(i=1; i<limit; i++){
            for(j=1; j<=(limit-i); j++){
                Console.Write("*");
            }
            
            for(k=1; k<=(i*2); k++){
                Console.Write(" ");
            }
            
            for(j=1; j<=(limit-i); j++){
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}
