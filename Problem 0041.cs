//Find Second Largest & Second Smallest
//arr = {7, 5, 1, 3, 9, 6, 2, 5} 
//Second Largest: 7, 
//Second Smallest: 2

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {7, 5, 1, 3, 9, 6, 2, 5};
        int i,j,temp=0;
        
        for(i=0;i<arr.Length;i++){
            for(j=0;j<i;j++){
                if(arr[i]<arr[j]){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        Console.Write("Second Largest Number:- ");
        for(i=0;i<arr.Length;i++){
            if(i==arr.Length-2){
                Console.Write(arr[arr.Length-2]);
            }
        }
        
        Console.Write("\nSecond Smallest Number:- ");
        for(i=0;i<arr.Length;i++){
            if(i==1){
                Console.Write(arr[i]);
            }
        }
    }
}
