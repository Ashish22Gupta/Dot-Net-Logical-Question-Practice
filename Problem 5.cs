// * Expected Output*
//         1 
//       1 2 
//     1 2 3 
//   1 2 3 4 
// 1 2 3 4 5 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i, j, k, limit=5;
        for(i=1;i<=limit;i++){
            for(k=(limit-i);k!=0;k--){
                Console.Write("  ");
            }
            for(j=1;j<=i;j++){
               Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }
}
