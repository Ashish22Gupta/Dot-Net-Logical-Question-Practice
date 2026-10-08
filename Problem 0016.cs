/* Expected Output */
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int limit = 4, number = 1, i,j;
        int[,] arr = new int[limit, limit];
        int top=0, bottom=limit-1, left=0, right = limit-1;
        while(number <= (limit*limit)){
            for(i=left;i<=right;i++){
                arr[top,i] = number;
                number++;
            }
            top++;

            for(i=top;i<=bottom;i++){
                arr[i,right] = number;
                number++;
            }
            right--;

            for(i=right;i>=left;i--){
                arr[bottom,i] = number;
                number++;
            }
            bottom--;

            for(i=bottom;i>=top;i--){
                arr[i,left] = number;
                number++;
            }
            left++;
        }

        for(i=0;i<limit; i++){
            for(j=0; j<limit; j++){
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
